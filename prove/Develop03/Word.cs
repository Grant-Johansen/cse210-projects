using System.Web;

class Word
{
    private string _word;
    private bool _hidden;

    public Word (string Word)
    {
        _word = Word;
        _hidden = false;
    }

    public bool IsHidden ()
    {
        return _hidden;
    }

    public void Hide ()
    {
        _hidden = true;
    }

    public string GetWordString()
    {
        string returnString = "";
        if(_hidden)
        {
            for (int i = 0; i < _word.Length; i ++)
            {
                returnString += '_';
            }
        } 
        else
        {
            returnString = _word;
        }
        
        return returnString;
    }

    public void Display ()
    {
        Console.Write($"{GetWordString()} ");
    }


}