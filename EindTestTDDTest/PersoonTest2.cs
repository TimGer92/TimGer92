using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using EindTestTDD2;

namespace EindTestTDDTest
{
    [TestClass]
    public class PersoonTest
    {
        [TestMethod]
        public void PersoonMoetMinstens1VoornaamBevattenControleOK()
        {
            new Persoon(new List<string> { "Eric" });
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void PersoonMoetMinstens1VoornaamBevattenControlenNietOK()
        {
            new Persoon(new List<string>());
        }

        [TestMethod]
        public void PersoonKanNiet2KeerDezelfdeNaamHebbenOK()
        {
            new Persoon(new List<string> { "Eric", "Paul", "Albert" });
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void PersoonKanNiet2KeerDezelfdeNaamHebben()
        {
            new Persoon(new List<string> { "Eric", "Paul", "Albert", "Eric" });
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void VoornaamMoetMinstens1TekenBevatten()
        {
            new Persoon(new List<string> { string.Empty });
        }

        [TestMethod, ExpectedException(typeof(ArgumentException))]
        public void VoornaamBevatGeenSpaties()
        {
            new Persoon(new List<string> { " " });
        }

        [TestMethod]
        public void VoornaamMetMinstens1TekenOK()
        {
            new Persoon(new List<string> { "a" });
        }

        
        [TestMethod]
        public void ToStringMoetVoornamenTeruggevenMetSpaties()
        {
            List<string> voornamen = new List<string> () { "Eric", "Frans", "Tom" };
            Persoon persoon = new Persoon(voornamen);
            var output = String.Join(" ", voornamen);
            Assert.AreEqual(output,persoon.ToString());
        }
        

    }
}
