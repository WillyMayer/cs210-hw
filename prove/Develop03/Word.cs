using System;

public class Word
{
    private string _words;
    private bool _hidden; 

    public Word(string text)
    {
        _words = text;
        _hidden = false;
    }

    public void Hide()
    {
        _hidden = true;
    }
    public void Show()
    {
        _hidden = false;
    }

    public bool IsHidden()
    {
        return _hidden;
    }
    public string GetDisplayText()
    {
        return _hidden ? new string('_', _words.Length) : _words;
    }
}