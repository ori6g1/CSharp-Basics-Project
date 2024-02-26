using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

static class Screen
{
    static private int _spaceStartX = 30;
    static private int _spaceStartY = 10;

    public static void PrintOutline()
    {
        ConsoleColor color = ConsoleColor.DarkGray;
        char sprite;

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
            {
                Position position = new Position(j + _spaceStartX, i + _spaceStartY);
                if (i == 0 || i == 9)
                    sprite = '-';
                else if (j == 0 || j == 9)
                    sprite = '|';
                else
                    sprite = ' ';

                Printer.Print(position, color, sprite);
            }
        }
    }
}