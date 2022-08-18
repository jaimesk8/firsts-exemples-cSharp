
int ano; // ou int ano=int.Parse(Console.ReadLine());

Console.Write("Ano para analisar: ");

ano = int.Parse(Console.ReadLine());

if (ano % 4 == 0 && ano % 100 != 0 || ano % 400 == 0)
{
    Console.WriteLine($"O {ano} é bissexto");
}
else
{
    Console.WriteLine("O ano não é bissexto");
}
