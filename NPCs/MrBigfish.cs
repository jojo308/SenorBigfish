using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SenorBigfish.NPCs
{
    class MrBigfish : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("MrBigfish");
            Main.npcFrameCount[npc.type] = 1;
        }

        public override void SetDefaults()
        {
            npc.width = 32;
            npc.height = 32;
            npc.aiStyle = 3; // fighter AI
            npc.damage = 7;
            npc.defense = 10;
            npc.lifeMax = 125;
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
                return SpawnChanceHelper(spawnInfo) * (float)0.25; // lower spawn chance because there should be more Senor Bigfish in hardmode
            }
            else
            {
                return SpawnChanceHelper(spawnInfo);
            }
        }
        
         /*
          * Helper method for SpawnChance(), determines the spawnrate based on the given spawnInfo.
          * NPC spawns naturally in the ocean biome or on the entire surface if it's raining.
          * */
        private float SpawnChanceHelper(NPCSpawnInfo spawnInfo)
        {
            if (spawnInfo.player.ZoneBeach)
            {
                return 0.2f;
            }

            if (Main.raining)
            {
                return 0.1f;
            }
            return 0;
        }

        public override void NPCLoot()
        {
            var rect = npc.getRect();
            if (Main.rand.NextFloat() < .01f)
            {
                Item.NewItem(rect.X, rect.Y, rect.Width, rect.Height, mod.ItemType("MrBubbles"), 1);
            }

            base.NPCLoot();
        }
    }
}
