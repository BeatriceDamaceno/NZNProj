namespace NZNCaseTest
{
    public class Tests
    {

        [Test]
        public void WordsFoundInArray()
        {
            Assert.That(Globals.foundWords.Count, Is.GreaterThan(0));
        }

        [Test]
        public void WordArrayRepetitionTest()
        {
            Globals.foundWords = NZNCase.WordHandler.RemoveRepeats(Globals.foundWords);

            var repeatedWords = Globals.foundWords.GroupBy(w => w)
                .Where(group => group.Count() > 1)
                .Select(group => group.Key)
                .ToList();

            if (repeatedWords.Count == 0) Assert.Pass();
            else Assert.Fail();

        }

        [Test]
        public void LargestWordInArray()
        {
            if (NZNCase.WordHandler.FindLargestWord(Globals.foundWords) == null) Assert.Fail();
            Assert.Pass();
        }
    }
}