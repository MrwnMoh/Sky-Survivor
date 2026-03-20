using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items;

namespace SimpleGame.Resources
{
    internal class clsFire: Item
    {

        public override void FillItemIdelAnim()
        {
            ItemIdelAnimList.Add(Properties.Resources.Fire_Arrow_Frame_01);
            ItemIdelAnimList.Add(Properties.Resources.Fire_Arrow_Frame_03);
            ItemIdelAnimList.Add(Properties.Resources.Fire_Arrow_Frame_04);
            ItemIdelAnimList.Add(Properties.Resources.Fire_Arrow_Frame_05);
            ItemIdelAnimList.Add(Properties.Resources.Fire_Arrow_Frame_06);
            ItemIdelAnimList.Add(Properties.Resources.Fire_Arrow_Frame_07);
            ItemIdelAnimList.Add(Properties.Resources.Fire_Arrow_Frame_08);
        }


    }
}
