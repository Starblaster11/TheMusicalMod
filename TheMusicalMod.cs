using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
//using TheMusicalMod.Items; These will come in once we figure out what we will put in these folders.
//using TheMusicalMod.NPCs;  These will come in once we figure out what we will put in these folders.

namespace TheMusicalMod
{
    public class TheMusicalMod : Mod
    {
        public override void SetModInfo(out string name, ref ModProperties properties)
        {
            name = "TheMusicalMod";
            properties.Autoload = true;
            properties.AutoloadGores = true;
            properties.AutoloadSounds = true;
        }
    }
}
