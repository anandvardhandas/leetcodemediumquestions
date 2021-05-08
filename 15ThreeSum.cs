public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {

            List<IList<int>> result = new List<IList<int>>();
            if(nums.Length < 3)
                return result;
        
            Array.Sort(nums);

            for(int i = 0; i < nums.Length - 2; i++)
            {
                if(i == 0 || nums[i] != nums[i-1])
                {
                    int l = i+1;
                    int r = nums.Length - 1;
                    while(l < r)
                    {
                        int sum = nums[i] + nums[l] + nums[r];
                        if(sum == 0)
                        {
                            IList<int> triplet = new List<int>() { nums[i], nums[l], nums[r] };
                            result.Add(triplet);
                            while(l < r && nums[l] == nums[l+1])
                                l++;
                            while(l < r && nums[r] == nums[r-1])
                                r--;

                            l++;
                            r--;

                        }
                        else if(sum < 0)
                        {
                           l++;
                        }
                        else
                           r--;

                    }
                }
            }

            return result;
    }
}
