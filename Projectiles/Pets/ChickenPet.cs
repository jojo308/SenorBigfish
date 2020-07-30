using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SenorBigfish.Projectiles.Pets
{
    public class ChickenPet : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            Main.projFrames[projectile.type] = 4;
            Main.projPet[projectile.type] = true;
        }
        public override void SetDefaults()
        {
            projectile.CloneDefaults(ProjectileID.ZephyrFish);
            aiType = ProjectileID.ZephyrFish;
        }

        public override bool PreAI()
        {
            Main.player[projectile.owner].zephyrfish = false;
            return true;
        }

        public override void AI()
        {
            Player player = Main.player[projectile.owner];
            player.zephyrfish = false;
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
