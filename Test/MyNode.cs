using Godot;
using System;
using Test;

public class MyNode : Node
{
    // Member variables here, example:
    // private int a = 2;
    // private string b = "textvar";

    public override void _Ready()
    {
        // Called every time the node is added to the scene.
        // Initialization here
        GD.Print("Hello from the Node CS Script Init");

        Hexasphere h = new Hexasphere(30, 25, 0.95);

        GD.Print("Number of Tiles: " + h.GetTiles().Count);
    }

//    public override void _Process(float delta)
//    {
//        // Called every frame. Delta is time since last frame.
//        // Update game logic here.
//        
//    }
}
