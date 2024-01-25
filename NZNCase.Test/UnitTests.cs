namespace NZNCaseTest
{
    public class Tests
    {
        [Test]
        public void WordsFoundInArray()
        {
           List<string> foundWords = NZNCase.WordHandler.FindWords(NZNCase.Globals.targetString);
            Assert.That(foundWords.Count, Is.GreaterThan(0));
        }

        [Test]
        public void WordArrayRepetitionTest()
        {
            List<string> foundWords = NZNCase.WordHandler.FindWords(NZNCase.Globals.targetString);
            foundWords = NZNCase.WordHandler.RemoveRepeats(foundWords);

            var repeatedWords = foundWords.GroupBy(w => w)
                .Where(group => group.Count() > 1)
                .Select(group => group.Key)
                .ToList();

            if (repeatedWords.Count == 0) Assert.Pass();
            else Assert.Fail();

        }
    }
}