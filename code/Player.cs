//Player.cs
using Sandbox;


 namespace bomber{
        
        /*public int getMax(){
            return maxbombs;
        }

        public int getLiv(){
            return livbombs;
        }

        public void setMax(int foo, bool bar){
            if(bar==true)
                maxbombs -= foo;
            else
                maxbombs += foo;
        }

        public void setLiv(int foo, bool bar){
            if(bar==true)
                livbombs -= foo;
            else
                livbombs += foo;
        }*/
    }

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
            
            int maxbombs = 1;
            int livbombs = 0;


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
