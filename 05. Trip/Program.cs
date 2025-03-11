/**
 * 05. Trip
 */

string destination = Console.ReadLine(); //дестинацията
double targetBudget = double.Parse(Console.ReadLine()); //необходимите пари за пътуване
double savedMoney = 0.0; //натрупалите се пари

while (destination != "End")
{
    while (savedMoney <= targetBudget)
    {
        savedMoney += double.Parse(Console.ReadLine()); 
    }

    Console.WriteLine($"Going to {destination}!");
    savedMoney = 0.0; //Занъляване на спестените пари за следващата дестинация

    destination = Console.ReadLine();

    if (destination == "End")
    {
        return;
    }

    targetBudget = double.Parse(Console.ReadLine());
}