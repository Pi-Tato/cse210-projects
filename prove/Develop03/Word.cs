using System;

public class Word
{
    string _text;
    bool _isHidden;

    public Word(string text)
    {
        _text = text;
    }

    public void Hide()
    {
        _isHidden = true;
        string hiddenWord = "";
        for(int i = 0; i < _text.Length; i++)
        {
            hiddenWord += "_";
        }
        _text = hiddenWord;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
    public string GetDisplayText()
    {
        return _text;
    }
}