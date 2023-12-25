namespace LIT__
{
    partial class mainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.start_PB = new System.Windows.Forms.PictureBox();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.token_LV = new System.Windows.Forms.ListView();
            this.token_PB = new System.Windows.Forms.PictureBox();
            this.token_LB = new System.Windows.Forms.Label();
            this.midPanel = new System.Windows.Forms.Panel();
            this.code_PB = new System.Windows.Forms.PictureBox();
            this.codePanel = new System.Windows.Forms.Panel();
            this.linesCounter = new System.Windows.Forms.RichTextBox();
            this.CodeArea_RB = new System.Windows.Forms.RichTextBox();
            this.codeEditor_LB = new System.Windows.Forms.Label();
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.error_LV = new System.Windows.Forms.ListView();
            this.error_PB = new System.Windows.Forms.PictureBox();
            this.Error_LB = new System.Windows.Forms.Label();
            this.DragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.NameLB = new System.Windows.Forms.Label();
            this.minmizedPB = new System.Windows.Forms.PictureBox();
            this.fitPB = new System.Windows.Forms.PictureBox();
            this.closePB = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.start_PB)).BeginInit();
            this.rightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.token_PB)).BeginInit();
            this.midPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.code_PB)).BeginInit();
            this.codePanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error_PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minmizedPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePB)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.mainPanel.Controls.Add(this.panel1);
            this.mainPanel.Controls.Add(this.rightPanel);
            this.mainPanel.Controls.Add(this.midPanel);
            this.mainPanel.Controls.Add(this.bottomPanel);
            this.mainPanel.Location = new System.Drawing.Point(3, 30);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(794, 567);
            this.mainPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.start_PB);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 24);
            this.panel1.TabIndex = 4;
            // 
            // start_PB
            // 
            this.start_PB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.start_PB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("start_PB.BackgroundImage")));
            this.start_PB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.start_PB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.start_PB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.start_PB.Location = new System.Drawing.Point(2, 2);
            this.start_PB.Name = "start_PB";
            this.start_PB.Size = new System.Drawing.Size(54, 18);
            this.start_PB.TabIndex = 88;
            this.start_PB.TabStop = false;
            this.start_PB.Click += new System.EventHandler(this.start_PB_Click);
            // 
            // rightPanel
            // 
            this.rightPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rightPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.rightPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rightPanel.Controls.Add(this.token_LV);
            this.rightPanel.Controls.Add(this.token_PB);
            this.rightPanel.Controls.Add(this.token_LB);
            this.rightPanel.Location = new System.Drawing.Point(530, 24);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(264, 543);
            this.rightPanel.TabIndex = 3;
            // 
            // token_LV
            // 
            this.token_LV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.token_LV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.token_LV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.token_LV.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.token_LV.ForeColor = System.Drawing.Color.Gainsboro;
            this.token_LV.Location = new System.Drawing.Point(-1, 24);
            this.token_LV.Name = "token_LV";
            this.token_LV.Size = new System.Drawing.Size(264, 517);
            this.token_LV.TabIndex = 33;
            this.token_LV.UseCompatibleStateImageBehavior = false;
            this.token_LV.View = System.Windows.Forms.View.List;
            // 
            // token_PB
            // 
            this.token_PB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.token_PB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("token_PB.BackgroundImage")));
            this.token_PB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.token_PB.Location = new System.Drawing.Point(96, 3);
            this.token_PB.Name = "token_PB";
            this.token_PB.Size = new System.Drawing.Size(28, 18);
            this.token_PB.TabIndex = 90;
            this.token_PB.TabStop = false;
            // 
            // token_LB
            // 
            this.token_LB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.token_LB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.token_LB.ForeColor = System.Drawing.Color.Gainsboro;
            this.token_LB.Location = new System.Drawing.Point(119, 2);
            this.token_LB.Name = "token_LB";
            this.token_LB.Size = new System.Drawing.Size(84, 19);
            this.token_LB.TabIndex = 89;
            this.token_LB.Text = "Tokens";
            // 
            // midPanel
            // 
            this.midPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.midPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.midPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.midPanel.Controls.Add(this.code_PB);
            this.midPanel.Controls.Add(this.codePanel);
            this.midPanel.Controls.Add(this.codeEditor_LB);
            this.midPanel.Location = new System.Drawing.Point(0, 24);
            this.midPanel.Name = "midPanel";
            this.midPanel.Size = new System.Drawing.Size(528, 390);
            this.midPanel.TabIndex = 2;
            // 
            // code_PB
            // 
            this.code_PB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.code_PB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("code_PB.BackgroundImage")));
            this.code_PB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.code_PB.Location = new System.Drawing.Point(208, 2);
            this.code_PB.Name = "code_PB";
            this.code_PB.Size = new System.Drawing.Size(28, 18);
            this.code_PB.TabIndex = 88;
            this.code_PB.TabStop = false;
            // 
            // codePanel
            // 
            this.codePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.codePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.codePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.codePanel.Controls.Add(this.linesCounter);
            this.codePanel.Controls.Add(this.CodeArea_RB);
            this.codePanel.Location = new System.Drawing.Point(0, 24);
            this.codePanel.Name = "codePanel";
            this.codePanel.Size = new System.Drawing.Size(526, 364);
            this.codePanel.TabIndex = 0;
            // 
            // linesCounter
            // 
            this.linesCounter.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.linesCounter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.linesCounter.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.linesCounter.Cursor = System.Windows.Forms.Cursors.PanNE;
            this.linesCounter.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.linesCounter.ForeColor = System.Drawing.Color.DimGray;
            this.linesCounter.Location = new System.Drawing.Point(-1, -1);
            this.linesCounter.Name = "linesCounter";
            this.linesCounter.ReadOnly = true;
            this.linesCounter.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
            this.linesCounter.Size = new System.Drawing.Size(45, 360);
            this.linesCounter.TabIndex = 32;
            this.linesCounter.Text = "";
            // 
            // CodeArea_RB
            // 
            this.CodeArea_RB.AcceptsTab = true;
            this.CodeArea_RB.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CodeArea_RB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.CodeArea_RB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.CodeArea_RB.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CodeArea_RB.ForeColor = System.Drawing.Color.DarkGray;
            this.CodeArea_RB.Location = new System.Drawing.Point(51, 1);
            this.CodeArea_RB.Name = "CodeArea_RB";
            this.CodeArea_RB.Size = new System.Drawing.Size(474, 359);
            this.CodeArea_RB.TabIndex = 31;
            this.CodeArea_RB.Text = "";
            this.CodeArea_RB.SelectionChanged += new System.EventHandler(this.CodeArea_RB_SelectionChanged);
            this.CodeArea_RB.VScroll += new System.EventHandler(this.CodeArea_RB_VScroll);
            this.CodeArea_RB.FontChanged += new System.EventHandler(this.CodeArea_RB_FontChanged);
            this.CodeArea_RB.TextChanged += new System.EventHandler(this.CodeArea_RB_TextChanged);
            this.CodeArea_RB.MouseDown += new System.Windows.Forms.MouseEventHandler(this.CodeArea_RB_MouseDown);
            // 
            // codeEditor_LB
            // 
            this.codeEditor_LB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.codeEditor_LB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.codeEditor_LB.ForeColor = System.Drawing.Color.Gainsboro;
            this.codeEditor_LB.Location = new System.Drawing.Point(231, 2);
            this.codeEditor_LB.Name = "codeEditor_LB";
            this.codeEditor_LB.Size = new System.Drawing.Size(84, 19);
            this.codeEditor_LB.TabIndex = 87;
            this.codeEditor_LB.Text = "Code Editor";
            // 
            // bottomPanel
            // 
            this.bottomPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.bottomPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bottomPanel.Controls.Add(this.error_LV);
            this.bottomPanel.Controls.Add(this.error_PB);
            this.bottomPanel.Controls.Add(this.Error_LB);
            this.bottomPanel.Location = new System.Drawing.Point(0, 416);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(528, 151);
            this.bottomPanel.TabIndex = 1;
            // 
            // error_LV
            // 
            this.error_LV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.error_LV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.error_LV.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.error_LV.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold);
            this.error_LV.ForeColor = System.Drawing.Color.Gainsboro;
            this.error_LV.Location = new System.Drawing.Point(-1, 23);
            this.error_LV.Name = "error_LV";
            this.error_LV.Size = new System.Drawing.Size(527, 126);
            this.error_LV.TabIndex = 91;
            this.error_LV.UseCompatibleStateImageBehavior = false;
            this.error_LV.View = System.Windows.Forms.View.List;
            // 
            // error_PB
            // 
            this.error_PB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.error_PB.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("error_PB.BackgroundImage")));
            this.error_PB.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.error_PB.Location = new System.Drawing.Point(212, 3);
            this.error_PB.Name = "error_PB";
            this.error_PB.Size = new System.Drawing.Size(24, 16);
            this.error_PB.TabIndex = 90;
            this.error_PB.TabStop = false;
            // 
            // Error_LB
            // 
            this.Error_LB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Error_LB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Error_LB.ForeColor = System.Drawing.Color.Gainsboro;
            this.Error_LB.Location = new System.Drawing.Point(232, 1);
            this.Error_LB.Name = "Error_LB";
            this.Error_LB.Size = new System.Drawing.Size(84, 19);
            this.Error_LB.TabIndex = 89;
            this.Error_LB.Text = "Errors";
            // 
            // DragControl
            // 
            this.DragControl.Fixed = true;
            this.DragControl.Horizontal = true;
            this.DragControl.TargetControl = this;
            this.DragControl.Vertical = true;
            // 
            // NameLB
            // 
            this.NameLB.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.NameLB.Font = new System.Drawing.Font("Segoe UI Semibold", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLB.ForeColor = System.Drawing.Color.Gainsboro;
            this.NameLB.Location = new System.Drawing.Point(400, 6);
            this.NameLB.Name = "NameLB";
            this.NameLB.Size = new System.Drawing.Size(48, 19);
            this.NameLB.TabIndex = 0;
            this.NameLB.Text = "LIT++";
            // 
            // minmizedPB
            // 
            this.minmizedPB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minmizedPB.BackColor = System.Drawing.Color.Transparent;
            this.minmizedPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.minmizedPB.Image = ((System.Drawing.Image)(resources.GetObject("minmizedPB.Image")));
            this.minmizedPB.Location = new System.Drawing.Point(719, 2);
            this.minmizedPB.Name = "minmizedPB";
            this.minmizedPB.Size = new System.Drawing.Size(26, 26);
            this.minmizedPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.minmizedPB.TabIndex = 1;
            this.minmizedPB.TabStop = false;
            this.minmizedPB.Click += new System.EventHandler(this.minmizedPB_Click);
            // 
            // fitPB
            // 
            this.fitPB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fitPB.BackColor = System.Drawing.Color.Transparent;
            this.fitPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fitPB.Image = global::LIT__.Properties.Resources.Fit50px;
            this.fitPB.Location = new System.Drawing.Point(745, 2);
            this.fitPB.Name = "fitPB";
            this.fitPB.Size = new System.Drawing.Size(26, 26);
            this.fitPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.fitPB.TabIndex = 1;
            this.fitPB.TabStop = false;
            this.fitPB.Click += new System.EventHandler(this.fitPB_Click);
            // 
            // closePB
            // 
            this.closePB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closePB.BackColor = System.Drawing.Color.Transparent;
            this.closePB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closePB.Image = global::LIT__.Properties.Resources.Close50px;
            this.closePB.Location = new System.Drawing.Point(771, 2);
            this.closePB.Name = "closePB";
            this.closePB.Size = new System.Drawing.Size(26, 26);
            this.closePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.closePB.TabIndex = 0;
            this.closePB.TabStop = false;
            this.closePB.Click += new System.EventHandler(this.closePB_Click);
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.NameLB);
            this.Controls.Add(this.minmizedPB);
            this.Controls.Add(this.fitPB);
            this.Controls.Add(this.closePB);
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(640, 480);
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LIT++";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.Resize += new System.EventHandler(this.mainForm_Resize);
            this.mainPanel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.start_PB)).EndInit();
            this.rightPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.token_PB)).EndInit();
            this.midPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.code_PB)).EndInit();
            this.codePanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.error_PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minmizedPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fitPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closePB)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox closePB;
        private System.Windows.Forms.PictureBox fitPB;
        private System.Windows.Forms.PictureBox minmizedPB;
        private Bunifu.Framework.UI.BunifuDragControl DragControl;
        private System.Windows.Forms.Label NameLB;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel midPanel;
        private System.Windows.Forms.Panel bottomPanel;
        private System.Windows.Forms.Panel codePanel;
        private System.Windows.Forms.RichTextBox CodeArea_RB;
        private System.Windows.Forms.PictureBox code_PB;
        private System.Windows.Forms.Label codeEditor_LB;
        private System.Windows.Forms.PictureBox token_PB;
        private System.Windows.Forms.Label token_LB;
        private System.Windows.Forms.PictureBox error_PB;
        private System.Windows.Forms.Label Error_LB;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox start_PB;
        private System.Windows.Forms.ListView token_LV;
        private System.Windows.Forms.ListView error_LV;
        private System.Windows.Forms.RichTextBox linesCounter;
    }
}

