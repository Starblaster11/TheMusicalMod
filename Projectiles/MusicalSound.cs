﻿using Terraria;
using Terraria.ModLoader;

namespace TheMusicalMod.Projectiles
{
    public class MusicalSound : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.name = "Musical Sound";
            projectile.width = 30;
            projectile.height = 30;
            projectile.alpha = 255;
            projectile.timeLeft = 600;
            projectile.penetrate = -1;
            projectile.hostile = true;
            projectile.magic = true;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
        }

        public override void AI()
        {
        }

        public override bool CanHitPlayer(Player target, ref int cooldownSlot)
        {
            return true;
        }

        public override void OnHitPlayer(Player target, int damage, bool crit)
        {
        }
    }
}
