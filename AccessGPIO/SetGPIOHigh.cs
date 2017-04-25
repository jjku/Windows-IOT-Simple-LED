using Windows.Devices.Gpio;

namespace AccessGPIO
{
    public class SetGPIOHigh
    {

        GpioController gpio;

        public void GPIO(int _pinID)
        {
            gpio = GpioController.GetDefault();
            if (gpio == null)
                return; // GPIO not available on this system

            // int _pinIDint = int.Parse(_pinID.ToString());

            using (GpioPin pin = gpio.OpenPin(_pinID))
            {
                // Latch HIGH value first. This ensures a default value when the pin is set as output
                pin.Write(GpioPinValue.High);

                // Set the IO direction as output
                pin.SetDriveMode(GpioPinDriveMode.Output);
            } // Close pin - will revert to its power-on state

            
        }

        public void GPIOLow(int _pinID)
        {

            GpioPin pin = gpio.OpenPin(_pinID);
            pin.Write(GpioPinValue.Low);
            pin.SetDriveMode(GpioPinDriveMode.Output);

        }



    }
}
