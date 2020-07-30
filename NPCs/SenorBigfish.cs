using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace SenorBigfish.NPCs
{
    class SenorBigfish : ModNPC
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("SenorBigfish");
            Main.npcFrameCount[npc.type] = 1;
        }

        public override void SetDefaults()
        {
            npc.width = 40;
            npc.height = 61;
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
    }
}
