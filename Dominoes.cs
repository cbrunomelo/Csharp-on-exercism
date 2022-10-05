using System.Collections.Generic;

// ira retornar todas as possibilidades para 3 dominos
public class Dominoes : IEquatable<Dominoes>
{
    public int Face1 { get; set; }

    public int Face2 { get; set; }

    public static List<string[]> Orderdominoes(List<Dominoes> dominoes)

    {
        List<Dominoes> LeftDomains = new();

        List<Dominoes> RightDomains = new();

        

        var Results = new List<string[]>();

        // ira escolher um domino como referencial e ira colocar no centro da lista, e caso as demais validações ocorra certo
        // ira ser adcionado a lista de Results
        for (int i = 0; i < 3; i++)
        {
            var ArrayResult = new string[3];

            var CentralDomain = dominoes[i];

            // a minha esqueda do referencial
            LeftDomains.AddRange(dominoes.Where(n => n.Face1 == CentralDomain.Face1));
            LeftDomains.AddRange(dominoes.Where(n => n.Face2 == CentralDomain.Face1));


            // a minha direita do referencial
            RightDomains.AddRange(dominoes.Where(n => n.Face2 == CentralDomain.Face2));
            RightDomains.AddRange(dominoes.Where(n => n.Face1 == CentralDomain.Face2));


            LeftDomains.RemoveAll(x => x.Face1 == CentralDomain.Face1 && x.Face2 == CentralDomain.Face2);
            RightDomains.RemoveAll(x => x.Face1 == CentralDomain.Face1 && x.Face2 == CentralDomain.Face2);

            var LeftDomainsNoRepetion = LeftDomains.Distinct().ToList<Dominoes>();
            var RightDomainNoRepetion = RightDomains.Distinct().ToList<Dominoes>();

            foreach (var item in LeftDomainsNoRepetion)
            {
                ArrayResult[1] = $"{CentralDomain.Face1} | {CentralDomain.Face2} ";

                if (item.Face1 == CentralDomain.Face1)
                    ArrayResult[0] = $"{item.Face2} | {item.Face1}";
                else
                    ArrayResult[0] = $"{item.Face1} | {item.Face2}";

                foreach (var item2 in RightDomainNoRepetion)
                    if (item2.Face1 == CentralDomain.Face2)
                    {
                        ArrayResult[2] = $"{item2.Face1} | {item2.Face2}";
                        if (ArrayResult[0].ToString()[0] == ArrayResult[2].ToString()[4])
                            if(!Results.Contains(ArrayResult))
                                 Results.Add(ArrayResult);
                    }
                    else
                    {
                        ArrayResult[2] = $"{item2.Face2} | {item2.Face1}";
                        if (ArrayResult[0].ToString()[0] == ArrayResult[2].ToString()[4])
                            if (!Results.Contains(ArrayResult))
                                Results.Add(ArrayResult);
                    }




            }
        }

            return Results;
    }

    public bool Equals(Dominoes? other)
    {
        if(Face1 == other.Face1 && Face2 == other.Face2)
            return true;
        return false;
    }
}

