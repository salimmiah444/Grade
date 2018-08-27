using Grades1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Grades.Tests
{
    [TestClass]
    public class GradeBookTests
    {
        [TestMethod]
        public void CalculatesHighestGrade()
        {
            var book = new GradeBook();
            book.AddGrade(90f);
            book.AddGrade(50f);
            var stats = book.ComuteStatistics();
            Assert.AreEqual(90f, stats.HighestGrade);
        }
        [TestMethod]    
        public void PassByValue()
        {
            var book = new GradeBook();
            book.Name = "Not Set";
            SetName(book);
            Assert.AreEqual("Name Set", book.Name);

        }

        void SetName(GradeBook book)
        {
            book.Name = "Name Set";

        }
    }
}
