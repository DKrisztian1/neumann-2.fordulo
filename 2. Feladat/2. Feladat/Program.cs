using System.IO;
List<string[]> Jatekok = new List<string[]>();

StreamReader sr = new StreamReader("jatszmak.txt");
while (!sr.EndOfStream)
{
    string sor = sr.ReadLine().Trim();
    string[] jatek = sor.Split("\t");
    Jatekok.Add(jatek);
}
sr.Close();


//a.

string nyert = "";
foreach (var jatek in Jatekok)
{
    if (jatek.Length % 2 == 0)
        nyert += "s";
    else
        nyert += "v";
}
Console.WriteLine($"a: { nyert}");

//a. Valasz: vvvsvsvvsvvsvvssvvvvs 



//b.

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
Console.WriteLine($"b: { hanyMezon}");
//b. Valasz: 944



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
                feketeQueenPozicio = $"{jatek[i][jatek[i].Length - 2]}{jatek[i][jatek[i].Length - 1]}";
            else
                feherQueenPozicio = $"{jatek[i][jatek[i].Length - 2]}{jatek[i][jatek[i].Length - 1]}";
        }

        if (jatek[i].Contains('x') && jatek[i].Contains(feketeQueenPozicio) && i % 2 == 0)
        {
            kiralynoKill = true;
        }
        if (jatek[i].Contains('x') && jatek[i].Contains(feherQueenPozicio) && i % 2 == 1)
        {
            kiralynoKill = true;
        }

    }
    if (kiralynoKill)
        melyikekben += $"{jatekSzam};";
    jatekSzam++;
}
Console.WriteLine($"c: { melyikekben}");

//c. Valasz: 2;4;13;14;18;19;21;





//d.

int vezerekLepeseinekSzama = 0;
string feherQueenPoziciod = "d1";
string feketeQueenPoziciod = "d8";


foreach (var jatek in Jatekok)
{
    feherQueenPoziciod = "d1";
    feketeQueenPoziciod = "d8";
    for (int i = 0; i < jatek.Length; i++)
    {
        if (jatek[i].Contains('V'))
        {

            if (i % 2 == 1)
            {
                if (jatek[i][jatek[i].Length - 1] != feketeQueenPoziciod[feketeQueenPoziciod.Length - 1])
                    vezerekLepeseinekSzama += Math.Abs(Convert.ToInt32(feketeQueenPoziciod[feketeQueenPoziciod.Length - 1]) - Convert.ToInt32(jatek[i][jatek[i].Length - 1]));
                else
                    vezerekLepeseinekSzama += Math.Abs((byte)feketeQueenPoziciod[feketeQueenPoziciod.Length - 2] - (byte)jatek[i][jatek[i].Length - 2]);

                feketeQueenPoziciod = jatek[i];
            }
            else if (i % 2 == 0)
            {
                if (jatek[i][jatek[i].Length - 1] != feherQueenPoziciod[feherQueenPoziciod.Length - 1])
                    vezerekLepeseinekSzama += Math.Abs(Convert.ToInt32(feherQueenPoziciod[feherQueenPoziciod.Length - 1]) - Convert.ToInt32(jatek[i][jatek[i].Length - 1]));
                else
                    vezerekLepeseinekSzama += Math.Abs((byte)feherQueenPoziciod[feherQueenPoziciod.Length - 2] - (byte)jatek[i][jatek[i].Length - 2]);

                feherQueenPoziciod = jatek[i];
            }
        }
    }
    Console.WriteLine(vezerekLepeseinekSzama);
}
Console.WriteLine($"d: { vezerekLepeseinekSzama}");

//d Valasz: 293





//e.

bool volt = false;
int hany = 0;
foreach (var jatek in Jatekok)
{
    volt = false;
    for (int i = 0; i < jatek.Length; i++)
    {
        if (i % 2 != 1 && (jatek[i].Contains('K') || jatek[i].Contains("O-O-O") || jatek[i].Contains("O-O")))
        {
            volt = true;
        }
    }
    if (!volt)
    {
        hany++;
    }
}
Console.WriteLine($"e: {hany}");

//e Valasz: 4




//f.

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

    if (32- utesekSzama > 20)
    {
        hany20++;
    }
}
Console.WriteLine($"f: {hany20}");

//f Valasz: 11