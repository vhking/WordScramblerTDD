using System;
using System.Collections.Generic;
using WordScramblerTDD.Data;

namespace WordScramblerTDD
{
    public class WordMatcher
    {
        public List<MacthedWord> Match(string[] scrambleWords, string[] wordList)
        {
            var matchedWords = new List<MacthedWord>();

            foreach (var scrambleWord in scrambleWords)
            {
                foreach (var word in wordList)
                {
                    if (scrambleWord.Equals(word, StringComparison.OrdinalIgnoreCase))
                    {
                        matchedWords.Add(BuildMatchedWord(scrambleWord, word));
                    }else
                    {
                        var scrambleWordArray = scrambleWord.ToCharArray();
                        var wordArray = word.ToCharArray();

                        Array.Sort(scrambleWordArray);
                        Array.Sort(wordArray);

                        var sortedScrambledWord = new string(scrambleWordArray);
                        var sortedWord = new string(wordArray);

                        if (sortedScrambledWord.Equals(sortedWord, StringComparison.OrdinalIgnoreCase))
                        {
                            matchedWords.Add(BuildMatchedWord(scrambleWord, word));
                        }
                    }
                }
                
            }
            return matchedWords;
        }

        private MacthedWord BuildMatchedWord(string scrambleWord, string word)
        {
            MacthedWord macthedWord = new MacthedWord
            {
                ScrambledWord = scrambleWord,
                Word = word
            };

            return macthedWord;
        }
    }
}