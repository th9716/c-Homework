namespace HomeWork
{
    partial class Frm_Alarm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lab_Time = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_S = new System.Windows.Forms.TextBox();
            this.txt_M = new System.Windows.Forms.TextBox();
            this.txt_H = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lab_Time
            // 
            this.lab_Time.AutoSize = true;
            this.lab_Time.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lab_Time.Location = new System.Drawing.Point(339, 38);
            this.lab_Time.Name = "lab_Time";
            this.lab_Time.Size = new System.Drawing.Size(79, 35);
            this.lab_Time.TabIndex = 0;
            this.lab_Time.Text = "Time";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_S);
            this.groupBox1.Controls.Add(this.txt_M);
            this.groupBox1.Controls.Add(this.txt_H);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(84, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(617, 334);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "SELECT TIME";
            // 
            // txt_S
            // 
            this.txt_S.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_S.Location = new System.Drawing.Point(374, 155);
            this.txt_S.Name = "txt_S";
            this.txt_S.Size = new System.Drawing.Size(24, 28);
            this.txt_S.TabIndex = 4;
            this.txt_S.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_M
            // 
            this.txt_M.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_M.Location = new System.Drawing.Point(323, 155);
            this.txt_M.Name = "txt_M";
            this.txt_M.Size = new System.Drawing.Size(24, 28);
            this.txt_M.TabIndex = 4;
            this.txt_M.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_H
            // 
            this.txt_H.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_H.Location = new System.Drawing.Point(271, 155);
            this.txt_H.Name = "txt_H";
            this.txt_H.Size = new System.Drawing.Size(24, 28);
            this.txt_H.TabIndex = 4;
            this.txt_H.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(265, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "__時__分__秒";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(285, 224);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(124, 30);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "SetAlarm";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.Click += new System.EventHandler(this.checkBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Alarm Time:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(281, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Alarm Time";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Frm_Alarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lab_Time);
            this.Name = "Frm_Alarm";
            this.Text = "Frm_Alarm";
            this.Load += new System.EventHandler(this.Frm_Alarm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lab_Time;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txt_S;
        private System.Windows.Forms.TextBox txt_M;
        private System.Windows.Forms.TextBox txt_H;
        private System.Windows.Forms.Label label3;
    }
}