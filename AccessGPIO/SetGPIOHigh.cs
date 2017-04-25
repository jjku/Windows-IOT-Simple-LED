using Windows.Devices.Gpio;

namespace AccessGPIO
{
    public class SetGPIOHigh
    {

        GpioController gpio;
        GpioPin pin;

        public void GPIO(int _pinID)
        {
            gpio = GpioController.GetDefault();
            if (gpio == null)
            {
                return; // GPIO not available on this system, this will prevent an exception
            }
            
            pin = gpio.OpenPin(_pinID); // I believe this initializes the GPIO pin by ID# so that C# can use the pin
            pin.Write(GpioPinValue.High); // Latch HIGH value first. This ensures a default value when the pin is set as output
            pin.SetDriveMode(GpioPinDriveMode.Output); // Set the IO direction as output as opposed to input
        }

        public bool GPIOLow(int _pinID)
        {
            pin.Write(GpioPinValue.Low); //This turns on the light by setting the Pin to low
            return true;
        }

        public bool GPIOHigh(int _pinID)
        {
            pin.Write(GpioPinValue.High); //This turns off the light by setting the Pin to high
            return true;
        }
                


    }
}
