using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace accounts_create_account
{
    public partial class Form2 : Form
    {
        Form1 myform;

        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form checker = Application.OpenForms["Form1"];
            myform = new Form1();
            if (checker != null)
            {
                MessageBox.Show("Form is already open!");
                return;
            }                
            myform.Show();

        }

        private void fileSystemWatcher1_Changed(object sender, System.IO.FileSystemEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 myform3 = new Form3();
            myform3.Show();
        }
    }
}
