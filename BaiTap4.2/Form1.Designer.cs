namespace BaiTap4._2
{
    partial class frm_BtLTWindows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BtLTWindows));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_NewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Menu_OpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_SaveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_ = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Compile = new System.Windows.Forms.ToolStripMenuItem();
            this.Menu_Run = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_NewFile = new System.Windows.Forms.ToolStripButton();
            this.btn_OpenFile = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.btn_Run = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_Sodong = new System.Windows.Forms.TextBox();
            this.lbl_Sodong = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtb_Code = new System.Windows.Forms.RichTextBox();
            this.sta_Strip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.status = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.sta_Strip.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.Menu_});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(948, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_NewFile,
            this.toolStripSeparator1,
            this.Menu_OpenFile,
            this.Menu_SaveFile,
            this.Menu_Exit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // Menu_NewFile
            // 
            this.Menu_NewFile.Image = ((System.Drawing.Image)(resources.GetObject("Menu_NewFile.Image")));
            this.Menu_NewFile.Name = "Menu_NewFile";
            this.Menu_NewFile.Size = new System.Drawing.Size(195, 26);
            this.Menu_NewFile.Text = "Tạo Mới Crtl+N";
            this.Menu_NewFile.Click += new System.EventHandler(this.Menu_NewFile_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(192, 6);
            // 
            // Menu_OpenFile
            // 
            this.Menu_OpenFile.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Menu_OpenFile.Image = ((System.Drawing.Image)(resources.GetObject("Menu_OpenFile.Image")));
            this.Menu_OpenFile.Name = "Menu_OpenFile";
            this.Menu_OpenFile.Size = new System.Drawing.Size(195, 26);
            this.Menu_OpenFile.Text = "Mở File Crtl+O";
            this.Menu_OpenFile.Click += new System.EventHandler(this.Menu_OpenFile_Click);
            // 
            // Menu_SaveFile
            // 
            this.Menu_SaveFile.Image = ((System.Drawing.Image)(resources.GetObject("Menu_SaveFile.Image")));
            this.Menu_SaveFile.Name = "Menu_SaveFile";
            this.Menu_SaveFile.Size = new System.Drawing.Size(195, 26);
            this.Menu_SaveFile.Text = "Lưu File Crtl+S";
            this.Menu_SaveFile.Click += new System.EventHandler(this.Menu_SaveFile_Click);
            // 
            // Menu_Exit
            // 
            this.Menu_Exit.Name = "Menu_Exit";
            this.Menu_Exit.Size = new System.Drawing.Size(195, 26);
            this.Menu_Exit.Text = "Thoát ALT+F4";
            this.Menu_Exit.Click += new System.EventHandler(this.Menu_Exit_Click);
            // 
            // Menu_
            // 
            this.Menu_.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Menu_Compile,
            this.Menu_Run});
            this.Menu_.Name = "Menu_";
            this.Menu_.Size = new System.Drawing.Size(157, 24);
            this.Menu_.Text = "Biên dịch và thực thi";
            // 
            // Menu_Compile
            // 
            this.Menu_Compile.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Compile.Image")));
            this.Menu_Compile.Name = "Menu_Compile";
            this.Menu_Compile.Size = new System.Drawing.Size(224, 26);
            this.Menu_Compile.Text = "Biên dịch F6";
            this.Menu_Compile.Click += new System.EventHandler(this.Menu_Compile_Click);
            // 
            // Menu_Run
            // 
            this.Menu_Run.Image = ((System.Drawing.Image)(resources.GetObject("Menu_Run.Image")));
            this.Menu_Run.Name = "Menu_Run";
            this.Menu_Run.Size = new System.Drawing.Size(224, 26);
            this.Menu_Run.Text = "Thực thi F5";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_NewFile,
            this.btn_OpenFile,
            this.toolStripSeparator2,
            this.btn_Run,
            this.toolStripLabel1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(948, 27);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_NewFile
            // 
            this.btn_NewFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_NewFile.Image = ((System.Drawing.Image)(resources.GetObject("btn_NewFile.Image")));
            this.btn_NewFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_NewFile.Name = "btn_NewFile";
            this.btn_NewFile.Size = new System.Drawing.Size(29, 24);
            this.btn_NewFile.Text = "toolStripButton1";
            this.btn_NewFile.Click += new System.EventHandler(this.btn_NewFile_Click_1);
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_OpenFile.Image = ((System.Drawing.Image)(resources.GetObject("btn_OpenFile.Image")));
            this.btn_OpenFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Size = new System.Drawing.Size(29, 24);
            this.btn_OpenFile.Text = "toolStripButton2";
            this.btn_OpenFile.Click += new System.EventHandler(this.btn_OpenFile_Click_1);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 27);
            // 
            // btn_Run
            // 
            this.btn_Run.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Run.Image = ((System.Drawing.Image)(resources.GetObject("btn_Run.Image")));
            this.btn_Run.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Run.Name = "btn_Run";
            this.btn_Run.Size = new System.Drawing.Size(29, 24);
            this.btn_Run.Text = "toolStripButton3";
            this.btn_Run.Click += new System.EventHandler(this.btn_Run_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(65, 24);
            this.toolStripLabel1.Text = "Thực Thi";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_Sodong);
            this.panel1.Controls.Add(this.lbl_Sodong);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.rtb_Code);
            this.panel1.Location = new System.Drawing.Point(12, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 363);
            this.panel1.TabIndex = 3;
            // 
            // txt_Sodong
            // 
            this.txt_Sodong.BackColor = System.Drawing.Color.Silver;
            this.txt_Sodong.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Sodong.Location = new System.Drawing.Point(4, 3);
            this.txt_Sodong.Multiline = true;
            this.txt_Sodong.Name = "txt_Sodong";
            this.txt_Sodong.Size = new System.Drawing.Size(67, 347);
            this.txt_Sodong.TabIndex = 7;
            // 
            // lbl_Sodong
            // 
            this.lbl_Sodong.AutoSize = true;
            this.lbl_Sodong.Location = new System.Drawing.Point(17, 18);
            this.lbl_Sodong.Name = "lbl_Sodong";
            this.lbl_Sodong.Size = new System.Drawing.Size(0, 16);
            this.lbl_Sodong.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 16);
            this.label1.TabIndex = 5;
            // 
            // rtb_Code
            // 
            this.rtb_Code.Font = new System.Drawing.Font("Cascadia Mono", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_Code.ForeColor = System.Drawing.Color.Black;
            this.rtb_Code.Location = new System.Drawing.Point(77, 3);
            this.rtb_Code.Name = "rtb_Code";
            this.rtb_Code.Size = new System.Drawing.Size(844, 347);
            this.rtb_Code.TabIndex = 4;
            this.rtb_Code.Text = "";
            // 
            // sta_Strip
            // 
            this.sta_Strip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.sta_Strip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.status});
            this.sta_Strip.Location = new System.Drawing.Point(0, 424);
            this.sta_Strip.Name = "sta_Strip";
            this.sta_Strip.Size = new System.Drawing.Size(948, 26);
            this.sta_Strip.TabIndex = 5;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Cascadia Mono", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.Lime;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(0, 20);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 20);
            // 
            // status
            // 
            this.status.ForeColor = System.Drawing.Color.Lime;
            this.status.Name = "status";
            this.status.Size = new System.Drawing.Size(18, 20);
            this.status.Text = "...";
            // 
            // frm_BtLTWindows
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(948, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.sta_Strip);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Name = "frm_BtLTWindows";
            this.Text = "Bài tập LT Windows";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.sta_Strip.ResumeLayout(false);
            this.sta_Strip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Menu_NewFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Menu_OpenFile;
        private System.Windows.Forms.ToolStripMenuItem Menu_SaveFile;
        private System.Windows.Forms.ToolStripMenuItem Menu_Exit;
        private System.Windows.Forms.ToolStripMenuItem Menu_;
        private System.Windows.Forms.ToolStripMenuItem Menu_Compile;
        private System.Windows.Forms.ToolStripMenuItem Menu_Run;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_NewFile;
        private System.Windows.Forms.ToolStripButton btn_OpenFile;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_Run;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox rtb_Code;
        private System.Windows.Forms.StatusStrip sta_Strip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label lbl_Sodong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Sodong;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel status;
    }
}

