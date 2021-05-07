public class Solution {
    public int MaxArea(int[] height) {
        if(height == null || height.Length < 2)
            return 0;
        
        int maxArea = 0;
        
        for(int l = 0; l < height.Length-1; l++)
        {
            for(int r = l+1; r < height.Length; r++)
            {
                int length = height[l] > height[r] ? height[r] : height[l];
                int currArea = length * (r-l);
                if(currArea > maxArea)
                    maxArea = currArea;
            }
        }
        
        return maxArea;
    }
}
