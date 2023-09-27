using Exercicio_1;

try
{
    Console.WriteLine("Informe um número:");

    string input = Console.ReadLine();
    int output = 0;

    if (string.IsNullOrWhiteSpace(input))
        throw new Exception($"Número deve ser maior que zero.");
    else if (!int.TryParse(input, out output))
        throw new Exception($"Número deve ser maior que zero.");

    int times = Convert.ToInt32(input);

    if (times <= 0)
        throw new Exception($"Número deve ser maior que zero.");

    PowSequence powSequence = new PowSequence(times);
    List<int[]> sequenceList = powSequence.Get();
    foreach (var sequence in sequenceList)
    {
        Console.WriteLine(string.Join(" ", sequence));
    }
}
catch (Exception ex)
{
    Console.Write($"{ex.Message} O processo será encerrado.");
}
