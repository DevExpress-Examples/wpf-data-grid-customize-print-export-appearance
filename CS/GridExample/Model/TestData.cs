// Developer Express Code Central Example:
// How to use the PrintCellStyle property to customize cell's printing appearance
// 
// This example shows how to create custom PrintCellStyle for grid columns to bring
// a custom printing appearance for PopupImageEdit, CheckBoxEdit and MemoEdit.
// 
// You can find sample updates and versions for different programming languages here:
// http://www.devexpress.com/example=E3227

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Media;

namespace GridExample {
    public class TestData {
        public string PlainText { get; set; }
        public string MemoText { get; set; }
        public bool BooleanMember { get; set; }
        public ImageSource Image { get; set; }
    }
}
