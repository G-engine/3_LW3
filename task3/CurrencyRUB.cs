namespace task3;

public class CurrencyRUB : Currency
{
    public static double CurrEurRub;
    public static double CurrUsdRub;
    
    public static explicit operator CurrencyRUB(CurrencyEUR c)
    {
        CurrencyRUB cur = new();
        cur.Value = c.Value * CurrEurRub;
        return cur;
    }
    
    public static explicit operator CurrencyRUB(CurrencyUSD c)
    {
        CurrencyRUB cur = new();
        cur.Value = c.Value * CurrUsdRub;
        return cur;
    }
}