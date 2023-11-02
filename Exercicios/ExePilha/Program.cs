using System;               //conjunto de classes previamente definidas para uso dentro do programa
                            //o nome da classe precisa ter o mesmo nome do arquivo, por organização
namespace StackClass        //namespace equivale a uma biblioteca de ferramentas
{
    public class Stack      //classe é um TAD -> tipo abstrato de dados
    {
        static readonly int MAX = 1000;
        int top = -1;            //topo da pilha no vetor de mil posições
        int[] stack = new int [MAX];

        public bool IsEmpty()      //checa a variavel top                      //() parenteses é função/metodo 
        {
            return(top < 0);
        }

        public bool Push(int data)
        {
            if(top >= MAX)
            {
                Console.WriteLine("Stack Overflow");
                return false;
            }
            top += 1;
            stack[top] = data;
            return true;
        }

        public int Pop()
        {
            if(top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return 0;
            }

            int valor = stack[top];            
            top--;

            return valor;
        }

        public void Peek()
        {
            if(top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }

            Console.WriteLine($"O topo da pilha é: {stack[top]}" );
        }

        public void PrintStack()
        {
            if(top < 0)
            {
                Console.WriteLine("Stack Underflow");
                return;
            }

            Console.WriteLine("Itens da pilha:");
            for(int i = top; i >= 0; i-- )
            {
                string texto = $"Stack[{ stack[i] }]";
                Console.WriteLine(texto);
            }
        }
    }
}
    
