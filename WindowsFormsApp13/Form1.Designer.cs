
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
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbSize = new System.Windows.Forms.ComboBox();
            this.guna2ShadowPanel1 = new Guna.UI2.WinForms.Guna2ShadowPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTxtRight = new Guna.UI2.WinForms.Guna2Button();
            this.btnTxtCenter = new Guna.UI2.WinForms.Guna2Button();
            this.btnTxtLeft = new Guna.UI2.WinForms.Guna2Button();
            this.lblColor = new System.Windows.Forms.Label();
            this.btnUnderLine = new Guna.UI2.WinForms.Guna2Button();
            this.btnItalic = new Guna.UI2.WinForms.Guna2Button();
            this.btnBold = new Guna.UI2.WinForms.Guna2Button();
            this.cbFont = new System.Windows.Forms.ComboBox();
            this.txt = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbColor
            // 
            this.cbColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(30, 34);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(154, 21);
            this.cbColor.TabIndex = 0;
            this.cbColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.guna2ComboBox1_DrawItem);
            this.cbColor.SelectedIndexChanged += new System.EventHandler(this.cbColor_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(66, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Font";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Size";
            // 
            // label3
            // 
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
            this.cbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbSize.ForeColor = System.Drawing.Color.Black;
            this.cbSize.FormattingEnabled = true;
            this.cbSize.IntegralHeight = false;
            this.cbSize.ItemHeight = 20;
            this.cbSize.Location = new System.Drawing.Point(2, 25);
            this.cbSize.MaxDropDownItems = 13;
            this.cbSize.Name = "cbSize";
            this.cbSize.Size = new System.Drawing.Size(69, 28);
            this.cbSize.TabIndex = 2;
            // 
            // guna2ShadowPanel1
            // 
            this.guna2ShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ShadowPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2ShadowPanel1.FillColor = System.Drawing.Color.White;
            this.guna2ShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2ShadowPanel1.Name = "guna2ShadowPanel1";
            this.guna2ShadowPanel1.ShadowColor = System.Drawing.Color.Black;
            this.guna2ShadowPanel1.Size = new System.Drawing.Size(1160, 108);
            this.guna2ShadowPanel1.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Italic);
            this.label5.Location = new System.Drawing.Point(26, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 24);
            this.label5.TabIndex = 15;
            this.label5.Text = "Color";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Comic Sans MS", 12.75F, System.Drawing.FontStyle.Italic);
            this.label4.Location = new System.Drawing.Point(4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 24);
            this.label4.TabIndex = 14;
            this.label4.Text = "Alignment";
            // 
            // btnTxtRight
            // 
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
            this.btnTxtRight.Image = global::WindowsFormsApp13.Properties.Resources.icons8_align_text_right_80;
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
            // btnTxtCenter
            // 
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
            this.btnTxtCenter.Image = global::WindowsFormsApp13.Properties.Resources.icons8_align_text_center_80;
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
            // btnTxtLeft
            // 
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
            this.btnTxtLeft.Image = global::WindowsFormsApp13.Properties.Resources.icons8_align_text_left_80;
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
            // lblColor
            // 
            this.lblColor.Location = new System.Drawing.Point(4, 35);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(20, 20);
            this.lblColor.TabIndex = 10;
            // 
            // btnUnderLine
            // 
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
            this.btnUnderLine.Image = global::WindowsFormsApp13.Properties.Resources.underline_PNG;
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
            this.btnItalic.Image = global::WindowsFormsApp13.Properties.Resources.italic_PNG;
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
            this.btnBold.Image = global::WindowsFormsApp13.Properties.Resources.bold_PNG;
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
            this.cbFont.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbFont.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbFont.ForeColor = System.Drawing.Color.Black;
            this.cbFont.FormattingEnabled = true;
            this.cbFont.IntegralHeight = false;
            this.cbFont.ItemHeight = 20;
            this.cbFont.Location = new System.Drawing.Point(3, 25);
            this.cbFont.MaxDropDownItems = 13;
            this.cbFont.Name = "cbFont";
            this.cbFont.Size = new System.Drawing.Size(158, 28);
            this.cbFont.TabIndex = 6;
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(64, 103);
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(823, 549);
            this.txt.TabIndex = 8;
            this.txt.Text = "";
            this.txt.SelectionChanged += new System.EventHandler(this.txt_SelectionChanged);
            this.txt.CursorChanged += new System.EventHandler(this.txt_CursorChanged);
            this.txt.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cbFont);
            this.panel1.Location = new System.Drawing.Point(113, 308);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 60);
            this.panel1.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.cbSize);
            this.panel2.Location = new System.Drawing.Point(308, 308);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(73, 60);
            this.panel2.TabIndex = 11;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.btnBold);
            this.panel3.Controls.Add(this.btnItalic);
            this.panel3.Controls.Add(this.btnUnderLine);
            this.panel3.Location = new System.Drawing.Point(416, 308);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(95, 60);
            this.panel3.TabIndex = 12;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.btnTxtLeft);
            this.panel4.Controls.Add(this.btnTxtRight);
            this.panel4.Controls.Add(this.btnTxtCenter);
            this.panel4.Location = new System.Drawing.Point(534, 308);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(103, 60);
            this.panel4.TabIndex = 13;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label5);
            this.panel5.Controls.Add(this.lblColor);
            this.panel5.Controls.Add(this.cbColor);
            this.panel5.Location = new System.Drawing.Point(656, 308);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(187, 60);
            this.panel5.TabIndex = 14;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 164F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 95F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 108);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1160, 100);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1160, 651);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.guna2ShadowPanel1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cbColor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbSize;
        private Guna.UI2.WinForms.Guna2ShadowPanel guna2ShadowPanel1;
        private System.Windows.Forms.RichTextBox txt;
        private Guna.UI2.WinForms.Guna2Button btnBold;
        private Guna.UI2.WinForms.Guna2Button btnUnderLine;
        private Guna.UI2.WinForms.Guna2Button btnItalic;
        private System.Windows.Forms.ComboBox cbFont;
        private System.Windows.Forms.Label lblColor;
        private Guna.UI2.WinForms.Guna2Button btnTxtRight;
        private Guna.UI2.WinForms.Guna2Button btnTxtCenter;
        private Guna.UI2.WinForms.Guna2Button btnTxtLeft;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

