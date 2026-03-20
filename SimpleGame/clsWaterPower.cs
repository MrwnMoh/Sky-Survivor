using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Items;

namespace SimpleGame
{
    internal class clsWaterPower : Item
    {

        public override void FillItemIdelAnim()
        {
            ItemIdelAnimList.Add(Properties.Resources.Water_Spell_Frame_01);
            ItemIdelAnimList.Add(Properties.Resources.Water_Spell_Frame_02);
            ItemIdelAnimList.Add(Properties.Resources.Water_Spell_Frame_03);
            ItemIdelAnimList.Add(Properties.Resources.Water_Spell_Frame_04);
            ItemIdelAnimList.Add(Properties.Resources.Water_Spell_Frame_05);
            ItemIdelAnimList.Add(Properties.Resources.Water_Spell_Frame_06);
            ItemIdelAnimList.Add(Properties.Resources.Water_Spell_Frame_07);
            ItemIdelAnimList.Add(Properties.Resources.Water_Spell_Frame_08);
        }



    }
}
