using System;
using System.Runtime.InteropServices;

public class Reference
{
    private string _book;
    private string _chapter;
    private string _verses;


    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verses = verse;
    }

    public string DisplayScripture()
    {
        string scripture = $"{_book} {_chapter}:{_verses} ";
        return scripture;
    }
}

