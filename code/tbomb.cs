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
        }
    }   
}