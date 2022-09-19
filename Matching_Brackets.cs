public static class MatchingBrackets
{
    private static readonly string[] Brackets = new[] { "()", "[]", "{}" };
    public static bool IsPaired(string input)
    {
        var sequence =
            from c in input
            let pair = Brackets.FirstOrDefault(p => p.Contains(c))
            where pair != null
            let close = pair[1] == c
            select (c, pair, close);
        var stack = new Stack<string>();
        foreach (var (c, pair, close) in sequence)
        {
            if (close)
            {
                if (!stack.TryPop(out var popped) || popped[1] != c)
                    return false;
            }
            else
            {
                stack.Push(pair);
            }
        }
        return stack.Count == 0;
    }
}