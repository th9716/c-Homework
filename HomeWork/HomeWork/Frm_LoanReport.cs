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
    public partial class Frm_LoanReport : Form
    {
        
        public Frm_LoanReport(string str_amount,string str_year,string str_percent,string str_downpayment, string pmt,string total)
        {
            InitializeComponent();
            txt_money.Text = str_amount;
            txt_year.Text = str_year;
            txt_rate.Text = str_percent;
            txt_PMT.Text = pmt;
            txt_total.Text = total;
        }


        //private Frm_LoanReport

        //txt_PMT.Text = Loan.pmtTest;
        
    }
}
