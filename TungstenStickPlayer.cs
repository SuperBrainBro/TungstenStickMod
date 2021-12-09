using System;
using Terraria.ModLoader;

namespace TungstenStickMod
{
	public class TungstenStickPlayer : ModPlayer
	{
        public double damageNerf;
        public double healthBuff;
        public override void ResetEffects()
        {
            Player.statLifeMax2 += (int)(Player.statLifeMax2 * healthBuff);
        }
        public override void PostUpdate()
        {

        }

        public override void Initialize()
        {
            //Health Impact
            switch (ModContent.GetInstance<TungstenStickConfig>().statImpact)
            {
                case 1:
                    healthBuff = .25;
                    break;
                case 2:
                    healthBuff = .50;
                    break;
                case 3:
                    healthBuff = 1;
                    break;
                case 4:
                    healthBuff = 2;
                    break;
                case 5:
                    healthBuff = 3;
                    break;
            }

            //Damage Impact
            switch (ModContent.GetInstance<TungstenStickConfig>().statImpact)
            {
                case 1:
                    damageNerf = .80;
                    break;
                case 2:
                    damageNerf = .60;
                    break;
                case 3:
                    damageNerf = .5;
                    break;
                case 4:
                    damageNerf = .25;
                    break;
                case 5:
                    damageNerf = .10;
                    break;
            }
        }
    }
}