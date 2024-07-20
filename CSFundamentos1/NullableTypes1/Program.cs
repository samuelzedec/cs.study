Console.WriteLine("## Nullable Types ##");

int? valor = 9;
int a = valor ?? 10;


int? b = null;
if(b.HasValue) {
  Console.WriteLine($"b = {b.Value}");
} else {
  Console.WriteLine("O valor de  B é nulo (null)");
}

Console.WriteLine(a);
Console.ReadLine();
