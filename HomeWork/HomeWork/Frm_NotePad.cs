using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class Frm_NotePad : Form
    {
        string filePath = ""; //used to stored file location
        public Frm_NotePad()
        {
            InitializeComponent();
        }

        private void 新增ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            filePath = "";
            richTextBox1.Text = "";
        }

        private void 開啟ToolStripMenuItem_Click(object sender, EventArgs e)
        {

            using (OpenFileDialog ofd = new OpenFileDialog() { Filter ="TextDocument|*.txt",ValidateNames=true,Multiselect=false})
            {
                //code for open a txt file
                if(ofd.ShowDialog() == DialogResult.OK)
                {
                    using(StreamReader sr= new StreamReader(ofd.FileName))
                    {
                        filePath = ofd.FileName;
                        Task<string> text = sr.ReadToEndAsync();
                        richTextBox1.Text=text.Result;
                    }
                }
            }
        }

        private void 儲存ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(filePath))
            {
                using(SaveFileDialog sfd=new SaveFileDialog() { Filter = "TextDocument|*.txt", ValidateNames = true })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using(StreamWriter sw=new StreamWriter(sfd.FileName))
                        {
                            sw.WriteLineAsync(richTextBox1.Text);
                        }
                    }
                }
            }
            else
            {
                using(StreamWriter sw=new StreamWriter(filePath))
                {
                    sw.WriteLineAsync(richTextBox1.Text);
                }
            }
        }

        private void 另存新檔ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "TextDocument|*.txt", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        sw.WriteLineAsync(richTextBox1.Text);
                    }
                }
            }
        }

        private void 列印ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            if(printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void 預覽列印ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();
        }

        private void 結束ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void 復原ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Undo();
        }

        private void 取消復原ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Redo();
        }
        private void 剪下ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Cut();
        }

        private void 複製ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Copy();
        }

        private void 貼上ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.Paste();
        }

        private void 全選ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectAll();
        }


        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(richTextBox1.Text, richTextBox1.Font, Brushes.Black, 12, 10);
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            if(richTextBox1.Text.Length > 0)
            {
                剪下ToolStripMenuItem.Enabled = true;
                複製ToolStripMenuItem.Enabled = true;
            }
            else
            {
                剪下ToolStripMenuItem.Enabled = false;
                複製ToolStripMenuItem.Enabled = false;
            }
        }

        private void 顏色ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            colorDialog1 = new ColorDialog();
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                this.richTextBox1.ForeColor =colorDialog1.Color;
            }
        }

        private void 字型ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fontDialog1  = new FontDialog();
            if(fontDialog1.ShowDialog() == DialogResult.OK)
            {
                this.richTextBox1.Font = fontDialog1.Font;
            }
        }


        private void 關於ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This Application is created by Yan. This is only for learning purpose.","關於",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.ForeColor=Color.Red;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.ForeColor = Color.Green;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.ForeColor = Color.Blue;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.richTextBox1.ForeColor = Color.Black;
        }
    }
}
