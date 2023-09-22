using Godot;
using EgoScript;

namespace RamsesRun.Prefab;

public partial class Player : Ramses
{ 
	public override void _Ready() => Start();
	public override void _Process(double delta) => Update(delta);	
}
