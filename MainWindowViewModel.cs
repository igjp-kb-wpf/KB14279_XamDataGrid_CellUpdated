using KB14279_XamDataGrid_CellUpdated.Infrastructure;
using KB14279_XamDataGrid_CellUpdated.Model;
using System.Collections.ObjectModel;

namespace KB14279_XamDataGrid_CellUpdated;
internal class MainWindowViewModel : ObservableObject
{
    public ObservableCollection<Sample> Products { get; set; }

    public MainWindowViewModel()
    {
        Products =
        [
            new () { ID = "001", Product = "Laptop", UnitPrice = 150000, Quantity = 10, Price = 1500000 },
            new () { ID = "002", Product = "Smartphone", UnitPrice = 80000, Quantity = 20, Price = 1600000 },
            new () { ID = "003", Product = "Tablet", UnitPrice = 60000, Quantity = 10, Price = 600000 },
            new () { ID = "004", Product = "Monitor", UnitPrice = 30000, Quantity = 40, Price = 1200000 },
            new () { ID = "005", Product = "Keyboard", UnitPrice = 5000, Quantity = 30, Price = 150000 },
            new () { ID = "006", Product = "Mouse", UnitPrice = 3000, Quantity = 10, Price = 30000 },            
        ];
    }
}