// public enum ECurrencyType
// {
//     HD,
//     USD,
// }

// public class CurrencyAmount
// {
//     public int Money { get; set; }
//     public ECurrencyType Currency { get; set; }

//     public CurrencyAmount(int money, int currency)
//     {
//         Money = money;
//         Currency = (ECurrencyType)currency;
//     }

//     public static bool operator ==(CurrencyAmount a, CurrencyAmount B)
//     {
//         if (a.Currency != B.Currency)
//         {
//             throw new ArgumentException("Os tipos de moedas devem ser a msm");
//         }
//         return (a.Money == B.Money && a.Currency == B.Currency);
//     }
//     public static bool operator !=(CurrencyAmount a, CurrencyAmount B)
//     {
//         return !(a.Money == B.Money && a.Currency == B.Currency);
//     }
// }