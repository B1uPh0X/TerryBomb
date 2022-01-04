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
        Particles.Create("particles/explosion/barrel_explosion/explosion_barrel.vcpf", Position);
        //decreament LivBombs
        var overlap = Physics.GetEntitiesInSphere(Position, 1);
        //do stuff to stuff in radius
        
    }
}
