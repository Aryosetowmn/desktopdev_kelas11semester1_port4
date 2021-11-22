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
            this.Close();
            new User().Show();
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

        private void gunaButton60_Click(object sender, EventArgs e)
        {
            this.Close();
            new itemGrape().Show();
        }

        private void gunaButton59_Click(object sender, EventArgs e)
        {
            this.Close();
            new itemApple().Show();
        }

        private void gunaButton62_Click(object sender, EventArgs e)
        {
            this.Close();
            new itemBallpoint().Show();
        }

        private void gunaButton61_Click(object sender, EventArgs e)
        {
            this.Close();
            new itemCup().Show();
        }

        private void gunaButton34_Click(object sender, EventArgs e)
        {
            this.Close();
            new Login().Show();   
        }

        private void gunaButton56_Click(object sender, EventArgs e)
        {
            this.Close();
            new itemCocacola().Show();
        }

        private void gunaButton55_Click(object sender, EventArgs e)
        {
            this.Close();
            new itemSaklar().Show();
        }

        private void gunaButton57_Click(object sender, EventArgs e)
        {
            this.Close();
            new itemHotwheels().Show();
        }

        private void gunaButton58_Click(object sender, EventArgs e)
        {
            this.Close();
            new itemOrange().Show();
        }

        private void gunaButton52_Click(object sender, EventArgs e)
        {
            this.Close();
            new itemBulb().Show();
        }

        private void gunaButton51_Click(object sender, EventArgs e)
        {
            this.Close();
            new itemLego().Show();
        }

        private void PnlHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton53_Click(object sender, EventArgs e)
        {
            this.Close();
            new itemMizone().Show();
        }

        private void gunaButton54_Click(object sender, EventArgs e)
        {
            this.Close();
            new itemNabati().Show();
        }

        private void gunaButton48_Click(object sender, EventArgs e)
        {
            this.Close();
            new itemOreo().Show();
        }

        private void gunaButton47_Click(object sender, EventArgs e)
        {
            this.Close();
            new itemEraser().Show();
        }

        private void gunaButton42_Click(object sender, EventArgs e)
        {
            this.Close();
            new itemTeriyaki().Show();
        }

        private void gunaButton41_Click(object sender, EventArgs e)
        {
            this.Close();
            new itemUno().Show();
        }

        private void gunaButton39_Click(object sender, EventArgs e)
        {
            this.Close();
            new itemTaro().Show();
        }

        private void gunaButton40_Click(object sender, EventArgs e)
        {
            this.Close();
            new itemTandouri().Show();
        }

        private void gunaButton44_Click(object sender, EventArgs e)
        {
            this.Close();
            new itemPulpy().Show();
        }

        private void gunaButton43_Click(object sender, EventArgs e)
        {
            this.Close();
            new itemSpoonfork().Show();
        }

        private void gunaButton45_Click(object sender, EventArgs e)
        {
            this.Close();
            new itemSpaghetti().Show();
        }

        private void gunaButton46_Click(object sender, EventArgs e)
        {
            this.Close();
            new itemT().Show();
        }

        private void gunaButton50_Click(object sender, EventArgs e)
        {
            this.Close();
            new itemPlate().Show();
        }

        private void gunaButton49_Click(object sender, EventArgs e)
        {
            this.Close();
            new itemPencil().Show();
        }
    }
}
