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
            Hide();
            User form2 = new User();
            form2.ShowDialog();
            form2 = null;
            Show();
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
            PnlBtnAllUtensils.Visible = false;
            PnlBtnElectronic.Visible = false;
            PnlBtnStationary.Visible = false;
            PnlBtnKitchen.Visible = false;
            PnlBtnToys.Visible = false;
            PnlBtnAllFood.Visible = false;
            PnlBtnMeal.Visible = false;
            PnlBtnDrinks.Visible = false;
            PnlBtnSnacks.Visible = false;
            PnlBtnFruit.Visible = false;
        }

        private void BtnFood_Click_1(object sender, EventArgs e)
        {
            PnlStats.Top = BtnFood.Top;
            PnlHome.Visible = false;
            PnlUtensils.Visible = false;
            PnlBtnUtensils.Visible = false;
            PnlFood.Visible = true;
            PnlBtnFood.Visible = true;
            PnlBtnAllUtensils.Visible = false;
            PnlBtnElectronic.Visible = false;
            PnlBtnStationary.Visible = false;
            PnlBtnKitchen.Visible = false;
            PnlBtnToys.Visible = false;
            PnlBtnAllFood.Visible = false;
            PnlBtnMeal.Visible = false;
            PnlBtnDrinks.Visible = false;
            PnlBtnSnacks.Visible = false;
            PnlBtnFruit.Visible = false;
        }

        private void BtnHome_Click_1(object sender, EventArgs e)
        {
            PnlStats.Top = BtnHome.Top;
            PnlHome.Visible = true;
            PnlUtensils.Visible = false;
            PnlBtnUtensils.Visible = false;
            PnlFood.Visible = false;
            PnlBtnFood.Visible = false;
            PnlBtnAllUtensils.Visible = false;
            PnlBtnElectronic.Visible = false;
            PnlBtnStationary.Visible = false;
            PnlBtnKitchen.Visible = false;
            PnlBtnToys.Visible = false;
            PnlBtnAllFood.Visible = false;
            PnlBtnMeal.Visible = false;
            PnlBtnDrinks.Visible = false;
            PnlBtnSnacks.Visible = false;
            PnlBtnFruit.Visible = false;
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

        private void PnlBtnFood_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton60_Click(object sender, EventArgs e)
        {
            Hide();
            itemGrape form2 = new itemGrape();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton59_Click(object sender, EventArgs e)
        {
            Hide();
            itemApple form2 = new itemApple();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton62_Click(object sender, EventArgs e)
        {
            Hide();
            itemBallpoint form2 = new itemBallpoint();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton61_Click(object sender, EventArgs e)
        {
            Hide();
            itemCup form2 = new itemCup();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton34_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Want To Quit?", "Log Out", MessageBoxButtons.YesNo) == DialogResult.Yes) {
                this.Close();
                new Login().Show();
            }   
        }

        private void gunaButton56_Click(object sender, EventArgs e)
        {
            Hide();
            itemCocacola form2 = new itemCocacola();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton55_Click(object sender, EventArgs e)
        {
            Hide();
            itemSaklar form2 = new itemSaklar();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton57_Click(object sender, EventArgs e)
        {
            Hide();
            itemHotwheels form2 = new itemHotwheels();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton58_Click(object sender, EventArgs e)
        {
            Hide();
            itemOrange form2 = new itemOrange();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton52_Click(object sender, EventArgs e)
        {
            Hide();
            itemBulb form2 = new itemBulb();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton51_Click(object sender, EventArgs e)
        {
            Hide();
            itemLego form2 = new itemLego();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void PnlHome_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaButton53_Click(object sender, EventArgs e)
        {
            Hide();
            itemMizone form2 = new itemMizone();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton54_Click(object sender, EventArgs e)
        {
            Hide();
            itemNabati form2 = new itemNabati();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton48_Click(object sender, EventArgs e)
        {
            Hide();
            itemOreo form2 = new itemOreo();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton47_Click(object sender, EventArgs e)
        {
            Hide();
            itemEraser form2 = new itemEraser();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton42_Click(object sender, EventArgs e)
        {
            Hide();
            itemTeriyaki form2 = new itemTeriyaki();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton41_Click(object sender, EventArgs e)
        {
            Hide();
            itemUno form2 = new itemUno();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton39_Click(object sender, EventArgs e)
        {
            Hide();
            itemTaro form2 = new itemTaro();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton40_Click(object sender, EventArgs e)
        {
            Hide();
            itemTandouri form2 = new itemTandouri();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton44_Click(object sender, EventArgs e)
        {
            Hide();
            itemPulpy form2 = new itemPulpy();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton43_Click(object sender, EventArgs e)
        {
            Hide();
            itemSpoonfork form2 = new itemSpoonfork();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton45_Click(object sender, EventArgs e)
        {
            Hide();
            itemSpaghetti form2 = new itemSpaghetti();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton46_Click(object sender, EventArgs e)
        {
            Hide();
            itemT form2 = new itemT();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton50_Click(object sender, EventArgs e)
        {
            Hide();
            itemPlate form2 = new itemPlate();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton49_Click(object sender, EventArgs e)
        {
            Hide();
            itemPencil form2 = new itemPencil();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Want To Quit?", "Log Out", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                new Login().Show();
            }
        }

        private void PnlFood_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnFoodAll_Click(object sender, EventArgs e)
        {
            PnlBtnAllFood.Visible = true;
            PnlBtnMeal.Visible = false;
            PnlBtnDrinks.Visible = false;
            PnlBtnSnacks.Visible = false;
            PnlBtnFruit.Visible = false;
        }

        private void BtnUtensilsAll_Click(object sender, EventArgs e)
        {
            PnlBtnAllUtensils.Visible = true;
            PnlBtnElectronic.Visible = false;
            PnlBtnStationary.Visible = false;
            PnlBtnKitchen.Visible = false;
            
           
        }

        private void BtnElectronic_Click(object sender, EventArgs e)
        {
            PnlBtnAllUtensils.Visible = false;
            PnlBtnElectronic.Visible = true;
            PnlBtnStationary.Visible = false;
            PnlBtnKitchen.Visible = false;
            PnlBtnToys.Visible = false;



        }

        private void BtnStationary_Click(object sender, EventArgs e)
        {
            PnlBtnAllUtensils.Visible = false;
            PnlBtnElectronic.Visible = false;
            PnlBtnStationary.Visible = true;
            PnlBtnKitchen.Visible = false;
            PnlBtnToys.Visible = false;


        }

        private void BtnToys_Click(object sender, EventArgs e)
        {
            PnlBtnAllUtensils.Visible = false;
            PnlBtnElectronic.Visible = false;
            PnlBtnStationary.Visible = false;
            PnlBtnKitchen.Visible = false;
            PnlBtnToys.Visible = true;


        }

        private void BtnKitchen_Click(object sender, EventArgs e)
        {
            PnlBtnAllUtensils.Visible = false;
            PnlBtnElectronic.Visible = false;
            PnlBtnStationary.Visible = false;
            PnlBtnKitchen.Visible = true;
            PnlBtnToys.Visible = false;
        }

        private void gunaButton145_Click(object sender, EventArgs e)
        {

        }

        private void BtnMeal_Click(object sender, EventArgs e)
        {
            PnlBtnAllFood.Visible = false;
            PnlBtnMeal.Visible = true;
            PnlBtnDrinks.Visible = false;
            PnlBtnSnacks.Visible = false;
        }

        private void BtnDrinks_Click(object sender, EventArgs e)
        {
            PnlBtnAllFood.Visible = false;
            PnlBtnMeal.Visible = false;
            PnlBtnDrinks.Visible = true;
            PnlBtnSnacks.Visible = false;

        }

        private void BtnSnacks_Click(object sender, EventArgs e)
        {
            PnlBtnAllFood.Visible = false;
            PnlBtnMeal.Visible = false;
            PnlBtnDrinks.Visible = false;
            PnlBtnSnacks.Visible = true;
            PnlBtnFruit.Visible = false;
        }

        private void BtnFruit_Click(object sender, EventArgs e)
        {
            PnlBtnAllFood.Visible = false;
            PnlBtnMeal.Visible = false;
            PnlBtnDrinks.Visible = false;
            PnlBtnSnacks.Visible = false;
            PnlBtnFruit.Visible = true;
        }

        private void gunaButton10_Click(object sender, EventArgs e)
        {
            Hide();
            itemBulb form2 = new itemBulb();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton11_Click_1(object sender, EventArgs e)
        {
            Hide();
            itemSaklar form2 = new itemSaklar();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton14_Click(object sender, EventArgs e)
        {
            Hide();
            itemBallpoint form2 = new itemBallpoint();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton13_Click(object sender, EventArgs e)
        {
            Hide();
            itemCup form2 = new itemCup();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton4_Click(object sender, EventArgs e)
        {
            Hide();
            itemSpoonfork form2 = new itemSpoonfork();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton9_Click(object sender, EventArgs e)
        {
            Hide();
            itemLego form2 = new itemLego();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton12_Click(object sender, EventArgs e)
        {
            Hide();
            itemHotwheels form2 = new itemHotwheels();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton8_Click(object sender, EventArgs e)
        {
            Hide();
            itemPlate form2 = new itemPlate();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton6_Click_1(object sender, EventArgs e)
        {
            Hide();
            itemEraser form2 = new itemEraser();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton7_Click(object sender, EventArgs e)
        {
            Hide();
            itemPencil form2 = new itemPencil();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton5_Click(object sender, EventArgs e)
        {
            Hide();
            itemT form2 = new itemT();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton3_Click_1(object sender, EventArgs e)
        {
            Hide();
            itemUno form2 = new itemUno();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton67_Click(object sender, EventArgs e)
        {
            Hide();
            itemBulb form2 = new itemBulb();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton68_Click(object sender, EventArgs e)
        {
            Hide();
            itemSaklar form2 = new itemSaklar();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton71_Click(object sender, EventArgs e)
        {
            Hide();
            itemBallpoint form2 = new itemBallpoint();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton70_Click(object sender, EventArgs e)
        {
            Hide();
            itemCup form2 = new itemCup();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton36_Click(object sender, EventArgs e)
        {
            Hide();
            itemSpoonfork form2 = new itemSpoonfork();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton66_Click(object sender, EventArgs e)
        {
            Hide();
            itemLego form2 = new itemLego();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton69_Click(object sender, EventArgs e)
        {
            Hide();
            itemHotwheels form2 = new itemHotwheels();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton65_Click(object sender, EventArgs e)
        {
            Hide();
            itemPlate form2 = new itemPlate();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton63_Click(object sender, EventArgs e)
        {
            Hide();
            itemEraser form2 = new itemEraser();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton64_Click(object sender, EventArgs e)
        {
            Hide();
            itemPencil form2 = new itemPencil();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton37_Click(object sender, EventArgs e)
        {
            Hide();
            itemT form2 = new itemT();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton20_Click(object sender, EventArgs e)
        {
            Hide();
            itemUno form2 = new itemUno();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton109_Click(object sender, EventArgs e)
        {
            Hide();
            itemBulb form2 = new itemBulb();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton110_Click(object sender, EventArgs e)
        {
            Hide();
            itemSaklar form2 = new itemSaklar();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton104_Click(object sender, EventArgs e)
        {
            Hide();
            itemT form2 = new itemT();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton102_Click(object sender, EventArgs e)
        {
            Hide();
            itemUno form2 = new itemUno();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton113_Click(object sender, EventArgs e)
        {
            Hide();
            itemLego form2 = new itemLego();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton156_Click(object sender, EventArgs e)
        {
            Hide();
            itemHotwheels form2 = new itemHotwheels();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton103_Click(object sender, EventArgs e)
        {
            Hide();
            itemSpoonfork form2 = new itemSpoonfork();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton108_Click(object sender, EventArgs e)
        {
            Hide();
            itemPlate form2 = new itemPlate();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton127_Click(object sender, EventArgs e)
        {
            Hide();
            itemCup form2 = new itemCup();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton135_Click(object sender, EventArgs e)
        {
            Hide();
            itemEraser form2 = new itemEraser();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton136_Click(object sender, EventArgs e)
        {
            Hide();
            itemPencil form2 = new itemPencil();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton143_Click(object sender, EventArgs e)
        {
            Hide();
            itemBallpoint form2 = new itemBallpoint();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton84_Click(object sender, EventArgs e)
        {
            Hide();
            itemGrape form2 = new itemGrape();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton83_Click(object sender, EventArgs e)
        {
            Hide();
            itemApple form2 = new itemApple();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton82_Click(object sender, EventArgs e)
        {
            Hide();
            itemOrange form2 = new itemOrange();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton15_Click(object sender, EventArgs e)
        {
            Hide();
            itemTaro form2 = new itemTaro();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton80_Click(object sender, EventArgs e)
        {
            Hide();
            itemCocacola form2 = new itemCocacola();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton77_Click(object sender, EventArgs e)
        {
            Hide();
            itemMizone form2 = new itemMizone();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton78_Click(object sender, EventArgs e)
        {
            Hide();
            itemNabati form2 = new itemNabati();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton35_Click(object sender, EventArgs e)
        {
            Hide();
            itemOreo form2 = new itemOreo();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton29_Click(object sender, EventArgs e)
        {
            Hide();
            itemSpaghetti form2 = new itemSpaghetti();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton25_Click_1(object sender, EventArgs e)
        {
            Hide();
            itemPulpy form2 = new itemPulpy();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton21_Click(object sender, EventArgs e)
        {
            Hide();
            itemTeriyaki form2 = new itemTeriyaki();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton18_Click(object sender, EventArgs e)
        {
            Hide();
            itemTandouri form2 = new itemTandouri();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton173_Click(object sender, EventArgs e)
        {
            Hide();
            itemGrape form2 = new itemGrape();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton172_Click(object sender, EventArgs e)
        {
            Hide();
            itemApple form2 = new itemApple();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton171_Click(object sender, EventArgs e)
        {
            Hide();
            itemOrange form2 = new itemOrange();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton105_Click(object sender, EventArgs e)
        {
            Hide();
            itemTaro form2 = new itemTaro();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton158_Click(object sender, EventArgs e)
        {
            Hide();
            itemCocacola form2 = new itemCocacola();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton128_Click(object sender, EventArgs e)
        {
            Hide();
            itemMizone form2 = new itemMizone();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton157_Click(object sender, EventArgs e)
        {
            Hide();
            itemNabati form2 = new itemNabati();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton126_Click(object sender, EventArgs e)
        {
            Hide();
            itemOreo form2 = new itemOreo();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton112_Click(object sender, EventArgs e)
        {
            Hide();
            itemSpaghetti form2 = new itemSpaghetti();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton111_Click(object sender, EventArgs e)
        {
            Hide();
            itemPulpy form2 = new itemPulpy();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton107_Click(object sender, EventArgs e)
        {
            Hide();
            itemTeriyaki form2 = new itemTeriyaki();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton106_Click(object sender, EventArgs e)
        {
            Hide();
            itemTandouri form2 = new itemTandouri();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton242_Click(object sender, EventArgs e)
        {
            Hide();
            itemGrape form2 = new itemGrape();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton241_Click(object sender, EventArgs e)
        {
            Hide();
            itemApple form2 = new itemApple();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton240_Click(object sender, EventArgs e)
        {
            Hide();
            itemOrange form2 = new itemOrange();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton190_Click(object sender, EventArgs e)
        {
            Hide();
            itemSpaghetti form2 = new itemSpaghetti();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton187_Click(object sender, EventArgs e)
        {
            Hide();
            itemTandouri form2 = new itemTandouri();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton188_Click(object sender, EventArgs e)
        {
            Hide();
            itemTeriyaki form2 = new itemTeriyaki();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton196_Click(object sender, EventArgs e)
        {
            Hide();
            itemOreo form2 = new itemOreo();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton186_Click(object sender, EventArgs e)
        {
            Hide();
            itemTaro form2 = new itemTaro();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton211_Click(object sender, EventArgs e)
        {
            Hide();
            itemNabati form2 = new itemNabati();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton197_Click(object sender, EventArgs e)
        {
            Hide();
            itemCocacola form2 = new itemCocacola();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton195_Click(object sender, EventArgs e)
        {
            Hide();
            itemMizone form2 = new itemMizone();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton192_Click(object sender, EventArgs e)
        {
            Hide();
            itemPulpy form2 = new itemPulpy();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton33_Click(object sender, EventArgs e)
        {
            Hide();
            Cart form2 = new Cart();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void gunaButton23_Click(object sender, EventArgs e)
        {
            Hide();
            Wishlist form2 = new Wishlist();
            form2.ShowDialog();
            form2 = null;
            Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are You Sure Want To Quit?", "Log Out", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
                new Login().Show();
            }
        }
    }
}
