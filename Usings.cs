global using Xunit;
using System.Collections.Generic;

public static class ObfuscationServices
{
    public static string ObfuscateEmail(string emailAddress)
    {   
        // controllo del corretto uso delle @
        if(emailAddress[0] == '@' || emailAddress.Split('@').Length != 2) return "Indirizzo mail non valido"; 

        string userName = emailAddress.Split('@')[0];
        string domain = emailAddress.Split('@')[1];
        // controllo dei numeri di punti dopo la @
        if(domain.Split('.').Length < 2) return "Indirizzo mail non valido"; 

        // example --> e*****e
        userName = string.Join("", userName.ToCharArray().Select(x => '*'));
        if(userName.Length > 4) userName = emailAddress[0] + userName.Substring(1, userName.Length - 2) + emailAddress[userName.Length - 1];
        else userName = emailAddress[0] + userName.Substring(1);

        // gmail.com --> g***l.com
        string tld = domain.Substring(domain.LastIndexOf('.') + 1);
        // controllo della lunghezza del tld
        if(tld.Length < 2) return "Indirizzo mail non valido";
        domain = domain.Remove(domain.Length - tld.Length - 1);
        domain = string.Join("", domain.ToCharArray().Select(x => '*'));
        domain = emailAddress[userName.Length + 1] + domain.Substring(1, domain.Length - 2) + emailAddress[userName.Length + domain.Length];
        
        return userName + '@' + domain + '.' + tld;
    }
}
