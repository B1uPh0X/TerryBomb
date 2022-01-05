using Sandbox;

public class wall : ModelEntity{

	public override void Spawn(){
		base.Spawn();
        SetModel("models/citizen_props/crate01.vmdl");
	}

    public void SetPosition(Vector3 pos){
        Position = pos;
    }

}