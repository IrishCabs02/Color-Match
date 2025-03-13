using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ColorMatch
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class colormatch : ContentPage
    {
        private readonly Color[] colorSequence = {
            Color.Coral,
            Color.LavenderBlush,
            Color.Red,
            Color.Navy,
            Color.Brown,
            Color.Turquoise,
            Color.PaleVioletRed,
            Color.DarkGray,
            Color.PeachPuff
        };
        private int currentIndex = 0;
        private List<Button> ListButton;
        public colormatch()
        {
            InitializeComponent();
            ListButton = new List<Button> { button8, button5, button3, button4, button1, button6, button7, button9, button2 };
            ResetButton();
        }

       private void OnButtonClicked(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if(ListButton.IndexOf(button) == currentIndex)
            {
                button.BackgroundColor = colorSequence[currentIndex];
                currentIndex++;

                if(currentIndex == colorSequence.Length)
                {
                    DisplayAlert("🎉CONGRATULATIONS!!!🎉🎉", "YOU MATCHED THE COLOR SEQUENCE!🥳", "Ok");

                 ResetButton();
                }
            }
            else
            {
                ResetButton();
            }
        }

        private void ResetButton()
        {
            currentIndex = 0;
            foreach(Button button in ListButton)
            {
                button.BackgroundColor = Color.Maroon;
            }
        }
    }
}