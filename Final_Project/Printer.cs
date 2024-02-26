using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

internal class Printer
{
    public ConsoleColor Color { get; set; }
    public Position Position { get; set; }
    public char Sprite { get; set; }

    public Printer(ConsoleColor color, Position position, char sprite) 
    {
        Color = color;
        Position = position;
        Sprite = sprite;
    }

    public void Print() 
    {
        Console.SetCursorPosition(Position.X, Position.Y);
        Console.ForegroundColor = Color;
        Console.Write(Sprite);
        Console.ResetColor();
    }

    static public void Print(Position position, ConsoleColor color, char sprite)
    {
        Console.SetCursorPosition(position.X, position.Y);
        Console.ForegroundColor = color;
        Console.Write(sprite);
        Console.ResetColor();
    }

    
}