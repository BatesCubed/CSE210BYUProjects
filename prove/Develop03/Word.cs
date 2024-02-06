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
        bool hiddenYN = false;
        if (_isHidden == true)
        {
            hiddenYN = true;
        }
        else if (_isHidden == false)
        {
            hiddenYN = false;
        }

        return hiddenYN;
    }

    public string GetDisplayText()
    {
        string displayTxt = "";
        if (_isHidden == true)
        {
            int wordLen = _text.Length;
            for (int i = 0; i < wordLen; i++)
            {
                displayTxt = displayTxt + "_";
            }
        }
        else
        {
            displayTxt = _text;
        }
        return displayTxt;
    }
}