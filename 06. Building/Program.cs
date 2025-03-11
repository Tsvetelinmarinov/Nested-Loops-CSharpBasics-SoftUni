﻿/**
 * 06. Building
 */

int buildingFloors = int.Parse(Console.ReadLine()); //етажите
int apartmentsPerFloor = int.Parse(Console.ReadLine());//апартаментите на един етаж
int i = buildingFloors; //контролна променлива за външния цикъл
int j = 0; //контролна променлива за вложения цикъл

//•	На всеки четен етаж има само офиси
//•	На всеки нечетен етаж има само апартаменти
//•	Всеки апартамент се означава по следния начин : А{номер на етажа}{ номер на апартамента}, номерата на апартаментите започват от 0.
//•	Всеки офис се означава по следния начин : О{номер на етажа}{ номер на офиса}, номерата на офисите също започват от 0.
//•	На последният етаж винаги има апартаменти и те са по-големи от останалите, за това пред номера им пише 'L', вместо 'А'.
//  Ако има само един етаж, то има само големи апартаменти!

for (; i > 0; i--)
{
    for (; j < apartmentsPerFloor; j++)
    {
        if (i == buildingFloors)
        {
            Console.Write($"L{i}{j} ");
        }
        else if (i % 2 == 0) 
        {
            Console.Write($"O{i}{j} ");
        }
        else if (i % 2 != 0)
        {
            Console.Write($"A{i}{j} ");
        }
        else
        {
            Console.WriteLine("Invalid input!");
            return;
        }
    }

    j = 0; //зануляване на контролната променлива за следващата итерация
    Console.WriteLine(); //раздели етажите
}