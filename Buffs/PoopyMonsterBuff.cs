using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using SandTools.Minions;

namespace SandTools.Buffs
{
    internal class PoopyMonsterBuff : ModBuff
    {
        public override void SetStaticDefaults()
        {
            Main.buffNoSave[Type] = true;
            Main.buffNoTimeDisplay[Type] = true;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            if (player.ownedProjectileCounts[ModContent.ProjectileType<PoopyMonster>()] > 0)
            {
                player.buffTime[buffIndex] = 18000;
                return;
            }

            player.DelBuff(buffIndex);
            buffIndex--;
        }
    }
}
