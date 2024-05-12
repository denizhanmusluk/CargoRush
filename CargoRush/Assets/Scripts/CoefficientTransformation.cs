using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class CoefficientTransformation
{
    public static string Converter(int number)
    {
        int integerPart;
        int decimalPart;
        string result = number.ToString();
       if( number >= 1000)
        {
            integerPart = number / 1000;
            decimalPart = number % 1000;
            if(decimalPart >= 100)
            {
                decimalPart /= 10;
                result = integerPart.ToString() + "." + decimalPart.ToString() + "k";
            }
            else
            {
                decimalPart /= 10;
                result = integerPart.ToString() + ".0" + decimalPart.ToString() + "k";
            }
        }
        return result;
    }

    public static float FormatSaniye(int saniye)
    {
        int saat = saniye / 3600;
        int dakika = (saniye % 3600) / 60;
        int kalanSaniye = saniye % 60;

        int time = saat * 10000 + dakika * 100 + kalanSaniye;
        //string formatliSure = string.Format("{0:D2}:{1:D2}:{2:D2}", saat, dakika, kalanSaniye);
        return time;
    }
}
