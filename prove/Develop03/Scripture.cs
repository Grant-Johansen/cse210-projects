class Scripture
{
    private List <Word> _words;
    
    private ScriptureReference _reference; 

    public Scripture(string name, int chapter, int verse, string text)
    {
        _words = ConvertToWordList(text);
        _reference = new ScriptureReference(name, chapter, verse); 
    }
    public Scripture (string name, int chapter, int startVerse, int endVerse, string text)
    {
        _words = ConvertToWordList(text);
        _reference = new ScriptureReference(name, chapter, startVerse, endVerse); 
    }
    
    /****************************
    * ConverToWordList() - This method will recieve a string paramter,
    * which is a paragraph of text. It will split that text into words 
    * and add those words to a List<Word> and return the list
    *******************************/
    private List<Word> ConvertToWordList (string text)
    {
        List<Word> tempWordList = new List<Word>();
        string[] tempWords = text.Split(' ');
        foreach(string w in tempWords)
        {
            Word tempWord = new Word(w);
            tempWordList.Add(tempWord);
        }
        
        return tempWordList;
    }
    public bool HideSomeWords()
    {
        Random random = new Random();
        int randomWord = random.Next(1,_words.Count());
        while (_words[randomWord].IsHidden()== true)
        {
            randomWord = random.Next(0,_words.Count());
        }
        _words[randomWord].Hide();

        return true; 
    }
    public void ShowScripture()
    {
        _reference.DisplayScriptureReference();
        foreach (Word word in _words)
        {
            word.Display();
        }

    }

    public int NumberOfHiddenWords()
    {
        int numHiddenWords = _words.Count()+1;
        foreach (Word word in _words)
        {
          if (word.IsHidden() == true)
          {
              numHiddenWords -=1; 
            }
        }
        return numHiddenWords;
    }

}