using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows;

namespace PrintCustomGroupRows {
    public enum Category {
        Deferred, Normal, Urgent
    }
    public class Item {
        public int ID { get; set; }
        public string Name { get; set; }
        public double Value { get; set; }
        public Category Category { get; set; }
    }
    public partial class MainWindow : Window {
        public MainWindow() {
            InitializeComponent();
            grid.ItemsSource = new ObservableCollection<Item>(GetData());
        }
        static IEnumerable<Item> GetData() {
            var r = new Random();
            for (int i = 0; i < 50; i++) {
                yield return new Item() { ID = i, Name = "Item " + i, Value = r.Next(0, 50), Category = (Category)r.Next(0, 3) };
            }
        }
    }
}
