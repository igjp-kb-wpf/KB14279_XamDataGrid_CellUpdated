using Infragistics.Windows.DataPresenter.Events;
using Infragistics.Windows.DataPresenter;
using KB14279_XamDataGrid_CellUpdated.Model;
using System.Windows;

namespace KB14279_XamDataGrid_CellUpdated;
/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    private void XamDataGrid_CellUpdated(object sender, CellUpdatedEventArgs e)
    {
        DataRecord dataRecord = e.Cell.Record;
        if (dataRecord != null)
        {
            if (dataRecord.DataItem is Sample sample)
            {
                sample.Price = sample.UnitPrice * sample.Quantity;
            }
        }
    }
}
