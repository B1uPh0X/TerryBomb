using System;
using Sandbox;

public class tbomb : ModelEntity
{

    //check bombs here using accssor func??
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
    
    public void explode(){
        // Effects
		Sound.FromWorld("rust_pumpshotgun.shootdouble", Position);
        Particles.Create("particles/explosion/barrel_explosion/explosion_barrel.vcpf", Position);


        var overlap = Physics.GetEntitiesInSphere(Position, 1);
    }
}