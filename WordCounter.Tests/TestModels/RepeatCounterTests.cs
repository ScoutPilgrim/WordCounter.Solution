using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounter.Models;
using System;
using System.Collections.Generic;

namespace WordCounter.Tests
{
  [TestClass]
  public class RepeatCounterTest
  {
    [TestMethod]
    public void Constructor_Test()
    {
      string testString = "test";
      string testSentence = "This is a test";
      WordCheck testObj = new WordCheck(testString, testSentence);
      Assert.AreEqual(testString, testObj.GetUserEnteredWord());
      Assert.AreEqual(testSentence, testObj.GetUserSentence());
    }
    [TestMethod]
    public void GenerateSplitList_Test()
    {
      string testString = "test";
      string testSentence = "This is a test";
      WordCheck testObj = new WordCheck(testString, testSentence);
      List<string> testList = new List<string>{"This","is","a","test"};
      testObj.GenerateSplitList();
      CollectionAssert.AreEqual(testList, testObj.GetSplitList());
    }
  }
}
