using System;


namespace LINQAssignment02.Helpers
{
    public class StringCaseInsensitiveComparer : IComparer<string>
    {
        public int Compare(string? x, string? y)
        {
            return string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
        }
    }
}
