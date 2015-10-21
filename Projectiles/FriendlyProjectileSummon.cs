using System;
using Terraria.ModLoader;

namespace TheMusicalMod.Projectiles
{
    public class FriendlyProjectileRanged : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.name = "Friendly melee projectile";
            projectile.width = 30;
            projectile.height = 30;
            projectile.alpha = 255;
            projectile.timeLeft = 600;
            projectile.penetrate = -1;
            projectile.friendly = true;
            projectile.ranged = true;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
        }
    }
}
