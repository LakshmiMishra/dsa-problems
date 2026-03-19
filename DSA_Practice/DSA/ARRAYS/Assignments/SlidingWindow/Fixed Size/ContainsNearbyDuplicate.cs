public class Solution {
//     Given an integer array nums and an integer k, return true if there are two distinct indices i and j in the array such that nums[i] == nums[j] and abs(i - j) <= k.

 

// Example 1:

// Input: nums = [1,2,3,1], k = 3
// Output: true
// Example 2:

// Input: nums = [1,0,1,1], k = 1
// Output: true
// Example 3:

// Input: nums = [1,2,3,1,2,3], k = 2
// Output: false
 
    public static void Main(string[] args)
		{
	int[] arr={1,0,1,1};
	int k=1;
	bool res=ContainsNearbyDuplicate(arr,k);
	Console.Write(res);
		}
    public static bool ContainsNearbyDuplicate(int[] nums, int k) {
        int n=nums.Length;
        HashSet<int> window=new HashSet<int>();
        for(int fast=0;fast<n;fast++){
         // If the element is already in the set, a duplicate within distance k is found
            if (window.Contains(nums[fast])) {
                return true;
            }
            window.Add(nums[fast]);// Sliding window concept
            if(window.Count>k){
                window.Remove(nums[fast-k]);
            }
        }
        return false;
    }
}