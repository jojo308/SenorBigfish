using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SenorBigfish.Items.Armor
{
    class BigfishMask : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("MrBubbles");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 26;
            item.maxStack = 1;
            item.value = Item.sellPrice(0, 2, 0, 0);
            item.headSlot = 26;
            item.rare = ItemRarityID.Blue;
            item.vanity = true;
        }

        public override void DrawHair(ref bool drawHair, ref bool drawAltHair)
        {
            base.DrawHair(ref drawHair, ref drawAltHair);
        }
    }
}
