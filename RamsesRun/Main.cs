using System.Linq;
using Godot;
using EgoScript;

namespace RamsesRun;

public partial class Main : Node2D
{
	public override void _Process(double delta)
	{
		if (Input.IsKeyPressed(Key.Escape)) GetTree().Quit();
	}
}
