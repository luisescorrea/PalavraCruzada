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
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void Dica1(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Comida favorita dos ratos nos desenhos.", "Dica:");
        }

        private void Dica2(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Casa de Deus.", "Dica:");
        }

        private void Dica3(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Entrega notícia no dia a dia.", "Dica:");
        }

        private void Dica4(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Truco, Uno, Poker, BlackJack(21).", "Dica:");
        }

        private void Dica5(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Doce com palito.", "Dica:");
        }

        private void Dica6(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("[Cala boca] Jovem!! em inglês.", "Dica:");
        }

        private void Dica7(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Todos os caminhos levam a ____.", "Dica:");
        }

        private void Dica8(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Roupa de cima.", "Dica:");
        }

        private void Dica9(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Forma geométrica mágica.", "Dica:");
        }

        private void Dica10(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Aparelho auditivo particular.", "Dica:");
        }

        private void VerificarP1(object sender, KeyEventArgs e)
        {
            if (C1_1.Text.Contains("Q") && C1_2.Text.Contains("U") && C1_3.Text.Contains("E") && C1_4.Text.Contains("I") && C1_5.Text.Contains("J") && C1_6.Text.Contains("O") && Palavra1 == false)
            {
                C1_1.Background = Brushes.LightGreen;
                C1_2.Background = Brushes.LightGreen;
                C1_3.Background = Brushes.LightGreen;
                C1_4.Background = Brushes.LightGreen;
                C1_5.Background = Brushes.LightGreen;
                C1_6.Background = Brushes.LightGreen;
                MessageBoxResult result = MessageBox.Show("PALAVRA 1 COMPLETA", "Parabéns:");
                Palavra1 = true;
            }

            if (C1_4.Text.Contains("I") && C2_2.Text.Contains("G") && C2_3.Text.Contains("R") && C2_4.Text.Contains("E") && C2_5.Text.Contains("J") && C2_6.Text.Contains("A") && Palavra2 == false)
            {
                C1_4.Background = Brushes.LightGreen;
                C2_2.Background = Brushes.LightGreen;
                C2_3.Background = Brushes.LightGreen;
                C2_4.Background = Brushes.LightGreen;
                C2_5.Background = Brushes.LightGreen;
                C2_6.Background = Brushes.LightGreen;
                MessageBoxResult result = MessageBox.Show("PALAVRA 2 COMPLETA", "Parabéns:");
                Palavra2 = true;
            }

            if (C3_1.Text.Contains("J") && C1_6.Text.Contains("O") && C3_2.Text.Contains("R") && C3_3.Text.Contains("N") && C3_4.Text.Contains("A") && C3_5.Text.Contains("L") && Palavra3 == false)
            {
                C3_1.Background = Brushes.LightGreen;
                C1_6.Background = Brushes.LightGreen;
                C3_2.Background = Brushes.LightGreen;
                C3_3.Background = Brushes.LightGreen;
                C3_4.Background = Brushes.LightGreen;
                C3_5.Background = Brushes.LightGreen;
                MessageBoxResult result = MessageBox.Show("PALAVRA 3 COMPLETA", "Parabéns:");
                Palavra3 = true;
            }
        }

        private void VerificarP2(object sender, KeyEventArgs e)
        {
            if (C1_4.Text.Contains("I") && C2_2.Text.Contains("G") && C2_3.Text.Contains("R") && C2_4.Text.Contains("E") && C2_5.Text.Contains("J") && C2_6.Text.Contains("A") && Palavra2 == false)
            {
                    C1_4.Background = Brushes.LightGreen;
                    C2_2.Background = Brushes.LightGreen;
                    C2_3.Background = Brushes.LightGreen;
                    C2_4.Background = Brushes.LightGreen;
                    C2_5.Background = Brushes.LightGreen;
                    C2_6.Background = Brushes.LightGreen;
                    MessageBoxResult result = MessageBox.Show("PALAVRA 2 COMPLETA", "Parabéns:");
                    Palavra2 = true;
            }
        }

        private void VerificarP3(object sender, KeyEventArgs e)
        {
            if (C3_1.Text.Contains("J") && C1_6.Text.Contains("O") && C3_2.Text.Contains("R") && C3_3.Text.Contains("N") && C3_4.Text.Contains("A") && C3_5.Text.Contains("L") && Palavra3 == false)
            {
                C3_1.Background = Brushes.LightGreen;
                C1_6.Background = Brushes.LightGreen;
                C3_2.Background = Brushes.LightGreen;
                C3_3.Background = Brushes.LightGreen;
                C3_4.Background = Brushes.LightGreen;
                C3_5.Background = Brushes.LightGreen;
                MessageBoxResult result = MessageBox.Show("PALAVRA 3 COMPLETA", "Parabéns:");
                Palavra3 = true;
            }

            if (C3_2.Text.Contains("R") && C7_2.Text.Contains("O") && C7_3.Text.Contains("M") && C4_2.Text.Contains("A") && Palavra7 == false)
            {
                C3_2.Background = Brushes.LightGreen;
                C7_2.Background = Brushes.LightGreen;
                C7_3.Background = Brushes.LightGreen;
                C4_2.Background = Brushes.LightGreen;
                MessageBoxResult result = MessageBox.Show("PALAVRA 7 COMPLETA", "Parabéns:");
                Palavra7 = true;
            }

        }

        private void VerificarP4(object sender, KeyEventArgs e)
        {
            if (C4_1.Text.Contains("C") && C4_2.Text.Contains("A") && C4_3.Text.Contains("R") && C4_4.Text.Contains("T") && C4_5.Text.Contains("A") && Palavra4 == false)
            {
                C4_1.Background = Brushes.LightGreen;
                C4_2.Background = Brushes.LightGreen;
                C4_3.Background = Brushes.LightGreen;
                C4_4.Background = Brushes.LightGreen;
                C4_5.Background = Brushes.LightGreen;
                MessageBoxResult result = MessageBox.Show("PALAVRA 4 COMPLETA", "Parabéns:");
                Palavra4 = true;
            }

            if (C3_2.Text.Contains("R") && C7_2.Text.Contains("O") && C7_3.Text.Contains("M") && C4_2.Text.Contains("A") && Palavra7 == false)
            {
                C3_2.Background = Brushes.LightGreen;
                C7_2.Background = Brushes.LightGreen;
                C7_3.Background = Brushes.LightGreen;
                C4_2.Background = Brushes.LightGreen;
                MessageBoxResult result = MessageBox.Show("PALAVRA 7 COMPLETA", "Parabéns:");
                Palavra7 = true;
            }

            if (C4_1.Text.Contains("C") && C9_2.Text.Contains("U") && C9_3.Text.Contains("B") && C9_4.Text.Contains("O") && Palavra9 == false)
            {
                C4_1.Background = Brushes.LightGreen;
                C9_2.Background = Brushes.LightGreen;
                C9_3.Background = Brushes.LightGreen;
                C9_4.Background = Brushes.LightGreen;
                MessageBoxResult result = MessageBox.Show("PALAVRA 9 COMPLETA", "Parabéns:");
                Palavra9 = true;
            }

            if (C8_1.Text.Contains("C") && C4_5.Text.Contains("A") && C8_3.Text.Contains("M") && C5_2.Text.Contains("I") && C8_5.Text.Contains("S") && C8_6.Text.Contains("E") && C8_7.Text.Contains("T") && C6_2.Text.Contains("A") && Palavra8 == false)
            {
                C8_1.Background = Brushes.LightGreen;
                C4_5.Background = Brushes.LightGreen;
                C8_3.Background = Brushes.LightGreen;
                C5_2.Background = Brushes.LightGreen;
                C8_5.Background = Brushes.LightGreen;
                C8_6.Background = Brushes.LightGreen;
                C8_7.Background = Brushes.LightGreen;
                C6_2.Background = Brushes.LightGreen;
                MessageBoxResult result = MessageBox.Show("PALAVRA 8 COMPLETA", "Parabéns:");
                Palavra8 = true;
            }
        }

        private void VerificarP5(object sender, KeyEventArgs e)
        {
            if (C5_1.Text.Contains("P") && C5_2.Text.Contains("I") && C5_3.Text.Contains("R") && C5_4.Text.Contains("U") && C5_5.Text.Contains("L") && C5_6.Text.Contains("I") && C5_7.Text.Contains("T") && C5_8.Text.Contains("O") && Palavra5 == false)
            {
                C5_1.Background = Brushes.LightGreen;
                C5_2.Background = Brushes.LightGreen;
                C5_3.Background = Brushes.LightGreen;
                C5_4.Background = Brushes.LightGreen;
                C5_5.Background = Brushes.LightGreen;
                C5_6.Background = Brushes.LightGreen;
                C5_7.Background = Brushes.LightGreen;
                C5_8.Background = Brushes.LightGreen;
                MessageBoxResult result = MessageBox.Show("PALAVRA 5 COMPLETA", "Parabéns:");
                Palavra5 = true;
            }

            if (C8_1.Text.Contains("C") && C4_5.Text.Contains("A") && C8_3.Text.Contains("M") && C5_2.Text.Contains("I") && C8_5.Text.Contains("S") && C8_6.Text.Contains("E") && C8_7.Text.Contains("T") && C6_2.Text.Contains("A") && Palavra8 == false)
            {
                C8_1.Background = Brushes.LightGreen;
                C4_5.Background = Brushes.LightGreen;
                C8_3.Background = Brushes.LightGreen;
                C5_2.Background = Brushes.LightGreen;
                C8_5.Background = Brushes.LightGreen;
                C8_6.Background = Brushes.LightGreen;
                C8_7.Background = Brushes.LightGreen;
                C6_2.Background = Brushes.LightGreen;
                MessageBoxResult result = MessageBox.Show("PALAVRA 8 COMPLETA", "Parabéns:");
                Palavra8 = true;
            }

            if (C10_1.Text.Contains("F") && C5_8.Text.Contains("O") && C10_3.Text.Contains("N") && C10_4.Text.Contains("E") && Palavra10 == false)
            {
                C10_1.Background = Brushes.LightGreen;
                C5_8.Background = Brushes.LightGreen;
                C10_3.Background = Brushes.LightGreen;
                C10_4.Background = Brushes.LightGreen;
                MessageBoxResult result = MessageBox.Show("PALAVRA 9 COMPLETA", "Parabéns:");
                Palavra10 = true;
            }
        }

        private void VerificarP6(object sender, KeyEventArgs e)
        {
            if (C6_1.Text.Contains("X") && C6_2.Text.Contains("A") && C6_3.Text.Contains("R") && C6_4.Text.Contains("O") && C6_5.Text.Contains("P") && C6_6.Text.Contains("E") && Palavra6 == false)
            {
                C6_1.Background = Brushes.LightGreen;
                C6_2.Background = Brushes.LightGreen;
                C6_3.Background = Brushes.LightGreen;
                C6_4.Background = Brushes.LightGreen;
                C6_5.Background = Brushes.LightGreen;
                C6_6.Background = Brushes.LightGreen;
                MessageBoxResult result = MessageBox.Show("PALAVRA 6 COMPLETA", "Parabéns:");
                Palavra6 = true;
            }

            if (C8_1.Text.Contains("C") && C4_5.Text.Contains("A") && C8_3.Text.Contains("M") && C5_2.Text.Contains("I") && C8_5.Text.Contains("S") && C8_6.Text.Contains("E") && C8_7.Text.Contains("T") && C6_2.Text.Contains("A") && Palavra8 == false)
            {
                C8_1.Background = Brushes.LightGreen;
                C4_5.Background = Brushes.LightGreen;
                C8_3.Background = Brushes.LightGreen;
                C5_2.Background = Brushes.LightGreen;
                C8_5.Background = Brushes.LightGreen;
                C8_6.Background = Brushes.LightGreen;
                C8_7.Background = Brushes.LightGreen;
                C6_2.Background = Brushes.LightGreen;
                MessageBoxResult result = MessageBox.Show("PALAVRA 8 COMPLETA", "Parabéns:");
                Palavra8 = true;
            }
        }

        private void VerificarP7(object sender, KeyEventArgs e)
        {
            if (C3_2.Text.Contains("R") && C7_2.Text.Contains("O") && C7_3.Text.Contains("M") && C4_2.Text.Contains("A") && Palavra7 == false)
            {
                C3_2.Background = Brushes.LightGreen;
                C7_2.Background = Brushes.LightGreen;
                C7_3.Background = Brushes.LightGreen;
                C4_2.Background = Brushes.LightGreen;
                MessageBoxResult result = MessageBox.Show("PALAVRA 7 COMPLETA", "Parabéns:");
                Palavra7 = true;
            }
        }

        private void VerificarP8(object sender, KeyEventArgs e)
        {
            if (C8_1.Text.Contains("C") && C4_5.Text.Contains("A") && C8_3.Text.Contains("M") && C5_2.Text.Contains("I") && C8_5.Text.Contains("S") && C8_6.Text.Contains("E") && C8_7.Text.Contains("T") && C6_2.Text.Contains("A") && Palavra8 == false)
            {
                C8_1.Background = Brushes.LightGreen;
                C4_5.Background = Brushes.LightGreen;
                C8_3.Background = Brushes.LightGreen;
                C5_2.Background = Brushes.LightGreen;
                C8_5.Background = Brushes.LightGreen;
                C8_6.Background = Brushes.LightGreen;
                C8_7.Background = Brushes.LightGreen;
                C6_2.Background = Brushes.LightGreen;
                MessageBoxResult result = MessageBox.Show("PALAVRA 8 COMPLETA", "Parabéns:");
                Palavra7 = true;
            }
        }

        private void VerificarP9(object sender, KeyEventArgs e)
        {
            if (C4_1.Text.Contains("C") && C9_2.Text.Contains("U") && C9_3.Text.Contains("B") && C9_4.Text.Contains("O") && Palavra9 == false)
            {
                C4_1.Background = Brushes.LightGreen;
                C9_2.Background = Brushes.LightGreen;
                C9_3.Background = Brushes.LightGreen;
                C9_4.Background = Brushes.LightGreen;
                MessageBoxResult result = MessageBox.Show("PALAVRA 9 COMPLETA", "Parabéns:");
                Palavra9 = true;
            }
        }

        private void VerificarP10(object sender, KeyEventArgs e)
        {
            if (C10_1.Text.Contains("F") && C5_8.Text.Contains("O") && C10_3.Text.Contains("N") && C10_4.Text.Contains("E") && Palavra10 == false)
            {
                C10_1.Background = Brushes.LightGreen;
                C5_8.Background = Brushes.LightGreen;
                C10_3.Background = Brushes.LightGreen;
                C10_4.Background = Brushes.LightGreen;
                MessageBoxResult result = MessageBox.Show("PALAVRA 9 COMPLETA", "Parabéns:");
                Palavra10 = true;
            }
        }

        //private void VerificarVitoria(object sender, MouseEventArgs e)
       // {
       //     if(Palavra1 == true && Palavra2 == true && Palavra3 == true && Palavra4 == true && Palavra5 == true && Palavra6 == true && Palavra7 == true && Palavra8 == true && Palavra9 == true && Palavra10 == true)
       //     {
       //         txtVitoria.Text = "Vitória";
       //     }
      //  }

        private void VerificarVitoria(object sender, KeyboardFocusChangedEventArgs e)
        {
            if (Palavra1 == true)
            {
                MessageBoxResult result = MessageBox.Show("FOI");
                txtVitoria.Text += "Vitória";
            }
        }
    }
 }
