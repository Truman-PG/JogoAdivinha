using System;

//Gera um número aleatório
Random aleatorio = new Random();
int numaleatorio = aleatorio.Next(1,100);

//número de tentativas
int tentativas = 3;

//Loop principal
while (tentativas > 0)
{
    //Palpite dado pelo usuário
    Console.WriteLine($"Você tem {tentativas} tentativas");
    Console.WriteLine("Escolha um número entre 1 e 100:");
    int palpite = int.Parse(Console.ReadLine());

    //Desconta as tentativas
    tentativas--;

    //Compara as variáveis
    if (palpite > numaleatorio)
    {
        Console.WriteLine("O número é menor");
    }
    else if (palpite < numaleatorio)
    {
        Console.WriteLine("O número é maior");
    }
    else if (palpite == numaleatorio)
    {
        Console.WriteLine("Parabéns você acertou o número");
        return;
    }

    //Fim de tentativas
    if (tentativas == 0)
    {
        Console.WriteLine($"Suas tentativas acabaram. O número era {numaleatorio}");
        return;
    }
}
