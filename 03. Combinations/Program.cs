/**
 * 03. Combinations
 */

int targetNumber = int.Parse(Console.ReadLine()); //Целевото число
int validMatches = 0; //валидните комбинаций

for (int i = 0; i <= targetNumber; i++)
{
	for (int j = 0; j <= targetNumber; j++)
	{
		for (int k = 0; k <= targetNumber; k++)
		{
			if (i + j + k == targetNumber) { validMatches++; }
		}
	}
}

Console.WriteLine(validMatches);