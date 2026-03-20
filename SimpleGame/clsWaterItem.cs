using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items;

namespace SimpleGame
{
    internal class clsWaterItem : Item
    {
       
        public override void FillItemIdelAnim()
        {
            ItemIdelAnimList.Add(Properties.Resources.Water_Ball_Frame_01);
            ItemIdelAnimList.Add(Properties.Resources.Water_Ball_Frame_02);
            ItemIdelAnimList.Add(Properties.Resources.Water_Ball_Frame_03);
            ItemIdelAnimList.Add(Properties.Resources.Water_Ball_Frame_04);
            ItemIdelAnimList.Add(Properties.Resources.Water_Ball_Frame_05);
            ItemIdelAnimList.Add(Properties.Resources.Water_Ball_Frame_06);
            ItemIdelAnimList.Add(Properties.Resources.Water_Ball_Frame_07);
            ItemIdelAnimList.Add(Properties.Resources.Water_Ball_Frame_08);
            ItemIdelAnimList.Add(Properties.Resources.Water_Ball_Frame_09);
            ItemIdelAnimList.Add(Properties.Resources.Water_Ball_Frame_10);
            ItemIdelAnimList.Add(Properties.Resources.Water_Ball_Frame_11);
            ItemIdelAnimList.Add(Properties.Resources.Water_Ball_Frame_12);
        }


    }
}
