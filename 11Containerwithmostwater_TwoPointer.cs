public class Solution {
    public int MaxArea(int[] height) {
        if(height == null || height.Length < 2)
            return 0;
        
        int maxArea = 0;
        int l = 0;
        int r = height.Length - 1;
        
        while(l < r)
        {
            int length = height[l] < height[r] ? height[l] : height[r];
            int currArea = (r - l) * length;
            if(currArea > maxArea)
                maxArea = currArea;
            
            if(height[l] < height[r])
                l++;
            else
                r--;
        }
        
        return maxArea;
    }
}
