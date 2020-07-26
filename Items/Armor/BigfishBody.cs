using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SenorBigfish.Items.Armor
{
    class BigfishBody : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bigfish body");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 18;
            item.maxStack = 1;
            item.value = Item.sellPrice(0, 2, 0, 0);
            item.headSlot = 26;
            item.rare = ItemRarityID.Blue;
            item.vanity = true;
        }

        public override bool DrawBody()
        {
            return base.DrawBody();
        }
    }
}
