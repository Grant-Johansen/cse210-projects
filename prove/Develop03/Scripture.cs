class Scripture
{
    private List <Word> _words;
    // TODO - ADD scripture Reference
    public Scripture(string name, int chapter, int verse, string text)
    {
        _words = ConvertToWordList(text);
    }
    public Scripture (string name, int chapter, int startVerse, int endVerse, string text)
    {
        
    }
    //ADD Scripture ScriputreReference
    // public Scripture (ScriputreReference ref, string text)
    // {
        
    // }


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
    // public bool HideSomeWords()
    // {
        
    // }
    public void ShowScripture()
    {
        foreach (Word word in _words)
        {
            word.Display();
        }

    }
    // public GetScriputreReference()
    // {
        
    // }
    // string NumberOfHiddenWords()
    // {
        
    // }

}