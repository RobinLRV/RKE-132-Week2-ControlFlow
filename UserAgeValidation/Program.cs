// See https://aka.ms/new-console-template for more information

//rakendus kysib vanust
//kui vanus v2iksem kui 13, siis konsoolis kuvatakse:
//"You're too young to use Instagram"
//muul juhul
//"Welcome to Instagram"

Console.WriteLine("Enter your age");

int userAge = Int32.Parse(Console.ReadLine()); //"13" - heap, 13 - stack

if (userAge >= 13)
{
    Console.WriteLine("Welcome to Instagram");
}
else
{
    Console.WriteLine("You're too young to use Instagram :(");
}



