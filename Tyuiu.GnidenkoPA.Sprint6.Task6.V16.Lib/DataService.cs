using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.GnidenkoPA.Sprint6.Task6.V16.Lib
{
    public class DataService : ISprint6Task6V16
    {
        public string CollectTextFromFile(string path)
        {
            string res = File.ReadAllText(path);

            var wordsWithB = res.Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                                         .Where(word => word.Contains('b'));
            res = string.Join(" ", wordsWithB);

            return res;
        }
    }
}