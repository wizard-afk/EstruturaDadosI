using System;
using System.Collections;

class Program
{
    static void Main()
    {
        Hashtable cpfname = new Hashtable();

        Console.WriteLine("Digite uma nova entrada (ou digite 'sair' para sair).");

        while (true)
        {
            Console.Write("Digite o CPF: ");
            string cpf = Console.ReadLine();

            if (cpf.ToLower() == "sair")
            {
                break;
            }

            if (cpfname.ContainsKey(cpf))
            {
                Console.WriteLine("Entrada já existe. Por favor, digite um CPF diferente.");
                continue;
            }

            Console.Write("Digite o Nome: ");
            string nome = Console.ReadLine();

            try
            {
                cpfname.Add(cpf, nome);
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Erro: A entrada já existe.");
            }
        }

        Console.WriteLine("Registros na agenda:");
        if (cpfname.Count == 0)
        {
            Console.WriteLine("Vazio");
        }
        else
        {
            foreach (DictionaryEntry entrada in cpfname)
            {
                Console.WriteLine($" - CPF: {entrada.Key}, Nome: {entrada.Value}");
            }
        }
    }
}