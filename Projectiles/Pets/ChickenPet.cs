using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SenorBigfish.Projectiles.Pets
{
    public class ChickenPet : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.ZephyrFish);
            projectile.Name = "Chicken pet";
            Main.projFrames[projectile.type] = 4;
            Main.projPet[projectile.type] = true;
        }

        public override bool PreAI()
        {
            //Main.player[projectile.owner].zephyrfish = false;
            //return true;

            Player player = Main.player[projectile.owner];
            player.zephyrfish = false; // Relic from aiType
            return true;
        }

        public override void AI()
        {
            Player player = Main.player[projectile.owner];
            MyPlayer modPlayer = player.GetModPlayer<MyPlayer>();
            if (player.dead)
            {
                modPlayer.ChickenPet = false;
            }
            if (modPlayer.ChickenPet)
            {
                projectile.timeLeft = 2;
            }
        }
    }
}
