using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Tioneel
{
    public partial class Dashboard : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );
        public Dashboard()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            new User().Show();
            this.Hide();
        }

        private void gunaLabel5_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            PnlStats.Top = BtnUtensils.Top;
            PnlHome.Visible = false;
            PnlUtensils.Visible = true;
            PnlBtnUtensils.Visible = true;
            PnlFood.Visible = false;
            PnlBtnFood.Visible = false;
        }

        private void BtnFood_Click_1(object sender, EventArgs e)
        {
            PnlStats.Top = BtnFood.Top;
            PnlHome.Visible = false;
            PnlUtensils.Visible = false;
            PnlBtnUtensils.Visible = false;
            PnlFood.Visible = true;
            PnlBtnFood.Visible = true;
        }

        private void BtnHome_Click_1(object sender, EventArgs e)
        {
            PnlStats.Top = BtnHome.Top;
            PnlHome.Visible = true;
            PnlUtensils.Visible = false;
            PnlBtnUtensils.Visible = false;
            PnlFood.Visible = false;
            PnlBtnFood.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LbAyamGoreng_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton6_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton11_Click(object sender, EventArgs e)
        {

        }

        private void gunaButton25_Click(object sender, EventArgs e)
        {

        }

        private void BtnKitchen_Click(object sender, EventArgs e)
        {

        }

        private void PnlBtnFood_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
