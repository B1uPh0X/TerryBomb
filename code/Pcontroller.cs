using Sandbox;



public class Pcontroller : WalkController
{

	public override void Move()
	{
		if( Input.Pressed(InputButton.Forward)){
                    
        }
        else if( Input.Pressed(InputButton.Right)){

        }
        else if(Input.Pressed(InputButton.Left)){

        }
        else if(Input.Pressed(InputButton.Back)){	

        }
		base.Move();
	}


	public override float GetWishSpeed()
	{
		return SprintSpeed;
	}
}
