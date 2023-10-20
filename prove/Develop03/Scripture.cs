using System;
using System.Runtime.CompilerServices;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }
    public void HideWords(int amount)
    {
        Random random = new Random();

    }
    public string GetDisplayText()
    {
        
        return $"{_reference.DisplayScripture()} - {_words.Select(word => word.GetDisplayText()).Aggregate((a, b) => a + " " + b)}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}

