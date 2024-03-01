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

string melyikekben = "";
int jatekSzam = 1;
bool kiralynoKill = false;
string feherQueenPozicio = "d1";
string feketeQueenPozicio = "d8";


foreach (string[] jatek in Jatekok)   
{
    feherQueenPozicio = "d1";
    feketeQueenPozicio = "d8";
    kiralynoKill = false;
    for (int i = 0; i < jatek.Length; i++)
    {
        if (jatek[i].Contains('V'))
        {
            if (i % 2 == 1)
                feketeQueenPozicio = $"{jatek[i][jatek[i].Length-2]}{jatek[i][jatek[i].Length-1]}";
            else
                feherQueenPozicio = $"{jatek[i][jatek[i].Length - 2]}{jatek[i][jatek[i].Length - 1]}";
        }

        if (jatek[i].Contains('x') && jatek[i].Contains(feketeQueenPozicio) && i % 2 == 0)
        {
            kiralynoKill = true;
            Console.WriteLine($"fekete: {feketeQueenPozicio}, kiutes:{jatek[i]}");
        }
        if (jatek[i].Contains('x') && jatek[i].Contains(feherQueenPozicio) && i % 2 == 1)
        {
            kiralynoKill = true;
            Console.WriteLine($"feher: {feherQueenPozicio}, kiutes:{jatek[i]}");
        }
            
    }
    if (kiralynoKill)
        melyikekben += $"{jatekSzam};";
    jatekSzam++;
}
Console.WriteLine(melyikekben);

//c. Valasz: 2;4;13;14;18;19;21;




char a = 'b';
Console.WriteLine(((byte)a));




//d.
/*
int vezerekLepeseinekSzama = 0;
string feherQueenPozicio = "d1";
string feketeQueenPozicio = "d8";


foreach (var jatek in Jatekok)
{
    feherQueenPozicio = "d1";
    feketeQueenPozicio = "d8";
    for (int i = 0; i < jatek.Length; i++)
    {
        if (jatek[i].Contains('V'))
        {

            if (i % 2 == 0)
            {
                if (jatek[i][jatek[i].Length - 1] != feketeQueenPozicio[feketeQueenPozicio.Length-1])
                {
                    vezerekLepeseinekSzama += Math.Abs(Convert.ToInt32(feketeQueenPozicio[feketeQueenPozicio.Length - 1]) - Convert.ToInt32(jatek[i][jatek[i].Length - 1]));
                    feketeQueenPozicio = jatek[i];
                }              
            }
            else if (i % 2 == 1)
            {
                if (jatek[i][jatek[i].Length - 1] != feherQueenPozicio[feherQueenPozicio.Length - 1])
                {
                    vezerekLepeseinekSzama += Math.Abs(Convert.ToInt32(feherQueenPozicio[feherQueenPozicio.Length - 1]) - Convert.ToInt32(jatek[i][jatek[i].Length - 1]));
                    feherQueenPozicio = jatek[i];
                }              
            }
        }
    }
}
Console.WriteLine(vezerekLepeseinekSzama);
*/
//d Valasz: 345




//e.
/*
bool volt = false;
int hany = 0;
foreach (var jatek in Jatekok)
{
    volt = false;
    for (int i = 0; i < jatek.Length; i++)
    {
        if (i % 2 != 0 && jatek[i].Contains('K'))
        {
            volt = true;
        }
    }
    if (!volt)
    {
        hany++;
    }
}
Console.WriteLine(hany);
*/
//e Valasz: 10




//f.
/*
int hany20 = 0;
int utesekSzama = 0;
foreach (var jatek in Jatekok)
{
    utesekSzama = 0;
    foreach (var lepes in jatek)
    {
        if (lepes.Contains('x'))
        {
            utesekSzama++;
        }
    }

    if (32- utesekSzama >= 20)
    {
        hany20++;
    }
}
Console.WriteLine(hany20);
*/
//f Valasz: 12