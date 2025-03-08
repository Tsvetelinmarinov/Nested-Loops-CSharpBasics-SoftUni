/**
 * 02. Multiplication Table
 */

//Отпечатайте на конзолата таблицата за умножение за числата от 1 до 10 във формат: 
//"{първи множител} * {втори множител} = {резултат}".

int leftNumber = 1, rightNumber = 1; // множителите (ляв и десен)

for (; leftNumber <= 10; leftNumber++)
{
    for (; rightNumber <= 10; rightNumber++)
    {
        Console.WriteLine($"{leftNumber} * {rightNumber} = {leftNumber * rightNumber}");
    }
    rightNumber = 1; //зануляване на дясната променлива за да може следващата итерация да започне с 0
}