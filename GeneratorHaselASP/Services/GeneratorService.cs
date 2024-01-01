using GeneratorHaselASP.Models;

namespace GeneratorHaselASP.Services
{
    public class GeneratorService : IGeneratorService
    {
        TableOfChars TableOfChars = new TableOfChars();
        private string result;
        public string GeneratePassword(int LongPassword, bool specialsPlChars)
        {
            Random rnd = new Random();
            var Password = new List<string>();
            if (specialsPlChars == true)
            {
                for (int i = 0; i < LongPassword; i++)
                {
                    int RandomTable = rnd.Next(1, 7);
                    if (RandomTable == 1)
                    {
                        Password.Add(TableOfChars.alphabet[rnd.Next(0, TableOfChars.alphabet.Count())]);
                    }
                    if (RandomTable == 2)
                    {
                        Password.Add(TableOfChars.alphabetLitle[rnd.Next(0, TableOfChars.alphabetLitle.Count())]);
                    }
                    if (RandomTable == 3)
                    {
                        Password.Add(TableOfChars.alphabetNumeric[rnd.Next(0, TableOfChars.alphabetNumeric.Count())]);
                    }
                    if (RandomTable == 4)
                    {
                        Password.Add(TableOfChars.alphabetSpecial[rnd.Next(0, TableOfChars.alphabetSpecial.Count())]);
                    }
                    if (RandomTable == 5)
                    {
                        Password.Add(TableOfChars.alphabetSpecial2[rnd.Next(0, TableOfChars.alphabetSpecial2.Count())]);
                    }
                    if (RandomTable == 6)
                    {
                        Password.Add(TableOfChars.plCharsBig[rnd.Next(0, TableOfChars.plCharsBig.Count())]);
                    }
                    if (RandomTable == 7)
                    {
                        Password.Add(TableOfChars.plChars[rnd.Next(0, TableOfChars.plChars.Count())]);
                    }
                }
                this.result = string.Join("", Password);
                return this.result;
            }
            else
            {
                for (int i = 0; i < LongPassword; i++)
                {
                    int RandomTable = rnd.Next(1, 5);
                    if (RandomTable == 1)
                    {
                        Password.Add(TableOfChars.alphabet[rnd.Next(0, TableOfChars.alphabet.Count())]);
                    }
                    if (RandomTable == 2)
                    {
                        Password.Add(TableOfChars.alphabetLitle[rnd.Next(0, TableOfChars.alphabetLitle.Count())]);
                    }
                    if (RandomTable == 3)
                    {
                        Password.Add(TableOfChars.alphabetNumeric[rnd.Next(0, TableOfChars.alphabetNumeric.Count())]);
                    }
                    if (RandomTable == 4)
                    {
                        Password.Add(TableOfChars.alphabetSpecial[rnd.Next(0, TableOfChars.alphabetSpecial.Count())]);
                    }
                    if (RandomTable == 5)
                    {
                        Password.Add(TableOfChars.alphabetSpecial2[rnd.Next(0, TableOfChars.alphabetSpecial2.Count())]);
                    }
                }
                this.result = string.Join("", Password);
                return this.result;
            }



        }
    }
}
