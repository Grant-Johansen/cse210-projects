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
        return _word;
    }

    public void Display ()
    {
        Console.WriteLine($"{_word}");
    }

    
}