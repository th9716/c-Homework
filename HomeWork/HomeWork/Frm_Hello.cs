using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{
    public partial class Frm_Hello : Form
    {
        public Frm_Hello()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hello,我是{txtName.Text},\n" + $"英文名字是{txtEName.Text},\n" + $"性別是{txtSex.Text},\n" + $"星座是{txtStar.Text},\n" + $"很高興認識你。");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Hi,我是{txtName.Text},\n" + $"英文名字是{txtEName.Text},\n" + $"性別是{txtSex.Text},\n" + $"星座是{txtStar.Text},\n" + $"很高興認識你。");
        }
    }
}
