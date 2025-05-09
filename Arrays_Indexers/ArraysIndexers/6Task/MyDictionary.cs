namespace _6Task
{
    internal class MyDictionary
    {
        private Translator[] translateWords;

        public MyDictionary(Translator[] translateWords)
        {
            this.translateWords = translateWords;
        }

        //доступ за числовим індексом
        public Translator this[int index]
        {
            get
            {
                if (index >= 0 && index < translateWords.Length) { return translateWords[index]; }
                else { Console.WriteLine("Вихід за межі індексу."); return null; }
            }
        }

        // доступ за українським словом
        public string this[string ukr]
        {
            get
            {
                foreach (var pair in translateWords)
                {
                    if (pair.Ukr.Equals(ukr, StringComparison.OrdinalIgnoreCase))
                        return pair.Eng;
                }
                return $"Слово {ukr} не знайдено у словнику.";
            }
        }

        public void ShowAllDictionary()
        {
            foreach (var pair in translateWords)
            {
                pair.ShowTranslateWord();
            }
        }
    }
}
