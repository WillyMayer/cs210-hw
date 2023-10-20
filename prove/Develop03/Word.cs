using System;

public class Word
{
    private string _words;
    private bool _hidden; 

    public Word(string words)
    {
        _words = words;
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
        if (_hidden)
        {
           return new string('_', _words.Length);
        }
        else
        {
            return _words;
        }
    }
}