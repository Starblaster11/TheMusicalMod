using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheMusicalMod.NPCs
{
	public class MusicalMadBro : ModNPC
	{
		public override void SetDefaults()
		{
			npc.name = "Musical Mad Bro";
			npc.lifeMax = 150;
			npc.damage = 20;
			npc.defense = 5;
			npc.width = 50;
			npc.height = 25;
			npc.aiStyle = 3;
			npc.soundKilled = 1;
			npc.value = Item.buyPrice(999, 99, 99, 99);
		}

        public override bool CanHitPlayer(Player target, ref int cooldownSlot)
        {
            return true;
        }

        public override float CanSpawn(NPCSpawnInfo spawnInfo)
        {
            return 100f;
        }
        //Here I'm trying to make the enemy shoot the HostileProjectile. Failing terribly plz help.
    }
}
