using _12_StackUndo;
Console.WriteLine("## Stack II - Undo ##\n");

EditorTexto editor = new();
Console.WriteLine("Digitando...");

editor.DigitarChar('S');
editor.DigitarChar('t');
editor.DigitarChar('a');
editor.DigitarChar('c');
editor.DigitarChar('q');

Console.WriteLine("\nFazendo o Undo...");
editor.Undo();
editor.Undo();

Console.WriteLine("\nRedigitando...");
editor.DigitarChar('c');
editor.DigitarChar('k');
editor.DigitarChar('!');