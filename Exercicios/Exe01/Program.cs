int[] arr = { 800, 11, 50, 771, 649, 770, 240, 9 };
for(int i = 0; i < arr.Length; i++)
{
    Console.WriteLine( $"arr[{i}] = {arr[i]}" );
}

// -------------
Console.WriteLine("ORDENANDO");

for(int i = 0; i < arr.Length - 1; i++)
{
    for(int j = i + 1; j < arr.Length; j++)
    {
        int aux = arr[j];
        if(arr[i] > arr[j])
        {
            arr[j] = arr[i];
            arr[i] = aux;
        }
    }
}

Console.WriteLine("IMPRIMINDO ORDENADO");
for(int i = 0; i < arr.Length; i++)
    Console.WriteLine( $"arr[{i}] = {arr[i]}" );


// ---------------

int[] arr2 = { 800, 11, 50, 771, 649, 770, 240, 9 };
Console.WriteLine("IMPRIMINDO ORDENADO arr2");
Array.Sort(arr2);
for(int i = 0; i < arr2.Length; i++)
    Console.WriteLine( $"arr2[{i}] = {arr2[i]}" );
















/*
int[] arr = { 800, 11, 50, 771, 649, 770, 240, 9 };

int temp = 0;

for (int write = 0; write < arr.Length; write++) {
    for (int sort = 0; sort < arr.Length - 1; sort++) {
        if (arr[sort] > arr[sort + 1]) {
            temp = arr[sort + 1];
            arr[sort + 1] = arr[sort];
            arr[sort] = temp;
        }
    }
}

for (int i = 0; i < arr.Length; i++)
    Console.Write(arr[i] + " ");

Console.ReadKey();
*/