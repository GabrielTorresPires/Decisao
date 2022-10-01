int n1, n2;

Console.WriteLine ("Divisão de dois números: ");

Console.Write ("Digite o primeiro número: ");
n1 = Convert.ToInt32(Console.ReadLine());

Console.Write ("Digite o segundo número: ");
n2 = Convert.ToInt32(Console.ReadLine());

if (n2==0)
{

Console.WriteLine ("Por favor digite um número maior que 0");

}

else 

{

double resultado = n1 / n2 ;


Console.WriteLine ($"{n1} dividido por {n2} é igual a {resultado}");

}


