using System.ComponentModel;
using Terraria.ModLoader;
using Terraria.ModLoader.Config;

namespace TungstenStickMod
{
    [Label("Settings")]
    public class TungstenStickConfig : ModConfig
    {
        public override ConfigScope Mode => ConfigScope.ClientSide;

        [Header("Settings")]
        [DefaultValue(3)]
        [Range(1, 5)]
        [ReloadRequired]
        [Label("Stat Impact (Default: 3) (Max: 5)")]
        public int statImpact;
    }
}
