using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SenorBigfish.Buffs
{
    public class ChickenPet : ModBuff
    {
        public override void SetDefaults()
        {
            DisplayName.SetDefault("Chicken pet");
            Description.SetDefault("this one won't try to invade the world");
            Main.buffNoTimeDisplay[Type] = true;
            Main.vanityPet[Type] = true;
            //Main.buffNoSave[Type] = true;
        }

        public override void Update(Player player, ref int buffIndex)
        {
            player.buffTime[buffIndex] = 18000;
            player.GetModPlayer<MyPlayer>().ChickenPet = true;
            bool notSpawned = player.ownedProjectileCounts[mod.ProjectileType("ChickenPet")] <= 0;
            if (notSpawned && player.whoAmI == Main.myPlayer)
            {
                Projectile.NewProjectile(player.position.X +
                    player.width / 2, player.position.Y +
                    player.height / 2, 0f, 0f, mod.ProjectileType("ChickenPet"), 0, 0f, player.whoAmI, 0f, 0f);
            }
        }
    }
}
