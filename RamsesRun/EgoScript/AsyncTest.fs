namespace EgoScript
open Godot
open System.Threading.Tasks

type IconRotate() =
    inherit Node2D()

    let DelayTime = 16
    let RotateAngle = 1.0f

    let mutable isRotate = true

    member this.IconNode = this.GetNode<Sprite2D>("Icon")

    member this.AsyncRoutine() =
        async {
            while isRotate do
                this.IconNode.RotationDegrees <- this.IconNode.RotationDegrees + RotateAngle
                do! Task.Delay(DelayTime) |> Async.AwaitTask
        }

    member public this.Start() = this.AsyncRoutine() |> Async.StartImmediate