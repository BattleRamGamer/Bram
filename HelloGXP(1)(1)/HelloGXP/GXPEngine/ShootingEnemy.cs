using GXPEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class ShootingEnemy : Enemy
{

    private float speed = 1;
    private Sprite target;

    public ShootingEnemy(string fileName, int cols, int rows) : base("checkers.png", cols, rows)
    {
        scale = 1;
        SetOrigin(width/2, height/2);


    }


    protected override void Act()
    {
        //Console.WriteLine("starting Act");
        if (target == null)
        {
            Console.WriteLine("target == null");
            target = game.FindObjectOfType<TemporaryPlayerClass>();
            Console.WriteLine("target should be defined");
        }
        //Console.WriteLine("doing the speed");
        //x += speed;
        Console.WriteLine(target);
        Console.WriteLine(Mathf.Sign(target.x - x));

        x += speed * Mathf.Sign(target.x - x);
        y += speed * Mathf.Sign(target.y - y);
        //Console.WriteLine("done with speed");


    }



    

}