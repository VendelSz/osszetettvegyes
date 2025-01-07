namespace osszetettvegyes;

class Program
{
    static void Main()
    {
        // 1
        List<int> numbers = new List<int>();

        // 2
        for (int i = 1; i <= 10; i++)
        {
            numbers.Add(i);
        }

        //3
        int Square(int num) => num * num;

        // 4
        List<int> squaredNumbers = numbers.Select(Square).ToList();

        // 5
        int SumOfList(List<int> list) => list.Sum();

        // 6
        List<int> GetEvenNumbers(List<int> list) => list.Where(x => x % 2 == 0).ToList();

        // 7
        List<int> MultiplyListByNumber(int multiplier, List<int> list) => list.Select(x => x * multiplier).ToList();

        // 8
        List<int> MergeLists(List<int> list1, List<int> list2)
        {
            List<int> merged = new List<int>();
            int maxLength = Math.Max(list1.Count, list2.Count);
            for (int i = 0; i < maxLength; i++)
            {
                if (i < list1.Count) merged.Add(list1[i]);
                if (i < list2.Count) merged.Add(list2[i]);
            }
            return merged;
        }

        // 9
        int GetMaxElement(List<int> list) => list.Max();

        // 10
        int GetMinElement(List<int> list) => list.Min();

        // 11
        bool AreAllEven(List<int> list) => list.All(x => x % 2 == 0);

        // 12
        List<int> GetEverySecondElement(List<int> list)
        {
            List<int> result = new List<int>();
            for (int i = 1; i < list.Count; i += 2)
            {
                result.Add(list[i]);
            }
            return result;
        }

        // 13
        List<int> ReverseList(List<int> list) => list.AsEnumerable().Reverse().ToList();

        // 14
        List<string> CapitalizeStrings(List<string> list) => list.Select(s => char.ToUpper(s[0]) + s.Substring(1).ToLower()).ToList();

        // 15
        List<string> GetStringsLongerThanFive(List<string> list) => list.Where(s => s.Length > 5).ToList();
    }
}

