using System;
using System.Collections.Generic;

public class Verse
{
    List<Word> _words = new List<Word>();

    public Verse(String verse)
    {
        char[] delimiterChars = {' ', '\t'};
        string[] words = verse.Split(delimiterChars);

        foreach (string wordStr in words)
        {
            Word word = new Word(wordStr);
            _words.Add(word);
        }
    }

    public void HideRandomWord()
    {
        Random randGen = new Random();
        int wordNum = (int)(randGen.NextDouble() * _words.Count);
        _words[wordNum].Hide();
    }

    public void GetText()
    {
        foreach (Word w in _words)
        {
            w.GetText();
            System.Console.Write(" ");
        }

        System.Console.Write("\n");
    }

    public bool AllHidden()
    {
        bool blankedout = true;

        foreach (Word w in _words)
        {
            blankedout = (blankedout && w.isBlank());
        }

        return blankedout;
    }
}