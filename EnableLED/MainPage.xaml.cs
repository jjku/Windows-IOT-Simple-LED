using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using AccessGPIO;  // You need this reference to AccessGPIO on the right because I created a class


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace EnableLED
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        SetGPIOHigh GPIO; // Sets a variable GPIO to be used further down

        public MainPage()
        {
            this.InitializeComponent();
            GPIO = new SetGPIOHigh(); //Instantiates the class
            GPIO.GPIO(4); // This calls the class in AccessGPIO called GPIO to initialize the pin
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //This class is waiting for a button click
            if (GPIO.GPIOLow(4) == true)
            {
                tb_what_is_happening.Text = "You clicked on Litt up"; // This simply changes the text box to read this when the button is clicked.
            }
            
        }

        private void btn_2_Click(object sender, RoutedEventArgs e)
        {
            //This class is waiting for a button click
            if (GPIO.GPIOHigh(4)==true)
            {
                tb_what_is_happening.Text = "You clicked on off"; // This simply changes the text box to read this when the button is clicked.
            }
        }
    }
}
