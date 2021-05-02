public string LongestPalindrome(string s) {
        if(s == null || s.Length == 0)
            return null;
        
        string result = s[0].ToString();
        
        for(int i = 0; i < s.Length; i++)
        {
               for(int j = i + 1; j < s.Length; j++)
               {
                   string sub = s.Substring(i, j - i + 1);
                   if(IsPalindrome(sub) && sub.Length > result.Length)
                   {
                       result = sub;
                   }
               }
        }
        
        return result;
    }
    
    private bool IsPalindrome(string s)
    {
        for(int i = 0, j = s.Length -1; i<=j; i++,j--)
        {
            if(s[i] != s[j])
                return false;
        }
        
        return true;
    }
