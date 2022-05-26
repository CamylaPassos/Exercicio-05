// See https://aka.ms/new-console-template for more information

int numero1 = 0;
int numero2 = 0;


Console.Write("Digite o primeiro número: ");
numero1 = Convert.ToInt32(Console.ReadLine());


Console.Write("Digite o segundo número: ");
numero2 = Convert.ToInt32(Console.ReadLine());

if(numero1 > numero2)
{
    Console.WriteLine("O número maior é " + numero1);
}
else
{
    Console.WriteLine("O número maior é " + numero2);
}

