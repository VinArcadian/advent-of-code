using System.IO;

string filePath = "puzzle_input.txt";

string[] instructionArray = File.ReadAllLines(filePath);

int dial = 50;

int zeroCount = 0;

foreach (string instruction in instructionArray)
{
    if (instruction.StartsWith("L"))
    {
        char newDirection = '-';
        string newInstruction = newDirection + instruction.Substring(1);
        int rotation = int.Parse(newInstruction);
        dial += rotation;
        while (dial < 0)
        {
            dial += 100;
        }
        ;
        if (dial == 0)
        {
            zeroCount++;
        }
        continue;
    }
    else if (instruction.StartsWith("R"))
    {
        string newInstruction = instruction.Remove(0, 1);
        int rotation = int.Parse(newInstruction);
        dial += rotation;
        while (dial > 99)
        {
            dial -= 100;
        }
        ;
        if (dial == 0)
        {
            zeroCount++;
        }
        ;
        continue;
    }
    else
    {
        Console.WriteLine("Invalid instruction.");
    }
}

Console.WriteLine($"The dial hit zero {zeroCount} times.");