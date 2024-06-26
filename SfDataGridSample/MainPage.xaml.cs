using System.Globalization;

namespace SfDataGridSample
{
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
        }

        private void sfGrid_AutoGeneratingColumn(object sender, Syncfusion.Maui.DataGrid.DataGridAutoGeneratingColumnEventArgs e)
        {
            if (e.Column.MappingName == "ID")
                e.Cancel = true;
        }
    }
}
