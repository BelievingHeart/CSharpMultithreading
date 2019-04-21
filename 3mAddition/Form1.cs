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

namespace _3mAddition
{
    public partial class Form1 : Form
    {
        private int _count = 0;
        private object mu_count = new object();

        public int Count
        {
            get
            {
                lock (mu_count)
                {
                    return _count;
                }
            }
            set {
                lock (mu_count)
                {
                    _count = value;
                }
            }
        }

        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
            

        }

        private void accumulate()
        {
            for (int i = 0; i < 1000000; i++)
            {
                addOne();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var t1 = new Thread(accumulate);
            var t2 = new Thread(accumulate);
            var t3 = new Thread(accumulate);
            Thread.Sleep(1000);
            label1.Text = _count.ToString();
        }

        private void addOne()
        {
            lock (mu_count)
            {
                _count++;
            }
        }
    }
}
