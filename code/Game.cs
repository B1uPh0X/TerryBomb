//game.cs file

using Sandbox;


public partial class TerryBomb : Sandbox.Game
{
    public TerryBomb()
    {
		Grid grid = new Grid();
		grid.InitGrid();
		grid.generate();
    }//end of terrybomb

	public override void Simulate( Client cl )
	{
		base.Simulate( cl );
		Event.
	}
}//end of partial class
