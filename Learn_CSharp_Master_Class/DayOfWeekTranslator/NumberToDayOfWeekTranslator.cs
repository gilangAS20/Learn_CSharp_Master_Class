﻿namespace DayOfWeekTranslator;

public static class NumberToDayOfWeekTranslator
{
    public static string Translate(int numOfDay)
    {
        return numOfDay switch
        {
            1 => "Monday",
            2 => "Tuesday",
            3 => "Wednesday",
            4 => "Thursday",
            5 => "Friday",
            6 => "Saturday",
            7 => "Sunday",
            _ => "Invalid day of the week"
        };
    }
}