using System.IO;
List<string[]> Jatekok = new List<string[]>();

StreamReader sr = new StreamReader("jatszmak.txt");
while (!sr.EndOfStream)
{
    string[] jatek = sr.ReadLine().Split("\t"); ;   
    Jatekok.Add(jatek);
}
sr.Close();


//a.
/*
string nyert = "";
foreach (var jatek in Jatekok)
{
    if (jatek.Length % 2 == 0)
        nyert += "s";
    else
        nyert += "v";
}
Console.WriteLine(nyert);
*/
//a. Valasz: vvvvvvvvvvvvvvvvvvvvv



//b.
/*
int hanyMezon = 0;
foreach (string[] jatek in Jatekok)
{
    foreach (string lepes in jatek)
    {
        if (lepes.Contains('H'))
        {
            if (lepes.IndexOf('H') < lepes.IndexOf('x') || !lepes.Contains('x'))
                hanyMezon += 4;
        }       
    }
}
Console.WriteLine(hanyMezon);
//b. Valasz: 944
*/



//c
/*
string melyikekben = "";
int jatekSzam = 1;
bool kiralynoKill = false;

string? feherQueenPozicio = null;
string? feketeQueenPozicio = null;

foreach (string[] jatek in Jatekok)   
{
    kiralynoKill = false;
    for (int i = 0; i < jatek.Length; i++)
    {
        if (jatek[i].Contains('V'))
        {
            jatek[i].Replace("V", "");
            jatek[i].Replace("x", "");
            if (i % 2 == 0)
                feketeQueenPozicio = jatek[i];
            else
                feherQueenPozicio = jatek[i];
        }

        if (jatek[i].Contains('x') && feketeQueenPozicio != null && jatek[i].Contains(feketeQueenPozicio))
            kiralynoKill = true;
        if (jatek[i].Contains('x') && feherQueenPozicio != null && jatek[i].Contains(feherQueenPozicio))
            kiralynoKill = true;
    }
    if (kiralynoKill)
        melyikekben += $"{jatekSzam};";
    jatekSzam++;
}
Console.WriteLine(melyikekben);
*/
//c. Valasz: 1;2;3;4;5;7;8;9;10;11;13;14;16;18;19;20;21;