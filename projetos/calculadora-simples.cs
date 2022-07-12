decimal a = 0, b = 0, c = 0;
char operador, resp = 's';


Console.WriteLine("Calculadora");
Console.WriteLine();

while (resp == 's')
{
    Console.Write("digite um número: ");
    a = Convert.ToInt32(Console.ReadLine());
    Console.Write("digite um operador: ");
    operador = Console.ReadLine()[0];
    Console.Write("digite outro número: ");
    b = Convert.ToInt32(Console.ReadLine());

    if (operador == '+'){
        c = a + b;
    }
    else if (operador == '-'){
        c = a - b;
    }
    else if (operador == '*'){
        c = a * b;
    }
    else if (operador == '/'){
        c = a / b;
    }

    Console.WriteLine(c);

    Console.Write($"Quer repetir ? 's' para sim ou 'n' para nao:");
    resp = Console.ReadLine()[0];
}