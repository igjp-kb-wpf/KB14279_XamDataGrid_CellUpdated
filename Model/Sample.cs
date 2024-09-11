using KB14279_XamDataGrid_CellUpdated.Infrastructure;

namespace KB14279_XamDataGrid_CellUpdated.Model;
internal class Sample : ObservableObject
{
    private string _id;
    public string ID
    {
        get { return _id; }
        set { _id = value; OnPropertyChanged(); }
    }
    private string _product = string.Empty;
    public string Product
    {
        get { return _product; }
        set { _product = value; OnPropertyChanged(); }
    }
    private double _unitPrice;
    public double UnitPrice
    {
        get { return _unitPrice; }
        set { _unitPrice = value; OnPropertyChanged(); }
    }
    private int _quantity;
    public int Quantity
    {
        get { return _quantity; }
        set { _quantity = value; OnPropertyChanged(); }
    }
    private double _price;
    public double Price
    {
        get { return _price; }
        set { _price = value; OnPropertyChanged(); }
    }


    public Sample()
    {
    }
}