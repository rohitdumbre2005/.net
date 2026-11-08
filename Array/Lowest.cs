namespace Array;

public class Arr
{

    public static void Main(){
    int[] arr={23,43,56,1,23};

    int min = arr[0];

    for(int i=0;i<arr.Length ;i++)
    {
            
        if(arr[i] < min)
            {
                min = arr[i];
                
            }

    }
    Console.WriteLine("Lowest number is : "+min);

    }

}
