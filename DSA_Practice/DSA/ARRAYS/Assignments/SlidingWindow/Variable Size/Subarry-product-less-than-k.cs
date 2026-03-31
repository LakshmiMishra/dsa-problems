public class Solution {
    // 			20. Subarray Product Less Than K
// Count contiguous subarrays where product < k.
// Input
// arr = [10,5,2,6], k = 100
// Output
// 8
    public int NumSubarrayProductLessThanK(int[] arr, int k) {
        if(k<=1)
        return 0;     
        int  slow=0;

int n=arr.Length;

int pd=1;
int counter=0;
for(int i=0;i<n;i++){

  pd*=arr[i];
  
  Console.WriteLine(pd);
 
  while(pd>=k && slow<=i){
    
    pd=pd/arr[slow];
    slow++;
  }
   if(pd<k)
    counter+=i-slow+1;
 
    }
    return counter;
}
}