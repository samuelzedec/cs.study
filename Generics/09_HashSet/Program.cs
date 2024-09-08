Console.WriteLine("## Collection HashSet<T> ##");
HashSet<string> timeSP = new() { "Santos", "Palmeiras", "São Paulo" };
HashSet<string> timeRJ = new() { "Vasco", "Flamengo", "Fluminense" };
HashSet<string> timeBA = new() { "Bahia", "Vitória", "Juazeiro" };
HashSet<string> timeMundiais = new() { "Santos", "Palmeiras", "São Paulo", "Flamengo"};

if (!timeSP.Contains("Corinthians"))
{
    timeSP.Add("Corinthians");
    timeSP.Add("Santos");
}

//Aqui estamos a remover Juazeiro, caso ele exista na HashSet<T>, ele irá remover e retorna true, se não, retornará false
var resultado = timeBA.Remove("Juazeiro");

//Aqui estamos a verificar se todos os elementos de timeSP estão no timeMundiais.
if (timeSP.IsSubsetOf(timeMundiais)) Console.WriteLine("\n- timeSP é um sub conjunto de timesMundiais");

//Aqui estamos a verificar se o timeMundiais contém todos os elementos de timeSP, mesmo que timeMundiais tenha outros elementos q não fazem parte de timeSP.
if (timeMundiais.IsSupersetOf(timeSP)) Console.WriteLine("- timeMundiais é um super conjunto de timeSP");

//Aqui estamos a verificar se há pelo menos 1 elemento do timeRJ no timeMundiais
if (timeRJ.Overlaps(timeMundiais)) Console.WriteLine("- Pelo menos um time do RJ tem título mundial");

//Aqui estamos a verificar se timeSP e timeRJ contém os mesmos elementos independente da ordem
if (!timeSP.SetEquals(timeRJ)) Console.WriteLine("- timeSP e timeRJ não contém os mesmos elementos");

//Aqui estamos a unir duas HashSet<T>, sendo assim, timeSP vai conter os elementos de timeRJ e timeBA
/*timeSP.UnionWith(timeRJ);
timeSP.UnionWith(timeBA);
Console.WriteLine("\n- Times na coleção timeSP:");
ExibirColecao(timeSP);*/

//Ordenando o timeSP com SortedSet<T>
/*Console.WriteLine("\n -Exibindo de forma ordenada pelo SortedSet<T>");
SortedSet<string> todosTimes = new(timeSP);
ExibirColecao(todosTimes);*/

Console.WriteLine("\n- Interseção de dois HashSet<T> : timeSP e timesMundiais");
//Nesse caso ele está a filtrar apenas os elementos que eles têm em comum, então timeSP só ficará com os elementos q tiver em comum com timeMundiais
/*
timeSP.IntersectWith(timeMundiais);
ExibirColecao(timeSP);
*/

Console.WriteLine("\n- Diferença de dois HashSet<T> : timeMundiais e timeSP");
//Nesse caso ele está a filtrar apenas os elementos q não tiver em timeSP, sendo assim, o timeMundiais ficará com apenas os elementos q forem diferentes
/*timeMundiais.ExceptWith(timeSP);
ExibirColecao(timeMundiais);*/
//no caso do ExceptWith ele ira-so filtra os times q timeMundiais tem e timeSP não tem


Console.WriteLine("\n- Diferença de dois HasSet<T> : timesMundiais e timeSP com SymmetricExceptWith");
//Nesse caso, ele filtra a diferença que tem entre os dois, timeMundiasi, irá ficar apenas com elementos q ambos não tiverem
timeMundiais.SymmetricExceptWith(timeSP);
ExibirColecao(timeMundiais);
//no caso do SymmetricExceptWith ele só irá filtrar os times que timeMundiais nao tem de timeSP e os que timeSP não tem q timeMundiais tem

//Limpar é só usar o método clear

//No caso desse método ele se adapta a qualquer tipo de coleção, ele não precisa receber nenhum tipo na sua chamada, porque o compilador puxa da colção passada.
static void ExibirColecao<T>(IEnumerable<T> times)
{
    foreach (var time in times) Console.WriteLine($"    * Time: {time}"); 
}
Console.ReadKey();