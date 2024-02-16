public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) 
    {
        List<int> a = new List<int>();
        int[] b = new int[]{0,0,0,0,0,0};
        int ind = 0;
        for(int i = 0; i < nums1.Length; i++)
        {
            if(i < m)
            {
                a.Add(nums1[i]);
            }
        }
        for(int i = 0; i < nums2.Length; i++)
        {
            a.Add(nums2[i]);
        }        
        a.Sort();
        for(int i = 0; i < a.Count; i++)
        {
            nums1[i] = a[i];
        }
    }
}
