using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SenorBigfish.NPCs
{
    class SenorBigfish : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Senor Bigfish");
            Main.npcFrameCount[npc.type] = 1;
        }

        public override void SetDefaults()
        {
            npc.width = 40;
            npc.height = 61;
            npc.aiStyle = 3; // fighter AI
            npc.damage = 7;
            npc.defense = 10;
            npc.lifeMax = 300;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            npc.value = 25f;
            npc.buffImmune[BuffID.Poisoned] = true;
            npc.buffImmune[BuffID.Confused] = false;
        }

        public override float SpawnChance(NPCSpawnInfo spawnInfo)
        {
            if (Main.hardMode)
            {
                return SpawnChanceHelper(spawnInfo);
            }
            else
            {
                return 0f; // can't spawn until world is in harmode
            }
        }

        /*
         * Helper method for SpawnChance(), determines the spawnrate based on the given spawnInfo.
         * This NPC spawns naturally in the ocean biome or on the entire surface if it's raining.
         * */
        private float SpawnChanceHelper(NPCSpawnInfo spawnInfo)
        {
            if (spawnInfo.player.ZoneBeach)
            {
                return 0.2f;
            }
            else if (Main.raining)
            {
                return 0.1f;
            }
            else if (Main.bloodMoon)
            {
                return 0.2f;
            }
            return 0;
        }

        public override void NPCLoot()
        {
            var rect = npc.getRect();
            if (Main.rand.NextFloat() < .01f)
            {
                Item.NewItem(rect.X, rect.Y, rect.Width, rect.Height, mod.ItemType("SenorBubbles"), 1);
            }
            base.NPCLoot();
        }
    }
}
