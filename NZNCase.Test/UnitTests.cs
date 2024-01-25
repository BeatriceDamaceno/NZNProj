namespace NZNCaseTest
{
    public class Tests
    {
        [Test]
        public void WordsFoundInArray()
        {
            string[] foundWords = NZNCase.WordFinder.FindWords(NZNCase.Globals.targetString);
            Assert.That(foundWords.Length, Is.GreaterThan(0));
        }


    }
}