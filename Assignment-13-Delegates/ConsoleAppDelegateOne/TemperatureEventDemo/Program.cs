using System;

namespace TemperatureEventDemo
{
    // Step 1: Define delegate for the event
    public delegate void TemperatureHandler(string message);

    // Step 2: Create TemperatureMonitor class
    public class TemperatureMonitor
    {
        private int _temperature;

        // Event declaration
        public event TemperatureHandler CriticalTemperature;

        // Property to get/set temperature
        public int Temperature
        {
            get { return _temperature; }
            set
            {
                _temperature = value;
                Console.WriteLine($"Temperature set to: {_temperature}°C");

                // Step 3: Raise event if condition met
                if (_temperature > 100 || _temperature < 0)
                {
                    OnCriticalTemperature("Critical temperature reached!");
                }
            }
        }

        // Step 4: Method to raise event
        protected virtual void OnCriticalTemperature(string message)
        {
            if (CriticalTemperature != null)
            {
                CriticalTemperature.Invoke(message);
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Step 5: Create object
            TemperatureMonitor monitor = new TemperatureMonitor();

            // Step 6: Subscribe to event
            monitor.CriticalTemperature += msg => Console.WriteLine("ALERT: " + msg);

            // Step 7: Simulate temperature changes
            monitor.Temperature = 25;
            monitor.Temperature = 105; // Triggers event
            monitor.Temperature = -5;  // Triggers event
            monitor.Temperature = 80;  // Safe
        }
    }
}