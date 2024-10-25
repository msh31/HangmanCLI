using CrypticWizard.RandomWordGenerator;
using HangmanCLI;

WordGenerator wordGenerator = new WordGenerator();
Drawing drawing = new Drawing();
string randomWord = wordGenerator.GetWord();

int maxAttempts = 6;
int attemptCount = 0;
bool correct = false;

while (attemptCount < maxAttempts && !correct)
{
    Console.Write($"{attemptCount + 1}/{maxAttempts} - Word has [{randomWord.Length}] characters, enter your guess: ");
    var input = Console.ReadLine();
    
    if (input.ToLower() == randomWord)
    {
        drawing.WriteColoredText("Correct!", ConsoleColor.Green, true);
        correct = true;
    }
    else
    {
        attemptCount++;
        drawing.DrawLevel(attemptCount, ConsoleColor.Magenta);
        
        int hintLength = Math.Min(attemptCount, randomWord.Length - 1);
        string hint = randomWord.Substring(0, hintLength) + new string('_', randomWord.Length - hintLength);
        drawing.WriteColoredText($"Wrong! Here's a hint: {hint}", ConsoleColor.Yellow, true);
    }
}

if (!correct)
    drawing.WriteColoredText($"Out of attempts! The word was: {randomWord}", ConsoleColor.Red, true);
    Console.ReadKey();