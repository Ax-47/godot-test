using Godot;
using System;

public partial class PrintInput : Node
{
    public override void _Input(InputEvent @event)
    {
        if (@event is InputEventKey keyEvent && keyEvent.Pressed)
        {
            GD.Print(@event.AsText());
        }
        else
        {
        }
    }
}