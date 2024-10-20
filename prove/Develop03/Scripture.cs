using System;
using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using Microsoft.VisualBasic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;

        List<Word> words = new List<Word>();

        string[] strings = text.Split(' ');

        foreach (var i in strings)
        {
            string newString = i.ToString();
            
            Word newWord = new Word(newString);

            words.Add(newWord);
        }

        _words = words;
    }

    public void HideRandomWords(int numberToHide)
    {
        int hiddenWordCount = 0;

        if (numberToHide >= _words.Count())
        {
            foreach (Word i in _words)
            {
                i.Hide();
            }
        }

        else
        {
            foreach (Word i in _words)
            {
                if (i.IsHidden() == true)
                {
                    hiddenWordCount += 1;
                }
            }

            if (hiddenWordCount < numberToHide)
            {
                int remainingNumberToHide = numberToHide - hiddenWordCount;

                for (int i = 0; i < remainingNumberToHide; i++)
                {
                    bool complete = false;
                    
                    do
                    {
                        Random random = new Random();

                        int randomNumber = random.Next(0, _words.Count());

                        if (_words[randomNumber].IsHidden() == false)
                        {
                            _words[randomNumber].Hide();

                            complete = true;
                        }

                    } while (complete == false);
                }
            }
        }
    }
    
    public string GetDisplayText()
    {
        List<string> strings = new List<string>();

        foreach (Word i in _words)
        {
            string word = i.GetDisplayText();

            strings.Add(word);
        }

        string text = String.Join(" ", strings);

        return text;
    }

    public bool IsCompletelyHidden()
    {
        bool isCompletelyHidden;

        int hiddenWordCount = 0;
        
        foreach (Word i in _words)
        {
            if (i.IsHidden() == true)
            {
                hiddenWordCount += 1;
            }
        }

        if (hiddenWordCount < _words.Count())
        {
            isCompletelyHidden = false;
        }
        
        else
        {
            isCompletelyHidden = true;
        }

        return isCompletelyHidden;
    }
}