using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsingLock
{
    public partial class Form1 : Form
    {
        private bool _FormIsAlive = true;
        private static object mu_formAlive = new object();
        private int currentCount = 0;
        private volatile bool formClosed = false;

        private bool FormIsAlive
        {
            get
            {
                lock (mu_formAlive)
                {
                    return _FormIsAlive;
                }
            }
            set
            {
                lock (mu_formAlive)
                {
                    _FormIsAlive = value;
                }
            }
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_stopCounting_Click(object sender, EventArgs e)
        {
            FormIsAlive = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new Task(incrementCount).Start();


        }

        private void incrementCount()
        {
            while (!formClosed)
            {
                btn_stopCounting.Invoke(new Action(
                    () => { label_showCounting.Text = currentCount++.ToString(); }
                ));
                Thread.Sleep(100);

            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormIsAlive = false;
            formClosed = true;
        }
    }
}
