using Terraria;
using Terraria.ModLoader;

namespace TheMusicalMod.Projectiles
{
    public class HostileProjectile : ModProjectile
    {
        public override void SetDefaults()
        {
            projectile.name = "Hostile Projectile";
            projectile.width = 30;
            projectile.height = 30;
            projectile.alpha = 255;
            projectile.timeLeft = 600;
            projectile.penetrate = -1;
            projectile.hostile = true;
            projectile.tileCollide = true;
            projectile.ignoreWater = true;
        }

        public override void AI()
        {
            PlaySound();
        }

        public override bool CanHitPlayer(Player target, ref int cooldownSlot)
        {
            return true;
        }
        
        public override void OnHitPlayer(Player target, int damage, bool crit)
        {
            target.Hurt(5, projectile.direction);
        }

        public virtual void PlaySound()
        {
            Main.PlaySound(2, (int)projectile.position.X, (int)projectile.position.Y, 20);
        }
    }
}
