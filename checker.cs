using System;
using System.Diagnostics;

class Checker
{
    static bool IsBatteryOk(float temperature, float soc, float chargeRate)
    {
        if (IsTempOutOfRange(temperature) || IsSOCOutOfRange(soc) || IsChargeRateOutOfRange(chargeRate))
        {
            return false;
        }

        return true;
    }

    static void ExpectTrue(bool expression)
    {
        if (!expression)
        {
            Console.WriteLine("Expected true, but got false");
            Environment.Exit(1);
        }
    }

    static void ExpectFalse(bool expression)
    {
        if (expression)
        {
            Console.WriteLine("Expected false, but got true");
            Environment.Exit(1);
        }
    }

    static bool IsTempOutOfRange(float temperature)
    {
        if (temperature < 0 || temperature > 45)
        {
            Console.WriteLine("Temperature is out of range!");
            return true;
        }

        return false;
    }

    static bool IsSOCOutOfRange(float soc)
    {
        if (soc < 20 || soc > 80)
        {
            Console.WriteLine("State of Charge is out of range!");
            return true;
        }

        return false;
    }

    static bool IsChargeRateOutOfRange(float chargeRate)
    {
        if (chargeRate > 0.8)
        {
            Console.WriteLine("Charge Rate is out of range!");
            return true;
        }

        return false;
    }

    static int Main()
    {
        ExpectTrue(IsBatteryOk(25, 70, 0.7f));
        ExpectFalse(IsBatteryOk(50, 85, 0.0f));
        Console.WriteLine("All ok");
        return 0;
    }
}
