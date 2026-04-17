using Godot;
using System;
public interface GravityMovement
{
    public const double Gravity = 980.0f;
    virtual public void GravityProcess(double delta)
    {
    }
}
