//Player.cs
using Sandbox;

partial class Bomber : Player
{
        public override void Respawn(){
            SetModel("models/citizen/citizen.vmdl");

            Controller = new Pcontroller();

            Animator = new StandardPlayerAnimator();

            Camera = new td_cam();

            EnableAllCollisions = true;
            EnableDrawing = true;
            EnableHideInFirstPerson = true;
            EnableShadowInFirstPerson = true;

            base.Respawn();
        }//end of respawn override

}//end of player partial

//game.cs
public partial class TerryBomb : Sandbox.Game
{
    public override void ClientJoined( Client client)
    {
        base.ClientJoined( client );

        var player = new Bomber();
        client.Pawn = player;

        player.Respawn();
    }
}
