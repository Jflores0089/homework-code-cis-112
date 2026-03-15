using static System.Console;
class Hurricane
{
    static void Main()
    {
        WriteLine("What is the Windspeed?");
        float windspeed = Convert.ToSingle(ReadLine());
       
        {
            if (windspeed >= 157)
            {
                WriteLine("This hurricane is category 5");
            }
            else
            {
                if (windspeed < 157 && windspeed >= 130)
                {
                    WriteLine("This hurrican is category 4");
                }
                else
                {
                    if (windspeed < 130 && windspeed >= 111)
                    {
                        WriteLine("This hurricane is category 3");
                    }
                    else
                    {
                        if (windspeed < 111 && windspeed >= 96)
                        {
                            WriteLine("This hurricane is category 2");
                        }
                        else
                        {
                            if (windspeed < 96 && windspeed >= 74)
                            {
                                WriteLine("This hurricane is category 1");
                            }
                            else
                            {
                                if (windspeed < 74)
                                {
                                    WriteLine("This is not a hurricane");
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}