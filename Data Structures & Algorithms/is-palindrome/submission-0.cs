public class Solution {
    public bool IsPalindrome(string s) {
          s = new string([.. s
                .Where(char.IsLetterOrDigit)
                .Select(char.ToLowerInvariant)]);

  s = s.Trim().ToLower();

  int i = 0;
  int j = s.Length - 1;

  while (i < j)
  {
      if (s[i] != s[j])
          return false;
      i++;
      j--;
  }

  return true;
    }
}
