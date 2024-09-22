namespace _02_MulticastDelegate;

public class Message<Type>
{
    public static void M1(Type value) => Console.WriteLine($"({nameof(M1)}) - Type: {typeof(Type)} | Value: {value?.ToString()}");
    public static void M2(Type value) => Console.WriteLine($"({nameof(M2)}) - Type: {typeof(Type)} | Value: {value?.ToString()}");
    public static void M3(Type value) => Console.WriteLine($"({nameof(M3)}) - Type: {typeof(Type)} | Value: {value?.ToString()}");
}