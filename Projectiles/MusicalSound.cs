using System;
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
            projectile.melee = true;
            projectile.tileCollide = false;
            projectile.ignoreWater = true;
            projectile.aiStyle = 1;
        }
    }
}
