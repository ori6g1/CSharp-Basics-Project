using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

enum ObjectType
{
    empty,
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
    public ObjectType Type {  get; set; }
    public Position Position { get; set; }

    public GameObject(ObjectType type, Position position) 
    { 
        Type = type;
        Position = position;
    }
}