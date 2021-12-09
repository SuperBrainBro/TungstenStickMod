using Terraria;
using Terraria.ModLoader;

namespace TungstenStickMod
{
	public class TungstenStickGlobalItem : GlobalItem
	{
        public override void ModifyWeaponDamage(Item item, Player player, ref StatModifier damage, ref float flat)
        {
            damage = new StatModifier(1, (float)player.GetModPlayer<TungstenStickPlayer>().damageNerf);
        }
    }
}