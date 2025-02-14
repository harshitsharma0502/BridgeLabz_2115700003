using System;
class InsertionSort{
	public static void Main(string[] args){             // Main fucntion
		Console.WriteLine("Enter no. of Employees: ");
		int n=int.Parse(Console.ReadLine());
		Console.WriteLine("Enter Employee IDs: ");
		int []arr=new int[n];                           // Initialize array for Employee IDs
		for(int i=0;i<n;i++){
			arr[i]=int.Parse(Console.ReadLine());
		}
		Sort(arr,n);                                   // Calling Sort() function
		Console.Write("Sorted Employee IDs : ");
		for(int i=0;i<n;i++){                          // Print Sorted array
			Console.Write(arr[i]+" ");
		}
	}
	static void Sort(int []arr, int n){                // Sort fucntion for sorting array by using Insertion Sort.
		for(int i=1;i<n;i++){
			int key=arr[i];
			int j=i-1;
			while(j>=0 && arr[j]>key){                 // Swapping numbers after checking conditions
				arr[j+1]=arr[j];
				j-=1;
			}
			arr[j+1]=key;
		}
	}
}