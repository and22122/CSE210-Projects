using System;
using System.Collections.Generic;

public class Word
{
    private string _text = "";
    private bool _isHidden = false;

    public Word (String word)
    {
        _text = word;
    }

    public void Show()
    {
        _isHidden = false;
    }

    public void Hide()
    {
        _isHidden = true;
    }

    public void GetText()
    {
        if (_isHidden)
        {
            for (int i = 0; i < _text.Length; i ++)
            {
                System.Console.Write("_");
            }
        }
        else
        {
            System.Console.Write(_text);
        }
    }

    public bool isBlank()
    {
        return _isHidden;
    }
}