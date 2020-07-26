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
            projectile.timeLeft = 300; // 300 / 60fps = 5 sec
            projectile.penetrate = 3;
            projectile.scale = 0.6f;
            projectile.ignoreWater = true;
            projectile.melee = true;
            projectile.friendly = true;
            projectile.aiStyle = ProjectileID.IceBolt;
            projectile.tileCollide = false;
        }

        public override void OnHitNPC(NPC target, int damage, float knockback, bool crit)
        {
            target.AddBuff(BuffID.Wet, 10);
            base.OnHitNPC(target, damage, knockback, crit);
        }
    }
}
