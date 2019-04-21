using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AsyncAndAwait
{
    public partial class Form1 : Form
    {
        private static int totalTasks = 10;
        private static Progress<int> progress;
        private static CancellationTokenSource cancellationTokenSource;

        public Form1()
        {
            InitializeComponent();
            progress = new Progress<int>();
            cancellationTokenSource = new CancellationTokenSource();
            progress.ProgressChanged += (sender, i) => progressBar1.Value = i;
        }

        private async void btn_runAsync_Click(object sender, EventArgs e)
        {
            var timer = Stopwatch.StartNew();
            btn_runAsync.Enabled = false;
            
            for (int i = 0; i < totalTasks; i++)
            {
                var num = await Task.Run(() =>
                {
                    Thread.Sleep(1000);
              
                    return i;
                });
              
                   // cancellationTokenSource.Token.ThrowIfCancellationRequested();
                   if (cancellationTokenSource.Token.IsCancellationRequested)
                   {
                       textBox1.AppendText("Canceled\n");
                       break;
                   }
                
                ((IProgress<int>)progress).Report(i*100/totalTasks);
                textBox1.AppendText(num + Environment.NewLine);
            }
            timer.Stop();
            btn_runAsync.Enabled = true;
            textBox1.AppendText(timer.ElapsedMilliseconds.ToString());
        }

        private async void btn_ranAsyncParallel_Click(object sender, EventArgs e)
        {
            var timer = Stopwatch.StartNew();

            var tasks = new List<Task<int>>();
            for (int i = 0; i < 10; i++)
            {
                var i1 = i;
                tasks.Add(Task.Run(() =>
                {
                    Thread.Sleep(1000);
                    return i1;
                }));
            }

            var nums = await Task.WhenAll(tasks);

            foreach (var num in nums)
            {
                textBox1.AppendText(num + Environment.NewLine);                
            }

            timer.Stop();
            textBox1.AppendText(timer.ElapsedMilliseconds.ToString());
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            cancellationTokenSource.Cancel();
        }
    }
}
