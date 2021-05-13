public class Solution {
    public int Search(int[] nums, int target) {
        
        //finding pivot
        
        int left = 0;
        int right = nums.Length - 1;
        int mid = -1;
        
        while(left < right)
        {
            mid = left + (right-left)/2;
            
            if(nums[mid] > nums[right])
                left = mid + 1;
            else
                right = mid;
        }
        
        int pivot = left;
        
        //deciding in which part to search
        left = 0;
        right = nums.Length - 1;
        if(target >= nums[pivot] && target <= nums[right])
            left = pivot;
        else
            right = pivot - 1;
        
        while(left <= right)
        {
            mid = left + (right - left)/2;
            if(nums[mid] == target)
                return mid;
            else if(nums[mid] > target)
                right = mid - 1;
            else
                left = mid + 1;
        }
        
        return -1;
    }
}
