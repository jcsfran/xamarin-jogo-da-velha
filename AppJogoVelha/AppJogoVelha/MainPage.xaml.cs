using System;
using Xamarin.Forms;

namespace AppJogoVelha
{
    public partial class MainPage : ContentPage
    {
        string vez = "X";

        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            Button btn = (Button)sender;

            btn.IsEnabled = false;
            btn.Text = vez;

            verificarGanhador();
            verificarSeDeuVelha();

            if (vez== "X")
            {
                vez = "O";
            } else
            {
                vez = "X";
            }
            //vez == "X" 
             //   ? vez = "O"
             //   : vez = "X";
        }

        private void verificarSeDeuVelha()
        {
            if (
                (btn10.Text != "") &&
                (btn20.Text != "") &&
                (btn30.Text != "") &&
                (btn11.Text != "") &&
                (btn21.Text != "") &&
                (btn31.Text != "") &&
                (btn12.Text != "") &&
                (btn22.Text != "") &&
                (btn32.Text != "")
                )
            {
                DisplayAlert("Deu Velha", "O jogo irá recomeçar", "OK");
                vez = "X";

                zerar();
            }
        }

        private async void verificarGanhador()
        {
            if (
                (btn10.Text == vez && btn11.Text == vez && btn12.Text == vez) ||
                (btn20.Text == vez && btn21.Text == vez && btn22.Text == vez) ||
                (btn30.Text == vez && btn31.Text == vez && btn32.Text == vez) ||
                (btn10.Text == vez && btn21.Text == vez && btn32.Text == vez) ||
                (btn30.Text == vez && btn21.Text == vez && btn12.Text == vez) ||
                (btn10.Text == vez && btn20.Text == vez && btn30.Text == vez) ||
                (btn11.Text == vez && btn21.Text == vez && btn31.Text == vez) ||
                (btn12.Text == vez && btn22.Text == vez && btn32.Text == vez)
                )
            {
                await DisplayAlert("Parabens", "O " + vez + "ganhou!", "OK");
                vez = "X";

                zerar();
            }
        }

        private void zerar()
        {
            btn10.Text = "";
            btn20.Text = "";
            btn30.Text = "";

            btn11.Text = "";
            btn21.Text = "";
            btn31.Text = "";

            btn12.Text = "";
            btn22.Text = "";
            btn32.Text = "";

            btn10.IsEnabled = true;
            btn20.IsEnabled = true;
            btn30.IsEnabled = true;

            btn11.IsEnabled = true;
            btn21.IsEnabled = true;
            btn31.IsEnabled = true;

            btn12.IsEnabled = true;
            btn22.IsEnabled = true;
            btn32.IsEnabled = true;
        }
    }
}
