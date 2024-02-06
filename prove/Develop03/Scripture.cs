
public class Scripture
{
    private Reference _reference;
    private List<Word> _words = new List<Word>{};

    public Scripture(Reference Reference,string text)
    {
        _reference = Reference;
        string fullTxt = text;
        string[] fullStr = fullTxt.Split(" ");
        foreach (string word in fullStr)
        {
            Word indWord = new Word(word);
            _words.Add(indWord);
        }

    }

    public void HideRandomWords(int numberToHide)
    {
        int randCount = 0;
        int shownWordCount = 0;
        foreach (Word word in _words)
        {
            bool wordHidden = word.IsHidden();
            if (wordHidden == false)
            {
                shownWordCount += 1;
            }
            else
            {
                continue;
            }
        }
        if (shownWordCount < 3)
        {
            numberToHide = shownWordCount;
        }
        Random randHide = new Random();
        while (randCount != numberToHide)
        {
            int hidePos = randHide.Next(0,_words.Count());
            if (_words[hidePos].IsHidden() == true)
            {
                continue;
            }
            else if (_words[hidePos].IsHidden() == false)
            {
                randCount += 1;
                _words[hidePos].Hide();
            }
        }

    }

    public void RevealAll()
    {
        foreach(Word word in _words)
        {
            word.Show();
        }
    }
    public string GetDisplayText()
    {
        string hidWordsString = "";
        foreach (Word word in _words)
        {
            string displayTxt = word.GetDisplayText();
            hidWordsString += displayTxt + " ";
        }
        hidWordsString = hidWordsString.Trim();
        return hidWordsString;
    }

    public bool IsCompletelyHidden()
    {
        bool wordHidden = true;
        foreach (Word word in _words)
        {
            wordHidden = word.IsHidden();
            if (wordHidden == false)
            {
                break;
            }
            else
            {
                wordHidden = true;
            }
        }
        return wordHidden;
    }
}