using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EindTestTDD2
{
    public class Persoon
    {
        private List<string> Voornamen;
        public Persoon(List<string> voornamen)
        {
            this.Voornamen = voornamen;

            if (voornamen.Count() == 0)
            {
                throw new ArgumentException();
            }
            if (voornamen.Contains(string.Empty))
            {
                throw new ArgumentException();
            }
            if (voornamen.Contains(" "))
            {
                throw new ArgumentException();
            }

            if (voornamen.Distinct().Count() != voornamen.Count())
            {
                throw new ArgumentException();
            }
        }

        public override string ToString()
        {
            var voornamenSpaties = String.Join(" ", Voornamen);
            return voornamenSpaties.ToString(); 
        }
    }
}
