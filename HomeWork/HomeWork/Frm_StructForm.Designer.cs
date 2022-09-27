namespace HomeWork
{
    partial class Frm_StructForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Add = new System.Windows.Forms.Button();
            this.Btn_Show = new System.Windows.Forms.Button();
            this.txt_Name = new System.Windows.Forms.TextBox();
            this.txt_Chinese = new System.Windows.Forms.TextBox();
            this.txt_Math = new System.Windows.Forms.TextBox();
            this.txt_English = new System.Windows.Forms.TextBox();
            this.Btn_HLGrades = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_ShowGrades = new System.Windows.Forms.RichTextBox();
            this.txt_ShowHLGrades = new System.Windows.Forms.RichTextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(148, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(148, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "國文";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(148, 216);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "數學";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(148, 273);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "英文";
            // 
            // Btn_Add
            // 
            this.Btn_Add.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_Add.Location = new System.Drawing.Point(105, 368);
            this.Btn_Add.Name = "Btn_Add";
            this.Btn_Add.Size = new System.Drawing.Size(93, 43);
            this.Btn_Add.TabIndex = 1;
            this.Btn_Add.Text = "儲存";
            this.Btn_Add.UseVisualStyleBackColor = true;
            this.Btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // Btn_Show
            // 
            this.Btn_Show.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_Show.Location = new System.Drawing.Point(234, 368);
            this.Btn_Show.Name = "Btn_Show";
            this.Btn_Show.Size = new System.Drawing.Size(167, 43);
            this.Btn_Show.TabIndex = 1;
            this.Btn_Show.Text = "顯示儲存內容";
            this.Btn_Show.UseVisualStyleBackColor = true;
            this.Btn_Show.Click += new System.EventHandler(this.Btn_Show_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Name.Location = new System.Drawing.Point(248, 100);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(123, 33);
            this.txt_Name.TabIndex = 2;
            this.txt_Name.Text = "0";
            this.txt_Name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Chinese
            // 
            this.txt_Chinese.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Chinese.Location = new System.Drawing.Point(248, 155);
            this.txt_Chinese.Name = "txt_Chinese";
            this.txt_Chinese.Size = new System.Drawing.Size(123, 33);
            this.txt_Chinese.TabIndex = 2;
            this.txt_Chinese.Text = "0";
            this.txt_Chinese.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Math
            // 
            this.txt_Math.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_Math.Location = new System.Drawing.Point(248, 213);
            this.txt_Math.Name = "txt_Math";
            this.txt_Math.Size = new System.Drawing.Size(123, 33);
            this.txt_Math.TabIndex = 2;
            this.txt_Math.Text = "0";
            this.txt_Math.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_English
            // 
            this.txt_English.Font = new System.Drawing.Font("微軟正黑體", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_English.Location = new System.Drawing.Point(248, 270);
            this.txt_English.Name = "txt_English";
            this.txt_English.Size = new System.Drawing.Size(123, 33);
            this.txt_English.TabIndex = 2;
            this.txt_English.Text = "0";
            this.txt_English.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Btn_HLGrades
            // 
            this.Btn_HLGrades.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Btn_HLGrades.Location = new System.Drawing.Point(513, 368);
            this.Btn_HLGrades.Name = "Btn_HLGrades";
            this.Btn_HLGrades.Size = new System.Drawing.Size(204, 43);
            this.Btn_HLGrades.TabIndex = 1;
            this.Btn_HLGrades.Text = "最高分/最低分科目";
            this.Btn_HLGrades.UseVisualStyleBackColor = true;
            this.Btn_HLGrades.Click += new System.EventHandler(this.Btn_HLGrades_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txt_ShowGrades);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(459, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 311);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "成績";
            // 
            // txt_ShowGrades
            // 
            this.txt_ShowGrades.Enabled = false;
            this.txt_ShowGrades.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_ShowGrades.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_ShowGrades.Location = new System.Drawing.Point(6, 23);
            this.txt_ShowGrades.Name = "txt_ShowGrades";
            this.txt_ShowGrades.Size = new System.Drawing.Size(285, 177);
            this.txt_ShowGrades.TabIndex = 0;
            this.txt_ShowGrades.Text = "";
            // 
            // txt_ShowHLGrades
            // 
            this.txt_ShowHLGrades.Enabled = false;
            this.txt_ShowHLGrades.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txt_ShowHLGrades.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txt_ShowHLGrades.Location = new System.Drawing.Point(465, 256);
            this.txt_ShowHLGrades.Name = "txt_ShowHLGrades";
            this.txt_ShowHLGrades.Size = new System.Drawing.Size(285, 99);
            this.txt_ShowHLGrades.TabIndex = 0;
            this.txt_ShowHLGrades.Text = "";
            // 
            // Frm_StructForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt_ShowHLGrades);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txt_English);
            this.Controls.Add(this.txt_Math);
            this.Controls.Add(this.txt_Chinese);
            this.Controls.Add(this.txt_Name);
            this.Controls.Add(this.Btn_HLGrades);
            this.Controls.Add(this.Btn_Show);
            this.Controls.Add(this.Btn_Add);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Frm_StructForm";
            this.Text = "Frm_StructForm";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Btn_Add;
        private System.Windows.Forms.Button Btn_Show;
        private System.Windows.Forms.TextBox txt_Name;
        private System.Windows.Forms.TextBox txt_Chinese;
        private System.Windows.Forms.TextBox txt_Math;
        private System.Windows.Forms.TextBox txt_English;
        private System.Windows.Forms.Button Btn_HLGrades;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox txt_ShowGrades;
        private System.Windows.Forms.RichTextBox txt_ShowHLGrades;
    }
}