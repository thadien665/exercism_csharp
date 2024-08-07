using System;

public static class ResistorColorDuo
{
    public static int Value(string[] colors)
    {
        string[] list = { "black", "brown", "red", "orange", "yellow", "green", "blue", "violet", "grey", "white" };

        int sign1 = Array.IndexOf(list, colors[0]);
        int sign2 = Array.IndexOf(list, colors[1]);

        string result = sign1.ToString() + sign2.ToString();

        return int .Parse(result);


    }
}
