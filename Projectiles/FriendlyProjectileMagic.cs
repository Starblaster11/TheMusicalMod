using System;
using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ModLoader;

namespace TheMusicalMod.Projectiles
{
    public class FriendlyProjectileMagic : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.name = "Friendly magic projectile";
            projectile.width = 30;
            projectile.height = 30;
            projectile.timeLeft = 600;
            projectile.penetrate = 0;
            projectile.friendly = true;
            projectile.magic = true;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
        }
    }
}
