using Microsoft.Win32;
using System;


class Program
{
    static void Main()
    {
        // Specify the Registry key and path
        string keyPath = @"HKEY_LOCAL_MACHINE\SOFTWARE\YourSoftware";
        string valueName = "YourValueName";


        try
        {
            // Read the value from the Registry
            string value = Registry.GetValue(keyPath, valueName, null) as string;


            if (value != null)
            {
                Console.WriteLine($"The value of {valueName} is: {value}");
            }
            else
            {
                Console.WriteLine($"Value {valueName} not found in the Registry.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}