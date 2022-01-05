using System;
using System.Reflection;
//Player.cs
using Sandbox;
       
        /*public int getMax(){
            return MaxBombs;
        }

        public int getLiv(){
            return LivBombs;
        }

        public void setMax(int foo, bool bar){
            if(bar==true)
                MaxBombs -= foo;
            else
                MaxBombs += foo;
        }

        public void setLiv(int foo, bool bar){
            if(bar==true)
                LivBombs -= foo;
            else
                LivBombs += foo;
        }*/
    
   
    partial class Bomber : Player
    {
        public int MaxBombs = 1;
        public int LivBombs = 0;

        //public object[] bombarry;

        public tbomb e;
            public override void Respawn(){
                SetModel("models/citizen/citizen.vmdl");

                Controller = new Pcontroller();//revert back to defualt if nothing happens pcontroller

                Animator = new StandardPlayerAnimator();

                Camera = new td_cam();
                //make it so the player rotates according to movement inputs, not mouse

                EnableAllCollisions = true;
                EnableDrawing = true;
                EnableHideInFirstPerson = true;
                EnableShadowInFirstPerson = true;              

                MaxBombs = 1;
                LivBombs = 0;            
                
                

                base.Respawn();
            }//end of respawn override  

            public override void Simulate( Client cl ){
                if ( Input.Pressed (InputButton.Jump)){
                    if(LivBombs<MaxBombs){
			        //bombarry[0] = 
                    e = new tbomb();
                    LivBombs++;
                    }
		        }
                else if( Input.Pressed (InputButton.Attack1)){
                    if(e!=null){
                    //tbomb e = (tbomb)bombarry[0];
                        LivBombs--;
                        e.explode();
                        e.Delete();
                   // bombarry[0]=null;
                    }
                }
                else if(Input.Pressed (InputButton.Attack2)){
                    //MaxBombs++;
                }
                else
                base.Simulate( cl );
            }


    }

//game.cs

public partial class TerryBomb : Sandbox.Game
{
    public override void ClientJoined( Client client)
    {
        base.ClientJoined( client );

        var player = new Bomber();
        client.Pawn = player;

        player.Respawn();

        //move this out of client joined before multiplayer test
        //where? idk
        var grid = new Grid();
		grid.InitGrid();
		grid.generate();
    }
}
