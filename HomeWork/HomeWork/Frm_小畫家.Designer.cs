namespace HomeWork
{
    partial class Frm_小畫家
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.Btn_color = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.p_showcolor = new System.Windows.Forms.Panel();
            this.Btn_Clear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Location = new System.Drawing.Point(0, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(840, 485);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            this.pictureBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseUp);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(67, 192);
            this.trackBar1.Maximum = 30;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar1.Size = new System.Drawing.Size(45, 183);
            this.trackBar1.TabIndex = 1;
            this.trackBar1.ValueChanged += new System.EventHandler(this.trackBar1_ValueChanged);
            // 
            // Btn_color
            // 
            this.Btn_color.Location = new System.Drawing.Point(26, 36);
            this.Btn_color.Name = "Btn_color";
            this.Btn_color.Size = new System.Drawing.Size(103, 49);
            this.Btn_color.TabIndex = 2;
            this.Btn_color.Text = "顏色";
            this.Btn_color.UseVisualStyleBackColor = true;
            this.Btn_color.Click += new System.EventHandler(this.Btn_color_Click);
            // 
            // p_showcolor
            // 
            this.p_showcolor.BackColor = System.Drawing.SystemColors.Desktop;
            this.p_showcolor.Location = new System.Drawing.Point(27, 118);
            this.p_showcolor.Name = "p_showcolor";
            this.p_showcolor.Size = new System.Drawing.Size(102, 48);
            this.p_showcolor.TabIndex = 3;
            // 
            // Btn_Clear
            // 
            this.Btn_Clear.Location = new System.Drawing.Point(27, 404);
            this.Btn_Clear.Name = "Btn_Clear";
            this.Btn_Clear.Size = new System.Drawing.Size(103, 49);
            this.Btn_Clear.TabIndex = 4;
            this.Btn_Clear.Text = "Clear";
            this.Btn_Clear.UseVisualStyleBackColor = true;
            this.Btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.groupBox1.Controls.Add(this.Btn_Clear);
            this.groupBox1.Controls.Add(this.Btn_color);
            this.groupBox1.Controls.Add(this.trackBar1);
            this.groupBox1.Controls.Add(this.p_showcolor);
            this.groupBox1.Location = new System.Drawing.Point(694, -1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(146, 485);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // Frm_小畫家
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 482);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Frm_小畫家";
            this.Text = "Frm_小畫家";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button Btn_color;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Panel p_showcolor;
        private System.Windows.Forms.Button Btn_Clear;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}