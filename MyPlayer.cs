using Terraria.ModLoader;

namespace SenorBigfish
{
    class MyPlayer : ModPlayer
    {
        public bool ChickenPet = false;

        public override void ResetEffects()
        {
            ChickenPet = false;
        }
    }
}
