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
      RepeatCounter testObj = new RepeatCounter(testString, testSentence);
      Assert.AreEqual(testString, testObj.GetUserEnteredWord());
      Assert.AreEqual(testSentence, testObj.GetUserSentence());
    }
    [TestMethod]
    public void GenerateSplitList_Test()
    {
      string testString = "test";
      string testSentence = "This is a test";
      RepeatCounter testObj = new RepeatCounter(testString, testSentence);
      List<string> testList = new List<string>{"This","is","a","test"};
      testObj.GenerateSplitList();
      CollectionAssert.AreEqual(testList, testObj.GetSplitList());
    }
    [TestMethod]
    public void WordCheck_TestSimple()
    {
      string testString = "test";
      string testSentence = "This is a test";
      RepeatCounter testObj = new RepeatCounter(testString, testSentence);
      testObj.GenerateSplitList();
      testObj.WordCheck();
      Assert.AreEqual(1, testObj.GetWordCount());
    }
    [TestMethod]
    public void WordCheck_TestNormal()
    {
      string testString = "test";
      string testSentence = "testib Notest test test istest testeroo test hubalootest";
      RepeatCounter testObj = new RepeatCounter(testString, testSentence);
      testObj.GenerateSplitList();
      testObj.WordCheck();
      Assert.AreEqual(3, testObj.GetWordCount());
    }
  }
}
