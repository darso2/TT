using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string FileName = "";
        Boolean changed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void adapt(object sender, EventArgs e)
        {
            richTextBox1.Width = this.Width - 40;
            richTextBox1.Height = this.Height - 73;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (richTextBox1.Visible == false)
            {
                MessageBox.Show("Cant save with no text field, Please open a new document.");
            }
            else
            {
                SaveFileDialog saveFileDialog1 = new SaveFileDialog();
                DialogResult dialogResult = saveFileDialog1.ShowDialog();
                if (saveFileDialog1.FileName != "")
                    richTextBox1.SaveFile(saveFileDialog1.FileName);
                FileName = saveFileDialog1.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (changed == false)
            {
                OpenFileDialog openFileDialog1 = new OpenFileDialog();
                DialogResult dialogResult = openFileDialog1.ShowDialog();
                if (openFileDialog1.FileName != "")
                    richTextBox1.LoadFile(openFileDialog1.FileName);
                FileName = openFileDialog1.FileName;
                richTextBox1.Visible = true;
            }
            else
            {
                DialogResult save = MessageBox.Show("Would you like to save your file?", "Save File", MessageBoxButtons.YesNo);
                {
                    if (save == DialogResult.Yes)
                    {
                        if (FileName == "")
                        {
                            saveFileDialog1.ShowDialog();
                                if (saveFileDialog1.FileName != "")
                                    {
                                         richTextBox1.Visible = true;
                                         richTextBox1.SaveFile(saveFileDialog1.FileName);                                FileName = saveFileDialog1.FileName;
                                         var a = openFileDialog1.ShowDialog();
                                         if (openFileDialog1.FileName != "")
                                            {
                                            richTextBox1.LoadFile(openFileDialog1.FileName);
                                            richTextBox1.Visible = true;
                                            changed = false;
                                            FileName = openFileDialog1.FileName;
                                            }
                                         else if (a == DialogResult.Cancel) { changed = false; return; }
                                         else
                                            {
                                            changed = false;
                                            FileName = openFileDialog1.FileName;
                                            }
                                    }
                                else
                                    {
                                    richTextBox1.SaveFile(saveFileDialog1.FileName);
                                    }
                        }
                        else
                        {
                           
                            richTextBox1.SaveFile(FileName);
                            MessageBox.Show("Saved!");
                            var a = openFileDialog1.ShowDialog();
                            if (openFileDialog1.FileName != "")
                            {
                                richTextBox1.LoadFile(openFileDialog1.FileName);
                                richTextBox1.Visible = true;
                                changed = false;
                                FileName = openFileDialog1.FileName;
                            }
                            else if (a == DialogResult.Cancel) { changed = false; return; }
                            else
                            {
                                changed = false;
                                FileName = openFileDialog1.FileName;
                            }

                        }
                    }
                    else
                    {
                        openFileDialog1.FileName = "";
                        var a = openFileDialog1.ShowDialog();
                        if (openFileDialog1.FileName != "")
                        {
                            richTextBox1.LoadFile(openFileDialog1.FileName);
                            richTextBox1.Visible = true;
                            changed = false;
                            FileName = openFileDialog1.FileName;

                        }
                        else if (a == DialogResult.Cancel) { changed = false; return; }
                        else
                        {
                            changed = false;
                            FileName = openFileDialog1.FileName;
                        }
                    }
                }
            }
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void changechange(object sender, KeyPressEventArgs e)
        {
            changed = true;
        }

        private void change1(object sender, EventArgs e)
        {
            changed = true;
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Visible = true;
            if (changed == false)
            {
                richTextBox1.Text = "";
            }
            else
            {
                DialogResult save = MessageBox.Show("Would you like to save your file?", "Save File", MessageBoxButtons.YesNo);
                {
                    if (save == DialogResult.Yes)
                        if (FileName == "")
                        {
                            saveFileDialog1.ShowDialog();
                            if (saveFileDialog1.FileName != "")
                            {
                                richTextBox1.SaveFile(saveFileDialog1.FileName);
                                richTextBox1.Text = "";
                                richTextBox1.Focus();
                                FileName = saveFileDialog1.FileName;
                                changed = false;
                            }
                        }
                        else
                            richTextBox1.SaveFile(FileName);
                    richTextBox1.Text = "";
                    richTextBox1.Focus();
                    FileName = saveFileDialog1.FileName;
                    changed = false;
                }
            }
        }

        private void richtextbox_keypress(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (changed == true)
            {
                if (FileName != "")
                {
                    richTextBox1.SaveFile(FileName);
                    changed = false;
                }

                else
                {
                    saveFileDialog1.ShowDialog();
                    if (saveFileDialog1.FileName != "")
                        richTextBox1.SaveFile(saveFileDialog1.FileName);
                    changed = false;
                }


           }
            else
            {
                if (richTextBox1.Visible == false)
                {
                    MessageBox.Show("Cant save with no text field, Please open a new document.");
                }
                else
                {
                    saveFileDialog1.ShowDialog();
                    if (saveFileDialog1.FileName != "")
                           richTextBox1.SaveFile(saveFileDialog1.FileName);
                    changed = false;
                }
            }
            FileName = saveFileDialog1.FileName;
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (changed == true)
            {
                DialogResult save = MessageBox.Show("Would you like to save your file?", "Save File", MessageBoxButtons.YesNo);
                {
                    if (save == DialogResult.Yes)
                        if (FileName == "")
                        {
                            saveFileDialog1.ShowDialog();
                            if (saveFileDialog1.FileName != "")
                            {
                                richTextBox1.SaveFile(saveFileDialog1.FileName);
                                richTextBox1.Focus();
                                FileName = saveFileDialog1.FileName;
                                changed = false;
                            }
                        }
                        else
                            richTextBox1.SaveFile(FileName);
                    richTextBox1.Focus();
                    FileName = saveFileDialog1.FileName;
                    changed = false;
                }
            }
            richTextBox1.Visible = false;
            richTextBox1.Text = "";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void formclose(object a, FormClosingEventArgs e)
        {
            if (changed == false)
            {
                return;
            }
            else
            {
                DialogResult save = MessageBox.Show("Would you like to save your file?", "Save File", MessageBoxButtons.YesNoCancel);
                {
                    if (save == DialogResult.Yes)
                    {
                        if (FileName == "")
                        {
                            saveFileDialog1.ShowDialog();
                            if (saveFileDialog1.FileName != "")
                            {
                                richTextBox1.SaveFile(saveFileDialog1.FileName);
                                richTextBox1.Focus();
                                FileName = saveFileDialog1.FileName;
                                changed = false;
                                return;
                            }
                        }
                    }
                    else if (save == DialogResult.Cancel) { e.Cancel = true; }
                    else
                        return;
                }

            }
        }




        private void Form1_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
