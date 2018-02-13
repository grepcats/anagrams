using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Anagram.Models
{
  public class AnagramChecker
  {
    private string _word;
    private List<string> _wordList;
    private List<string> _returnWordList;

    public AnagramChecker(string word, List<string> wordList)
    {
      _word = word;
      _wordList = wordList;
      _returnWordList = new List<string>{};
    }

    public string GetWord()
    {
      return _word;
    }

    public void SetWord(string word)
    {
      _word = word;
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

  }
}
