namespace EgoScript
open Godot
open System

module Init =
    let say = fun() -> GD.Print("Hello Godot!")

    let saySwitch (say : string) =
        match say.ToLower() with
        | "hello world!" -> "Nice to meet you!"
        | "hello world" -> "Nice to meet you"
        | "hello godot!" -> "Good to see you again!"
        | "hello godot" -> "Good to see you again"
        | _ -> say