using System;
using System.Collections.Generic;
using System.Linq;

public static class Languages
{
    public static List<string> NewList()
    {
        return new List<string>();
    }

    public static List<string> listLanguages = new List<string>() { "C#", "Clojure", "Elm" };

    public static List<string> GetExistingLanguages()
    {
        return listLanguages;
    }

    public static List<string> AddLanguage(List<string> languages, string language)
    {
        languages.Add(language);
        return languages;
    }

    public static int CountLanguages(List<string> languages)
    {
        return languages.Count;
    }

    public static bool HasLanguage(List<string> languages, string language)
    {
        return languages.Contains(language);
    }

    public static List<string> ReverseList(List<string> languages)
    {
        var newlist = NewList();
        languages.Reverse();
        foreach (string  item in languages)
        {
            newlist.Add(item);
        }
        return newlist;

    }

    public static bool IsExciting(List<string> languages)
    {
        if (IsFirstC(languages) | IsSecondOrThirdC(languages))  return true ;
        
        return false;
    }

    public static bool IsFirstC(List<string> languages)
    {
        if (CountLanguages(languages) > 0 && languages[0] == "C#") return true;
        return false;
    }

    public static bool IsSecondOrThirdC(List<string> languages)
    {
        if (CountLanguages(languages)>=2 && CountLanguages(languages)<=3 && languages[1] == "C#") return true;
        return false;
    }
    public static List<string> RemoveLanguage(List<string> languages, string language)
    {
        languages.Remove(language);
        return languages;
    }

    public static bool IsUnique(List<string> languages)
    {
        foreach (var item in languages.GroupBy(x => x))
        {
            if (item.Count() > 1) return false;
        }
        return true;
    }
}
