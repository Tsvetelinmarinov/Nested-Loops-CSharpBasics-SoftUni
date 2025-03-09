/**
 * 04. Sum Of Two Numbers
 */

//•	Първи ред – начало на интервала – цяло число в интервала [1...999]
//•	Втори ред – край на интервала – цяло число в интервала [по-голямо от първото число...1000]
//•	Трети ред – магическото число – цяло число в интервала [1...10000]

int startingInterval = int.Parse(Console.ReadLine());
int endingInterval = int.Parse(Console.ReadLine());
int targetNumber = int.Parse(Console.ReadLine());
int combinations = 0; //брой на валидните комбинаций

for (int leftNumber = startingInterval; leftNumber <= endingInterval; leftNumber++)
{
    for (int rightNumber = startingInterval; rightNumber <= endingInterval; rightNumber++)
    {
        combinations++;
        if (leftNumber + rightNumber == targetNumber) 
        { 
            Console.WriteLine($"Combination N:{combinations} ({leftNumber} + {rightNumber} = {targetNumber})");
            return; //команда 'return' ще прекрати напълно програмата
        }
    }
}

//•	Ако е намерена комбинация чиито сбор на числата е равен на магическото число
//o	"Combination N:{пореден номер} ({първото число} + {второ число} = {магическото число})"
//•	Ако не е намерена комбинация отговаряща на условието
//o	"{броят на всички комбинации} combinations - neither equals {магическото число}"

Console.WriteLine($"{combinations} combinations - neither equals {targetNumber}");