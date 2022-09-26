using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWork
{

    //-------------------------------------------------------------
    


    //------------------------------------------------------------
    public partial class Frm_Loan : Form
    {


        
        public Frm_Loan()
        {
            InitializeComponent();
        }

        /*
            


         每月應還本息金額之平均攤還率＝{[(1＋月利率)月數]×月利率}÷{[(1＋月利率)月數]－1}
        (公式中：月利率 ＝ 年利率／12 ； 月數=貸款年期 ｘ 12)
        平均每月應還本息金額＝貸款本金×每月應還本息金額之平均攤還率
        ＝每月應還本金金額＋每月應付利息金額
        每月應付利息金額＝本金餘額×月利率
        每月應還本金金額＝平均每月應還本息金額－每月應付利息金額


         */

        private void Btn_MonthPay_Click(object sender, EventArgs e)
        {

            double Money = double.Parse(txt_Amount.Text); /*貸款金額*/
            double Year = double.Parse(txt_Year.Text); /*期限年*/
            double Rate = double.Parse(txt_Percent.Text); /*年利率*/
            double DownPayment = double.Parse(txt_DownPayment.Text); /*頭期款*/

            double month = (Year * 12);
            double Mpercent =(1.0 + Rate / 12 /100); 
            double rpn = Math.Pow(Mpercent, month);
            double PMT = (Money * rpn *(Mpercent - 1) / (rpn - 1));//月應付
            

            



            MessageBox.Show($"月付額是: {PMT:c0}");

            //todo頭期款
        }


        private void Btn_Total_Click(object sender, EventArgs e)
        {

            double Money = double.Parse(txt_Amount.Text); /*貸款金額*/
            double Year = double.Parse(txt_Year.Text); /*期限年*/
            double Rate = double.Parse(txt_Percent.Text); /*年利率*/
            double DownPayment = double.Parse(txt_DownPayment.Text); /*頭期款*/

            double month = (Year * 12);
            double Mpercent = (1.0 + Rate / 12 / 100);
            double rpn = Math.Pow(Mpercent, month);
            double PMT = (Money * rpn * (Mpercent - 1) / (rpn - 1)); //月應付
            double Total = (PMT) * (month); //總付款
      
            MessageBox.Show($"總付款: {Total:c0}");


        }

        



        private void Btn_Report_Click(object sender, EventArgs e)
        {
            //--------------------------------------------------

            double Money = double.Parse(txt_Amount.Text); /*貸款金額*/
            double Year = double.Parse(txt_Year.Text); /*期限年*/
            double Rate = double.Parse(txt_Percent.Text); /*年利率*/
            double DownPayment = double.Parse(txt_DownPayment.Text); /*頭期款*/

            double month = (Year * 12);
            double Mpercent = (1.0 + Rate / 12 / 100);
            double rpn = Math.Pow(Mpercent, month);
            double PMT = (Money * rpn * (Mpercent - 1) / (rpn - 1));//月應付
            string pmt = PMT.ToString();
            double Total = (PMT) * (month); //總付款
            string total = (Total).ToString();

            string str_amount =Money.ToString();
            string str_year = Year.ToString();
            string str_percent = Rate.ToString();
            string str_downpayment = DownPayment.ToString();


            Frm_LoanReport Frp = new Frm_LoanReport(str_amount, str_year, str_percent, str_downpayment,pmt, total);
            
            Frp.Show();
            
          


           





        }
    }
    
}
