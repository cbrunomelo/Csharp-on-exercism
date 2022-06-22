using System;

static class Languages
{
    public static List<string> NewList() => new List<string>();


    public static List<string> GetExistingLanguages() => new List<string>() { "C#", "Clojure", "Elm" };

    public static void AddLanguage(List<string> lista, string elemento) => lista.Add(elemento);


    public static int CountLanguages(List<string> lista) => lista.Count();

    public static bool HasLanguage(List<string> lista, string valor) => lista.Contains(valor);


    public static void ReverseList(ref List<string> lista) => lista.Reverse();


    public static bool IsExciting(List<string> lista) => lista[0] == "C#" && lista[1] == "C#" && (lista.Count == 2 || lista.Count == 3);

    public static void RemoveLanguage(List<string> lista, string lingua) => lista.Remove(lingua);

    public static bool IsUnique(List<string> lista) => lista.Distinct().Count() == lista.Count();

}
