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
        }

        private void cbSize_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (BoldIsChecked && ItalicIsChecked && UnderLineIsChecked)
                txt.Font = new Font(cbFont.Text, Convert.ToInt32(cbSize.Text), FontStyle.Bold | FontStyle.Italic | FontStyle.Underline);
            else if (BoldIsChecked && ItalicIsChecked)
                txt.Font = new Font(cbFont.Text, Convert.ToInt32(cbSize.Text), FontStyle.Bold | FontStyle.Italic);
            else if (BoldIsChecked && UnderLineIsChecked)
                txt.Font = new Font(cbFont.Text, Convert.ToInt32(cbSize.Text), FontStyle.Bold | FontStyle.Underline);
            else if (ItalicIsChecked && UnderLineIsChecked)
                txt.Font = new Font(cbFont.Text, Convert.ToInt32(cbSize.Text), FontStyle.Underline | FontStyle.Italic);
            else if (BoldIsChecked)
                txt.Font = new Font(cbFont.Text, Convert.ToInt32(cbSize.Text), FontStyle.Bold);
            else if (ItalicIsChecked)
                txt.Font = new Font(cbFont.Text, Convert.ToInt32(cbSize.Text), FontStyle.Italic);
            else if (UnderLineIsChecked)
                txt.Font = new Font(cbFont.Text, Convert.ToInt32(cbSize.Text), FontStyle.Underline);
            else
                txt.Font = new Font(cbFont.Text, Convert.ToInt32(cbSize.Text));
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
            if (txt.SelectedText.Length == 0)
                txt.ForeColor = Color.FromName(cbColor.SelectedItem.ToString());
            else
                txt.SelectionColor = Color.FromName(cbColor.SelectedItem.ToString());
            lblColor.BackColor = Color.FromName(cbColor.SelectedItem.ToString());
        }
        private bool txtLeftIsChecked = false;

        private void btnTxtLeft_Click(object sender, EventArgs e)
        {
            BtnDesing(ref txtLeftIsChecked, ref btnTxtLeft);

        }

        private bool txtCenterIsChecked = false;
        private void btnTxtCenter_Click(object sender, EventArgs e)
        {
            BtnDesing(ref txtCenterIsChecked, ref btnTxtCenter);

        }

        private bool txtRightIsChecked = false;
        private void btnTxtRight_Click(object sender, EventArgs e)
        {
            BtnDesing(ref txtRightIsChecked, ref btnTxtRight);

        }
    }
}
