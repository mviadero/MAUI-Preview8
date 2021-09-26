using Microsoft.Maui;
using Microsoft.Maui.Controls;
using Microsoft.Maui.Essentials;
using System;

namespace MAUI_Preview8.Views
{
    public partial class MainPage : ContentPage
    {
        private int count = 0;
        readonly double[] WindValues = { 98, 84, 140, 92, 55 };
        private Random rand = new Random();

        public MainPage()
        {
            InitializeComponent();
        }

        private void OnCounterClicked(object sender, EventArgs e)
        {
            count++;
            CounterLabel.Text = $"Current count: {count}";

            SemanticScreenReader.Announce(CounterLabel.Text);
        }

        private int GetDirection()
        {
            return rand.Next(0, WindValues.Length - 1);
        }

        private void OnRotarImagen(object sender, EventArgs e)
        {
            var direction = GetDirection();
            LogoPJ.RotateTo(direction,200,Easing.SpringOut);
        }
    }
}
