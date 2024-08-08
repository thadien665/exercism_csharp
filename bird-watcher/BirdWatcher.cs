using System;
using System.Linq;
using System.Runtime.CompilerServices;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        int[] counts = { 0, 2, 5, 3, 7, 8, 4 };
        return counts;
    }


    public int Today() => birdsPerDay[6];


    public void IncrementTodaysCount() => birdsPerDay[6]++;


    public bool HasDayWithoutBirds() => birdsPerDay.Contains(0) == true ? true : false;


    public int CountForFirstDays(int numberOfDays)
    {
        int summ = 0;
        for (int i = 0; i < numberOfDays; i++)
        {
            summ += birdsPerDay[i];
        }
        return summ;
    }

    public int BusyDays()
    {
        int counter = 0;
        foreach (int i in birdsPerDay)
        {
            if (i >= 5)
            {
                counter++;
            }
        }
        return counter;
    }
    
}
