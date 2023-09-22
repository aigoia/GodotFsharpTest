namespace EgoScript
open Godot
open System

type Ramses() =
    inherit Node2D()

    let MoveSpeed = 60f

    let Left = Key.A
    let Right = Key.D
    let Down = Key.S

    let mutable velocity = Vector2.Zero
    let mutable horizontalMovement = 0f
    let mutable track = false

    member this.ImageNode = this.GetNode<Sprite2D>("Image")
    member this.AnimationNode = this.GetNode<AnimationPlayer>("AnimationPlayer")
    
    member public this.Start() = this.AnimationNode.Play("Idle")
    member public this.Update(deltaTime) =
        this.Action(deltaTime)
        this.State()
    
    member this.Action(deltaTime: double) =
        horizontalMovement <- if Input.IsKeyPressed(Left) then -1f
                              elif Input.IsKeyPressed(Right) then 1f
                              else 0f
        track <- Input.IsKeyPressed(Down)
        velocity.X <- horizontalMovement * MoveSpeed
        this.MoveLocalX(velocity.X * (float32)deltaTime)

    member this.State() =
        this.ImageNode.FlipH <- if velocity.X = 0f then this.ImageNode.FlipH
                                else velocity.X < 0f

        this.AnimationNode.Play(if velocity.X <> 0f then "Walk"
                                elif track then "Track"
                                else "Idle")