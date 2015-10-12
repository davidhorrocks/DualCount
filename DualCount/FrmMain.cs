using System;
using System.Threading;
using System.Windows.Forms;

namespace DualCount
{
    public partial class FrmMain : Form
    {
        long sharedCounter;
        long countA;
        long countB;
        Thread threadA;
        Thread threadB;
        Thread threadWatcher;
        ManualResetEvent finishedA = new ManualResetEvent(false);
        ManualResetEvent finishedB = new ManualResetEvent(false);
        ManualResetEvent quitApplicationEvent = new ManualResetEvent(false);
        bool quitAandBThreads = false;
        bool quitApplication = false;
        bool running = false;
        object mylock = new object();
        bool useLock;
        bool watcherIsFinished = false;
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            txtCountA.Text = "10000000";
            txtCountB.Text = "10000000";
            Thread threadWatcher = new Thread(new ThreadStart(RunWatcher));
            threadWatcher.Start();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (quitApplication)
            {
                return;
            }
            if (!running)
            {
                useLock = chkUseLock.Checked;
                txtResult.Text = "";
                countA = 0;
                countB = 0;
                sharedCounter = 0;
                quitAandBThreads = false;
                long.TryParse(txtCountA.Text, out countA);
                long.TryParse(txtCountB.Text, out countB);
                finishedA.Reset();
                finishedB.Reset();
                threadA = new Thread(new ThreadStart(RunA));
                threadB = new Thread(new ThreadStart(RunB));
                threadA.Start();
                threadB.Start();
                EnableUI(false);   
            }
            else
            {
                quitAandBThreads = true;
                btnStart.Enabled = false;
            }
        }

        void EnableUI(bool enable)
        {
            running = !enable;
            txtCountA.Enabled = enable;
            txtCountB.Enabled = enable;
            chkUseLock.Enabled = enable;                 
            if (enable)
            {
                btnStart.Text = "Start";
            }
            else
            {
                btnStart.Text = "Stop";
            }
        }

        void RunA()
        {
            if (useLock)
            {
                for (long i = 0; i < countA && !quitAandBThreads; i++)
                {
                    lock (mylock)
                    {
                        sharedCounter++;
                    }
                }
            }
            else
            {
                for (long i = 0; i < countA && !quitAandBThreads; i++)
                {
                    sharedCounter++;
                }
            }
            finishedA.Set();
        }

        void RunB()
        {
            if (useLock)
            {
                for (long i = 0; i < countB && !quitAandBThreads; i++)
                {
                    lock (mylock)
                    {
                        sharedCounter++;
                    }
                }
            }
            else
            {
                for (long i = 0; i < countB && !quitAandBThreads; i++)
                {
                    sharedCounter++;
                }
            }
            finishedB.Set();
        }

        void ThreadsFinished()
        {
            threadA.Join();
            threadB.Join();            
            EnableUI(true);
            btnStart.Enabled = true;
            txtResult.Text = sharedCounter.ToString("D");
        }

        void WatcherFinished()
        {
            if (threadA != null)
            {
                threadA.Join();
            }
            if (threadB != null)
            {
                threadB.Join();
            }
            watcherIsFinished = true;
            this.Close();
        }

        void RunWatcher()
        {
            int k;
            while (!quitApplication)
            {
                k = WaitHandle.WaitAny(new WaitHandle[] { quitApplicationEvent, finishedA });
                if (k == 0)
                {
                    break;
                }
                k = WaitHandle.WaitAny(new WaitHandle[] { quitApplicationEvent, finishedB });
                if (k == 0)
                {
                    break;
                }
                finishedA.Reset();
                finishedB.Reset();
                //Callback on the STA.
                this.Invoke(new MethodInvoker(ThreadsFinished));
            }
            quitAandBThreads = true;
            //Callback on the STA.
            this.Invoke(new MethodInvoker(WatcherFinished));
        }

        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            quitAandBThreads = true;
            quitApplication = true;
            quitApplicationEvent.Set();
            if (!watcherIsFinished)
            {
                //A background thread may be trying to callback on STA so abort the close.
                e.Cancel = true;
            }
        }
    }

}
