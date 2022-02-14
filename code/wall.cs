using Sandbox;

public class wall : ModelEntity{

	public override void Spawn(){
		base.Spawn();
        EnableAllCollisions = true;
        EnableTouch = true;
        SetModel("models/citizen/citizen.vmdl");
        Scale = 1.8f;
	}

    public void SetPosition(Vector3 pos){
        Position = pos;
    }

}