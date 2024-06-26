# How to display RowIndex at RowHeaderCell in SfDataGrid in MAUI DataGrid?

Display RowIndex in the RowHeaderCell in SfDataGrid in .NET MAUI. You can use a column as the RowHeader by setting the [ShowRowHeader](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_ShowRowHeader) property to true. Cancel the generation of the ID column in the [AutoGeneratingColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_AutoGeneratingColumn) event. Use the [RowHeaderTemplate](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.SfDataGrid.html#Syncfusion_Maui_DataGrid_SfDataGrid_RowHeaderTemplate) of the DataGrid to display the Row Header. A label inside the template bind the ID value to its text property. To set the background color for this template, you can use the background property of the label. We have attached the code snippet and sample for your reference.

```Xaml
<syncfusion:SfDataGrid.RowHeaderTemplate>
    <DataTemplate>
        <Label Text="{Binding ID}" Background="AliceBlue" HorizontalTextAlignment = "Center" VerticalTextAlignment = "Center" />
    </DataTemplate>
</syncfusion:SfDataGrid.RowHeaderTemplate>

```
 
 ![RowHeader.png](https://support.syncfusion.com/kb/agent/attachment/article/16352/inline?token=eyJhbGciOiJodHRwOi8vd3d3LnczLm9yZy8yMDAxLzA0L3htbGRzaWctbW9yZSNobWFjLXNoYTI1NiIsInR5cCI6IkpXVCJ9.eyJpZCI6IjI0NTk0Iiwib3JnaWQiOiIzIiwiaXNzIjoic3VwcG9ydC5zeW5jZnVzaW9uLmNvbSJ9.vgJ67y3_4yKvN21U7XlW4GpH3OUFwtg3K2bAJBWdAAM)
[View sample in GitHub](https://github.com/SyncfusionExamples/How-to-display-RowIndex-at-RowHeaderCell-in-SfDataGrid-in-MAUI-DataGrid)

Take a moment to explore this [documentation](https://help.syncfusion.com/maui/datagrid/overview), where you can find more information about Syncfusion .NET MAUI DataGrid (SfDataGrid) with code examples. Please refer to this [link](https://www.syncfusion.com/maui-controls/maui-datagrid) to learn about the essential features of Syncfusion .NET MAUI DataGrid (SfDataGrid).
 
##### Conclusion
 
I hope you enjoyed learning about how to display RowIndex at RowHeaderCell in MAUI DataGrid (SfDataGrid).
 
You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to learn about its other groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid Documentation](https://help.syncfusion.com/maui/datagrid/getting-started) to understand how to present and manipulate data. 
For current customers, you can check out our .NET MAUI components on the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to explore our .NET MAUI DataGrid and other .NET MAUI components.
 
If you have any queries or require clarifications, please let us know in the comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/create) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid), or the feedback portal. We are always happy to assist you!