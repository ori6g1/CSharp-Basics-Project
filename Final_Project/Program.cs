// ---- C# I (Dor Ben Dor) ----
// Ori Shacham-Barr
// -----------------------------

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;

        Printer.PrintOutline();

        ObjectType[,] room = new ObjectType[,] 
        { 
            {ObjectType.terrain, ObjectType.terrain, ObjectType.empty}, 
            {ObjectType.terrain, ObjectType.terrain, ObjectType.empty}, 
            {ObjectType.empty, ObjectType.empty, ObjectType.empty} 
        };
        Space space = new Space(room);
        

    }
}