using Terraria.ID;
using Terraria.ModLoader;

namespace SenorBigfish.Items
{
    public class MrBubbles : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("MrBubbles"); // By default, capitalization in classnames will add spaces to the display name. You can customize the display name here by uncommenting this line.
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
            item.shootSpeed = 10;
            item.knockBack = 3;
            item.value = 10000;
            item.rare = ItemRarityID.Green;
            item.UseSound = SoundID.Item1;
        }
    }
}