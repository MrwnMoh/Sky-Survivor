using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleGame
{
    public partial class frmGameOver : Form
    {
        public frmGameOver(int time, int coins, int arrows, List<Image> idelAnimList)
        {
            InitializeComponent();
            this.time = time;
            this.coins = coins;
            this.Arrows = arrows;
            this.IdelAnimList = idelAnimList;
        }

        int time;
        int coins;
        int Arrows;
        byte CurrentIdelAnim = 0;
        bool BackIdel = false;

        List<Image> IdelAnimList = new List<Image>();

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmGameOver_Load(object sender, EventArgs e)
        {
            LpCoins.Text  = coins.ToString();
            LpWave.Text = (Arrows/5).ToString();
            LpTime.Text = time.ToString() + " Secounds";
        }

        void DoIdelAnim()
        {
            if (IdelAnimList.Count == 0)
                return;

            PbPlayer.Image = IdelAnimList[CurrentIdelAnim];
            if (!BackIdel)
                CurrentIdelAnim++;
            else
                CurrentIdelAnim--;


            if (CurrentIdelAnim >= IdelAnimList.Count - 1)
                BackIdel = true;

            else if (CurrentIdelAnim <= 0)
                BackIdel = false;

        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            DoIdelAnim();
        }

    }
}
