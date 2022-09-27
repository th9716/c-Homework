namespace HomeWork
{
    partial class Frm_MyClac
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Num1 = new System.Windows.Forms.TextBox();
            this.txt_Num2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_Answer = new System.Windows.Forms.TextBox();
            this.Btn_Plus = new System.Windows.Forms.Button();
            this.Btn_Minus = new System.Windows.Forms.Button();
            this.Btn_Times = new System.Windows.Forms.Button();
            this.Btn_DividedBy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(39, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 26);
            this.label1.TabIndex = 0;
            this.label1.Text = "Num1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(39, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 26);
            this.label2.TabIndex = 1;
            this.label2.Text = "Num2:";
            // 
            // txt_Num1
            // 
            this.txt_Num1.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Num1.Location = new System.Drawing.Point(146, 51);
            this.txt_Num1.Name = "txt_Num1";
            this.txt_Num1.Size = new System.Drawing.Size(137, 30);
            this.txt_Num1.TabIndex = 2;
            // 
            // txt_Num2
            // 
            this.txt_Num2.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Num2.Location = new System.Drawing.Point(146, 103);
            this.txt_Num2.Name = "txt_Num2";
            this.txt_Num2.Size = new System.Drawing.Size(137, 30);
            this.txt_Num2.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(39, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Answer:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(12, 150);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(332, 26);
            this.label4.TabIndex = 5;
            this.label4.Text = "====================";
            // 
            // txt_Answer
            // 
            this.txt_Answer.Font = new System.Drawing.Font("新細明體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Answer.Location = new System.Drawing.Point(146, 201);
            this.txt_Answer.Name = "txt_Answer";
            this.txt_Answer.Size = new System.Drawing.Size(137, 30);
            this.txt_Answer.TabIndex = 6;
            // 
            // Btn_Plus
            // 
            this.Btn_Plus.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_Plus.Location = new System.Drawing.Point(346, 34);
            this.Btn_Plus.Name = "Btn_Plus";
            this.Btn_Plus.Size = new System.Drawing.Size(58, 43);
            this.Btn_Plus.TabIndex = 7;
            this.Btn_Plus.Text = "+";
            this.Btn_Plus.UseVisualStyleBackColor = true;
            this.Btn_Plus.Click += new System.EventHandler(this.Btn_Plus_Click);
            // 
            // Btn_Minus
            // 
            this.Btn_Minus.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_Minus.Location = new System.Drawing.Point(346, 90);
            this.Btn_Minus.Name = "Btn_Minus";
            this.Btn_Minus.Size = new System.Drawing.Size(58, 43);
            this.Btn_Minus.TabIndex = 8;
            this.Btn_Minus.Text = "-";
            this.Btn_Minus.UseVisualStyleBackColor = true;
            this.Btn_Minus.Click += new System.EventHandler(this.Btn_Minus_Click);
            // 
            // Btn_Times
            // 
            this.Btn_Times.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_Times.Location = new System.Drawing.Point(346, 145);
            this.Btn_Times.Name = "Btn_Times";
            this.Btn_Times.Size = new System.Drawing.Size(58, 43);
            this.Btn_Times.TabIndex = 9;
            this.Btn_Times.Text = "*";
            this.Btn_Times.UseVisualStyleBackColor = true;
            this.Btn_Times.Click += new System.EventHandler(this.Btn_Times_Click);
            // 
            // Btn_DividedBy
            // 
            this.Btn_DividedBy.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_DividedBy.Location = new System.Drawing.Point(346, 198);
            this.Btn_DividedBy.Name = "Btn_DividedBy";
            this.Btn_DividedBy.Size = new System.Drawing.Size(58, 43);
            this.Btn_DividedBy.TabIndex = 10;
            this.Btn_DividedBy.Text = "/";
            this.Btn_DividedBy.UseVisualStyleBackColor = true;
            this.Btn_DividedBy.Click += new System.EventHandler(this.Btn_DividedBy_Click);
            // 
            // Frm_MyClac
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 274);
            this.Controls.Add(this.Btn_DividedBy);
            this.Controls.Add(this.Btn_Times);
            this.Controls.Add(this.Btn_Minus);
            this.Controls.Add(this.Btn_Plus);
            this.Controls.Add(this.txt_Answer);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Num2);
            this.Controls.Add(this.txt_Num1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_MyClac";
            this.Text = "Frm_MyClac";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_Num1;
        private System.Windows.Forms.TextBox txt_Num2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_Answer;
        private System.Windows.Forms.Button Btn_Plus;
        private System.Windows.Forms.Button Btn_Minus;
        private System.Windows.Forms.Button Btn_Times;
        private System.Windows.Forms.Button Btn_DividedBy;
    }
}