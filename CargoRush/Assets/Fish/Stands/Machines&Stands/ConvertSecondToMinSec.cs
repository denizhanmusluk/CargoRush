using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ConvertSecondToMinSec
{
    public static string Converter(int second)
    {
        string minSecValue;
        int countdownValue = second;
        int minute = Mathf.FloorToInt(countdownValue / 60);
        int _second = Mathf.FloorToInt(countdownValue % 60);



        minSecValue = minute.ToString() + ":" + ($"{_second}");
        if (minute < 10)
        {
            minSecValue = "0" + minute.ToString() + ":" + ($"{_second}");
        }

        if (_second < 10)
        {
            minSecValue = minute.ToString() + ":0" + ($"{_second}");
            if (minute < 10)
            {
                minSecValue = "0" + minute.ToString() + ":0" + ($"{_second}");

            }

            if (countdownValue <= 0)
            {
                minSecValue = "00:00";
            }

        }

        return minSecValue;
    }


    public static string ConverterMinAndHour(int minute)
    {
        string minSecValue;
        int countdownValue = minute;
        int hour = Mathf.FloorToInt(countdownValue / 60);
        int _minute = Mathf.FloorToInt(countdownValue % 60);



        minSecValue = hour.ToString() + "h " + ($"{_minute}m");
        if (hour < 10)
        {
            minSecValue = "0" + hour.ToString() + "h " + ($"{_minute}m");
        }

        if (_minute < 10)
        {
            minSecValue = hour.ToString() + "h 0" + ($"{_minute}m");
            if (hour < 10)
            {
                minSecValue = "0" + hour.ToString() + "h 0" + ($"{_minute}m");

            }

            if (countdownValue <= 0)
            {
                minSecValue = "00h 00m";
            }

        }

        return minSecValue;
    }
}
