using SimpleGame.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;



namespace SimpleGame
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        //clsFire FireArrowItem = new clsFire();
        clsWaterPower WaterPower = new clsWaterPower();

        byte speed = 5;

        bool moveLeft = false;
        bool moveRight = false;
        bool moveUp = false;
        bool moveDown = false;


        byte CurrentIdelAnim = 0;
        byte CurrentAnimNum = 0;
        bool BackIdel = false;

        byte DefSpeed = 0;

        bool IsSliding = false;
        byte SlideFillingValAtSec = 5;
        bool SlideStillFilling = false;


        int coins = 0;
        bool IsGameOver = false;

        Random random = new Random();
        int num = 0;
        int PrevNum = 0;

        List<PictureBox> InteractItemsList = new List<PictureBox>();
        List<PictureBox> ArrowPlaces = new List<PictureBox>();
        List<PictureBox> CoinsPlaces = new List<PictureBox>();
        List<PictureBox> ArrowList = new List<PictureBox>();
        List<Image> IdelAnimList = new List<Image>();
        List<Image> RunAnimList = new List<Image>();
        List<Image> LeftRunAnimList = new List<Image>();
        List<Image> SlideAnimList = new List<Image>();
        List<Image> LeftSlideAnimList = new List<Image>();


        int CurrentTimer = 0;





        SoundPlayer CoinSound = new SoundPlayer(@"D:\Assets\Edit\SFX\Coin\Coin 2.wav");  
        SoundPlayer FootStepsSound1 = new SoundPlayer(@"D:\Assets\Edit\SFX\Footstep\Footstep Wood 2.wav");  
        SoundPlayer FootStepsSound2 = new SoundPlayer(@"D:\Assets\Edit\SFX\Footstep\Footstep Wood3.wav");
        SoundPlayer HitSound = new SoundPlayer(@"D:\Assets\Edit\SFX\Hit\freesound_community-hurt_c_08-102842.wav");
        SoundPlayer WaterSound = new SoundPlayer(@"D:\Assets\Edit\SFX\Pop\Pop (9).wav");
        
        

        byte CurrentFootStepsSound = 0;

        List<SoundPlayer> FootStepsSoundsList = new List<SoundPlayer>();

        //////////////////////////////////////////////////
        void CheckColl()
        {
            if(IsGameOver) return;

            for (int i = InteractItemsList.Count - 1; i >= 0; i--)
            {
                PictureBox item = InteractItemsList[i];
                if (PbPlayer.Bounds.IntersectsWith(item.Bounds))
                {
                    if (item.Tag.ToString().Contains("coin"))
                    {
                        while(num == PrevNum)
                        num = random.Next(CoinsPlaces.Count);

                        PrevNum = num;

                        coins++;
                        item.Visible = false;
                        lpCoins.Text = coins.ToString();
                        CoinSound.Play();
                        item.Location = CoinsPlaces[num].Location;

                        InteractItemsList.Add(item);

                    }
                    else if (item.Tag.ToString().Contains("fire"))
                    {
                        item.Location = ArrowPlaces[i % ArrowPlaces.Count].Location;
                        HitPlayer();
                        HitSound.Play();
                    }
                    else if (item.Tag.ToString().Contains("water"))
                    {

                        AddHealToPlayer();
                        
                        item.Visible = false;
                        this.Controls.Remove(item);
                        InteractItemsList.Remove(item);
                        item.Dispose();
                        item = null;
                        WaterSound.Play();

                    }

                    if(item != null)
                    item.Visible = true;

                    if (IsGameOver)
                    {
                        GameOver();
                        return;
                    }
                }
            }
        }

        void HitPlayer()
        {
            if(pbHeal.Value > 0)
            {
                pbHeal.Value -= 10;
                if( pbHeal.Value <= 0 )
                {
                    IsGameOver = true;
                }
            }
        }

        void GameOver()
        {

            KeyBandTimer.Stop();
            ArrowTimer.Stop();
             FootStepsSoundTimer.Stop();
            SecsTimer.Stop();
            foreach (var item in InteractItemsList.ToList())
            {
                this.Controls.Remove(item);
                InteractItemsList.Remove(item);
                item.Dispose(); 
            }
            using (frmGameOver frm = new frmGameOver(CurrentTimer, coins,ArrowList.Count,IdelAnimList))
            {
                frm.ShowDialog();
            }

            this.Close();

        }

        void AddHealToPlayer()
        {
            pbHeal.Value = Math.Min(pbHeal.Value + 20, pbHeal.Maximum);
        }

        void FillArrowPlaces()
        {
            ArrowPlaces.Add(PbPlace1);
            ArrowPlaces.Add(PbPlace2);
            ArrowPlaces.Add(PbPlace3);
            ArrowPlaces.Add(PbPlace5);
            ArrowPlaces.Add(PbPlace6);
            ArrowPlaces.Add(PbPlace7);
            ArrowPlaces.Add(PbPlace8);
            ArrowPlaces.Add(PbPlace9);
            ArrowPlaces.Add(PbPlace10);
            ArrowPlaces.Add(PbPlace11);
            ArrowPlaces.Add(PbPlace12);
            ArrowPlaces.Add(PbPlace13);
            ArrowPlaces.Add(PbPlace14);
            ArrowPlaces.Add(PbPlace15);
        }

        void FillCoinsPlaces()
        {
            CoinsPlaces.Add(pbCoinPlace1);
            CoinsPlaces.Add(pbCoinPlace2);
            CoinsPlaces.Add(pbCoinPlace2);
            CoinsPlaces.Add(pbCoinPlace3);
            CoinsPlaces.Add(pbCoinPlace5);
            CoinsPlaces.Add(pbCoinPlace6);
            CoinsPlaces.Add(pbCoinPlace7);
            CoinsPlaces.Add(pbCoinPlace8);
            CoinsPlaces.Add(pbCoinPlace9);
            CoinsPlaces.Add(pbCoinPlace10);
            CoinsPlaces.Add(pbCoinPlace11);
            CoinsPlaces.Add(pbCoinPlace12);
            CoinsPlaces.Add(pbCoinPlace13);
            CoinsPlaces.Add(pbCoinPlace14);
            CoinsPlaces.Add(pbCoinPlace15);
            CoinsPlaces.Add(pbCoinPlace16);
            CoinsPlaces.Add(pbCoinPlace17);
            CoinsPlaces.Add(pbCoinPlace18);
            CoinsPlaces.Add(pbCoinPlace19);
            CoinsPlaces.Add(pbCoinPlace20);
            CoinsPlaces.Add(pbCoinPlace21);
            CoinsPlaces.Add(pbCoinPlace22);
            CoinsPlaces.Add(pbCoinPlace23);
            CoinsPlaces.Add(pbCoinPlace24);
            CoinsPlaces.Add(pbCoinPlace25);
        }

        void FillCoinsPics()
        {
            InteractItemsList.Add(PbCoin1);
            InteractItemsList.Add(PbCoin2);
            InteractItemsList.Add(PbCoin3);
            InteractItemsList.Add(PbCoin4);
            InteractItemsList.Add(PbCoin5);
    
        }

        void FillIdelAnimation()
        {
            IdelAnimList.Add(Properties.Resources.Idle__000);
            IdelAnimList.Add(Properties.Resources.Idle__001);
            IdelAnimList.Add(Properties.Resources.Idle__002);
            IdelAnimList.Add(Properties.Resources.Idle__003);
            IdelAnimList.Add(Properties.Resources.Idle__004);
            IdelAnimList.Add(Properties.Resources.Idle__005);
            IdelAnimList.Add(Properties.Resources.Idle__006);
            IdelAnimList.Add(Properties.Resources.Idle__007);
            IdelAnimList.Add(Properties.Resources.Idle__008);
            IdelAnimList.Add(Properties.Resources.Idle__009);



        }

        void FillRunAnimation()
        {
            RunAnimList.Add(Properties.Resources.Run__000);
            RunAnimList.Add(Properties.Resources.Run__001);
            RunAnimList.Add(Properties.Resources.Run__002);
            RunAnimList.Add(Properties.Resources.Run__003);
            RunAnimList.Add(Properties.Resources.Run__004);
            RunAnimList.Add(Properties.Resources.Run__005);
            RunAnimList.Add(Properties.Resources.Run__006);
            RunAnimList.Add(Properties.Resources.Run__007);
            RunAnimList.Add(Properties.Resources.Run__008);
            RunAnimList.Add(Properties.Resources.Run__009);

            LeftRunAnimList.Add(Properties.Resources.LeftRun__000);
            LeftRunAnimList.Add(Properties.Resources.LeftRun__001);
            LeftRunAnimList.Add(Properties.Resources.LeftRun__002);
            LeftRunAnimList.Add(Properties.Resources.LeftRun__003);
            LeftRunAnimList.Add(Properties.Resources.LeftRun__004);
            LeftRunAnimList.Add(Properties.Resources.LeftRun__005);
            LeftRunAnimList.Add(Properties.Resources.LeftRun__006);
            LeftRunAnimList.Add(Properties.Resources.LeftRun__007);
            LeftRunAnimList.Add(Properties.Resources.LeftRun__008);
            LeftRunAnimList.Add(Properties.Resources.LeftRun__009);


        }

        void FillSlideAnimation()
        {

            //Right
            SlideAnimList.Add(Properties.Resources.Slide__000);
            SlideAnimList.Add(Properties.Resources.Slide__001);
            SlideAnimList.Add(Properties.Resources.Slide__002);
            SlideAnimList.Add(Properties.Resources.Slide__003);
            SlideAnimList.Add(Properties.Resources.Slide__004);
            SlideAnimList.Add(Properties.Resources.Slide__005);
            SlideAnimList.Add(Properties.Resources.Slide__006);
            SlideAnimList.Add(Properties.Resources.Slide__007);
            SlideAnimList.Add(Properties.Resources.Slide__008);
            SlideAnimList.Add(Properties.Resources.Slide__009);




            //Left
            LeftSlideAnimList.Add(Properties.Resources.LeftSlide__000);
            LeftSlideAnimList.Add(Properties.Resources.LeftSlide__001);
            LeftSlideAnimList.Add(Properties.Resources.LeftSlide__002);
            LeftSlideAnimList.Add(Properties.Resources.LeftSlide__003);
            LeftSlideAnimList.Add(Properties.Resources.LeftSlide__004);
            LeftSlideAnimList.Add(Properties.Resources.LeftSlide__005);
            LeftSlideAnimList.Add(Properties.Resources.LeftSlide__006);
            LeftSlideAnimList.Add(Properties.Resources.LeftSlide__007);
            LeftSlideAnimList.Add(Properties.Resources.LeftSlide__008);
            LeftSlideAnimList.Add(Properties.Resources.LeftSlide__009);

        }

        void FillFootStepsSound()
        {
            FootStepsSoundsList.Add(FootStepsSound1);
            FootStepsSoundsList.Add(FootStepsSound2);
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

        void DoRunAnim()
        {
            if (RunAnimList.Count == 0)
                return;

            PbPlayer.Image = RunAnimList[CurrentAnimNum];

                CurrentAnimNum++;

            if (CurrentAnimNum == 9)
                CurrentAnimNum = 0;


        }

        void DoLeftRunAnim()
        {
            if (LeftRunAnimList.Count == 0)
                return;

            PbPlayer.Image = LeftRunAnimList[CurrentAnimNum];

            CurrentAnimNum++;

            if (CurrentAnimNum == 9)
                CurrentAnimNum = 0;


        }

        void DoSlidAnim()
        {
            if (SlideAnimList.Count == 0 || LeftSlideAnimList.Count ==0)
                return;

            if(moveRight)
            PbPlayer.Image = SlideAnimList[CurrentAnimNum];
            else if (moveLeft)
            PbPlayer.Image = LeftSlideAnimList[CurrentAnimNum];

            CurrentAnimNum++;

            if (CurrentAnimNum == 9)
                CurrentAnimNum = 0;


        }

        void Slide()
        {

            if (IsSliding || SlideStillFilling)
                return;

            SlideTimer.Start();
            IsSliding = true;

            DefSpeed = speed;
            speed = 20;


        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            TrackbarValu.Text = trackBar1.Value.ToString();

            int X = PbPlayer.Location.X + PbPlayer.Width / 2;
            int Y = PbPlayer.Location.Y + PbPlayer.Height / 2;

            PbPlayer.Size = new Size(trackBar1.Value, trackBar1.Value);
            PbPlayer.Location = new Point(X - PbPlayer.Width / 2, Y - PbPlayer.Height / 2);
        }

        private void trbSpeed_Scroll(object sender, EventArgs e)
        {
            LpSpeedTravk.Text = trbSpeed.Value.ToString();
            speed = (byte)trbSpeed.Value;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A) moveLeft = true;
            if (e.KeyCode == Keys.D) moveRight = true;
            if (e.KeyCode == Keys.W) moveUp = true;
            if (e.KeyCode == Keys.S) moveDown = true;
            if (e.KeyCode == Keys.ShiftKey) Slide();

         

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A) moveLeft = false;
            if (e.KeyCode == Keys.D) moveRight = false;
            if (e.KeyCode == Keys.W) moveUp = false;
            if (e.KeyCode == Keys.S) moveDown = false;





        }

        private void KeyBandTimer_Tick(object sender, EventArgs e)
        {
            if (IsGameOver)
                return;

                if (moveLeft) PbPlayer.Left -= speed;
                if (moveRight) PbPlayer.Left += speed;
                if (moveUp) PbPlayer.Top -= speed;
                if (moveDown) PbPlayer.Top += speed;

                CheckColl();
        }

      

        clsFire FireArrow(int PlaceNum)
        {
            clsFire FireArrowItem = new clsFire();


            FireArrowItem.ItemPic.Location = ArrowPlaces[PlaceNum].Location;
            FireArrowItem.ItemPic.Size = new Size(100, 100);
            FireArrowItem.ItemPic.Tag = "Item fire";
            InteractItemsList.Add(FireArrowItem.ItemPic);

            return FireArrowItem;
        }
        void AddWater()
        {
            clsWaterItem WaterItem = new clsWaterItem();
            num = random.Next(CoinsPlaces.Count);
            WaterItem.ItemPic.Location = CoinsPlaces[num].Location;
            WaterItem.ItemPic.Size = new Size(50, 50);
            WaterItem.ItemPic.Tag = "Item water";
            WaterItem.DisableMove();
            InteractItemsList.Add(WaterItem.ItemPic);
            this.Controls.Add(WaterItem.ItemPic);


        }

        void FillArrowsList(int NumOfArrow)
        {
            for(int i = 0; i < NumOfArrow; i++)
           {
                num = random.Next(ArrowPlaces.Count);
                clsFire FireArrowItem = new clsFire();
                FireArrowItem = FireArrow(num);
                ArrowList.Add(FireArrowItem.ItemPic);
                this.Controls.Add(FireArrowItem.ItemPic);
            }

           
        }


        private void Form1_Load(object sender, EventArgs e)
        {

            FillCoinsPlaces();
            FillCoinsPics();
            FillIdelAnimation();
            FillRunAnimation();
            FillSlideAnimation();
            FillArrowPlaces();
            FillArrowsList(5);
            FillFootStepsSound();
            AddWater();
        }

        void CloudAnimation()
        {
            pbCloud1.Left++ ;
            pbCloud2.Left++ ;

            if (pbCloud1.Bounds.IntersectsWith(pbTheEndOfCloud.Bounds))
                pbCloud1.Location = new Point (170, -53); // the start location

            if (pbCloud2.Bounds.IntersectsWith(pbTheEndOfCloud.Bounds))
                pbCloud2.Location = new Point(170, -53); // the start location
        }

        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            if(!IsSliding)
                {
                if (moveRight)
                    DoRunAnim();
                else if (moveLeft)
                    DoLeftRunAnim();
                else
                    DoIdelAnim();
                }
            else
                DoSlidAnim();
            CloudAnimation();
        }

        private void SecsTimer_Tick(object sender, EventArgs e)
        {
            if (pbSlide.Value > 0)
            {
                pbSlide.Value--;
                LpSlideCoolDown.Text = ((pbSlide.Value / (double)pbSlide.Maximum ) * 100).ToString() + "%";

                if (pbSlide.Value == 0)
                {
                    SlideTimer.Stop();

                    LpSlideCoolDown.Text = pbSlide.Value.ToString() + "%";
                    SecsTimer.Start();
                    speed = DefSpeed;
                    IsSliding = false;
                    SlideStillFilling = true;

                }
            }
        }

        void FillSlideAgain()
        {
            if(pbSlide.Value < pbSlide.Maximum)
               {
                pbSlide.Value += SlideFillingValAtSec;
                LpSlideCoolDown.Text = pbSlide.Value.ToString() + "%";

                if (pbSlide.Value == pbSlide.Maximum)
                {
                    SecsTimer.Stop();
                    SlideStillFilling  = false;
                }

            }
        }
        private void SecsTimer_Tick_1(object sender, EventArgs e)
        {
            FillSlideAgain();
        }

        void UserWaterPower()
        {
            if (moveLeft)
            {

                WaterPower.ItemPic.Location = new Point(PbPlayer.Right - (PbPlayer.Width + 50), PbPlayer.Top);
            }
            else
            {
                WaterPower.ItemPic.Location = new Point(PbPlayer.Right + 5, PbPlayer.Top);
            }
            WaterPower.ItemPic.Visible = true;
        }

        private void ArrowTimer_Tick(object sender, EventArgs e)
        {
            CurrentTimer++;
            lpTimer.Text = CurrentTimer.ToString();

            if (CurrentTimer == ArrowList.Count * 4)
            {
                FillArrowsList(5);
                AddWater();
                AddWater();
            }
            lpWave.Text = (ArrowList.Count/5).ToString();
        }

        private void ArrosEndTimer_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < ArrowList.Count; i++)
            {
                PictureBox Arrow = ArrowList[i];
                if (pbTheEndOfArrows.Bounds.IntersectsWith(Arrow.Bounds))
                {
                    num = random.Next(ArrowPlaces.Count);
                    Arrow.Location = ArrowPlaces[num].Location;
                }
            }
        }

        private void FootStepsSoundTimer_Tick(object sender, EventArgs e)
        {
            if((moveLeft || moveRight ||  moveUp || moveDown) && !IsSliding)
            {
                SoundPlayer Sp = FootStepsSoundsList[CurrentFootStepsSound];
                Sp.Play();
                CurrentFootStepsSound++;

                if (CurrentFootStepsSound == FootStepsSoundsList.Count)
                    CurrentFootStepsSound = 0;

            }
        }

        private void pbCoinPlace13_Click(object sender, EventArgs e)
        {

        }
    }
}
