namespace _12_StackUndo;

public class EditorTexto
{
    private Stack<char> undoStack = new();
    private string texto = String.Empty;
    public void DigitarChar(char c)
    {
        texto += c;
        undoStack.Push(c);
        Console.WriteLine($"{nameof(texto)}: {texto}");
    }
    public void Undo()
    {
        if (undoStack.Count > 0)
        {
            char ultimoChar = undoStack.Pop();
            texto = texto.Substring(0, texto.Length - 1);
            Console.WriteLine($"{nameof(texto)}: {texto}");
        }
    }
}