using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            Form1 NewForm = new Form1();

            NewForm.Show();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            BackgroundWorker Worker = new BackgroundWorker();

            Worker.DoWork += new DoWorkEventHandler(Worker_DoWork);

            Worker.RunWorkerAsync("Background");
            //DoStuff("Normal");

            
            

            this.Close();
        }

        private void Worker_DoWork(object sender, DoWorkEventArgs e)
        {
            string Reference = (string)e.Argument;

            DoStuff(Reference);
        }

        private void DoStuff(string Reference)
        {
            Console.WriteLine(Reference + " clicked");
            
            System.Threading.Thread.Sleep(5000);

            Console.WriteLine(Reference + " closing");
        }
    }
}
