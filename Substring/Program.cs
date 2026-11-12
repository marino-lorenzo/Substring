string s, sS = "";
int p, l;
Console.WriteLine("Inserire la stringa");
s = Console.ReadLine();

do
{
    Console.WriteLine("Inserire la posizione di partenza");
    p = Convert.ToInt16(Console.ReadLine());
    if (p < 0 || p > (s.Length - 1))
    {
        Console.WriteLine("Posizione invalida, riprovare");
    }
} while (p < 0 || p > (s.Length - 1));

do
{
    Console.WriteLine("Inserire la lunghezza");
    l = Convert.ToInt16(Console.ReadLine());
    if (l < 1 || l > (s.Length - p))
    {
        Console.WriteLine("Lunghezza invalida, riprovare");
    }
} while (l < 1 || l > (s.Length - p));

for(int i = p; i < (l + p); i++)
{
    char c = s[i];
    sS += c;
}

Console.WriteLine(sS);


