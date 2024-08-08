using System;
using System.Diagnostics;
using System.Linq;

public static class Bob
{
    public static string Response(string statement)
    {

        if (statement.All(char.IsUpper) == true && statement.Contains("?") == true)
        {
            return "Calm down, I know what I'm doing!";
        }
        else if (statement.All(char.IsUpper) == true && statement.Contains("?") == false)
        {
            return "Whoa, chill out!";
        }
        else if (statement.All(char.IsUpper) == false && statement.Contains("?") == true)
        {
            return "Sure.";
        }
        else if (statement.All(char.IsLetterOrDigit) == false || statement.All(char.IsSeparator))
        {
            return "Fine. Be that way!";
        }
        else
        {
            return "Whatever.";
        }
    }   
     

    
    
}