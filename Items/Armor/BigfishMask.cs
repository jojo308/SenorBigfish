using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SenorBigfish.Items.Armor
{
    [AutoloadEquip(EquipType.Head)]
    public class BigfishMask : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Bigfish Mask");
        }

        public override void SetDefaults()
        {
            item.width = 30;
            item.height = 26;
            item.maxStack = 1;
            item.value = Item.sellPrice(0, 2, 0, 0);
            item.rare = ItemRarityID.Green;
            item.vanity = true;
        }

        public override bool DrawHead()
        {
            return false;
        }
    }
}
