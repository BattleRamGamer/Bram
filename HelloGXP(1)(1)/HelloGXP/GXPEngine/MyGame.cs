using System;                   // System contains a lot of default C# libraries 
using GXPEngine;                // GXPEngine contains the engine

public class MyGame : Game {

	Player player;
	public MyGame() : base(800, 600, false)
	{
        EasyDraw canvas = new EasyDraw(800, 600, false);
        player = new Player();

		AddChild(canvas);
		AddChild(player);
    }
	void Update() {
		
	}

	static void Main() {
		new MyGame().Start();
	}
}