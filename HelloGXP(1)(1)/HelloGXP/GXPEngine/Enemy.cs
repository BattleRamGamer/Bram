using GXPEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Enemy : Sprite
{
    

    public Enemy() : base("colors.png")
    {
        
        SetOrigin(width / 2, height / 2);
    }

    

    void Update()
    {
        
    }
}