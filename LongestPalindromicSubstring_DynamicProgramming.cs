public string LongestPalindrome(string s) {
        if(s == null || s.Length == 0)
            return null;
       string result = s[0].ToString();
       bool[,] store = new bool[s.Length, s.Length];
        
        for(int i = s.Length - 1; i >= 0; i--)
        {
            for(int j = i; j <= s.Length - 1; j++)
            {
                if(j-i <=1 && s[i] == s[j])
                {
                    store[i,j] = true;
                }
                else if(j-i >= 2 && s[i] == s[j] && store[i+1, j-1])
                {
                    store[i,j] = true;
                }
                
                if(store[i,j] && (j-i+1) > result.Length)
                {
                    result = s.Substring(i, j - i + 1);
                }
            }
        }
        
        return result;
    }
