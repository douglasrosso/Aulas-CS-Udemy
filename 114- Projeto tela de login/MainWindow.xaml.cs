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

namespace _114._Projeto_tela_de_login
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            passwordBoxSenha.Visibility = Visibility.Collapsed;
            textBoxSenha.Visibility = Visibility.Visible;
            textBoxSenha.Text = passwordBoxSenha.Password;
        }

        private void Button_MouseLeave(object sender, MouseEventArgs e)
        {
            textBoxSenha.Visibility = Visibility.Collapsed;
            passwordBoxSenha.Visibility = Visibility.Visible;
            textBoxSenha.Text = "";
        }

        private void buttonEntrar_Click(object sender, RoutedEventArgs e)
        {
            if (buttonEntrar.Content.ToString() == "Entrar")
            {
                if (textBoxUsuario.Text == "maria")
                {
                    if (passwordBoxSenha.Password == "1234")
                    {
                        // Usuário logado no sistema
                        MessageBox.Show("Usuário logado com sucesso!", "Sucesso", MessageBoxButton.OK, MessageBoxImage.Information);
                        buttonEntrar.Content = "Sair";
                        buttonEntrar.Background = new SolidColorBrush(Colors.Green);
                        passwordBoxSenha.Password = "";
                        MeuPrograma meuPrograma = new MeuPrograma();
                        meuPrograma.Show();
                    }
                    else
                    {
                        // Senha está incorreta
                        MessageBox.Show("Senha incorreta!", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);
                    }
                }
                else
                {
                    // Usuário incorreto
                    MessageBox.Show("Usuário incorreto!", "Erro", MessageBoxButton.OK, MessageBoxImage.Error);

                }
            }
            else
            {
                buttonEntrar.Content = "Entrar";
                buttonEntrar.Background = new SolidColorBrush(Color.FromArgb(221, 221, 221, 221));
            }
        }
    }
}
