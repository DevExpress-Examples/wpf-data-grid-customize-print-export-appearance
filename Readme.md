<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128653781/21.1.5%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3227)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
# WPF Data Grid - Customize the Print and Export Appearance

This example demonstrates how to use the GridControl's [styles](https://docs.devexpress.com/WPF/6771/controls-and-libraries/data-grid/appearance-customization/grid-control-styles#printing-styles) and [templates](https://docs.devexpress.com/WPF/6770/controls-and-libraries/data-grid/appearance-customization/grid-elements-that-support-templates#print-templates) to customize its appearance when you [print the grid](https://docs.devexpress.com/WPF/6160/controls-and-libraries/data-grid/printing-and-exporting/print-data) or export it in [WYSIWYG mode](https://docs.devexpress.com/WPF/118842/controls-and-libraries/data-grid/printing-and-exporting/wysiwyg-export).

## Example Structure

### PrintCustomCells

**View File:** [PrintCustomCells/MainWindow.xaml](./CS/PrintCustomCells/MainWindow.xaml)

This project creates a custom [PrintCellStyle](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.ColumnBase.PrintCellStyle) for grid columns. In this project, the [GridControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl) contains the [MemoEdit](http://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.MemoEdit), [CheckEdit](http://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.CheckEdit), and [PopupImageEdit](http://docs.devexpress.com/WPF/DevExpress.Xpf.Editors.PopupImageEdit) editors:

![image](https://user-images.githubusercontent.com/65009440/174296836-6684bfa7-2dc7-41e1-9aa3-a8490d932409.png)

The following image shows the [GridControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl)'s print preview:

![image](https://user-images.githubusercontent.com/65009440/174297141-da85de96-09ea-4824-a160-1b234606fc6d.png)


### PrintCustomRows

**View File:** [PrintCustomRows/MainWindow.xaml](./CS/PrintCustomRows/MainWindow.xaml)

This project uses the [PrintRowTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TableView.PrintRowTemplate) property to completely change the layout of printed rows. This project also customizes column headers ([PrintHeaderTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataViewBase.PrintHeaderTemplate)) and the total summary panel ([PrintFooterTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataViewBase.PrintFooterTemplate)).

The following image shows the GridControl:

![image](https://user-images.githubusercontent.com/65009440/174292844-27a18d3d-fa14-4ca3-a11d-1deb0458fff1.png)

The image below shows the [GridControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl)'s print preview:

![image](https://user-images.githubusercontent.com/65009440/174292992-1c72415a-fe8d-477b-ac0a-712297d5760d.png)


### PrintCustomGroupRows

**View File:** [PrintCustomGroupRows/MainWindow.xaml](./CS/PrintCustomGroupRows/MainWindow.xaml)

This project uses the [PrintGroupRowTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridViewBase.PrintGroupRowTemplate) property to display images in printed group rows and remove parentheses from group summaries.

![image](https://user-images.githubusercontent.com/65009440/174296998-64be14b9-3152-4997-8bfc-bf0c8d782803.png)

The following image shows the [GridControl](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridControl)'s print preview:

![image](https://user-images.githubusercontent.com/65009440/174294325-745b19f7-4f63-4469-910c-398c489b9c9a.png)


## Documentation

* [Print and Export Data](https://docs.devexpress.com/WPF/117296/controls-and-libraries/data-grid/printing-and-exporting)
* [ColumnBase.PrintCellStyle](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.ColumnBase.PrintCellStyle)
* [PrintRowTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.TableView.PrintRowTemplate)
* [PrintHeaderTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataViewBase.PrintHeaderTemplate)
* [PrintFooterTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.DataViewBase.PrintFooterTemplate)
* [PrintGroupRowTemplate](https://docs.devexpress.com/WPF/DevExpress.Xpf.Grid.GridViewBase.PrintGroupRowTemplate)

## More Examples

* [WPF Data Grid - Print and Export the GridControl](https://github.com/DevExpress-Examples/how-to-print-and-export-the-grid-e1669)
* [WPF Data Grid - Create a Print Page Header and Footer](https://github.com/DevExpress-Examples/how-to-create-the-print-page-header-and-footer-when-exporting-the-gridcontrol-e2608)
