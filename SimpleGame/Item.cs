using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Items
{
    public class Item
    {

        public List<Image> ItemIdelAnimList = new List<Image>();

        public PictureBox ItemPic = new PictureBox();

        Timer IdelAnimTimer = new Timer();

        Timer DownTimer = new Timer();

        public byte speed = 2;

        public bool IsAnim = true;

        byte CurrentAnimNum = 0;
        public Item()
        {
            IdelAnimTimer.Interval = 80;
            IdelAnimTimer.Tick += IdelAnimTimer_Tick;
            IdelAnimTimer.Start();
            FillItemIdelAnim();
            AdjustItemPic();


            DownTimer.Interval = 10;
            DownTimer.Tick += DownTimer_Tick;
            DownTimer.Start();
        }

        void DoIdelAnim()
        {
            if (ItemIdelAnimList.Count == 0)
                return;

            ItemPic.Image = ItemIdelAnimList[CurrentAnimNum];

            CurrentAnimNum++;

            if (CurrentAnimNum >= ItemIdelAnimList.Count)
                CurrentAnimNum = 0;
        }

        public void DisableMove()
        {
            IsAnim = false;
            DownTimer.Stop();
        }

        void IdelAnimTimer_Tick(object sender, EventArgs e)
        {
            DoIdelAnim();
        }

        void DownTimer_Tick(object sender, EventArgs e)
        {
            if(IsAnim)
            ItemPic.Top += speed;
        }

        public virtual void FillItemIdelAnim()
        {

        }

        public virtual void AdjustItemPic()
        {
            ItemPic.SizeMode = PictureBoxSizeMode.Zoom;

            ItemPic.Tag = "Item";
        }

        public  void SetItemTag(string tag)
        {
            ItemPic.Tag = tag;
        }

    }
}
