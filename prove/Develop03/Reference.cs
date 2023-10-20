using System;
using System.Runtime.InteropServices;

public class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;


    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public string DisplayScripture()
    {
        string scripture = $"{_book} {_chapter} {_verse}";
        return scripture;
    }
}

