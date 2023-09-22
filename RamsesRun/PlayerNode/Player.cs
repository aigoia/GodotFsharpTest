using EgoScript;

namespace RamsesRun.PlayerNode;

public partial class Player : Ramses
{ 
	public override void _Ready() => Start();
	public override void _Process(double delta) => Update(delta);	
}
