namespace HangmanCLI;

public class Drawing
{
    private readonly string[] hangmanStages = {
        @"
  +---+
  |   |
      |
      |
      |
      |
=========
", @"
  +---+
  |   |
  O   |
      |
      |
      |
=========
", @"
  +---+
  |   |
  O   |
  |   |
      |
      |
=========
", @"
  +---+
  |   |
  O   |
 /|   |
      |
      |
=========
", @"
  +---+
  |   |
  O   |
 /|\  |
      |
      |
=========
", @"
  +---+
  |   |
  O   |
 /|\  |
 /    |
      |
=========
", @"
  +---+
  |   |
  O   |
 /|\  |
 / \  |
      |
=========
"};
    
    public void DrawLevel(int level, ConsoleColor color)
    {
        if (level < 0 || level > 6)
        {
            Console.WriteLine("Level out of range!");
            return;
        }

        Console.ForegroundColor = color;
        Console.WriteLine(hangmanStages[level]);
        Console.ResetColor();
    }

    public void WriteColoredText(string text, ConsoleColor color, bool newLine)
    {
        Console.ForegroundColor = color;
        
        if(newLine)
            Console.WriteLine(text);
        else Console.Write(text);

        Console.ForegroundColor = ConsoleColor.White;
    }
}