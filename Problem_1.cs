using System;
class BubbleSort{
	public static void Main(string[] args){           // Main function;
		Console.WriteLine("Enter no. of Students: "); 
		int n=int.Parse(Console.ReadLine());
		Console.WriteLine("Enter Marks: ");
		int []arr=new int [n];                        // Initialize Array for marks;
		for(int i=0;i<n;i++){                  
			arr[i]= int.Parse(Console.ReadLine());
		}
		Sort(arr,n);                                  // Call function Sort();
		Console.Write("Sorted array of marks is : ");
		for(int i=0;i<n;i++){                         // Print Array;
			Console.Write(arr[i]+" ");
		}
	}
	static void Sort(int []arr,int n){                // Sort function for sorting array;
		for(int i=0;i<n;i++){
			for(int j=i;j<n;j++){                     // Nested loop  
				if(arr[i]>arr[j]){                    // Swap if last mark is greater than next;
					int temp=arr[i];
					arr[i]=arr[j];
					arr[j]=temp;
				}
			}
		}
		return;
	}
}