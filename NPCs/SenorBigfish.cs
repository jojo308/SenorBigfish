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
            //Main.npcFrameCount[npc.type] = 1;
            Main.npcFrameCount[npc.type] = NPCID.Zombie;
        }

        public override void SetDefaults()
        {
            npc.width = 40;
            npc.height = 61;
            npc.aiStyle = 2;
            npc.damage = 7;
            npc.defense = 10;
            npc.lifeMax = 125;
            npc.HitSound = SoundID.NPCHit1;
            npc.DeathSound = SoundID.NPCDeath1;
            //npc.alpha = 175;
            //npc.color = new Color(0, 80, 255, 100);
            npc.value = 25f;
            npc.buffImmune[BuffID.Poisoned] = true;
            npc.buffImmune[BuffID.Confused] = false;

            animationType = 1;
        }
    }
}
