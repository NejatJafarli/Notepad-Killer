
namespace WindowsFormsApp13
{
    partial class Form1
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.cbSize = new System.Windows.Forms.ComboBox();
			this.btnUnderLine = new Guna.UI2.WinForms.Guna2Button();
			this.btnItalic = new Guna.UI2.WinForms.Guna2Button();
			this.btnBold = new Guna.UI2.WinForms.Guna2Button();
			this.cbFont = new System.Windows.Forms.ComboBox();
			this.txt = new System.Windows.Forms.RichTextBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnTxtCenter = new Guna.UI2.WinForms.Guna2Button();
			this.btnTxtRight = new Guna.UI2.WinForms.Guna2Button();
			this.btnTxtLeft = new Guna.UI2.WinForms.Guna2Button();
			this.label4 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.cbColor = new System.Windows.Forms.ComboBox();
			this.lblColor = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.btnSave = new Guna.UI2.WinForms.Guna2Button();
			this.txtSave = new Guna.UI2.WinForms.Guna2TextBox();
			this.btnOpen = new Guna.UI2.WinForms.Guna2Button();
			this.txtLoad = new Guna.UI2.WinForms.Guna2TextBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel8 = new System.Windows.Forms.Panel();
			this.Star = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.panel9 = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel5.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel8.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Italic);
			this.label1.Location = new System.Drawing.Point(57, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 24);
			this.label1.TabIndex = 1;
			this.label1.Text = "Font";
			// 
			// label2
			// 
			this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(14, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(45, 24);
			this.label2.TabIndex = 3;
			this.label2.Text = "Size";
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.Top;
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Italic);
			this.label3.Location = new System.Drawing.Point(2, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(89, 24);
			this.label3.TabIndex = 4;
			this.label3.Text = "FontStyle";
			// 
			// cbSize
			// 
			this.cbSize.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbSize.ForeColor = System.Drawing.Color.Black;
			this.cbSize.FormattingEnabled = true;
			this.cbSize.IntegralHeight = false;
			this.cbSize.ItemHeight = 20;
			this.cbSize.Location = new System.Drawing.Point(2, 25);
			this.cbSize.MaxDropDownItems = 13;
			this.cbSize.Name = "cbSize";
			this.cbSize.Size = new System.Drawing.Size(67, 28);
			this.cbSize.TabIndex = 2;
			// 
			// btnUnderLine
			// 
			this.btnUnderLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnUnderLine.Animated = true;
			this.btnUnderLine.BackColor = System.Drawing.Color.Transparent;
			this.btnUnderLine.BorderColor = System.Drawing.Color.White;
			this.btnUnderLine.BorderThickness = 2;
			this.btnUnderLine.CheckedState.Parent = this.btnUnderLine;
			this.btnUnderLine.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnUnderLine.CustomImages.Parent = this.btnUnderLine;
			this.btnUnderLine.FillColor = System.Drawing.Color.White;
			this.btnUnderLine.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.btnUnderLine.ForeColor = System.Drawing.Color.Black;
			this.btnUnderLine.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(206)))), ((int)(((byte)(249)))));
			this.btnUnderLine.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
			this.btnUnderLine.HoverState.Parent = this.btnUnderLine;
			this.btnUnderLine.Image = ((System.Drawing.Image)(resources.GetObject("btnUnderLine.Image")));
			this.btnUnderLine.ImageOffset = new System.Drawing.Point(1, 0);
			this.btnUnderLine.Location = new System.Drawing.Point(65, 28);
			this.btnUnderLine.Name = "btnUnderLine";
			this.btnUnderLine.ShadowDecoration.Parent = this.btnUnderLine;
			this.btnUnderLine.Size = new System.Drawing.Size(25, 25);
			this.btnUnderLine.TabIndex = 9;
			this.btnUnderLine.TextOffset = new System.Drawing.Point(-1, 0);
			this.btnUnderLine.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
			this.btnUnderLine.Click += new System.EventHandler(this.btnUnderLine_Click);
			// 
			// btnItalic
			// 
			this.btnItalic.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnItalic.Animated = true;
			this.btnItalic.BackColor = System.Drawing.Color.White;
			this.btnItalic.BorderColor = System.Drawing.Color.White;
			this.btnItalic.BorderThickness = 2;
			this.btnItalic.CheckedState.Parent = this.btnItalic;
			this.btnItalic.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnItalic.CustomImages.Parent = this.btnItalic;
			this.btnItalic.FillColor = System.Drawing.Color.White;
			this.btnItalic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.btnItalic.ForeColor = System.Drawing.Color.Black;
			this.btnItalic.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(206)))), ((int)(((byte)(249)))));
			this.btnItalic.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
			this.btnItalic.HoverState.Parent = this.btnItalic;
			this.btnItalic.Image = ((System.Drawing.Image)(resources.GetObject("btnItalic.Image")));
			this.btnItalic.Location = new System.Drawing.Point(33, 28);
			this.btnItalic.Name = "btnItalic";
			this.btnItalic.ShadowDecoration.Parent = this.btnItalic;
			this.btnItalic.Size = new System.Drawing.Size(25, 25);
			this.btnItalic.TabIndex = 9;
			this.btnItalic.TextOffset = new System.Drawing.Point(-1, 0);
			this.btnItalic.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
			this.btnItalic.Click += new System.EventHandler(this.btnItalic_Click);
			// 
			// btnBold
			// 
			this.btnBold.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnBold.Animated = true;
			this.btnBold.BackColor = System.Drawing.Color.White;
			this.btnBold.BorderColor = System.Drawing.Color.White;
			this.btnBold.BorderThickness = 2;
			this.btnBold.CheckedState.Parent = this.btnBold;
			this.btnBold.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnBold.CustomImages.Parent = this.btnBold;
			this.btnBold.FillColor = System.Drawing.Color.White;
			this.btnBold.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.btnBold.ForeColor = System.Drawing.Color.Black;
			this.btnBold.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(206)))), ((int)(((byte)(249)))));
			this.btnBold.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
			this.btnBold.HoverState.Parent = this.btnBold;
			this.btnBold.Image = ((System.Drawing.Image)(resources.GetObject("btnBold.Image")));
			this.btnBold.Location = new System.Drawing.Point(1, 28);
			this.btnBold.Name = "btnBold";
			this.btnBold.ShadowDecoration.Parent = this.btnBold;
			this.btnBold.Size = new System.Drawing.Size(25, 25);
			this.btnBold.TabIndex = 9;
			this.btnBold.TextOffset = new System.Drawing.Point(-1, 0);
			this.btnBold.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
			this.btnBold.Click += new System.EventHandler(this.btnBold_Click);
			// 
			// cbFont
			// 
			this.cbFont.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbFont.ForeColor = System.Drawing.Color.Black;
			this.cbFont.FormattingEnabled = true;
			this.cbFont.IntegralHeight = false;
			this.cbFont.ItemHeight = 20;
			this.cbFont.Location = new System.Drawing.Point(3, 23);
			this.cbFont.MaxDropDownItems = 13;
			this.cbFont.Name = "cbFont";
			this.cbFont.Size = new System.Drawing.Size(150, 28);
			this.cbFont.TabIndex = 6;
			// 
			// txt
			// 
			this.txt.Dock = System.Windows.Forms.DockStyle.Fill;
			this.txt.Location = new System.Drawing.Point(123, 74);
			this.txt.Name = "txt";
			this.txt.Size = new System.Drawing.Size(685, 577);
			this.txt.TabIndex = 8;
			this.txt.Text = "";
			this.txt.SelectionChanged += new System.EventHandler(this.txt_SelectionChanged);
			this.txt.TextChanged += new System.EventHandler(this.txt_TextChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.cbFont);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(164, 68);
			this.panel1.TabIndex = 10;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.cbSize);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(173, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(75, 68);
			this.panel2.TabIndex = 11;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.btnBold);
			this.panel3.Controls.Add(this.btnItalic);
			this.panel3.Controls.Add(this.btnUnderLine);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(254, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(100, 68);
			this.panel3.TabIndex = 12;
			// 
			// btnTxtCenter
			// 
			this.btnTxtCenter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnTxtCenter.Animated = true;
			this.btnTxtCenter.BackColor = System.Drawing.Color.White;
			this.btnTxtCenter.BorderColor = System.Drawing.Color.White;
			this.btnTxtCenter.BorderThickness = 2;
			this.btnTxtCenter.CheckedState.Parent = this.btnTxtCenter;
			this.btnTxtCenter.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnTxtCenter.CustomImages.Parent = this.btnTxtCenter;
			this.btnTxtCenter.FillColor = System.Drawing.Color.White;
			this.btnTxtCenter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.btnTxtCenter.ForeColor = System.Drawing.Color.Black;
			this.btnTxtCenter.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(206)))), ((int)(((byte)(249)))));
			this.btnTxtCenter.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
			this.btnTxtCenter.HoverState.Parent = this.btnTxtCenter;
			this.btnTxtCenter.Image = ((System.Drawing.Image)(resources.GetObject("btnTxtCenter.Image")));
			this.btnTxtCenter.ImageSize = new System.Drawing.Size(45, 45);
			this.btnTxtCenter.Location = new System.Drawing.Point(40, 27);
			this.btnTxtCenter.Name = "btnTxtCenter";
			this.btnTxtCenter.ShadowDecoration.Parent = this.btnTxtCenter;
			this.btnTxtCenter.Size = new System.Drawing.Size(25, 25);
			this.btnTxtCenter.TabIndex = 12;
			this.btnTxtCenter.TextOffset = new System.Drawing.Point(-1, 0);
			this.btnTxtCenter.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
			this.btnTxtCenter.Click += new System.EventHandler(this.btnTxtCenter_Click);
			// 
			// btnTxtRight
			// 
			this.btnTxtRight.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnTxtRight.Animated = true;
			this.btnTxtRight.BackColor = System.Drawing.Color.White;
			this.btnTxtRight.BorderColor = System.Drawing.Color.White;
			this.btnTxtRight.BorderThickness = 2;
			this.btnTxtRight.CheckedState.Parent = this.btnTxtRight;
			this.btnTxtRight.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnTxtRight.CustomImages.Parent = this.btnTxtRight;
			this.btnTxtRight.FillColor = System.Drawing.Color.White;
			this.btnTxtRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.btnTxtRight.ForeColor = System.Drawing.Color.Black;
			this.btnTxtRight.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(206)))), ((int)(((byte)(249)))));
			this.btnTxtRight.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
			this.btnTxtRight.HoverState.Parent = this.btnTxtRight;
			this.btnTxtRight.Image = ((System.Drawing.Image)(resources.GetObject("btnTxtRight.Image")));
			this.btnTxtRight.ImageSize = new System.Drawing.Size(45, 45);
			this.btnTxtRight.Location = new System.Drawing.Point(72, 27);
			this.btnTxtRight.Name = "btnTxtRight";
			this.btnTxtRight.ShadowDecoration.Parent = this.btnTxtRight;
			this.btnTxtRight.Size = new System.Drawing.Size(25, 25);
			this.btnTxtRight.TabIndex = 11;
			this.btnTxtRight.TextOffset = new System.Drawing.Point(-1, 0);
			this.btnTxtRight.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
			this.btnTxtRight.Click += new System.EventHandler(this.btnTxtRight_Click);
			// 
			// btnTxtLeft
			// 
			this.btnTxtLeft.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.btnTxtLeft.Animated = true;
			this.btnTxtLeft.BackColor = System.Drawing.Color.White;
			this.btnTxtLeft.BorderColor = System.Drawing.Color.White;
			this.btnTxtLeft.BorderThickness = 2;
			this.btnTxtLeft.CheckedState.Parent = this.btnTxtLeft;
			this.btnTxtLeft.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnTxtLeft.CustomImages.Parent = this.btnTxtLeft;
			this.btnTxtLeft.FillColor = System.Drawing.Color.White;
			this.btnTxtLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
			this.btnTxtLeft.ForeColor = System.Drawing.Color.Black;
			this.btnTxtLeft.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(206)))), ((int)(((byte)(249)))));
			this.btnTxtLeft.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(239)))), ((int)(((byte)(247)))));
			this.btnTxtLeft.HoverState.Parent = this.btnTxtLeft;
			this.btnTxtLeft.Image = ((System.Drawing.Image)(resources.GetObject("btnTxtLeft.Image")));
			this.btnTxtLeft.ImageSize = new System.Drawing.Size(45, 45);
			this.btnTxtLeft.Location = new System.Drawing.Point(8, 27);
			this.btnTxtLeft.Name = "btnTxtLeft";
			this.btnTxtLeft.ShadowDecoration.Parent = this.btnTxtLeft;
			this.btnTxtLeft.Size = new System.Drawing.Size(25, 25);
			this.btnTxtLeft.TabIndex = 13;
			this.btnTxtLeft.TextOffset = new System.Drawing.Point(-1, 0);
			this.btnTxtLeft.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;
			this.btnTxtLeft.Click += new System.EventHandler(this.btnTxtLeft_Click);
			// 
			// label4
			// 
			this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Italic);
			this.label4.Location = new System.Drawing.Point(4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(93, 24);
			this.label4.TabIndex = 14;
			this.label4.Text = "Alignment";
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.label4);
			this.panel4.Controls.Add(this.btnTxtLeft);
			this.panel4.Controls.Add(this.btnTxtRight);
			this.panel4.Controls.Add(this.btnTxtCenter);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel4.Location = new System.Drawing.Point(360, 3);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(107, 68);
			this.panel4.TabIndex = 13;
			// 
			// cbColor
			// 
			this.cbColor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.cbColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
			this.cbColor.FormattingEnabled = true;
			this.cbColor.Location = new System.Drawing.Point(30, 34);
			this.cbColor.Name = "cbColor";
			this.cbColor.Size = new System.Drawing.Size(154, 21);
			this.cbColor.TabIndex = 0;
			this.cbColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.guna2ComboBox1_DrawItem);
			this.cbColor.SelectedIndexChanged += new System.EventHandler(this.cbColor_SelectedIndexChanged);
			// 
			// lblColor
			// 
			this.lblColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.lblColor.Location = new System.Drawing.Point(4, 35);
			this.lblColor.Name = "lblColor";
			this.lblColor.Size = new System.Drawing.Size(20, 20);
			this.lblColor.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
			this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Italic);
			this.label5.Location = new System.Drawing.Point(26, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(93, 24);
			this.label5.TabIndex = 15;
			this.label5.Text = "Color";
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.label5);
			this.panel5.Controls.Add(this.lblColor);
			this.panel5.Controls.Add(this.cbColor);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel5.Location = new System.Drawing.Point(473, 3);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(198, 68);
			this.panel5.TabIndex = 14;
			// 
			// btnSave
			// 
			this.btnSave.Animated = true;
			this.btnSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(82)))), ((int)(((byte)(215)))));
			this.btnSave.BorderRadius = 10;
			this.btnSave.BorderThickness = 2;
			this.btnSave.CheckedState.Parent = this.btnSave;
			this.btnSave.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnSave.CustomImages.Parent = this.btnSave;
			this.btnSave.FillColor = System.Drawing.Color.White;
			this.btnSave.Font = new System.Drawing.Font("Segoe UI", 16F);
			this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(82)))), ((int)(((byte)(215)))));
			this.btnSave.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.btnSave.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.btnSave.HoverState.ForeColor = System.Drawing.Color.White;
			this.btnSave.HoverState.Parent = this.btnSave;
			this.btnSave.Location = new System.Drawing.Point(163, 38);
			this.btnSave.Name = "btnSave";
			this.btnSave.ShadowDecoration.Parent = this.btnSave;
			this.btnSave.Size = new System.Drawing.Size(67, 26);
			this.btnSave.TabIndex = 20;
			this.btnSave.Text = "Save";
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// txtSave
			// 
			this.txtSave.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(82)))), ((int)(((byte)(215)))));
			this.txtSave.BorderRadius = 5;
			this.txtSave.BorderThickness = 3;
			this.txtSave.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtSave.DefaultText = "";
			this.txtSave.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtSave.DisabledState.Parent = this.txtSave;
			this.txtSave.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtSave.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtSave.FocusedState.Parent = this.txtSave;
			this.txtSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.txtSave.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtSave.HoverState.Parent = this.txtSave;
			this.txtSave.IconRightSize = new System.Drawing.Size(40, 40);
			this.txtSave.Location = new System.Drawing.Point(2, 38);
			this.txtSave.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txtSave.Name = "txtSave";
			this.txtSave.PasswordChar = '\0';
			this.txtSave.PlaceholderText = "Save File";
			this.txtSave.SelectedText = "";
			this.txtSave.ShadowDecoration.Parent = this.txtSave;
			this.txtSave.Size = new System.Drawing.Size(156, 25);
			this.txtSave.TabIndex = 19;
			this.txtSave.TextChanged += new System.EventHandler(this.txtSave_TextChanged);
			// 
			// btnOpen
			// 
			this.btnOpen.Animated = true;
			this.btnOpen.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(82)))), ((int)(((byte)(215)))));
			this.btnOpen.BorderRadius = 10;
			this.btnOpen.BorderThickness = 2;
			this.btnOpen.CheckedState.Parent = this.btnOpen;
			this.btnOpen.Cursor = System.Windows.Forms.Cursors.Hand;
			this.btnOpen.CustomImages.Parent = this.btnOpen;
			this.btnOpen.FillColor = System.Drawing.Color.White;
			this.btnOpen.Font = new System.Drawing.Font("Segoe UI", 16F);
			this.btnOpen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(82)))), ((int)(((byte)(215)))));
			this.btnOpen.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.btnOpen.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
			this.btnOpen.HoverState.ForeColor = System.Drawing.Color.White;
			this.btnOpen.HoverState.Parent = this.btnOpen;
			this.btnOpen.Location = new System.Drawing.Point(163, 3);
			this.btnOpen.Name = "btnOpen";
			this.btnOpen.ShadowDecoration.Parent = this.btnOpen;
			this.btnOpen.Size = new System.Drawing.Size(67, 26);
			this.btnOpen.TabIndex = 18;
			this.btnOpen.Text = "Open";
			this.btnOpen.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// txtLoad
			// 
			this.txtLoad.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(82)))), ((int)(((byte)(215)))));
			this.txtLoad.BorderRadius = 5;
			this.txtLoad.BorderThickness = 3;
			this.txtLoad.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.txtLoad.DefaultText = "";
			this.txtLoad.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
			this.txtLoad.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
			this.txtLoad.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtLoad.DisabledState.Parent = this.txtLoad;
			this.txtLoad.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
			this.txtLoad.Enabled = false;
			this.txtLoad.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtLoad.FocusedState.Parent = this.txtLoad;
			this.txtLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
			this.txtLoad.ForeColor = System.Drawing.Color.DarkRed;
			this.txtLoad.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
			this.txtLoad.HoverState.Parent = this.txtLoad;
			this.txtLoad.IconRightSize = new System.Drawing.Size(40, 40);
			this.txtLoad.Location = new System.Drawing.Point(2, 3);
			this.txtLoad.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
			this.txtLoad.Name = "txtLoad";
			this.txtLoad.PasswordChar = '\0';
			this.txtLoad.PlaceholderForeColor = System.Drawing.Color.DimGray;
			this.txtLoad.PlaceholderText = "Open File";
			this.txtLoad.SelectedText = "";
			this.txtLoad.ShadowDecoration.Parent = this.txtLoad;
			this.txtLoad.Size = new System.Drawing.Size(156, 25);
			this.txtLoad.TabIndex = 17;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 6;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.82946F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.17054F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 106F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 113F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 204F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 279F));
			this.tableLayoutPanel1.Controls.Add(this.panel8, 5, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel3, 2, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel5, 4, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel4, 3, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(954, 74);
			this.tableLayoutPanel1.TabIndex = 12;
			// 
			// panel8
			// 
			this.panel8.Controls.Add(this.Star);
			this.panel8.Controls.Add(this.btnSave);
			this.panel8.Controls.Add(this.txtLoad);
			this.panel8.Controls.Add(this.txtSave);
			this.panel8.Controls.Add(this.btnOpen);
			this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel8.Location = new System.Drawing.Point(677, 3);
			this.panel8.Name = "panel8";
			this.panel8.Size = new System.Drawing.Size(274, 68);
			this.panel8.TabIndex = 13;
			// 
			// Star
			// 
			this.Star.AutoSize = true;
			this.Star.BackColor = System.Drawing.Color.Transparent;
			this.Star.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Star.ForeColor = System.Drawing.Color.Red;
			this.Star.Location = new System.Drawing.Point(235, 34);
			this.Star.Name = "Star";
			this.Star.Size = new System.Drawing.Size(25, 31);
			this.Star.TabIndex = 0;
			this.Star.Text = "*";
			this.Star.Visible = false;
			// 
			// panel6
			// 
			this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel6.Location = new System.Drawing.Point(0, 74);
			this.panel6.Name = "panel6";
			this.panel6.Size = new System.Drawing.Size(123, 577);
			this.panel6.TabIndex = 0;
			// 
			// panel9
			// 
			this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel9.Location = new System.Drawing.Point(808, 74);
			this.panel9.Name = "panel9";
			this.panel9.Size = new System.Drawing.Size(146, 577);
			this.panel9.TabIndex = 14;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
			this.ClientSize = new System.Drawing.Size(954, 651);
			this.Controls.Add(this.txt);
			this.Controls.Add(this.panel9);
			this.Controls.Add(this.panel6);
			this.Controls.Add(this.tableLayoutPanel1);
			this.KeyPreview = true;
			this.MinimumSize = new System.Drawing.Size(970, 690);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel8.ResumeLayout(false);
			this.panel8.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSize;
        private System.Windows.Forms.RichTextBox txt;
        private Guna.UI2.WinForms.Guna2Button btnBold;
        private Guna.UI2.WinForms.Guna2Button btnUnderLine;
        private Guna.UI2.WinForms.Guna2Button btnItalic;
        private System.Windows.Forms.ComboBox cbFont;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private Guna.UI2.WinForms.Guna2Button btnTxtCenter;
        private Guna.UI2.WinForms.Guna2Button btnTxtRight;
        private Guna.UI2.WinForms.Guna2Button btnTxtLeft;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel5;
        private Guna.UI2.WinForms.Guna2Button btnSave;
        private Guna.UI2.WinForms.Guna2TextBox txtSave;
        private Guna.UI2.WinForms.Guna2Button btnOpen;
        private Guna.UI2.WinForms.Guna2TextBox txtLoad;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Panel panel8;
		private System.Windows.Forms.Panel panel6;
		private System.Windows.Forms.Panel panel9;
		private System.Windows.Forms.Label Star;
	}
}

