using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using Anagram.Models;
using System;

namespace Anagram.Tests
{
  [TestClass]
  public class AnagramTest
  {
    [TestMethod]
    public void GetWord_FetchTheWord_Word()
    {
      //arrange
      string userWord = "word";
      List<string> fakeList = new List<string>{};
      AnagramChecker newAnagram = new AnagramChecker(userWord, fakeList);

      //act
      string result = newAnagram.GetWord();

      //assert
      Assert.AreEqual(userWord, result);
    }

    [TestMethod]
    public void SetWord_SetTheWord_void()
    {
      //arrange
      string userWord = "word";
      string newWord = "hello";
      List<string> fakeList = new List<string>{};
      AnagramChecker newAnagram = new AnagramChecker(userWord, fakeList);

      //act
      newAnagram.SetWord(newWord);

      //assert
      Assert.AreEqual(newWord, newAnagram.GetWord());
    }

    [TestMethod]
    public void GetList_FetchList_List()
    {
      //arrange
      string fakeWord = " ";
      List<string> userList = new List<string>{"Beard","Bread","Rad"};
      AnagramChecker newAnagram = new AnagramChecker(fakeWord, userList);
      //act
      List<string> result = newAnagram.GetList();
      //assert
      CollectionAssert.AreEqual(result, userList);
    }

    [TestMethod]
    public void SetList_SetTheList_void()
    {
      //arrange
      string fakeWord = " ";
      List<string> fakeList = new List<string>{};
      List<string> newList = new List<string>{"Beard","Bread","Rad"};
      AnagramChecker newAnagram = new AnagramChecker(fakeWord, fakeList);
      //act
      newAnagram.SetList(newList);
      //assert
      CollectionAssert.AreEqual(newList, newAnagram.GetList());
    }

    [TestMethod]
    public void GetReturnList_FetchTheReturnList_List()
    {
      //arrange
      string fakeWord = "Bread";
      List<string> fakeList = new List<string>{"Bread", "Dreab", "Rad"};
      List<string> fakeReturnedList = new List<string>{};
      AnagramChecker newAnagram = new AnagramChecker(fakeWord, fakeList);

      //act
      List<string> returnedList = newAnagram.GetReturnList();

      //assert
      CollectionAssert.AreEqual(returnedList, fakeReturnedList);
    }

    [TestMethod]
    public void SetReturnList_SetTheReturnList_List()
    {
      //arrange
      string fakeword = "Beard";
      List<string> fakeList = new List<string>{"Dreab","Bread","Rad"};
      List<string> returnList = new List<string>{"Dreab","Bread"};
      AnagramChecker newAnagram = new AnagramChecker(fakeword, fakeList);
      //act
      newAnagram.SetReturnList();

      //assert
      CollectionAssert.AreEqual(returnList, newAnagram.GetReturnList());
    }

  }
}
