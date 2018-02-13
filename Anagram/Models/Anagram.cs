using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;

namespace Anagram.Models
{
  public class AnagramChecker
  {
    private string _word;
    private List<string> _wordList;
    private List<string> _returnWordList;

    public AnagramChecker(string word, List<string> wordList)
    {
      _word = word.ToLower();
      _wordList = wordList;
      _returnWordList = new List<string>{};
    }

    public string GetWord()
    {
      return _word;
    }

    public void SetWord(string word)
    {
      string lowerWord = word.ToLower();
      _word = lowerWord;
    }

    public List<string> GetList()
    {
      return _wordList;
    }

    public void SetList(List<string> wordList)
    {
      _wordList = wordList;
    }

    public List<string> GetReturnList()
    {
      return _returnWordList;
    }

    public void SetReturnList()
    {
      char[] wordArray = _word.ToCharArray();
      List<string> returnList = new List<string>{};
      Array.Sort(wordArray);
      string baseWord = string.Join("", wordArray);
      foreach (string userWord in _wordList)
      {
        string lowerUserWord = userWord.ToLower();
        char[] checkArray = lowerUserWord.ToCharArray();
        Array.Sort(checkArray);
        string checkWord = string.Join("", checkArray);
        if (baseWord == checkWord)
        {
          returnList.Add(userWord);
        }
      }
      _returnWordList = returnList;
    }

    public void SetReturnListPartial()
    {
      char[] wordArray = _word.ToCharArray();
      List<string> returnList = new List<string>{};
      Array.Sort(wordArray);
      //string baseWord = string.Join("", wordArray);
      foreach (string userWord in _wordList)
      {
        string lowerUserWord = userWord.ToLower();
        char[] checkArray = lowerUserWord.ToCharArray();
        Array.Sort(checkArray);
        int i = 0;
        foreach (char letter in checkArray)
        {
          if (wordArray.Contains(letter))
          {
            i++;
          }
        }
        if (i == checkArray.Count())
        {
          returnList.Add(userWord);
        }
      }
      _returnWordList = returnList;
    }

  }
}
