using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace GridExample {
    public class TestData {
        public string PlainText { get; set; }
        public string MemoText { get; set; }
        public bool BooleanMember { get; set; }
        public ImageSource Image { get; set; }
    }

    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            grid.ItemsSource = GetData().ToList();
        }
        static IEnumerable<TestData> GetData() {
            yield return new TestData() { PlainText = "LMA AG", MemoText = "Mercedes-Benz SLK \n2004 \nSilver", BooleanMember = true, Image = GetImage("/Images/1.png") };
            yield return new TestData() { PlainText = "Western Motors", MemoText = "Rolls-Royce Corniche \n1975 \nSnowy white", BooleanMember = false, Image = GetImage("/Images/2.png") };
            yield return new TestData() { PlainText = "Sun car rent", MemoText = "Ford Ranger FX-4 \n1999 \nRed rock", BooleanMember = true, Image = GetImage("/Images/3.png") };
        }
        static ImageSource GetImage(string path) {
            return new BitmapImage(new Uri(path, UriKind.Relative));
        }
    }
}
