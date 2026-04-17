using Godot;
using System;
public abstract partial class CharacterMovement : CharacterBody2D, GravityMovement
{
    private const float Speed = 900.0f;
    public const float JumpSpeed = -600.0f;
    /// 1d direction
    public void Move(double delta, float direction)
    {
        Vector2 velocity = Velocity;
        if (direction != 0)
        {
            velocity.X = direction * Speed;
        }
        else
        {
            velocity.X = Mathf.MoveToward(Velocity.X, 0, Speed);
        }

        Velocity = velocity;
    }

    public void Jump()
    {
        Vector2 velocity = Velocity;
        velocity.Y = JumpSpeed;
        Velocity = velocity;
    }

    public void GravityProcess(double delta)
    {

        Vector2 velocity = Velocity;
        velocity.Y += (float)(GravityMovement.Gravity * delta);
        Velocity = velocity;
    }

}
