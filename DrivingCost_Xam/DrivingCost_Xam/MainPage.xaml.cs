using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DrivingCost_Xam
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }  
        
        void Button_Clicked(object sender, EventArgs e)
        {
            double Fuel_Price = Convert.ToDouble(EntryFuelPrice.Text);
            double Fuel_Consumption = Convert.ToSingle(EntryFuelConsumption.Text);
            double Route_Length = Convert.ToSingle(EntryRouteLength.Text);

            double Driving_Cost = (Convert.ToSingle(Fuel_Price * Fuel_Consumption) / 100) * Route_Length;

            
            
            lbl_Result.Text = Convert.ToString(Math.Round(Driving_Cost, 2) + " PLN");
            lbl_Result.TextColor = Color.Red;
        }

        void ButtonClicked(object sender, EventArgs e)
        {
            lbl_Result.Text = "Cost";
            lbl_Result.TextColor = Color.Gray;

            EntryFuelPrice.Text = "";
            EntryFuelConsumption.Text = "";
            EntryRouteLength.Text = "";
        }

        private void EntryFuelPrice_TextChanged(object sender, TextChangedEventArgs e)
        {
            //btnCalculate.IsEnabled = false;

            if (EntryFuelPrice.Text.Length > 0)
            {
                btnCalculate.IsEnabled = true;
                btnClear.IsEnabled = true;
            }             
            else
            {
                btnCalculate.IsEnabled = false;
                btnClear.IsEnabled = false;
            }
        }
        private void EntryFuelCons_TextChanged(object sender, TextChangedEventArgs e)
        {
            //btnCalculate.IsEnabled = false;

            if (EntryFuelConsumption.Text.Length > 0)
            {
                btnCalculate.IsEnabled = true;
                btnClear.IsEnabled = true;
            }
            else
            {
                btnCalculate.IsEnabled = false;
                btnClear.IsEnabled = false;
            }
        }
        private void EntryRouteLength_TextChanged(object sender, TextChangedEventArgs e)
        {
            //btnCalculate.IsEnabled = false;

            if (EntryRouteLength.Text.Length > 0)
            {
                btnCalculate.IsEnabled = true;
                btnClear.IsEnabled = true;
            }
            else
            {
                btnCalculate.IsEnabled = false;
                btnClear.IsEnabled = false;
            }

        }
    }
}
