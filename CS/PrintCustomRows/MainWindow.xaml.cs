using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace PrintCustomRows {
    public class TestData {
        public string PlainText { get; set; }
        public string MemoText { get; set; }
        public bool BooleanMember { get; set; }
        public ImageSource Image { get; set; }
        public double Price { get; set; }
    }
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            grid.ItemsSource = new ObservableCollection<TestData>(GetData());
        }
        static IEnumerable<TestData> GetData() {
            yield return new TestData() { PlainText = "LMA AG", MemoText = "Mercedes-Benz SLK \n2004 \nSilver", BooleanMember = true, Image = GetImage("1.jpg"), Price = 25 };
            yield return new TestData() { PlainText = "Western Motors", MemoText = "Rolls-Royce Corniche \n1975 \nSnowy white", BooleanMember = false, Image = GetImage("2.jpg"), Price = 15 };
            yield return new TestData() { PlainText = "Sun car rent", MemoText = "Ford Ranger FX-4 \n1999 \nRed rock", BooleanMember = true, Image = GetImage("3.jpg"), Price = 20 };
        }
        static ImageSource GetImage(string path) {
            return new BitmapImage(new Uri($"pack://application:,,,/Images/{path}"));
        }
    }
}
