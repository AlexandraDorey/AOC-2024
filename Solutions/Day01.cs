public static partial class Solves2024
{
    public static string Day1Part1(string input)
    {

        List<int> left = new();
        List<int> right = new();
        foreach (var line in input.Split("\n"))
        {
            var parts = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var a = int.Parse(parts[0]);
            var b = int.Parse(parts[1]);
            left.Add(a);
            right.Add(b);
        }

        left.Sort();
        right.Sort();

        int total = 0;
        for (int x = 0; x < left.Count; x++)
        {
            total += Math.Abs(right[x] - left[x]);
        }

        return total.ToString();
    }


    public static string Day1Part2(string input)
    {
        List<int> left = new();
        Dictionary<int, int> right = new();
        foreach (var line in input.Split("\n"))
        {
            var parts = line.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var a = int.Parse(parts[0]);
            var b = int.Parse(parts[1]);
            left.Add(a);
            if (!right.ContainsKey(b))
            {
                right[b] = 1;
            }
            else
            {
                right[b]++;
            }
        }
        int total = 0;
        foreach (int id in left)
        {
            if (right.ContainsKey(id))
            {
                Console.WriteLine($"id: {id} * {right[id]}");
                total += right[id] * id;
            }
        }

        return total.ToString();
    }

}