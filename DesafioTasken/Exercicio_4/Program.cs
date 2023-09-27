using System.Text.RegularExpressions;

try
{
	Console.WriteLine("Informe caminho do arquivo .txt:");
	string input = Console.ReadLine();

	if (!File.Exists(input))
		throw new Exception("Arquivo não existente.");

	string[] lines = File.ReadAllLines(input);

	var linesList = lines.Select(l => new 
	{ 
		line = l,
		vowals = Regex.Matches(l, @"[AEIOUaeiou]").Count,
        consonants = l.Count(c => c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z'))
	});

	int maxVowals = linesList.Max(l => l.vowals);
	string? vowalsLine = linesList.FirstOrDefault(l => l.vowals == maxVowals)?.line;

    int maxConsonants = linesList.Max(l => l.consonants);
    string? consonantsLine = linesList.FirstOrDefault(l => l.consonants == maxConsonants)?.line;

	Console.WriteLine("Linha com mais vogais:");
	Console.WriteLine(vowalsLine);

	Console.WriteLine("Linha com mais consoantes:");
	Console.WriteLine(consonantsLine);
}
catch (Exception ex)
{
    Console.Write($"{ex.Message} O processo será encerrado.");
}
