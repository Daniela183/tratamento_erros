//aula 171
Console.WriteLine("Bloco Try - Catch - Finally");

try
{
    Console.Write("\nInforme o dividendo: ");
    int dividendo = Convert.ToInt32(Console.ReadLine());

    Console.Write("\nInforme o divisor: ");
    int divisor = Convert.ToInt32(Console.ReadLine());

    int resultado = (dividendo / divisor);
    Console.WriteLine($"\n{dividendo} / {divisor} = {resultado}\n");

    Console.ReadKey();
}
catch (FormatException)
{
    Console.Write($"\nInforme um valor inteiro!");
}
catch (OverflowException)
{
    Console.WriteLine("\nInforme um valor inteiro entre 1 e 999999");
}
catch (DivideByZeroException)
{
    Console.WriteLine("\nNão existe divisão por zero, tente novamente!");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.ReadKey();
