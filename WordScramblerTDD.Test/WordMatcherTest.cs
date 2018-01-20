using NUnit.Framework;


namespace WordScramblerTDD.Test
{
    public class WordMatcherTest
    {        
        private readonly WordMatcher _wordMatcher = new WordMatcher();

        [Test]
        public void Match_UnscrambleWord_ReturnsTrue()
        {
            string[] wordList = {"senga","agnes","cat","ball"};
            string[] scrambleWords = {"ensga"};
            
            var matchedWords = _wordMatcher.Match(scrambleWords, wordList);
          
            Assert.True(matchedWords.Count == 2);
            Assert.That(matchedWords[0].ScrambledWord, Is.EqualTo("ensga"));
            Assert.That(matchedWords[0].Word, Is.EqualTo("senga"));
            Assert.That(matchedWords[1].Word, Is.EqualTo("agnes"));
        }
    }
}