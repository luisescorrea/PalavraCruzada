using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PalavraCruzada
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        bool Palavra1 = false;
        bool Palavra2 = false;
        bool Palavra3 = false;
        bool Palavra4 = false;
        bool Palavra5 = false;
        bool Palavra6 = false;
        bool Palavra7 = false;
        bool Palavra8 = false;
        bool Palavra9 = false;
        bool Palavra10 = false;
        bool vitoria = false;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Dica1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Comida favorita dos ratos nos desenhos.", "Dica:");//QUEIJO
        }

        private void Dica2(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Casa de Deus.", "Dica:"); //IGREJA
        }

        private void Dica3(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Entrega notícia no dia a dia.", "Dica:"); //JORNAL
        }

        private void Dica4(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Truco, Uno, Poker, BlackJack(21).", "Dica:");//CARTA
        }

        private void Dica5(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Doce no palito.", "Dica:");//PIRULITO
        }

        private void Dica6(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("[Cala boca] Jovem!! em inglês.", "Dica:");//XAROPE
        }

        private void Dica7(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Quem tem boca vaia ____.", "Dica:");//ROMA
        }

        private void Dica8(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Não é camisa.", "Dica:");//CAMISETA
        }

        private void Dica9(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Forma geométrica mágica.", "Dica:");//CUBO
        }

        private void Dica10(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Dispositivo sonoro portátil.", "Dica:");//FONE
        }

        private void VerificarP1(object sender, KeyEventArgs e)
        {
            Palavra1Correta();
            Palavra2Correta();
            Palavra3Correta();

            VerificarVitoria();
        }

        private void VerificarP2(object sender, KeyEventArgs e)
        {
            Palavra2Correta();
            
            VerificarVitoria();
        }

        private void VerificarP3(object sender, KeyEventArgs e)
        {
            Palavra3Correta();
            Palavra7Correta();

            VerificarVitoria();
        }

        private void VerificarP4(object sender, KeyEventArgs e)
        {
            Palavra4Correta();
            Palavra7Correta();
            Palavra9Correta();
            Palavra8Correta();

            VerificarVitoria();
        }

        private void VerificarP5(object sender, KeyEventArgs e)
        {
            Palavra5Correta();
            Palavra8Correta();
            Palavra10Correta();

            VerificarVitoria();
        }

        private void VerificarP6(object sender, KeyEventArgs e)
        {
            Palavra6Correta();
            Palavra8Correta();

            VerificarVitoria();
        }

        private void VerificarP7(object sender, KeyEventArgs e)
        {
            Palavra7Correta();

            VerificarVitoria();
        }

        private void VerificarP8(object sender, KeyEventArgs e)
        {
            Palavra8Correta();

            VerificarVitoria();
        }

        private void VerificarP9(object sender, KeyEventArgs e)
        {
            Palavra9Correta();

            VerificarVitoria();
        }

        private void VerificarP10(object sender, KeyEventArgs e)
        {
            Palavra10Correta();

            VerificarVitoria();
        }

        //Verificar se as palavras estão corretas---------------------------------------------------------------------------------------------------------------------------------------------------------
        //Verificar se as palavras estão corretas---------------------------------------------------------------------------------------------------------------------------------------------------------
        private void Palavra1Correta()
        {
            if (C1_1.Text.ToUpper() == "Q" && C1_2.Text.ToUpper() == "U" && C1_3.Text.ToUpper() == "E" && C1_4.Text.ToUpper() == "I" && C1_5.Text.ToUpper() == "J" && C1_6.Text.ToUpper() == "O" && Palavra1 == false)
            {
                C1_1.Background = Brushes.LightGreen;
                C1_2.Background = Brushes.LightGreen;
                C1_3.Background = Brushes.LightGreen;
                C1_4.Background = Brushes.LightGreen;
                C1_5.Background = Brushes.LightGreen;
                C1_6.Background = Brushes.LightGreen;
                C1_1.IsReadOnly = true;
                C1_2.IsReadOnly = true;
                C1_3.IsReadOnly = true;
                C1_4.IsReadOnly = true;
                C1_5.IsReadOnly = true;
                C1_6.IsReadOnly = true;
                MessageBoxResult result = MessageBox.Show("PALAVRA 1 COMPLETA", "Parabéns:");
                Palavra1 = true;
            }
        }

        private void Palavra2Correta()
        {
            if (C1_4.Text.ToUpper() == "I" && C2_2.Text.ToUpper() == "G" && C2_3.Text.ToUpper() == "R" && C2_4.Text.ToUpper() == "E" && C2_5.Text.ToUpper() == "J" && C2_6.Text.ToUpper() == "A" && Palavra2 == false)
            {
                C1_4.Background = Brushes.LightGreen;
                C2_2.Background = Brushes.LightGreen;
                C2_3.Background = Brushes.LightGreen;
                C2_4.Background = Brushes.LightGreen;
                C2_5.Background = Brushes.LightGreen;
                C2_6.Background = Brushes.LightGreen;
                C1_4.IsReadOnly = true;
                C2_2.IsReadOnly = true;
                C2_3.IsReadOnly = true;
                C2_4.IsReadOnly = true;
                C2_5.IsReadOnly = true;
                C2_6.IsReadOnly = true;
                MessageBoxResult result = MessageBox.Show("PALAVRA 2 COMPLETA", "Parabéns:");
                Palavra2 = true;
            }
        }

        private void Palavra3Correta()
        {
            if (C3_1.Text.ToUpper() == "J" && C1_6.Text.ToUpper() == "O" && C3_2.Text.ToUpper() == "R" && C3_3.Text.ToUpper() == "N" && C3_4.Text.ToUpper() == "A" && C3_5.Text.ToUpper() == "L" && Palavra3 == false)
            {
                C3_1.Background = Brushes.LightGreen;
                C1_6.Background = Brushes.LightGreen;
                C3_2.Background = Brushes.LightGreen;
                C3_3.Background = Brushes.LightGreen;
                C3_4.Background = Brushes.LightGreen;
                C3_5.Background = Brushes.LightGreen;
                C3_1.IsReadOnly = true;
                C1_6.IsReadOnly = true;
                C3_2.IsReadOnly = true;
                C3_3.IsReadOnly = true;
                C3_4.IsReadOnly = true;
                C3_5.IsReadOnly = true;
                MessageBoxResult result = MessageBox.Show("PALAVRA 3 COMPLETA", "Parabéns:");
                Palavra3 = true;
            }
        }

        private void Palavra4Correta()
        {
            if (C4_1.Text.ToUpper() == "C" && C4_2.Text.ToUpper() == "A" && C4_3.Text.ToUpper() == "R" && C4_4.Text.ToUpper() == "T" && C4_5.Text.ToUpper() == "A" && Palavra4 == false)
            {
                C4_1.Background = Brushes.LightGreen;
                C4_2.Background = Brushes.LightGreen;
                C4_3.Background = Brushes.LightGreen;
                C4_4.Background = Brushes.LightGreen;
                C4_5.Background = Brushes.LightGreen;
                C4_1.IsReadOnly = true;
                C4_2.IsReadOnly = true;
                C4_3.IsReadOnly = true;
                C4_4.IsReadOnly = true;
                C4_5.IsReadOnly = true;
                MessageBoxResult result = MessageBox.Show("PALAVRA 4 COMPLETA", "Parabéns:");
                Palavra4 = true;
            }
        }

        private void Palavra5Correta()
        {
            if (C5_1.Text.ToUpper() == "P" && C5_2.Text.ToUpper() == "I" && C5_3.Text.ToUpper() == "R" && C5_4.Text.ToUpper() == "U" && C5_5.Text.ToUpper() == "L" && C5_6.Text.ToUpper() == "I" && C5_7.Text.ToUpper() == "T" && C5_8.Text.ToUpper() == "O" && Palavra5 == false)
            {
                C5_1.Background = Brushes.LightGreen;
                C5_2.Background = Brushes.LightGreen;
                C5_3.Background = Brushes.LightGreen;
                C5_4.Background = Brushes.LightGreen;
                C5_5.Background = Brushes.LightGreen;
                C5_6.Background = Brushes.LightGreen;
                C5_7.Background = Brushes.LightGreen;
                C5_8.Background = Brushes.LightGreen;
                C5_1.IsReadOnly = true;
                C5_2.IsReadOnly = true;
                C5_3.IsReadOnly = true;
                C5_4.IsReadOnly = true;
                C5_5.IsReadOnly = true;
                C5_6.IsReadOnly = true;
                C5_7.IsReadOnly = true;
                C5_8.IsReadOnly = true;
                MessageBoxResult result = MessageBox.Show("PALAVRA 5 COMPLETA", "Parabéns:");
                Palavra5 = true;
            }
        }

        private void Palavra6Correta()
        {
            if (C6_1.Text.ToUpper() == "X" && C6_2.Text.ToUpper() == "A" && C6_3.Text.ToUpper() == "R" && C6_4.Text.ToUpper() == "O" && C6_5.Text.ToUpper() == "P" && C6_6.Text.ToUpper() == "E" && Palavra6 == false)
            {
                C6_1.Background = Brushes.LightGreen;
                C6_2.Background = Brushes.LightGreen;
                C6_3.Background = Brushes.LightGreen;
                C6_4.Background = Brushes.LightGreen;
                C6_5.Background = Brushes.LightGreen;
                C6_6.Background = Brushes.LightGreen;
                C6_1.IsReadOnly = true;
                C6_2.IsReadOnly = true;
                C6_3.IsReadOnly = true;
                C6_4.IsReadOnly = true;
                C6_5.IsReadOnly = true;
                C6_6.IsReadOnly = true;
                MessageBoxResult result = MessageBox.Show("PALAVRA 6 COMPLETA", "Parabéns:");
                Palavra6 = true;
            }
        }

        private void Palavra7Correta()
        {
            if (C3_2.Text.ToUpper() == "R" && C7_2.Text.ToUpper() == "O" && C7_3.Text.ToUpper() == "M" && C4_2.Text.ToUpper() == "A" && Palavra7 == false)
            {
                C3_2.Background = Brushes.LightGreen;
                C7_2.Background = Brushes.LightGreen;
                C7_3.Background = Brushes.LightGreen;
                C4_2.Background = Brushes.LightGreen;
                C3_2.IsReadOnly = true;
                C7_2.IsReadOnly = true;
                C7_3.IsReadOnly = true;
                C4_2.IsReadOnly = true;
                MessageBoxResult result = MessageBox.Show("PALAVRA 7 COMPLETA", "Parabéns:");
                Palavra7 = true;
            }
        }

        private void Palavra8Correta()
        {
            if (C8_1.Text.ToUpper() == "C" && C4_5.Text.ToUpper() == "A" && C8_3.Text.ToUpper() == "M" && C5_2.Text.ToUpper() == "I" && C8_5.Text.ToUpper() == "S" && C8_6.Text.ToUpper() == "E" && C8_7.Text.ToUpper() == "T" && C6_2.Text.ToUpper() == "A" && Palavra8 == false)
            {
                C8_1.Background = Brushes.LightGreen;
                C4_5.Background = Brushes.LightGreen;
                C8_3.Background = Brushes.LightGreen;
                C5_2.Background = Brushes.LightGreen;
                C8_5.Background = Brushes.LightGreen;
                C8_6.Background = Brushes.LightGreen;
                C8_7.Background = Brushes.LightGreen;
                C6_2.Background = Brushes.LightGreen;
                C8_1.IsReadOnly = true;
                C4_5.IsReadOnly = true;
                C8_3.IsReadOnly = true;
                C5_2.IsReadOnly = true;
                C8_5.IsReadOnly = true;
                C8_6.IsReadOnly = true;
                C8_7.IsReadOnly = true;
                C6_2.IsReadOnly = true;
                MessageBoxResult result = MessageBox.Show("PALAVRA 8 COMPLETA", "Parabéns:");
                Palavra8 = true;
            }
        }

        private void Palavra9Correta()
        {
            if (C4_1.Text.ToUpper() == "C" && C9_2.Text.ToUpper() == "U" && C9_3.Text.ToUpper() == "B" && C9_4.Text.ToUpper() == "O" && Palavra9 == false)
            {
                C4_1.Background = Brushes.LightGreen;
                C9_2.Background = Brushes.LightGreen;
                C9_3.Background = Brushes.LightGreen;
                C9_4.Background = Brushes.LightGreen;
                C4_1.IsReadOnly = true;
                C9_2.IsReadOnly = true;
                C9_3.IsReadOnly = true;
                C9_4.IsReadOnly = true;
                MessageBoxResult result = MessageBox.Show("PALAVRA 9 COMPLETA", "Parabéns:");
                Palavra9 = true;
            }
        }

        private void Palavra10Correta()
        {
            if (C10_1.Text.ToUpper() == "F" && C5_8.Text.ToUpper() == "O" && C10_3.Text.ToUpper() == "N" && C10_4.Text.ToUpper() == "E" && Palavra10 == false)
            {
                C10_1.Background = Brushes.LightGreen;
                C5_8.Background = Brushes.LightGreen;
                C10_3.Background = Brushes.LightGreen;
                C10_4.Background = Brushes.LightGreen;
                C10_1.IsReadOnly = true;
                C5_8.IsReadOnly = true;
                C10_3.IsReadOnly = true;
                C10_4.IsReadOnly = true;
                MessageBoxResult result = MessageBox.Show("PALAVRA 9 COMPLETA", "Parabéns:");
                Palavra10 = true;
            }
        }

        private void VerificarVitoria()
        {
            if (Palavra1 == true && Palavra2 == true && Palavra3 == true && Palavra4 == true && Palavra5 == true && Palavra6 == true && Palavra7 == true && Palavra8 == true && Palavra9 == true && Palavra10 == true && vitoria == false)
            {
                MessageBoxResult result = MessageBox.Show("Você venceu!!", "PARABÉNS:");
                txtVitoria.Text += "Vitória :)";
                vitoria = true;
            }
        }
    }
 }
