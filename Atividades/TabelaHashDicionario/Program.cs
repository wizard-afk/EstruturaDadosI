using System.Collections;

//Criar HashTable
Hashtable openWith = new Hashtable();

openWith.Add("txt", "notepad.exe");
openWith.Add("bmp", "paint.exe");
openWith.Add("dib", "paint.exe");
openWith.Add("rtf", "wordpad.exe");

try
{

    openWith.Add("txt", "notpad++.exe");

}
catch(ArgumentException aex)  //tipo da execeção
{
    Console.WriteLine("Oops. Você tentou adicionar uma chave invalida" );
    Console.WriteLine($"Detalhes:{aex.Message}");
}
catch(Exception)
{
    Console.WriteLine("Erro genérico");
}

//alterando o conteudo da tabela hash
openWith["rtf"] = "winword.exe";
Console.WriteLine(
    "Na \\ chave = \"rtf\" é {0}"
    , openWith["rtf"]
);

//testar se a chave hash existe
if(!openWith.ContainsKey("ht"))
{
    openWith.Add("ht", "hypertrm.exe");
    Console.WriteLine("Chave ht adicionada");
}

// percorrendo hash com foreach
Console.WriteLine();
foreach( DictionaryEntry de in openWith )
{
    Console.WriteLine(
        "Key = {0} - Value = {1}"
        , de.Key
        , de.Value
    );
}

// Obtendo apenas os valores do hash 
ICollection valueCol = openWith.Values;
Console.WriteLine();
foreach(string s in valueCol)
{
    Console.WriteLine("value = {0}", s);
}

//obtendo apena as chaves do hash
ICollection keyCol = openWith.Keys;
Console.WriteLine();
foreach(string s in keyCol)
{
Console.WriteLine("key = {0}", s);
}

//remover registro do hash
Console.WriteLine("removendo (\"doc\")");
openWith.Remove("doc");
if(!openWith.ContainsKey("doc"))
{
    Console.WriteLine("Chave \"doc\" foi removida");
}