using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Security.Encryption;

namespace Security
{
    /// <summary>
    /// MainWindow.xaml 的互動邏輯
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            string salt = GetSalt();
            txtbSalt.Text = salt;

            IEncrypt encrypt = new MD5Encrypt();
            txtbMD5.Text = encrypt.GetSecurePassword(txtPassword.Text);
            txtbMD5Salt.Text = encrypt.GetSecurePassword(txtPassword.Text, salt);

            encrypt = new SHA1Encrypt();
            txtbSHA1.Text = encrypt.GetSecurePassword(txtPassword.Text);
            txtbSHA1Salt.Text = encrypt.GetSecurePassword(txtPassword.Text, salt);

            encrypt = new SHA256Encrypt();
            txtbSHA256.Text = encrypt.GetSecurePassword(txtPassword.Text);
            txtbSHA256Salt.Text = encrypt.GetSecurePassword(txtPassword.Text, salt);

            encrypt = new SHA384Encrypt();
            txtbSHA384.Text = encrypt.GetSecurePassword(txtPassword.Text);
            txtbSHA384Salt.Text = encrypt.GetSecurePassword(txtPassword.Text, salt);

            encrypt = new SHA512Encrypt();
            txtbSHA512.Text = encrypt.GetSecurePassword(txtPassword.Text);
            txtbSHA512Salt.Text = encrypt.GetSecurePassword(txtPassword.Text, salt);

            encrypt = new BCryptEncrypt(5);
            txtbBcrypt.Text = encrypt.GetSecurePassword(txtPassword.Text);
            txtbBcryptSalt.Text = encrypt.GetSecurePassword(txtPassword.Text, salt);

        }

        private string GetSalt()
        {
            Random random = new Random(Guid.NewGuid().GetHashCode());
            return random.Next(1000, 9999).ToString();
        }
    }
}
