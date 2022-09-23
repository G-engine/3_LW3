namespace task3;

public class CurrencyUSD : Currency
{
    private static double _currEurUsd = CurrencyRUB.CurrEurRub/CurrencyRUB.CurrUsdRub;
    private static double _currRubUsd = 1f/CurrencyRUB.CurrUsdRub;
    
    public static explicit operator CurrencyUSD(CurrencyEUR c)
    {
        CurrencyUSD cur = new();
        cur.Value = c.Value * _currEurUsd;
        return cur;
    }
    
    public static explicit operator CurrencyUSD(CurrencyRUB c)
    {
        CurrencyUSD cur = new();
        cur.Value = c.Value * _currRubUsd;
        return cur;
    }
}