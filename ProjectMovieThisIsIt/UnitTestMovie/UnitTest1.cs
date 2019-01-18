using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectMovieThisIsIt;

namespace UnitTestMovie
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestConstructorMovie()
        {
            Movie m = new Movie(27,"Krecik",1999,"Karolina Dudzińska",4.0,15,"bla bla bla");
            Assert.AreEqual(27, m.IdMovie);
            Assert.AreEqual("Krecik", m.Name);
            Assert.AreEqual(1999, m.Year);
            Assert.AreEqual("Karolina Dudzińska", m.Director);
            Assert.AreEqual(4.0, m.AvgRate);
            Assert.AreEqual(15, m.NumberOfRates);
            Assert.AreEqual("bla bla bla", m.Description);
        }
        [TestMethod]
        public void TestListMovie()
        {
            Movie m = new Movie(27, "Krecik", 1999, "Karolina Dudzińska", 4.0, 15, "bla bla bla");
            LoM l = new LoM();
            l.Dodaj(m);
            Assert.AreEqual(1, l.Lista.Count);
        }
        [TestMethod]
        [ExpectedException(typeof(NameException))]
        public void TestNameExeption()
        {
            Movie m = new Movie(27, "", 1999, "Karolina Dudzińska", 4.0, 15, "bla bla bla");
            Assert.IsInstanceOfType("", typeof(string));
        }
    }
}
