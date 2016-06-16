using System;
using System.IO;
using System.Windows;
using System.Windows.Media.Imaging;
using Microsoft.Win32;

namespace FileComparator 
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private OpenFileDialog openFileDialog = new OpenFileDialog();
        private OpenFileDialog CompareFileDialog = new OpenFileDialog();
        private string comparingFilePath;

        public MainWindow() 
        {
            InitializeComponent();
            RenderAllAlgorithmes();         
        }     

        private void browse_btn_Click(object sender, RoutedEventArgs e)
        {
            ClearAllTextBox();
            ClearImage();
            if (openFileDialog.ShowDialog() == true)
            {
                OpenFileDlgTextBox.Text = openFileDialog.FileName;
            }
        }
        
        private void CalculateHashButton_Click(object sender, RoutedEventArgs e)
        {
            CompareHashCodeTextBox.Text = string.Empty;
            ClearImage();

            if (OpenFileDlgTextBox.Text == String.Empty)
            {
                MessageBox.Show("Choose the file location");
            }
            else if (File.Exists(OpenFileDlgTextBox.Text) == true)
            {
                HashProvider hashProvider = new HashProvider(OpenFileDlgTextBox.Text);

                switch (GetCurrentHashAlgorithm())
                {
                    case Algorithmes.CRC32: HashCodeTextBox.Text = hashProvider.GetCRCHash();
                        break;
                    case Algorithmes.MD5: HashCodeTextBox.Text = hashProvider.GetMD5Hash();
                        break;
                    case Algorithmes.RIPEMD160: HashCodeTextBox.Text = hashProvider.GetRIPEMD160Hash();
                        break;
                    case Algorithmes.SHA1: HashCodeTextBox.Text = hashProvider.GetSHA1Hash();
                        break;
                    case Algorithmes.SHA256: HashCodeTextBox.Text = hashProvider.GetSHA256Hash();
                        break;
                    case Algorithmes.KECCAK224: HashCodeTextBox.Text = hashProvider.GetKeccak224Hash();
                        break;
                    case Algorithmes.KECCAK256: HashCodeTextBox.Text = hashProvider.GetKeccak256Hash();
                        break;
                    case Algorithmes.KECCAK384: HashCodeTextBox.Text = hashProvider.GetKeccak384Hash();
                        break;
                    case Algorithmes.KECCAK512: HashCodeTextBox.Text = hashProvider.GetKeccak512Hash();
                        break;
                }
            }
            else
                MessageBox.Show("File does not exist");
        }

        private void CompareButton_Click(object sender, RoutedEventArgs e)
        {
            if (OpenFileDlgTextBox.Text == string.Empty)
            {
                browse_btn_Click(sender, e);
                CalculateHashButton_Click(sender, e);
            }
            if (HashCodeTextBox.Text == string.Empty)
            {
                CalculateHashButton_Click(sender, e);
            }
            if (CompareFileDialog.ShowDialog() == true)
            {
                comparingFilePath = CompareFileDialog.FileName;
            }
            if (OpenFileDlgTextBox.Text == comparingFilePath)
            {
                MessageBox.Show("The selected file is the same as the file you currently viewing");
            }
            if (File.Exists(comparingFilePath) == true)
            {
                HashProvider hashProvider = new HashProvider(comparingFilePath);

                switch (GetCurrentHashAlgorithm())
                {
                    case Algorithmes.CRC32: CompareHashCodeTextBox.Text = hashProvider.GetCRCHash();
                        break;
                    case Algorithmes.MD5: CompareHashCodeTextBox.Text = hashProvider.GetMD5Hash();
                        break;
                    case Algorithmes.RIPEMD160: CompareHashCodeTextBox.Text = hashProvider.GetRIPEMD160Hash();
                        break;
                    case Algorithmes.SHA1: CompareHashCodeTextBox.Text = hashProvider.GetSHA1Hash();
                        break;
                    case Algorithmes.SHA256: CompareHashCodeTextBox.Text = hashProvider.GetSHA256Hash();
                        break;
                    case Algorithmes.KECCAK224: CompareHashCodeTextBox.Text = hashProvider.GetKeccak224Hash();
                        break;
                    case Algorithmes.KECCAK256: CompareHashCodeTextBox.Text = hashProvider.GetKeccak256Hash();
                        break;
                    case Algorithmes.KECCAK384: CompareHashCodeTextBox.Text = hashProvider.GetKeccak384Hash();
                        break;
                    case Algorithmes.KECCAK512: CompareHashCodeTextBox.Text = hashProvider.GetKeccak512Hash();
                        break;
                }
                if (HashCodeTextBox.Text == CompareHashCodeTextBox.Text)
                {
                    SetImage(true);
                }
                else
                {
                    SetImage(false);
                }
            }
            else
                MessageBox.Show("File does not exist");
        }

        /// <summary>
        /// Возвращает текущее значение алгоритма хеширования.
        /// </summary>
        /// <returns></returns>
        private Algorithmes GetCurrentHashAlgorithm()
        {
            return (Algorithmes)cmbBox.SelectionBoxItem;           
        }

        /// <summary>
        /// Задает иконке подлинности исходное значение.
        /// </summary>
        private void ClearImage()
        {
            Uri uri = new Uri("pack://application:,,/null.png");
            BitmapImage bitmap = new BitmapImage(uri);
            comparationResult.Source = bitmap;
        }

        /// <summary>
        /// Задает иконку подлинности в соответствии с входящим параметром.
        /// </summary>
        /// <param name="isIdentity">Значение истинности иконки подлинности.</param>
        private void SetImage(bool isIdentity)
        {
            if (isIdentity)
            {
                Uri uri = new Uri("pack://application:,,/good.jpg");
                BitmapImage bitmap = new BitmapImage(uri);
                comparationResult.Source = bitmap;
            }
            else
            {
                Uri uri = new Uri("pack://application:,,/bad.png");
                BitmapImage bitmap = new BitmapImage(uri);
                comparationResult.Source = bitmap;
            }
        }

        /// <summary>
        /// Очищает все TextBox'ы.
        /// </summary>
        private void ClearAllTextBox()
        {
            OpenFileDlgTextBox.Text = string.Empty;
            HashCodeTextBox.Text = string.Empty;
            CompareHashCodeTextBox.Text = string.Empty;
        }

        private void RenderAllAlgorithmes()
        {
            int algorithmesCount = Enum.GetNames(typeof(Algorithmes)).Length;
            for (int i = 0; i < algorithmesCount; i++)
            {
                cmbBox.Items.Add((Algorithmes)i);
            }
        }
    }

}
