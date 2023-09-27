decimal number = 0;
List<decimal> numbers = new List<decimal>();

try
{

    do
    {
        Console.Clear();
        Console.WriteLine("Informe um número (digite 0 para imprimir o resultado):");

        decimal output = 0;
        string input = Console.ReadLine();

        if (string.IsNullOrWhiteSpace(input) || !decimal.TryParse(input, out output))
            throw new Exception("Número inválido ou não informado.");

        number = Convert.ToDecimal(input);

        if (number < 0)
            throw new Exception("Número deve ser positivo.");

        numbers.Add(number);

    } while (number > 0);

    Console.WriteLine($"Quantos números foram lidos: {numbers.Count}");
    Console.WriteLine($"O maior numero lido: {numbers.Max()}");
    Console.WriteLine($"A média dos números lidos: {numbers.Average()}");
    List<decimal> oddNumbers = numbers.Where(n => n % 2 != 0).ToList();
    Console.WriteLine($"O menor número ímpar lido: {(oddNumbers.Count > 0 ? oddNumbers.Min() : "nenhum número ímpar")}");
    Console.WriteLine($"A quantidade de vezes que cada número ocorreu:");
    var numbersQuantities = numbers.Distinct().Where(n => n > 0).Select(n =>
    {
        int quantity = numbers.Count(c => c == n);
        return $"O número {n} ocorreu {quantity} vez{(quantity > 1 ? "es" : "")}.";
    });
    Console.WriteLine(string.Join("\n", numbersQuantities));
}
catch (Exception ex)
{
    Console.Write($"{ex.Message} O processo será encerrado.");
}