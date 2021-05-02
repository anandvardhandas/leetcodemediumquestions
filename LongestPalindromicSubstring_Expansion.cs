public string LongestPalindrome(string s) {
        if(s == null || s.Length == 0)
            return null;
       string result = s[0].ToString();
        
        for(int i = 0; i < s.Length; i++)
        {
            int l = i - 1;
            int r = i + 1;
            
            //for odd
            while(l >= 0 && r <= s.Length - 1 && s[l] == s[r])
            {
                string subString = s.Substring(l, r-l + 1);
                if(subString.Length > result.Length)
                    result = subString;
                l--;
                r++;
            }
            
            //for even
            l = i;
            r = i+1;
            
            while(l >= 0 && r <= s.Length - 1 && s[l] == s[r])
            {
                string subString = s.Substring(l, r-l + 1);
                if(subString.Length > result.Length)
                    result = subString;
                l--;
                r++;
            }
        }
        
        return result;
    }
