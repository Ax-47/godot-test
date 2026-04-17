using Godot;
using System;
public partial class Character : CharacterMovement
{
    public override void _PhysicsProcess(double delta)
    {
        GravityProcess(delta);
        float direction = Input.GetAxis("a", "d");
        Move(delta, direction);
        if (Input.IsActionJustPressed("jump"))
        {
            Jump();
        }
        MoveAndSlide();
    }

}
