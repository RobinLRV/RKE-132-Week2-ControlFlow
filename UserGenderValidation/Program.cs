// See https://aka.ms/new-console-template for more information

//rakendus kysib kasutajalt tema sugu
//kysib perekonnanime
//l2htudes kasutaja valikust, rakendus terivitab kasutajat j2rgmiselt:
//"Welcome, Mr. [perekonnanimi] / "Welcome, Ms. [perekonnanimi]"

Console.WriteLine("Please select your gender (m/f)");
char userGender = Char.Parse(Console.ReadLine()); //loeb konsoolist maha andmeid string (s6ne) formaadis

Console.WriteLine("Please enter your last name");
string userLastName = Console.ReadLine();



if (userGender == 'm')
{
    Console.WriteLine($"Welcome, Mr. {userLastName}!");
}
else if (userGender == 'f')
{
    Console.WriteLine($"Welcome, Ms. {userLastName}!");
}
else
{
    Console.WriteLine($"Welcome {userLastName}!");
}
