using Microsoft.VisualStudio.TestTools.UnitTesting;
using Anagram;

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
  }
}
