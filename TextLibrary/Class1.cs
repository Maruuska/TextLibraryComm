namespace TextLibrary
{
    public class Class1
    {
        // Дунаева М.
        // Сравнение двух слов 
        // входные данные: два слова типа string
        // выходные данные: значение bool 
        public static bool WordsEqual(string word1, string word2)
        {
            // если строки пустые то они равны
            if (string.IsNullOrEmpty(word1) && string.IsNullOrEmpty(word2))
            {
                return true;
            }
            // если только одна строка пустая, то они не равны
            if (string.IsNullOrEmpty(word1) || string.IsNullOrEmpty(word2))
            {
                return false;
            }

            // преобразование к нижнему регистру обоих слов
            word1 = word1.ToLower().Trim();
            word2 = word2.ToLower().Trim();

            // сравнение двух слов
            return string.Equals(word1, word2);
        }


        // Трудникова К.
        // Поиск слова в строке
        // входные данные: текст и слово типа string
        // выходные данные: значение bool
        public static bool SearchWord(string text, string word)
        {
            
            //если строки пустые, то выбрасывается исключение
            if (text == "" || word == "")
            {
                throw new ArgumentNullException("Строки не должны быть пустыми!");
            }
            // преобразование к нижнему регистру
            text = text.ToLower().Trim();
            word = word.ToLower().Trim();

            //поиск слова
            if (text.Contains(word))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /* Трудникова К.
        Замена слова в строке
        входные данные: текст и два слова типа string
        выходные данные: значение string */

        public static string ChangeWord(string text, string word1, string word2)
        {

            //если строки пустые, то выбрасывается исключение
            if (text == "" || word1 == "" || word2 == "")
            {
                throw new ArgumentNullException("Строки не должны быть пустыми!");
            }
            // преобразование к нижнему регистру
            text = text.ToLower().Trim();
            word1 = word.ToLower().Trim();
            word2 = word.ToLower().Trim();

            //замена слова
            text.Replace(word1, word2) ;

            //возврат строки
            return text;
        }


    }
}
