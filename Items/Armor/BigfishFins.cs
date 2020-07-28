using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SenorBigfish.Items.Armor
{
    [AutoloadEquip(EquipType.Legs)]
    public class BigfishFins : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bigfish Fins");
        }

        public override void SetDefaults()
        {
            item.width = 22;
            item.height = 18;
            item.maxStack = 1;
            item.value = Item.sellPrice(0, 2, 0, 0);
            item.rare = ItemRarityID.Green;
            item.vanity = true;
        }

        public override bool DrawLegs()
        {
            return false;
        }
    }
}
