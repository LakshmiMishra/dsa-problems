public class Solution {
    public int PivotIndex(int[] arr) {
        int n=arr.Length;
        // int[] prefixArr=new int[n];
        // int[] suffixArr=new int[n];
   
        // //prefixSumArr
        // prefixArr[0]=0;
        // for(int i=1;i<n;i++)
        // {
        //     prefixArr[i]=prefixArr[i-1]+arr[i-1];
        //     Console.Write(prefixArr[i]+" ");
        // }
        //      Console.Write(" ");
        // suffixArr[n-1]=0;
        // for(int i=n-2;i>=0;i--)
        // {
        //     suffixArr[i]=suffixArr[i+1]+arr[i+1];
        //          Console.Write(suffixArr[i]+" ");
        // }
        int sum=0;
        for(int i=0;i<n;i++){
            sum+=arr[i];
        }
        int prefixSum=0;
        int suffixSum=0;
        for(int i=0;i<n;i++){
            suffixSum= sum-arr[i]-prefixSum;          
            if(prefixSum==suffixSum)
            return i;
              prefixSum+=arr[i];
        }
        return -1;
    }
}