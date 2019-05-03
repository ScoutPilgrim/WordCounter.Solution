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
    private int _id;
    private static List<RepeatCounter> _instances = new List<RepeatCounter> {};
    public RepeatCounter(string userEnteredWord, string userSentence)
    {
      UserEnteredWord = userEnteredWord;
      UserSentence = userSentence;
      this.GenerateSplitList();
      this.WordCheck();
      _instances.Add(this);
      _id = _instances.Count;
    }
    public static RepeatCounter Find(int searchId)
    {
      return _instances[searchId - 1];
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
    public static List<RepeatCounter> GetAll()
    {
      return _instances;
    }
    private void GenerateSplitList()
    {
      string[] tempString = UserSentence.Split(" ");
      for(int i = 0; i < tempString.Length; i++)
      {
        SplitList.Add(tempString[i]);
      }
    }
    private void WordCheck()
    {
      for(int i = 0; i < SplitList.Count; i++)
      {
        if(String.Compare(UserEnteredWord, SplitList[i]) == 0){
          WordCount++;
        }
      }
    }
    public int GetId()
    {
      return _id;
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
