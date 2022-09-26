namespace HomeWork
{
    partial class Frm_Loan
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Amount = new System.Windows.Forms.TextBox();
            this.txt_Year = new System.Windows.Forms.TextBox();
            this.txt_Percent = new System.Windows.Forms.TextBox();
            this.txt_DownPayment = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_PMT = new System.Windows.Forms.Button();
            this.Btn_Total = new System.Windows.Forms.Button();
            this.Btn_Report = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Amount
            // 
            this.txt_Amount.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Amount.Location = new System.Drawing.Point(333, 89);
            this.txt_Amount.Name = "txt_Amount";
            this.txt_Amount.Size = new System.Drawing.Size(247, 40);
            this.txt_Amount.TabIndex = 0;
            // 
            // txt_Year
            // 
            this.txt_Year.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Year.Location = new System.Drawing.Point(333, 141);
            this.txt_Year.Name = "txt_Year";
            this.txt_Year.Size = new System.Drawing.Size(247, 40);
            this.txt_Year.TabIndex = 1;
            // 
            // txt_Percent
            // 
            this.txt_Percent.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Percent.Location = new System.Drawing.Point(333, 196);
            this.txt_Percent.Name = "txt_Percent";
            this.txt_Percent.Size = new System.Drawing.Size(247, 40);
            this.txt_Percent.TabIndex = 2;
            // 
            // txt_DownPayment
            // 
            this.txt_DownPayment.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_DownPayment.Location = new System.Drawing.Point(333, 247);
            this.txt_DownPayment.Name = "txt_DownPayment";
            this.txt_DownPayment.Size = new System.Drawing.Size(247, 40);
            this.txt_DownPayment.TabIndex = 3;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label.Location = new System.Drawing.Point(201, 89);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(120, 27);
            this.label.TabIndex = 4;
            this.label.Text = "貸款金額";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(201, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 27);
            this.label2.TabIndex = 5;
            this.label2.Text = "期限(年)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(201, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 27);
            this.label3.TabIndex = 6;
            this.label3.Text = "利率(%)";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(201, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 27);
            this.label4.TabIndex = 7;
            this.label4.Text = "頭期款";
            // 
            // Btn_PMT
            // 
            this.Btn_PMT.Location = new System.Drawing.Point(177, 355);
            this.Btn_PMT.Name = "Btn_PMT";
            this.Btn_PMT.Size = new System.Drawing.Size(150, 52);
            this.Btn_PMT.TabIndex = 8;
            this.Btn_PMT.Text = "PMT(月付";
            this.Btn_PMT.UseVisualStyleBackColor = true;
            this.Btn_PMT.Click += new System.EventHandler(this.Btn_MonthPay_Click);
            // 
            // Btn_Total
            // 
            this.Btn_Total.Location = new System.Drawing.Point(333, 355);
            this.Btn_Total.Name = "Btn_Total";
            this.Btn_Total.Size = new System.Drawing.Size(150, 52);
            this.Btn_Total.TabIndex = 9;
            this.Btn_Total.Text = "總付款";
            this.Btn_Total.UseVisualStyleBackColor = true;
            this.Btn_Total.Click += new System.EventHandler(this.Btn_Total_Click);
            // 
            // Btn_Report
            // 
            this.Btn_Report.Location = new System.Drawing.Point(489, 355);
            this.Btn_Report.Name = "Btn_Report";
            this.Btn_Report.Size = new System.Drawing.Size(150, 52);
            this.Btn_Report.TabIndex = 10;
            this.Btn_Report.Text = "Report";
            this.Btn_Report.UseVisualStyleBackColor = true;
            this.Btn_Report.Click += new System.EventHandler(this.Btn_Report_Click);
            // 
            // Frm_Loan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Btn_Report);
            this.Controls.Add(this.Btn_Total);
            this.Controls.Add(this.Btn_PMT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txt_DownPayment);
            this.Controls.Add(this.txt_Percent);
            this.Controls.Add(this.txt_Year);
            this.Controls.Add(this.txt_Amount);
            this.Name = "Frm_Loan";
            this.Text = "貸款金額計算";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Amount;
        private System.Windows.Forms.TextBox txt_Year;
        private System.Windows.Forms.TextBox txt_Percent;
        private System.Windows.Forms.TextBox txt_DownPayment;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_PMT;
        private System.Windows.Forms.Button Btn_Total;
        private System.Windows.Forms.Button Btn_Report;
    }
}

