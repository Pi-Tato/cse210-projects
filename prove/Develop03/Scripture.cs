using System;

public class Scripture
{
    Reference _refrerence;
    List<Word> wordsList = new List<Word>();
    int wordsLeft;

    public Scripture(Reference reference, string text)
    {
        _refrerence = reference;
        string[] words = text.Split(" ");
        foreach(string w in words)
        {
            Word word = new Word(w);
            wordsList.Add(word);
        }
        wordsLeft = wordsList.Count();
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        for(int i = 0; i < numberToHide; i++) 
        {
            int index = random.Next(0, wordsList.Count());
            if(wordsLeft < numberToHide)
            {
                numberToHide = wordsLeft;
            }
            if (!wordsList[index].IsHidden())
            {
                wordsList[index].Hide();
                wordsLeft--;
            }else
            {
                foreach(Word word in wordsList)
                {
                    if(!word.IsHidden())
                    {
                        word.Hide();
                        wordsLeft--;
                        break;
                    }
                }
            }
        }
    }

    public string GetDisplayText()
    {
        string text = "";
        foreach(Word word in wordsList)
        {
            text += $"{word.GetDisplayText()} ";
        }
        return text;
    }

    public bool IsCompletelyHidden()
    {
        return wordsLeft == 0;
    }
}