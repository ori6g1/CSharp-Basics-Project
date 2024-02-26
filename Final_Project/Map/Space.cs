using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Space
{
    public ObjectType[,] Room {  get; set; }
    private Printer printer;

    public Space(ObjectType[,] room)
    {
        Room = room;
    }
}
