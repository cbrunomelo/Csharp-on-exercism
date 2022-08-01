

using System.Text;

public enum EAlphabet
{
    a,
    b,
    c,
    d,
    e,
    f,
    g,
    h,
    i,
    j,
    k,
    l,
    m,
    n,
    o,
    p,
    q,
    r,
    s,
    t,
    u,
    v,
    w,
    x,
    y,
    z

}
public static class RotationalCipher
{

    public static string ToRot(this string str, int RotNumber)
    {
        var NewWord = new StringBuilder();
        foreach (var letra in str)
        {
            EAlphabet letter = (EAlphabet)Enum.Parse(typeof(EAlphabet), letra.ToString()); //converte a letra para o Alfabeto em Enum
            int NumberFixed = CheckSum(RotNumber + (int)letter); // checar se o numero da soma Rot com o numero da posição nao quebra
            EAlphabet NewLetter = (EAlphabet)(NumberFixed);
            NewWord.Append(NewLetter.ToString());

        }
        return NewWord.ToString();
    }


    public static int CheckSum(int SumNumber) //se o numero for maior q a quantidade de posição subtrai para cair na msm posição. Ex: A= 0 , 26 ou 52 
    {
        while (SumNumber > 25)
        {
            SumNumber -= 26;
        }
        return SumNumber;
    }
}