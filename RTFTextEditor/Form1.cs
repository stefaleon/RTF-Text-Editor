using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RTFTextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_MouseEnter(object sender, EventArgs e)
        {
            textBox1.Text = "Open a file";
        }

        private void toolStripButton2_MouseLeave(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Rich Text File | *.rtf";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.SaveFile(sfd.FileName);
            }
            else
            {
                textBox1.Text = "The content has not been saved!";
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Rich Text File | *.rtf";

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(ofd.FileName);
            }
            else
            {
                textBox1.Text = "No file has been opened!";
            }
        }

        private void toolStripButton6_MouseEnter(object sender, EventArgs e)
        {
            textBox1.Text = "Save file";
        }

        private void toolStripButton6_MouseLeave(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void toolStripButton5_MouseEnter(object sender, EventArgs e)
        {
            textBox1.Text = "Set selection text to bold";
        }

        private void toolStripButton5_MouseLeave(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void toolStripButton4_MouseEnter(object sender, EventArgs e)
        {
            textBox1.Text = "Set selection text to italic";
        }

        private void toolStripButton4_MouseLeave(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void toolStripButton3_MouseEnter(object sender, EventArgs e)
        {
            textBox1.Text = "Underline selection";
        }

        private void toolStripButton3_MouseLeave(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void toolStripButton1_MouseEnter(object sender, EventArgs e)
        {
            textBox1.Text = "Change color for the selection";
        }

        private void toolStripButton1_MouseLeave(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            if (richTextBox1.SelectionFont.Bold != true)
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style | FontStyle.Bold);
            }
            else
            {
                richTextBox1.SelectionFont = new Font(richTextBox1.SelectionFont, richTextBox1.SelectionFont.Style ^ FontStyle.Bold);
            }
        }
    }
}
