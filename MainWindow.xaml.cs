using System.Windows;
using FreshFruit.model;
using FreshFruit.controller;

namespace FreshFruit
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, BucketEventListener
    {
        Seller seller;
        public MainWindow()
        {
            InitializeComponent();
            Bucket keranjangBuah = new Bucket(5);
            BucketController bucketController = new BucketController(keranjangBuah, this);
            seller = new Seller("seller", bucketController);
            ListBoxBucket.ItemsSource = keranjangBuah.findAll();
        }
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            Fruit anggur = new Fruit("Anggur");
            seller.addFruit(anggur);
        }

        private void Button2_Click(object sender, RoutedEventArgs e)
        {
            Fruit Apel = new Fruit("Apel");
            seller.addFruit(Apel);
        }
        private void Button3_Click(object sender, RoutedEventArgs e)
        {
            Fruit Pisang = new Fruit("Pisang");
            seller.addFruit(Pisang);
        }
        private void Button4_Click(object sender, RoutedEventArgs e)
        {
            Fruit jeruk = new Fruit("Jeruk");
            seller.addFruit(jeruk);
        }
        private void ClearButton_Click(object sender, RoutedEventArgs e)
        {
            seller.clearBucket();
        }
        public void onFailed(string message)
        {
            MessageBox.Show(message, "Warning");
        }
        public void onSucceed(string message)
        {
            ListBoxBucket.Items.Refresh();
        }

    }
}
