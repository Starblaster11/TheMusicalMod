using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using TheMusicalMod.Items;
using TheMusicalMod.NPCs;

namespace TheMusicalMod
{
    public class TheMusicalMod : Mod
    {
        public TheMusicalMod()
        {
            Properties = new ModProperties()
            {
                Autoload = true;  
            };
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
