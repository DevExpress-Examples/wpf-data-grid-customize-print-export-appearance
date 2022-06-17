using System;
using System.Globalization;
using System.Windows.Data;

namespace PrintCustomGroupRows {
    public class RemoveParenthesesConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            var str = value as string;
            if (str == null)
                return null;
            return str.Replace("(", string.Empty).Replace(")", string.Empty);
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
    public class PrintRowInfoToImageSourceConverter : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            Category category;
            if (Enum.TryParse(value.ToString(), out category)) {
                switch (category) {
                    case Category.Deferred:
                        return "Images/Deffered_32x32.png";
                    case Category.Normal:
                        return "Images/Normal_32x32.png";
                    case Category.Urgent:
                        return "Images/Urgent_32x32.png";
                }
            }
            return null;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            throw new NotImplementedException();
        }
    }
}
