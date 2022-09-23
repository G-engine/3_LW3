namespace task3;

public class CurrencyEUR : Currency
{
    private static double _currRubEur = 1f/CurrencyRUB.CurrEurRub;
    private static double _currUsdEur = CurrencyRUB.CurrUsdRub/CurrencyRUB.CurrEurRub;
    
    public static explicit operator CurrencyEUR(CurrencyRUB c)
    {
        CurrencyEUR cur = new();
        cur.Value = c.Value * _currRubEur;
        return cur;
    }
    
    public static explicit operator CurrencyEUR(CurrencyUSD c)
    {
        CurrencyEUR cur = new();
        cur.Value = c.Value * _currUsdEur;
        return cur;
    }
}