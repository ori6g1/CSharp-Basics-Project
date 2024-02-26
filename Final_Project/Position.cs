using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Position
{
    public int x, y;

    public Position(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    public void ChangePosition(Position newPosition)
    {
        this.x = newPosition.x;
        this.y = newPosition.y;
    }
}

