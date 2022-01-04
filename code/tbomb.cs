
using System;
using Sandbox;

public class tbomb : ModelEntity
{
        public override void Spawn(){       
        base.Spawn();
        var player = Local.Client?.Pawn;
        if( player != null ){
            Owner = player.Owner;
            Position = player.Position;
            EnableAllCollisions = true;
            SetModel("models/citizen_props/crate01.vmdl");          
            //increament LivBombs
        }
    }  

    public void explode(){
        // Effects
		Sound.FromWorld("rust_pumpshotgun.shootdouble", Position);
        Particles.Create("particles/explosion/barrel_explosion/explosion_barrel.vpcf", Position);
        //do stuff to stuff in radius
        var Radius = 1;
        var overlaps = Physics.GetEntitiesInSphere(Position, Radius);
        foreach( var overlap in overlaps ){
            if( overlap is not ModelEntity || !IsValid )
                continue;
            if( LifeState != LifeState.Alive )
                continue;
            if( PhysicsBody.IsValid() )
                continue;
            if( IsWorld )
                continue;

            var targetPos = PhysicsBody.MassCenter;
            var dist = Vector3.DistanceBetween(Position , targetPos);
            if( dist > Radius )
                continue;
            //TODO integrate this stuff into the grid, might make shit easier
           /* var tr = Trace.Ray( Position, targetPos )
                .WorldOnly()
                .Run();

            var distanceMul = 1.0f - Math.Clamp( dist / Radius, 0.0f, 1.0f );
            var dmg = 1000;
            var force = (1.0f * distanceMul) * PhysicsBody.Mass;
            var forceDir = (targetPos - Position).Normal;

            TakeDamage( DamageInfo.Explosion( Position, forceDir * force, dmg ));
*/
           // Delete();
        }
    }
}
