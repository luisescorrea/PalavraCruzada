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
        int PalavrasAcertatas = 0;
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
            if (C1_1.Text.Contains("Q") && C1_2.Text.Contains("U") && C1_3.Text.Contains("E") && C1_4.Text.Contains("I") && C1_5.Text.Contains("J") && C1_6.Text.Contains("O"))
            {
                MessageBoxResult result = MessageBox.Show("PALAVRA 1 COMPLETA", "Dica:");
            }
        }

        private void VerificarP2(object sender, KeyEventArgs e)
        {
            if (C1_4.Text.Contains("I") && C2_2.Text.Contains("G") && C2_3.Text.Contains("R") && C2_4.Text.Contains("E") && C2_5.Text.Contains("J") && C2_6.Text.Contains("A"))
            {
                MessageBoxResult result = MessageBox.Show("PALAVRA 2 COMPLETA", "Dica:");
            }
        }

        private void VerificarP3(object sender, KeyEventArgs e)
        {
            if (C3_1.Text.Contains("J") && C1_6.Text.Contains("O") && C3_2.Text.Contains("R") && C3_3.Text.Contains("N") && C3_4.Text.Contains("A") && C3_5.Text.Contains("L"))
            {
                MessageBoxResult result = MessageBox.Show("PALAVRA 3 COMPLETA", "Dica:");
            }
        }

        private void VerificarP4(object sender, KeyEventArgs e)
        {
            if (C4_1.Text.Contains("C") && C4_2.Text.Contains("A") && C4_3.Text.Contains("R") && C4_4.Text.Contains("T") && C4_5.Text.Contains("A"))
            {
                MessageBoxResult result = MessageBox.Show("PALAVRA 4 COMPLETA", "Dica:");
            }
        }

        private void VerificarP5(object sender, KeyEventArgs e)
        {
            if (C5_1.Text.Contains("P") && C5_2.Text.Contains("I") && C5_3.Text.Contains("R") && C5_4.Text.Contains("U") && C5_5.Text.Contains("L") && C5_6.Text.Contains("I") && C5_7.Text.Contains("L") && C5_8.Text.Contains("O"))
            {
                MessageBoxResult result = MessageBox.Show("PALAVRA 5 COMPLETA", "Dica:");
            }
        }

        private void VerificarP6(object sender, KeyEventArgs e)
        {
            if (C6_1.Text.Contains("X") && C6_2.Text.Contains("A") && C6_3.Text.Contains("R") && C6_4.Text.Contains("O") && C6_5.Text.Contains("P") && C6_6.Text.Contains("E"))
            {
                MessageBoxResult result = MessageBox.Show("PALAVRA 6 COMPLETA", "Dica:");
            }
        }

        private void VerificarP7(object sender, KeyEventArgs e)
        {
            if (C3_2.Text.Contains("R") && C7_2.Text.Contains("O") && C7_3.Text.Contains("M") && C4_2.Text.Contains("A"))
            {
                MessageBoxResult result = MessageBox.Show("PALAVRA 7 COMPLETA", "Dica:");
            }
        }
    }
 }
