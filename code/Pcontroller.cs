using Sandbox;

public class Pcontroller : WalkController
{
	public override void Simulate()
	{
		if ( Input.Pressed (InputButton.Attack1)){
			
			new tbomb();
		
		}

          base.Simulate();
	}

	public override void CheckJumpButton() {
		//change tbne
		new tbomb();
	}

	public override float GetWishSpeed(){
		return SprintSpeed;
	}

	public override void Move()
	{
		base.Move();
		
	}
}