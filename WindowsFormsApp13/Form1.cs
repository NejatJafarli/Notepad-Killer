using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            cbColor.Items.Clear();

            string[] colores = Enum.GetNames(typeof(System.Drawing.KnownColor));
            cbColor.Items.AddRange(colores);
        }

        private void guna2ComboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            try
            {
                e.DrawBackground();
                string texto = cbColor.Items[e.Index].ToString();
                Brush border = new SolidBrush(e.ForeColor);
                Color color = Color.FromName(texto);
                Brush pincel = new SolidBrush(color);
                Pen boli = new Pen(e.ForeColor);
                e.Graphics.DrawRectangle(boli, new Rectangle(e.Bounds.Left + 2, e.Bounds.Top + 2, 24, e.Bounds.Height - 4));
                e.Graphics.FillRectangle(pincel, new Rectangle(e.Bounds.Left + 3, e.Bounds.Top + 3, 22, e.Bounds.Height - 6));
                e.Graphics.DrawString(texto, e.Font, border, e.Bounds.Left + 30, e.Bounds.Top + 2);

                e.DrawFocusRectangle();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var fontFamily in FontFamily.Families)
                cbFont.Items.Add(fontFamily.Name.ToString());
            for (int i = 6; i <= 72; i += 2)
                cbSize.Items.Add(i.ToString());
            cbFont.SelectedIndex = 0;
            cbSize.SelectedIndex = 0;

            cbFont.SelectedIndexChanged += cbSize_SelectedIndexChanged;
            cbSize.SelectedIndexChanged += cbSize_SelectedIndexChanged;

            cbFont.SelectedIndex = 36;
            cbSize.SelectedIndex = 5;

            cbColor.SelectedIndex = 34;

            btnTxtLeft_Click(null, null);
        }

        private void BtnDesing(ref bool btn1, ref Guna.UI2.WinForms.Guna2Button Button)
        {
            if (btn1)
            {
                btn1 = false;
                Button.BorderColor = Color.White;
                Button.FillColor = Color.White;
            }
            else
            {
                Button.BorderColor = Color.FromArgb(164, 206, 249);
                Button.FillColor = Color.FromArgb(201, 224, 247);
                btn1 = true;
            }
        }
        private bool BoldIsChecked = false;
        private void btnBold_Click(object sender, EventArgs e)
        {
            BtnDesing(ref BoldIsChecked, ref btnBold);
            cbSize_SelectedIndexChanged(null, null);

        }

        private bool ItalicIsChecked = false;
        private void btnItalic_Click(object sender, EventArgs e)
        {
            BtnDesing(ref ItalicIsChecked, ref btnItalic);
            cbSize_SelectedIndexChanged(null, null);
        }

        private bool UnderLineIsChecked = false;
        private void btnUnderLine_Click(object sender, EventArgs e)
        {
            BtnDesing(ref UnderLineIsChecked, ref btnUnderLine);
            cbSize_SelectedIndexChanged(null, null);

        }

        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt.SelectionColor = Color.FromName(cbColor.SelectedItem.ToString());
            lblColor.BackColor = Color.FromName(cbColor.SelectedItem.ToString());
        }
        private bool txtLeftIsChecked = false;

        private void btnTxtLeft_Click(object sender, EventArgs e)
        {
            BtnDesing(ref txtLeftIsChecked, ref btnTxtLeft);
            if (txtCenterIsChecked)
                BtnDesing(ref txtCenterIsChecked, ref btnTxtCenter);
            if (txtRightIsChecked)
                BtnDesing(ref txtRightIsChecked, ref btnTxtRight);
            txt.SelectionAlignment = HorizontalAlignment.Left;
        }

        private bool txtCenterIsChecked = false;
        private void btnTxtCenter_Click(object sender, EventArgs e)
        {
            BtnDesing(ref txtCenterIsChecked, ref btnTxtCenter);
            if (txtLeftIsChecked)
                BtnDesing(ref txtLeftIsChecked, ref btnTxtLeft);
            if (txtRightIsChecked)
                BtnDesing(ref txtRightIsChecked, ref btnTxtRight);
            txt.SelectionAlignment = HorizontalAlignment.Center;
        }

        private bool txtRightIsChecked = false;
        private void btnTxtRight_Click(object sender, EventArgs e)
        {
            BtnDesing(ref txtRightIsChecked, ref btnTxtRight);

            if (txtLeftIsChecked)
                BtnDesing(ref txtLeftIsChecked, ref btnTxtLeft);
            if (txtCenterIsChecked)
                BtnDesing(ref txtCenterIsChecked, ref btnTxtCenter);
            txt.SelectionAlignment = HorizontalAlignment.Right;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.S)
            {
                MessageBox.Show("Save");
            }
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            if (txt.Text.Length == 0)
            {
                txt.SelectionColor = Color.FromName(cbColor.SelectedItem.ToString());
            }
        }

        private void txt_CursorChanged(object sender, EventArgs e)
        {

        }

        private void cbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BoldIsChecked && ItalicIsChecked && UnderLineIsChecked)
                txt.SelectionFont = new Font(cbFont.Text, Convert.ToInt32(cbSize.Text), FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            else if (BoldIsChecked && ItalicIsChecked)
                txt.SelectionFont = new Font(cbFont.Text, Convert.ToInt32(cbSize.Text), FontStyle.Bold | FontStyle.Italic);
            else if (BoldIsChecked && UnderLineIsChecked)
                txt.SelectionFont = new Font(cbFont.Text, Convert.ToInt32(cbSize.Text), FontStyle.Bold | FontStyle.Underline);
            else if (ItalicIsChecked && UnderLineIsChecked)
                txt.SelectionFont = new Font(cbFont.Text, Convert.ToInt32(cbSize.Text), FontStyle.Underline | FontStyle.Italic);
            else if (BoldIsChecked)
                txt.SelectionFont = new Font(cbFont.Text, Convert.ToInt32(cbSize.Text), FontStyle.Bold);
            else if (ItalicIsChecked)
                txt.SelectionFont = new Font(cbFont.Text, Convert.ToInt32(cbSize.Text), FontStyle.Italic);
            else if (UnderLineIsChecked)
                txt.SelectionFont = new Font(cbFont.Text, Convert.ToInt32(cbSize.Text), FontStyle.Underline);
            else
                txt.SelectionFont = new Font(cbFont.Text, Convert.ToInt32(cbSize.Text));
        }
        private void txt_SelectionChanged(object sender, EventArgs e)
        {
            if (txt.SelectedText.Length <= 1)
            {
                if (txt.SelectionFont.Bold && txt.SelectionFont.Italic && txt.SelectionFont.Underline)
                {
                    if (BoldIsChecked == false)
                        btnBold_Click(null, null);
                    if (ItalicIsChecked == false)
                        btnItalic_Click(null, null);
                    if (UnderLineIsChecked == false)
                        btnUnderLine_Click(null, null);
                }
                else if (txt.SelectionFont.Bold && txt.SelectionFont.Italic)
                {
                    if (BoldIsChecked == false)
                        btnBold_Click(null, null);
                    if (ItalicIsChecked == false)
                        btnItalic_Click(null, null);
                    if (UnderLineIsChecked == true)
                        btnUnderLine_Click(null, null);
                }
                else if (txt.SelectionFont.Bold && txt.SelectionFont.Underline)
                {
                    if (ItalicIsChecked == true)
                        btnItalic_Click(null, null);
                    if (BoldIsChecked == false)
                        btnBold_Click(null, null);
                    if (UnderLineIsChecked == false)
                        btnUnderLine_Click(null, null);
                }
                else if (txt.SelectionFont.Italic && txt.SelectionFont.Underline)
                {
                    if (BoldIsChecked == true)
                        btnBold_Click(null, null);
                    if (ItalicIsChecked == false)
                        btnItalic_Click(null, null);
                    if (UnderLineIsChecked == false)
                        btnUnderLine_Click(null, null);
                }
                else if (txt.SelectionFont.Bold)
                {
                    if (BoldIsChecked == false)
                        btnBold_Click(null, null);
                }
                else if (txt.SelectionFont.Italic)
                {
                    if (ItalicIsChecked == false)
                        btnItalic_Click(null, null);
                }
                else if (txt.SelectionFont.Underline)
                {
                    if (UnderLineIsChecked == false)
                        btnUnderLine_Click(null, null);
                }
                else
                {
                    if (BoldIsChecked)
                        btnBold_Click(null, null);
                    if (ItalicIsChecked == true)
                        btnItalic_Click(null, null);
                    if (UnderLineIsChecked == true)
                        btnUnderLine_Click(null, null);
                }
            }
        }
    }
}
