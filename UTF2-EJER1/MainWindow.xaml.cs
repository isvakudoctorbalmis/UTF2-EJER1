using System;

using System.Windows;


namespace UTF2_EJER1
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int numeroaleatorio;
        public MainWindow()
        {
            var seed = Environment.TickCount;
            var random = new Random(seed);

            var value = random.Next(0, 101);
            numeroaleatorio = value;
            InitializeComponent();
        }

    
        private void comprobarBoton_Click(object sender, RoutedEventArgs e)
        {
            int numero = int.Parse(numeroTextBox.Text);
            if (numeroaleatorio == numero)
             alertaTextBlock.Text = "ACERTASTE WEY!!!!"; 
            else if(numeroaleatorio>numero)
             alertaTextBlock.Text = "El numero buscado es mas alto WEY"; 
            else
                alertaTextBlock.Text = "El numero buscado es mas bajo WEY";
        }

        private void resetearButton_Click(object sender, RoutedEventArgs e)
        {
            var seed = Environment.TickCount;
            var random = new Random(seed);

            var value = random.Next(0, 101);
            numeroaleatorio = value;
            alertaTextBlock.Text = "";
            numeroTextBox.Text = "";
        }
    }
}
