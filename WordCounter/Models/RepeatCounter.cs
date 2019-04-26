using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class WordCheck
  {
    private string UserEnteredWord = "";
    private string UserSentence = "";
    private List<string> SplitList = new List<string>();
    private int WordCount = 0;
    public WordCheck(string userEnteredWord, string userSentence)
    {
      UserEnteredWord = userEnteredWord;
      UserSentence = userSentence;
    }
    public void GenerateSplitList()
    {
      string[] tempString = UserSentence.Split(" ");
      for(int i = 0; i < tempString.Length; i++)
      {
        SplitList.Add(tempString[i]);
      }
    }
    public string GetUserEnteredWord()
    {
      return UserEnteredWord;
    }
    public string GetUserSentence()
    {
      return UserSentence;
    }
    public int GetWordCount()
    {
      return WordCount;
    }
    public List<string> GetSplitList()
    {
      return SplitList;
    }
  }
}
