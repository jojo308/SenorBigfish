using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

namespace SenorBigfish.Items
{
    public class SenorBubbles : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Senor Bubbles");
            Tooltip.SetDefault("Its bubbles are very spicy");
        }

        public override void SetDefaults()
        {
            item.width = 40;
            item.height = 40;
            item.damage = 45;
            item.melee = true;
            item.useTime = 20;
            item.useAnimation = 20;
            item.useStyle = ItemUseStyleID.SwingThrow;
            item.shoot = mod.ProjectileType("BubbleProjectile");
            item.shootSpeed = 10;
            item.knockBack = 4;
            item.value = Item.buyPrice(gold: 10);
            item.rare = ItemRarityID.LightRed;
            item.UseSound = SoundID.Item1;
            item.autoReuse = true;
            item.crit = 6;
        }
    }
}
