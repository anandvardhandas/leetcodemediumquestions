public class Solution {
    public IList<IList<int>> Subsets(int[] nums) {
        IList<IList<int>> result = new List<IList<int>>();
        BTHelper(result, new List<int>(), nums, 0);
        return result;
    }
    
    private void BTHelper(IList<IList<int>> result, List<int> tempList, int[] nums, int index)
    {
        result.Add(new List<int>(tempList));
        
        for(int i = index; i < nums.Length; i++)
        {
            tempList.Add(nums[i]);
            BTHelper(result, tempList, nums, i + 1);
            tempList.RemoveAt(tempList.Count - 1);
        }
    }
}
