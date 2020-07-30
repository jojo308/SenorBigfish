using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SenorBigfish.Items
{
    public class FriedChicken : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Fried Chicken");
            Tooltip.SetDefault("summons a flying chicken");
        }

        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.ZephyrFish);
            item.shoot = mod.ProjectileType("ChickenPet");
            item.buffTime = mod.BuffType("ChickenPet");
        }

        public override void UseStyle(Player player)
        {
            if (player.whoAmI == Main.myPlayer && player.itemTime == 0)
            {
                player.AddBuff(mod.BuffType("ChickenPet"), 3600, true);
            }
        }
    }
}
