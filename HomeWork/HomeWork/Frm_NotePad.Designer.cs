namespace HomeWork
{
    partial class Frm_NotePad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_NotePad));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.新增ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.開啟ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.儲存ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.另存新檔ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.列印ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.預覽列印ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.結束ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.編輯ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.復原ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.取消復原ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.剪下ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.複製ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.貼上ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.全選ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.工具ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.自訂ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.選項ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.格式ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.顏色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.字型ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.選擇顏色ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.說明ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.內容ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.索引ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.搜尋ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.關於ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem,
            this.編輯ToolStripMenuItem,
            this.工具ToolStripMenuItem,
            this.格式ToolStripMenuItem,
            this.說明ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.新增ToolStripMenuItem,
            this.開啟ToolStripMenuItem,
            this.toolStripMenuItem1,
            this.儲存ToolStripMenuItem,
            this.另存新檔ToolStripMenuItem,
            this.toolStripSeparator1,
            this.列印ToolStripMenuItem,
            this.預覽列印ToolStripMenuItem,
            this.toolStripSeparator2,
            this.結束ToolStripMenuItem});
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.檔案ToolStripMenuItem.Text = "檔案(&F)";
            // 
            // 新增ToolStripMenuItem
            // 
            this.新增ToolStripMenuItem.Name = "新增ToolStripMenuItem";
            this.新增ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.新增ToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.新增ToolStripMenuItem.Text = "新增(&N)";
            this.新增ToolStripMenuItem.Click += new System.EventHandler(this.新增ToolStripMenuItem_Click);
            // 
            // 開啟ToolStripMenuItem
            // 
            this.開啟ToolStripMenuItem.Name = "開啟ToolStripMenuItem";
            this.開啟ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.開啟ToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.開啟ToolStripMenuItem.Text = "開啟(&O)";
            this.開啟ToolStripMenuItem.Click += new System.EventHandler(this.開啟ToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(158, 6);
            // 
            // 儲存ToolStripMenuItem
            // 
            this.儲存ToolStripMenuItem.Name = "儲存ToolStripMenuItem";
            this.儲存ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.儲存ToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.儲存ToolStripMenuItem.Text = "儲存(&S)";
            this.儲存ToolStripMenuItem.Click += new System.EventHandler(this.儲存ToolStripMenuItem_Click);
            // 
            // 另存新檔ToolStripMenuItem
            // 
            this.另存新檔ToolStripMenuItem.Name = "另存新檔ToolStripMenuItem";
            this.另存新檔ToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.另存新檔ToolStripMenuItem.Text = "另存新檔(&A)";
            this.另存新檔ToolStripMenuItem.Click += new System.EventHandler(this.另存新檔ToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(158, 6);
            // 
            // 列印ToolStripMenuItem
            // 
            this.列印ToolStripMenuItem.Name = "列印ToolStripMenuItem";
            this.列印ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.列印ToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.列印ToolStripMenuItem.Text = "列印(&P)";
            this.列印ToolStripMenuItem.Click += new System.EventHandler(this.列印ToolStripMenuItem_Click);
            // 
            // 預覽列印ToolStripMenuItem
            // 
            this.預覽列印ToolStripMenuItem.Name = "預覽列印ToolStripMenuItem";
            this.預覽列印ToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.預覽列印ToolStripMenuItem.Text = "預覽列印(&V)";
            this.預覽列印ToolStripMenuItem.Click += new System.EventHandler(this.預覽列印ToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(158, 6);
            // 
            // 結束ToolStripMenuItem
            // 
            this.結束ToolStripMenuItem.Name = "結束ToolStripMenuItem";
            this.結束ToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.結束ToolStripMenuItem.Text = "結束(&X)";
            this.結束ToolStripMenuItem.Click += new System.EventHandler(this.結束ToolStripMenuItem_Click);
            // 
            // 編輯ToolStripMenuItem
            // 
            this.編輯ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.復原ToolStripMenuItem,
            this.取消復原ToolStripMenuItem,
            this.toolStripSeparator3,
            this.剪下ToolStripMenuItem,
            this.複製ToolStripMenuItem,
            this.貼上ToolStripMenuItem,
            this.toolStripSeparator4,
            this.全選ToolStripMenuItem});
            this.編輯ToolStripMenuItem.Name = "編輯ToolStripMenuItem";
            this.編輯ToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.編輯ToolStripMenuItem.Text = "編輯(&E)";
            // 
            // 復原ToolStripMenuItem
            // 
            this.復原ToolStripMenuItem.Name = "復原ToolStripMenuItem";
            this.復原ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.復原ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.復原ToolStripMenuItem.Text = "復原(&Z)";
            this.復原ToolStripMenuItem.Click += new System.EventHandler(this.復原ToolStripMenuItem_Click);
            // 
            // 取消復原ToolStripMenuItem
            // 
            this.取消復原ToolStripMenuItem.Name = "取消復原ToolStripMenuItem";
            this.取消復原ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.取消復原ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.取消復原ToolStripMenuItem.Text = "取消復原(&R)";
            this.取消復原ToolStripMenuItem.Click += new System.EventHandler(this.取消復原ToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(177, 6);
            // 
            // 剪下ToolStripMenuItem
            // 
            this.剪下ToolStripMenuItem.Enabled = false;
            this.剪下ToolStripMenuItem.Name = "剪下ToolStripMenuItem";
            this.剪下ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.剪下ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.剪下ToolStripMenuItem.Text = "剪下(&X)";
            this.剪下ToolStripMenuItem.Click += new System.EventHandler(this.剪下ToolStripMenuItem_Click);
            // 
            // 複製ToolStripMenuItem
            // 
            this.複製ToolStripMenuItem.Enabled = false;
            this.複製ToolStripMenuItem.Name = "複製ToolStripMenuItem";
            this.複製ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.複製ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.複製ToolStripMenuItem.Text = "複製(&C)";
            this.複製ToolStripMenuItem.Click += new System.EventHandler(this.複製ToolStripMenuItem_Click);
            // 
            // 貼上ToolStripMenuItem
            // 
            this.貼上ToolStripMenuItem.Name = "貼上ToolStripMenuItem";
            this.貼上ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.貼上ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.貼上ToolStripMenuItem.Text = "貼上(&V)";
            this.貼上ToolStripMenuItem.Click += new System.EventHandler(this.貼上ToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(177, 6);
            // 
            // 全選ToolStripMenuItem
            // 
            this.全選ToolStripMenuItem.Name = "全選ToolStripMenuItem";
            this.全選ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.全選ToolStripMenuItem.Text = "全選(&A)";
            this.全選ToolStripMenuItem.Click += new System.EventHandler(this.全選ToolStripMenuItem_Click);
            // 
            // 工具ToolStripMenuItem
            // 
            this.工具ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.自訂ToolStripMenuItem,
            this.選項ToolStripMenuItem});
            this.工具ToolStripMenuItem.Name = "工具ToolStripMenuItem";
            this.工具ToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.工具ToolStripMenuItem.Text = "工具(&T)";
            // 
            // 自訂ToolStripMenuItem
            // 
            this.自訂ToolStripMenuItem.Name = "自訂ToolStripMenuItem";
            this.自訂ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.自訂ToolStripMenuItem.Text = "自訂(&C)";
            // 
            // 選項ToolStripMenuItem
            // 
            this.選項ToolStripMenuItem.Name = "選項ToolStripMenuItem";
            this.選項ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.選項ToolStripMenuItem.Text = "選項(&O)";
            // 
            // 格式ToolStripMenuItem
            // 
            this.格式ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.顏色ToolStripMenuItem,
            this.字型ToolStripMenuItem,
            this.選擇顏色ToolStripMenuItem});
            this.格式ToolStripMenuItem.Name = "格式ToolStripMenuItem";
            this.格式ToolStripMenuItem.Size = new System.Drawing.Size(63, 20);
            this.格式ToolStripMenuItem.Text = "格式(&M)";
            // 
            // 顏色ToolStripMenuItem
            // 
            this.顏色ToolStripMenuItem.Name = "顏色ToolStripMenuItem";
            this.顏色ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.顏色ToolStripMenuItem.Text = "顏色(&C)";
            this.顏色ToolStripMenuItem.Click += new System.EventHandler(this.顏色ToolStripMenuItem_Click);
            // 
            // 字型ToolStripMenuItem
            // 
            this.字型ToolStripMenuItem.Name = "字型ToolStripMenuItem";
            this.字型ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.字型ToolStripMenuItem.Text = "字型(&V)";
            this.字型ToolStripMenuItem.Click += new System.EventHandler(this.字型ToolStripMenuItem_Click);
            // 
            // 選擇顏色ToolStripMenuItem
            // 
            this.選擇顏色ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.redToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.blackToolStripMenuItem});
            this.選擇顏色ToolStripMenuItem.Name = "選擇顏色ToolStripMenuItem";
            this.選擇顏色ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.選擇顏色ToolStripMenuItem.Text = "選擇顏色";
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // blackToolStripMenuItem
            // 
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.blackToolStripMenuItem.Text = "Black";
            this.blackToolStripMenuItem.Click += new System.EventHandler(this.blackToolStripMenuItem_Click);
            // 
            // 說明ToolStripMenuItem
            // 
            this.說明ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.內容ToolStripMenuItem,
            this.索引ToolStripMenuItem,
            this.搜尋ToolStripMenuItem,
            this.toolStripSeparator5,
            this.關於ToolStripMenuItem});
            this.說明ToolStripMenuItem.Name = "說明ToolStripMenuItem";
            this.說明ToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.說明ToolStripMenuItem.Text = "說明(&H)";
            // 
            // 內容ToolStripMenuItem
            // 
            this.內容ToolStripMenuItem.Name = "內容ToolStripMenuItem";
            this.內容ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.內容ToolStripMenuItem.Text = "內容(&C)";
            // 
            // 索引ToolStripMenuItem
            // 
            this.索引ToolStripMenuItem.Name = "索引ToolStripMenuItem";
            this.索引ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.索引ToolStripMenuItem.Text = "索引(&I)";
            // 
            // 搜尋ToolStripMenuItem
            // 
            this.搜尋ToolStripMenuItem.Name = "搜尋ToolStripMenuItem";
            this.搜尋ToolStripMenuItem.Size = new System.Drawing.Size(114, 22);
            this.搜尋ToolStripMenuItem.Text = "搜尋(&S)";
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(111, 6);
            // 
            // 關於ToolStripMenuItem
            // 
            this.關於ToolStripMenuItem.Name = "關於ToolStripMenuItem";
            this.關於ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.關於ToolStripMenuItem.Text = "關於(&A)";
            this.關於ToolStripMenuItem.Click += new System.EventHandler(this.關於ToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(0, 27);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(800, 425);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Frm_NotePad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Frm_NotePad";
            this.Text = "Frm_NotePad";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 新增ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 開啟ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 儲存ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 另存新檔ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 列印ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 預覽列印ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 結束ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 編輯ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 復原ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 取消復原ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 剪下ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 複製ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 貼上ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 全選ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 工具ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 自訂ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 選項ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 格式ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 顏色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 字型ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 選擇顏色ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 說明ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 內容ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 索引ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 搜尋ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 關於ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
    }
}