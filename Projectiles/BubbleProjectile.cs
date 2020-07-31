using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SenorBigfish.Projectiles
{
    public class BubbleProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bubble Projectile");
        }

        public override void SetDefaults()
        {
            projectile.width = 15;
            projectile.height = 15;
            projectile.ranged = true;
            projectile.timeLeft = 300; // 300 / 60fps = 5 sec
            projectile.penetrate = 1;
            float scale = Main.rand.NextFloat(5, 15) / 10; // creates a scale value between 0.5 and 1
            projectile.scale = scale; // bubbles should have random sizes each time one is fired
            projectile.ignoreWater = true;
            projectile.friendly = true;
            projectile.aiStyle = ProjectileID.Bubble;
            projectile.tileCollide = true;
            Main.PlaySound(SoundID.Splash, projectile.position);
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.Wet, 10);
            base.OnHitNPC(target, damage, knockback, crit);
        }

        public override void Kill(int timeLeft)
        {
            Collision.HitTiles(projectile.position, projectile.velocity, projectile.width, projectile.height);
            Main.PlaySound(SoundID.Splash, projectile.position);
        }
    }
}
