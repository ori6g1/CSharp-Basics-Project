using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Position
{
    public int X { get; set; } 
    public int Y { get; set; }

    public Position(int x, int y)
    {
        X = x;
        Y = y;
    }

    public void ChangePosition(Position newPosition)
    {
        X = newPosition.X;
        Y = newPosition.Y;
    }
}

