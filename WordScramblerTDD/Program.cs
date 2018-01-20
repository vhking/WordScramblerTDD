using System;

namespace WordScramblerTDD
{
    class Program
    {
        private static readonly FileReader _fileReader = new FileReader();
        private static readonly WordMatcher _wordMatcher = new WordMatcher();
        static void Main(string[] args)
        {
            try
            {
                bool continueWordScrambler = true;
                do
                {
                    
               
                Console.Write(Constants.OptionsToEnterScrambledWords);
                var options = Console.ReadLine() ?? string.Empty;

                switch (options.ToUpper())
                {
                    case Constants.File:
                        Console.Write(Constants.EnterScrambledWordsWithFile);
                        ExecuteScrambledWordsInFile();
                        break;
                    case Constants.Manual:
                        Console.Write(Constants.EnterScrambledWords);
                        EcexuteScrambledWords();
                        break;                    
                    default:
                        Console.WriteLine(Constants.EnterScrambledWordsNotRecognized);
                        break;
                }

                var continueWordDecision = string.Empty;
                do
                {
                    Console.WriteLine(Constants.OptionOnContinuingTheProgram);
                    continueWordDecision = (Console.ReadLine() ?? string.Empty);
                }while(
                    !continueWordDecision.Equals(Constants.Yes, StringComparison.OrdinalIgnoreCase) &&
                    !continueWordDecision.Equals(Constants.No, StringComparison.OrdinalIgnoreCase));

                    continueWordScrambler = continueWordDecision.Equals(Constants.Yes, StringComparison.OrdinalIgnoreCase);
                }while(continueWordScrambler); 
            }
            catch (System.Exception ex)
            {
                
                Console.WriteLine(Constants.ErrorProgramWillBeTerminated + ex.Message);
            }
          
        }

        private static void ExecuteScrambledWordsInFile()
        {
            throw new NotImplementedException();
        }

        private static void EcexuteScrambledWords()
        {
            throw new NotImplementedException();
        }
    }
}
