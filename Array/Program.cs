namespace Arra;

public class Arr{

    public static void Main(){
    int[] arr={23,43,56,1,23};

    int max = arr[0];

    for(int i=0 ;i<arr.Length ;i++)
    {
            
        if(arr[i]>max)
            {
                max = arr[i];
                
            }

    }
    Console.WriteLine(max);

    }

}
