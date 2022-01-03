using Sandbox;
	public class td_cam : Camera
	{
		Vector3 TargetPos;
		Rotation TargetRot;
		//Entity player = Local.Client.Pawn;
		public td_cam()
		{		
			var player = Local.Client?.Pawn;
			if( player != null ){
				
				Position = player.Position;
				TargetPos = Position;
				TargetPos.z = 1028;

				Rotation = player.Rotation;
				TargetRot = Rotation;
				TargetRot.y = .71F;

			}

				/*
				//Position = player.Position;
                TargetPos.x = 0;
                TargetPos.y = 0;
                TargetPos.z = 256;//512 is top
				Position = TargetPos;

				//Rotation = player.Rotation;
				TargetRot = Rotation;
                TargetRot.x = 0;
                TargetRot.y = .71F;//.71F
                TargetRot.z = 0;
				Rotation = TargetRot;	*/
		}

		public override void Update()
		{
			FieldOfView = 70;
			Position = TargetPos;
			Rotation = TargetRot;
			Viewer = null;

			/*
			//TargetPos.x = player.Position.x;
			//TargetPos.y = player.Position.y;
			Position = TargetPos;
			Rotation = TargetRot;

			FieldOfView = 120;
			Viewer = null;*/
		}
	}
