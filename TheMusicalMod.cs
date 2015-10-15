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

        public override void ChatInput(string text)
        {
            if (text[0] != '/')
                return;

            string command;
            string[] args;

            text = text.Substring(1);
            var index = text.IndexOf(' ');

            if (index < 0)
            {
                command = text;
                args = new string[0];
            }
            else
            {
                command = text.Substring(0, index);
                args = text.Substring(index + 1).Split(new [] {' '}, StringSplitOptions.RemoveEmptyEntries);
            }

            ChatHandler.ProcessCommand(command, args);
        }
    }
}
