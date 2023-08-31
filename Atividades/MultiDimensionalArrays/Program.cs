int[,] biNumbers = new int[5,2];

int[,,] triNumbers = new int[5,4,3];


int[,,] loadedBiNumbers = new int[,,]
{
    {  { 9,   5 , 15 }, { 9,   5 , 15 }, { 9,   5 , 15 } },
    {  {10, -11 , 15 }, { 9,   5 , 15 }, { 9,   5 , 15 } },
    {  {101,  45 , 8 }, { 9,   5 , 15 }, { 9,   5 , 15 } }
};

for(int i = 0; i < loadedBiNumbers.GetLength(0); i++)
{
    for(int j = 0; j < loadedBiNumbers.GetLength(1); j++)
    {
        for(int z = 0; z < loadedBiNumbers.GetLength(2); z++)
        Console.Write( 
            $"[{loadedBiNumbers[i,j,z]}]" 
        );
    }
    Console.WriteLine("");
}


