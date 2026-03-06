//Elaborate a function to embed an element at a specified locus in a given array.
using System;
using System.Collections.Generic;

class EmbedElementInArray
{
    public static void Main(string[] args)
    {
       /// Console.WriteLine("Enter the size of the array: ");
     //   int size= Convert.ToInt32(Console.ReadLine());
     int size=5;
       // int[] arr=new int[size];
      //  Console.WriteLine("Enter the elements in the array:");
        // for(int i = 0; i < size; i++)
        // {
        //     arr[i]= Convert.ToInt32(Console.ReadLine());
        // }
       int[] arr={3,5,8,9,0};
     //   Console.WriteLine("Enter the element to embed: ");
      //  int element= Convert.ToInt32(Console.ReadLine());       
         int element=10;
      //  Console.WriteLine("Enter the position to embed the element: ");
       // int position= Convert.ToInt32(Console.ReadLine());
        int position=2;
        //let create a new array which will have a size of size+1
        int[] newarr= new int[size+1];

        //we need to copy the element as per the position 
        //We can have 3 cases
        //Insertion at start
        //we will copy all the elements form old array to new array, 
        //and shift all the elements to right, leaving one space at the start
       if(position == 0)
        {
        // {3,5,8,9,0};
        for (int i = 0; i < size; i++)
        {
            newarr[i + 1] = arr[i];
        }
        newarr[position]=element;
        }


      //Insertion at in between
      if(position>0 && position<size){
        
        //copy  the array elemnts before position to new array
        for(int i=0;i<position;i++){
          newarr[i]=arr[i];
        }
        
        newarr[position]=element;
        //copy the array elements after the position
        for(int i=position;i<size;i++){
          newarr[i+1]=arr[i];
        }
        
      }


      //Insertion at the end
      if(position == size)//at the last index
        {
            for (int i = 0; i < size; i++)
            {
                newarr[i] = arr[i];
            }
            newarr[size] = element; // Insert at the end
        }

      //Print the new array
      foreach(int n in newarr){
        Console.Write(n+",");
      }

       
    }
}