class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
        {
            return 40;            
        }
    // TODO: define the 'RemainingMinutesInOven()' method

    public int RemainingMinutesInOven(int minutes_in_oven)
        {
            return ExpectedMinutesInOven() - minutes_in_oven;
        }

    // TODO: define the 'PreparationTimeInMinutes()' method

    public int PreparationTimeInMinutes(int number_of_layers)
        {
            return number_of_layers * 2;
        }

    // TODO: define the 'ElapsedTimeInMinutes()' method

    public int ElapsedTimeInMinutes(int numb_of_layers, int mins_in_oven)
        {
            return numb_of_layers * 2 + mins_in_oven;
        }


}
