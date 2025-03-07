using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GridSagaPrototype
{
    public partial class HomePage : Form
    {
        public HomePage()
        {
            InitializeComponent();
        }
        private void playBtn_Click(object sender, EventArgs e)
        {
            var MainGame = new MainGame();
            MainGame.Show();
            this.Hide();
        }

        private void shopBtn_Click(object sender, EventArgs e)
        {
            var ShopMenu = new ShopMenu();
            ShopMenu.Show();
            this.Hide();
        }

        private void homeExitBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void achievementBtn_Click(object sender, EventArgs e)
        {
            var AchievementMenu = new AchievementMenu();
            AchievementMenu.Show();
            this.Hide();
        }

        private void settingsBtn_Click(object sender, EventArgs e)
        {
            var SettingsMenu = new SettingsMenu();
            SettingsMenu.Show();
            this.Hide();
        }
    }
}
