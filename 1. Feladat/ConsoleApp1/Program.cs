using System;
using System.Linq;

//a.
/*
string jelen = "1";
for (int i = 0; i < 20; i++)
{
    string ujSzam = "";
    foreach (char s in jelen)
    {
        ujSzam += char.GetNumericValue(s)*2;
    }
    jelen = ujSzam;   
}
Console.WriteLine(jelen);
*/
//a válasz: 1681684816816848424848168168481681684842484842421242484842484816816848168168484248481681684816816


//b
/*
int legkisebb = -1;
for (int i = 1; i < 100; i++)
{
    string jelen = Convert.ToString(i);
    for (int x = 0; x < 30; x++)
    {
        string ujSzam = "";
        foreach (char s in jelen)
        {
            ujSzam += char.GetNumericValue(s) * 2;
        }
        jelen = ujSzam;
        if (jelen.EndsWith("216816212162121681684816816"))
        {
            legkisebb = i;
            break;
        }
    }
    if (legkisebb != -1)
        break;
}
Console.WriteLine(legkisebb);
*/
//b válasz : 21




//c.
/*
string jelenlegi = "11";

for (int i = 0; i < 31; i++)
{
    string uj = "";
    double osszegAvegere = 0;

    foreach (char s in jelenlegi)
    {
        osszegAvegere += char.GetNumericValue(s);
    }
    uj = $"{jelenlegi}{osszegAvegere}";
    jelenlegi = uj;
}
Console.WriteLine(jelenlegi);
*/
//c válasz: 11248162328384962707791101103107115122127137148161169185199218229242250257271281