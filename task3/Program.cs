using task3;

CurrencyRUB.CurrEurRub = 62.32;
CurrencyRUB.CurrUsdRub = 59.80;

CurrencyRUB rub = new CurrencyRUB();
CurrencyUSD usd = new CurrencyUSD();
CurrencyEUR eur = new CurrencyEUR();
CurrencyEUR eur1 = new CurrencyEUR();

rub.Value = 1000;
usd = (CurrencyUSD)rub;
eur = (CurrencyEUR)rub;
eur1 = (CurrencyEUR)usd;

Console.WriteLine($"{rub.ToString()}rub = {usd.ToString()}$ = {eur.ToString()}э = {eur1.ToString()}э");




