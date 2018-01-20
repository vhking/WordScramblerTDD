using NUnit.Framework;


namespace WordScramblerTDD.Test
{
    public class WorkdMatcherTest
    {        
        private readonly WordMatcher _wordMatcher = new WordMatcher();

        [Test]
        public void Match_UnscrambleWord_ReturnsTrue()
        {
            string[] wordList = {"senga","agnes","cat","ball"};
            string[] scrambleWord = {"ensga"};
            
            var matchedWords = _wordMatcher.Match(scrambleWord, wordList);
          
            Assert.True(matchedWords.Count == 2);
            Assert.That(matchedWords[0].ScrambledWord, Is.EqualTo("senga"));
            Assert.That(matchedWords[0].ScrambledWord, Is.EqualTo("agnes"));
        }
    }
}