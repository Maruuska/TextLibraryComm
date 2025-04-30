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
    }
}
