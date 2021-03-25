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
}