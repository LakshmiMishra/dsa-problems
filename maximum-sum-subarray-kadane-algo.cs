class Solution {
    public int maxSubarraySum(int[] arr) {
        // code here
        int n= arr.Length;
        int currSum=0;
      int maxSum=int.MinValue;
       
       for(int i=0;i<n;i++){
           //We will check curr sum of the sub array
           //if curr sum becomes negative then we will not consider those elements for the max sub array
           //since those elements are making it negative
          
              currSum=currSum+arr[i];
           
           //check if the currSum or maxSum which is maximum 
           maxSum=Math.Max(currSum,maxSum);
           
           //now check if currSum is negative value
           if(currSum<0)
           currSum=0;
          //arr={2,3,-8,7,-1,2,3}
          //currSum=2;maxSum=2;
          //start the sub array sums in one traversal
           //for i=0
          //currSum=0+2=2;maxSum=2;
          //for i=1
          //currSum=2+3=5;maxSum=5;
          //for i=2
          //currsum=5-8=-3;maxSum=5
          //currSum<0 so currSum=0;
         //for i=3
          //currSum=0+7=7; maxSum=7
          //for i=4
          //currSum=7-1=6;maxSum=7
          //for i=5
          //currSum=6+2=8 maxSum=8
          //for i=6
          //currSum=8+3 maxsum=11
          
           
       }
       return maxSum;
       
    }
}