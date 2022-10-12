public class Solution {
    public int FirstMissingPositive(int[] nums) {
      
        HashSet<int> numsHash = new HashSet<int>(nums);
        int i = 1;
        for(int x= 0; x < numsHash.Count ; x++)
        {
            if(!numsHash.Contains(i))
            {
                return i;
            }
            i++; 
        }
        return i;
    }
}
