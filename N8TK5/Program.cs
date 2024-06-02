
string path = @"C:\data\";

string fileName = "chuck.txt";

string[] lines = File.ReadAllLines(path + fileName);



foreach (string hero in lines)

{

    Console.WriteLine(hero);

}