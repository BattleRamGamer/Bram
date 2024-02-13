using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GXPEngine;

internal class Player : AnimationSprite
{
    float speed;
    public Player() : base("barry.png",7,1) 
    {
        speed = 2f;
    }

    void Update()
    {
        Movement();
    }

    void Movement()
    {
        if (Input.GetKey(Key.LEFT))
        { Move(-speed, 0); }
        if (Input.GetKey(Key.RIGHT))
        { Move(speed, 0); }
        if (Input.GetKey(Key.UP))
        { Move(0, -speed); }
        if (Input.GetKey(Key.DOWN))
        { Move(0, speed); }
    }
}   

