using System;
using System;

public class TempratureChangeEventArgs : EventArgs
{

    public double NewTempature { get; }
    public double OldTempature { get; }
    public double Diffrence { get; }

    public TempratureChangeEventArgs(double OldTempature, double NewTempature)
    {
        this.OldTempature = OldTempature;
        this.NewTempature = NewTempature;
        Diffrence = NewTempature - OldTempature;

    }




}


public class Thermostat
{
    public EventHandler<TempratureChangeEventArgs> ThermostatChanged;

    public double CurrentTemprature;
    public double OldTemprature;

    public void SetTemprature(double NewTemprature)
    {
        if (NewTemprature != CurrentTemprature)
        {
            OldTemprature = CurrentTemprature;
            CurrentTemprature = NewTemprature;
            OnTempratureChange(OldTemprature, CurrentTemprature);
        }


    }

    private void OnTempratureChange(double OldTemprature, double CurrentTemprature)
    {

        OnTempratureChange(new TempratureChangeEventArgs(OldTemprature, CurrentTemprature));
    }

    protected virtual void OnTempratureChange(TempratureChangeEventArgs e)
    {
        ThermostatChanged.Invoke(this, e);

    }
    public class Display
    {

        public void Subscribe(Thermostat thermostat)
        {

            thermostat.ThermostatChanged += HandleTemperatureChange;

        }

        public void HandleTemperatureChange(object Sender, TempratureChangeEventArgs e)
        {

            Console.WriteLine("\n\nTemperature changed:");
            Console.WriteLine($"Temperature changed from {e.OldTempature}°C");
            Console.WriteLine($"Temperature changed to {e.NewTempature}°C");
            Console.WriteLine($"Temperature Differance to {e.Diffrence}°C");

        }


    }

    public class Program
    {
        static void Main()
        {
            Thermostat thermostat = new Thermostat();
            Display display = new Display();

            display.Subscribe(thermostat);

            thermostat.SetTemprature(25);
            thermostat.SetTemprature(30);
            thermostat.SetTemprature(30);
            thermostat.SetTemprature(30);
            thermostat.SetTemprature(30);
            thermostat.SetTemprature(30);
            thermostat.SetTemprature(30);

            Console.ReadLine();

        }
    }

}