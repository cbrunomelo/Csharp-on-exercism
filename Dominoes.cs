using System.Collections.Generic;

// ira retornar todas as possibilidades para 3 dominos
public class Dominoes
{
    public int Face1 { get; set; }

    public int Face2 { get; set; }

    public static List<string[]> Orderdominoes(List<Dominoes> dominoes)

    {
        List<Dominoes> List1 = new();

        List<Dominoes> List2 = new();

        

        var Results = new List<string[]>();

        // ira escolher um domino como referencial e ira colocar no centro da lista, e caso as demais validações ocorra certo
        // ira ser adcionado a lista de Results
        for (int i = 0; i < 3; i++)
        {
            var ArrayResult = new string[3];

            // a minha esqueda do referencial
            List1.AddRange(dominoes.Where(n => n.Face1 == dominoes[i].Face1));
            List1.AddRange(dominoes.Where(n => n.Face2 == dominoes[i].Face1));


            // a minha direita do referencial
            List2.AddRange(dominoes.Where(n => n.Face2 == dominoes[i].Face2));
            List2.AddRange(dominoes.Where(n => n.Face1 == dominoes[i].Face2));


            List1.RemoveAll(x => x.Face1 == dominoes[i].Face1 && x.Face2 == dominoes[i].Face2);
            List2.RemoveAll(x => x.Face1 == dominoes[i].Face1 && x.Face2 == dominoes[i].Face2);

            foreach (var item in List1)
            {
                ArrayResult[1] = $"{dominoes[i].Face1} | {dominoes[i].Face2} ";

                if (item.Face1 == dominoes[i].Face1)
                    ArrayResult[0] = $"{item.Face2} | {item.Face1}";
                else
                    ArrayResult[0] = $"{item.Face1} | {item.Face2}";

                foreach (var item2 in List2)
                    if (item2.Face1 == dominoes[i].Face2)
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
}

