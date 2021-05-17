public class Solution {
    public IList<IList<int>> Permute(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();
        BTHelper(result, new List<int>(), nums);
        return result;
    }
    
    private void BTHelper(IList<IList<int>> result, List<int> tempList, int[] nums)
    {
        if(tempList.Count == nums.Length)
        {
            result.Add(new List<int>(tempList));
            return;
        }
        else
        {
            for(int i = 0; i < nums.Length; i++)
            {
                if(!tempList.Contains(nums[i]))
                {
                    tempList.Add(nums[i]);
                    BTHelper(result, tempList, nums);
                    tempList.RemoveAt(tempList.Count - 1);
                }
            }
        }
    }
}
