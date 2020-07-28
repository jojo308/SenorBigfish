using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SenorBigfish.Items
{
    public class BubbleProjectile : ModProjectile
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("BubbleProjectile");
        }

        public override void SetDefaults()
        {
            projectile.width = 15;
            projectile.height = 15;
            projectile.ranged = true;
            projectile.timeLeft = 300; // 300 / 60fps = 5 sec
            projectile.penetrate = 3;
            projectile.scale = 0.6f;
            projectile.ignoreWater = true;
            projectile.friendly = true;
            projectile.aiStyle = ProjectileID.IceBolt;
            projectile.tileCollide = true;
        }

        public override void AI()
        {
            float scale = Main.rand.NextFloat(1, 15) / 10; // creates a scale value between 0.1 and 1.5
            projectile.scale = scale; // bubbles should have different sizes each time it is fired
            base.AI();
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.Wet, 10);
            base.OnHitNPC(target, damage, knockback, crit);
        }
    }
}
