public class Solution {
    public IList<IList<int>> CombinationSum(int[] candidates, int target) {
        IList<IList<int>> result = new List<IList<int>>();
        Array.Sort(candidates);
        BackTrack(result, new List<int>(), candidates, target, 0);
        return result;
    }
    
    private void BackTrack(IList<IList<int>> result, List<int> tempList, int[] candidates, int remain, int index)
    {
        if(remain < 0)
            return;
        else if(remain == 0)
        {
            result.Add(new List<int>(tempList));
            return;
        }
        else
        {
            for(int i = index; i < candidates.Length; i++)
            {
                tempList.Add(candidates[i]);
                BackTrack(result, tempList, candidates, remain - candidates[i], i);
                tempList.RemoveAt(tempList.Count - 1);
            }
        }
    }
}
