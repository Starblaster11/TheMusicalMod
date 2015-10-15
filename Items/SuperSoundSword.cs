using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace TheMusicalMod.Items
{
    public class SuperSoundSword : ModItem
    {
        public override void SetDefaults()
        {
            item.name = "Super Sound Sword";
            item.damage = 20;
            item.melee = true;
            item.width = 40;
            item.height = 40;
            item.useTime = 15;
            item.useAnimation = 15;
            item.useStyle = 1;
            item.knockBack = 5;
            item.value = 10000;
            item.rare = 5;
            item.useSound = 1;
            item.autoReuse = true;
            item.shoot = mod.ProjectileType("MusicalSound");
            item.shootSpeed = 15f;
        }

        public override void AddRecipes()
        {
            ModRecipe recipe = new ModRecipe(mod);
            recipe.AddIngredient(ItemID.DirtBlock);
            recipe.SetResult(this);
            recipe.AddRecipe();
        }
    }
}
