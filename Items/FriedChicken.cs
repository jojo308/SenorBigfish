using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ModLoader.ModContent;

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
            item.shoot = ProjectileType<Projectiles.Pets.ChickenPet>();
            item.buffType = BuffType<Buffs.ChickenPet>();
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
