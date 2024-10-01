namespace _12_MetodosDeExtensao;

public static class StringExtensions
{
    //O this quer dizer que estamos referênciando a classe do tipo string, então os tipos string que tiverem using esse namespace, terão acesso a esse método
    public static string Inverting(this string str) 
    {
        char[] charArray = str.ToLower().ToCharArray();
        //^ Nessa linha estamos usando o método .ToCharArray para fazer com a string viré um array de char
        Array.Reverse(charArray);
        //^ Aqui estamos usando a classe Array e seu método para reverte o charArray
        return new string(charArray);
        //^ Aqui está retornando uma instância da classe string e passando seu parâmetro que aceita uma array de Char. 
    }
}