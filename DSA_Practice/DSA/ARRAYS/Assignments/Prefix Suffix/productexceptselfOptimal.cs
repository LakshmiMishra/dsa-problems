public class ProductExceptSelf
{
    static void Main() {
        int[] arr = {10, 3, 5, 0, 2};
        int[] res = productExceptSelf(arr);

        Console.WriteLine(string.Join(" ", res));
    }
     public static int[] productExceptSelf(int[] arr) {
        int n=arr.Length;
        //without using division
        int[] res=new int[n];
        int zeros=0;int prod=1;
        int zeroIndex=-1;
        for(int i = 0; i < n; i++)
        {
            if (arr[i] == 0)
            {
                zeros++;
                zeroIndex = i;// Store the index of the zero element
            }
            else
            {
                prod *= arr[i];
            }
        }
        Array.Fill(res,0); // Fill the result array with zeros by default
        if (zeros == 0)
        {
            for(int i = 0; i < n; i++)
            {
                res[i]=prod/arr[i];
            }
        }
        else if(zeros == 1)
        {
            res[zeroIndex] = prod; // The product of all non-zero elements will be the result for the zero index
        }
        
  
         return res;
    }

}