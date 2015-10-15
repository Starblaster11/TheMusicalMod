using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheMusicalMod
{
    public class TheMusicalMod : Mod
    {
        public override void SetModInfo(out string name, ref ModProperties properties)
        {
            name = "TheExampleMod";
            properties.Autoload = true;
        }
    }
}
