using ElephantCarpaccio;
using System;
using System.Collections.Generic;

public abstract class CodePays
{
    public enum Code
    {
        fr,
        en,
        gb,
        us
    }

    private static List<float> tva = new List<float>() { 20, 15.5f, 10, 30 };

    public static Code current = Code.fr;

    public static float GetTVA(Code pays)
    {
        return tva[(int)pays];
    }

    public static void Display()
    {
        string colCodePays = Formatter.FormatString("Code Pays");
        string colTauxTva = Formatter.FormatString("Taux TVA");
        string inter = " --- ";

        Console.WriteLine(colCodePays + inter + colTauxTva + inter);

        int i = 0;
        foreach (String str in Enum.GetNames(typeof(Code)))
        {
            Console.WriteLine(str.PadRight(15) + tva[i]);
            i++;
        }
    }
}