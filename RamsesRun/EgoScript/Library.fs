namespace EgoScript
open Godot
open System

module Init =
    let say = fun() -> GD.Print("Hello Godot!")