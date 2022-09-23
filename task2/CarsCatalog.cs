namespace task2;

public class CarsCatalog
{
    private List<Car> _catalog = new List<Car>();

    public CarsCatalog(params Car[] cars)
    {
        _catalog.AddRange(cars);
    }

    public string this[int index]
    {
        get { return _catalog[index].ToString() + ' ' + _catalog[index].Engine; }
    }
}