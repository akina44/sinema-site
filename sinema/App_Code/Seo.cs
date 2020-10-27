using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

/// <summary>
/// Summary description for Seo
/// </summary>
public class Seo
{
	public Seo()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public static string Temizle(string Metin)
    {
        string ifade = Metin;
        ifade = ifade.Replace("'", "");
        ifade = ifade.Replace("%", "");
        ifade = ifade.Replace("<", "");
        ifade = ifade.Replace(">", "");
        ifade = ifade.Replace("[", "");
        ifade = ifade.Replace("]", "");
        ifade = ifade.Replace("(", "");
        ifade = ifade.Replace(")", "");
        return ifade;
    }
    public static string urlseo(string Metin)
    {
        string deger = Metin;
        deger = deger.Replace("'", "");
        deger = deger.Replace("+", "");
        deger = deger.Replace(".", "");
        deger = deger.Replace("#", "");
        deger = deger.Replace("[", "");
        deger = deger.Replace(" ", "_");
        deger = deger.Replace("]", "");
        deger = deger.Replace("<", "");
        deger = deger.Replace(">", "");
        deger = deger.Replace("&", "");
        deger = deger.Replace("?", "");
        deger = deger.Replace(",", "");
        deger = deger.Replace("ı", "i");
        deger = deger.Replace("ö", "o");
        deger = deger.Replace("ü", "u");
        deger = deger.Replace("ş", "s");
        deger = deger.Replace("ğ", "g");
        deger = deger.Replace("ç", "c");
        deger = deger.Replace("İ", "i");
        deger = deger.Replace("Ö", "o");
        deger = deger.Replace("Ü", "u");
        deger = deger.Replace("Ş", "s");
        deger = deger.Replace("Ğ", "g");
        deger = deger.Replace("Ç", "c");
        return deger;
    }
    public static string key(string Metin)
    {
        string deger = Metin;
        deger = deger.Replace(" ", " ,");
        return deger;
    }
    public static string OzetCek(string Metin, int Karakter)
    {
        if (Metin.Length >= Karakter)
            Metin = Metin.Substring(0, Karakter);
        return Metin;
    }
}