using System;
using System.Collections.Generic;

namespace WordCounter.Models
{
  public class RepeatCounter
  {
    private string UserEnteredWord = "";
    private string UserSentence = "";
    private List<string> SplitList = new List<string>();
    private int WordCount = 0;
    public RepeatCounter(string userEnteredWord, string userSentence)
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
    public void WordCheck()
    {
      for(int i = 0; i < SplitList.Count; i++)
      {
        if(String.Compare(UserEnteredWord, SplitList[i]) == 0){
          WordCount++;
        }
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
