using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonsterBattle
{
    public partial class BattleForm : Form
    {
        Random randomGenerator;
        bool enemyDead;

        public BattleForm()
        {
            InitializeComponent();

            randomGenerator = new Random();
        }

        private void attackButton_Click(object sender, EventArgs e)
        {
            if (!enemyDead)
            {
                enemyPictureBox.Tag = enemyPictureBox.Image;
                friendlyPictureBox.Tag = friendlyPictureBox.Image;
                friendlyPictureBox.Image = Properties.Resources.cannon_fast;
                enemyPictureBox.Image = Properties.Resources.explosion;

                attackButton.Enabled = false;
                attackTimer.Start();

                screenShakeTimer.Start();
            }

        }

        private void attackTimer_Tick(object sender, EventArgs e)
        {

            screenShakeTimer.Stop();
            attackTimer.Stop();
            attackButton.Enabled = true;

            enemyPictureBox.Image = (Image)enemyPictureBox.Tag;
            friendlyPictureBox.Image = (Image)friendlyPictureBox.Tag;

            enemyHealthPictureBox.Width -= 20;

            if (enemyHealthPictureBox.Width <= 0)
            {
                MessageBox.Show("Charizard has fainted!");
                enemyDead = true;
                enemyPictureBox.Image = Properties.Resources.god;
            }
        }

        private void screenShakeTimer_Tick(object sender, EventArgs e)
        {
            this.Top += randomGenerator.Next(-5, 6);
            this.Left += randomGenerator.Next(-5, 6);
        }

        private void switchButton_Click(object sender, EventArgs e)
        { 
            friendlyPictureBox.Image = Properties.Resources.pikachu_back;
            friendlyPictureBox.BackgroundImageLayout = ImageLayout.Stretch;

        }

        private void bagButton_Click(object sender, EventArgs e)
        {
            BagForm BagForm = new BagForm();
            BagForm.ShowDialog();
        }

        private void friendlyPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void enemyPictureBox_Click(object sender, EventArgs e)
        {
        }

        private void enemyPictureBox_BackgroundImageChanged(object sender, EventArgs e)
        {
            enemyHealthPictureBox.Width = 100;
        }

        private void attackButton2_Click(object sender, EventArgs e)
        {
            if (!enemyDead)
            {
                enemyPictureBox.Tag = enemyPictureBox.Image;
                enemyPictureBox.Image = Properties.Resources.teckle;

                attackButton.Enabled = false;
                attackTimer.Start();

                screenShakeTimer.Start();
            }
        }
    }
}
