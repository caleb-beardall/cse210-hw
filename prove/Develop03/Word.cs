using System;
using System.Collections.Concurrent;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public bool IsHidden()
    {
        bool isHidden;
        
        if (_isHidden == true)
        {
            isHidden = true;
        }
        else
        {
            isHidden = false;
        }

        return isHidden;
    }

    public string GetDisplayText()
    {
        string text;
        
        if (_isHidden == false)
        {
            text = _text;
        }
        else
        {
            string underscoreString = new string('_', _text.Length);

            text = underscoreString;
        }
        
        return text;
    }
}