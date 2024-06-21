using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class frmStartingScreen : Form
    {
        public frmStartingScreen()
        {
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SoundPlayer sound;
            sound = new SoundPlayer(Properties.Resources.Starting_Theme__wav_);
            sound.Play();
            sound.PlayLooping();
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            frmRules frmRules = new frmRules();
            this.Hide();
            frmRules.ShowDialog();
            this.Show();
            this.Dispose();
        }
    }
}
