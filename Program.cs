Console.Write("Tabuada do número:");
int N= Convert.ToInt16(Console.ReadLine());

Console.WriteLine();

int M = 0;
int produto;

while(M <= 10)
{
    produto = N*M;
    Console.WriteLine($"{N}x{M} = {produto}");
    M += 1;
}
