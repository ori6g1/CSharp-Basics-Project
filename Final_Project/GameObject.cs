using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum ObjectType
{
    enemy,
    player,
    npc,
    terrain,
    projectile,
    item,
    door
}

internal class GameObject
{
    ObjectType Type;
    Position Position;

    public GameObject(ObjectType type, Position position) 
    { 
        Type = type;
        Position = position;
    }
}