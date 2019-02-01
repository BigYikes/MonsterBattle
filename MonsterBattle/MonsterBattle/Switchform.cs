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
    public partial class SwitchForm : Form
    {
        public SwitchForm()
        {
            InitializeComponent();

        }

        private void currentPokemonPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void secondPokemonPB_Click(object sender, EventArgs e)
        {
            var battleForm = new BattleForm();
            this.Hide();
            var switchForm = new SwitchForm();
            switchForm.Closed += (s, args) => this.Close();
            battleForm.Show();

        }
    }
}
