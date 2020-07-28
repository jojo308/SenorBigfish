using Terraria.ID;
using Terraria.ModLoader;

namespace SenorBigfish.Items
{
    public class MrBubbles : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Mr Bubbles");
            Tooltip.SetDefault("It also has an older brother from Mexico");
        }

        public override void SetDefaults()
        {
            item.damage = 25;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.shoot = ProjectileID.Bubble;
            //item.shoot = mod.ProjectileType("BubbleProjectile");
            item.shootSpeed = 10;
            item.knockBack = 3;
            item.value = 10000;
            item.rare = ItemRarityID.Green;
            item.UseSound = SoundID.Item1;
        }
    }
}