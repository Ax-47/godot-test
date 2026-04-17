using Godot;
using System;
public abstract partial class CharacterMovement : CharacterBody2D, GravityMovement
{
    private const float Speed = 900.0f;
    public const float JumpSpeed = -600.0f;
    /// 1d direction
    public void Move(double delta, float direction)
    {
        Velocity = new Vector2(
                    Mathf.MoveToward(Velocity.X, direction * Speed, Speed * 0.1f),
                    Velocity.Y
                );
    }

    public void Jump()
    {
        if (IsOnFloor())
        {
            Velocity = new Vector2(Velocity.X, JumpSpeed);
        }
    }

    public void GravityProcess(double delta)
    {
        if (!IsOnFloor())
        {
            Velocity = new Vector2(
                Velocity.X,
                Velocity.Y + (float)GravityMovement.Gravity * (float)delta
            );
        }
    }

}
