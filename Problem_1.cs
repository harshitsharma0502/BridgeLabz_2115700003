using System;
using System.Diagnostics;
class SearchComparison{
	static int LinearSearch(int []arr, int target){
		for(int i=0;i<arr.Length;i++){
			if(arr[i]==target){
				return i;
			}
		}
		return -1;
	}
	static int BinarySearch(int []arr,int target){
		int left=0;
		int right=arr.Length-1;
		while(left<=right){
			int mid = left + (right-left)/2;
			if(arr[mid]==target){
				return mid;
			}else if(arr[mid]<target){
				left=mid+1;
			}else{
				right=mid-1;
			}
		}
		return -1;
	}
	public static void Main(string[] args){
		Console.WriteLine("Enter the Dataset Size: ");
		int n=int.Parse(Console.ReadLine());
		int[] arr = new int[n];
		for(int i=0;i<n;i++){
			Console.WriteLine("Enter Data {0}",i+1);
			arr[i]= int.Parse(Console.ReadLine());
		}
		Console.WriteLine("Enter target value: ");
		int t=int.Parse(Console.ReadLine());
		Stopwatch sw= Stopwatch.StartNew();
		int index = LinearSearch(arr,t);
		sw.Stop();
		Console.WriteLine("Linear Search: Target found in Data: {0} in Time: {1}ms.",index+1,sw.ElapsedMilliseconds);
		Array.Sort(arr);
		sw.Restart();
		index = BinarySearch(arr,t);
		sw.Stop();
		Console.WriteLine("Binary Search: Target found in Data: {0} in Time: {1}ms.",index+1,sw.ElapsedMilliseconds);
		
		Console.WriteLine("\nFor big data size like for 1000000 if our target is 999999: ");
		int[] data = new int[1000000];
        for (int i = 0; i < data.Length; i++)
            data[i] = i;

        int target = 999999;
		sw.Restart();
        int linearResult = LinearSearch(data, target);
        sw.Stop();
        Console.WriteLine("Linear Search: Found at index {0} in {1} ms",linearResult,sw.ElapsedMilliseconds);
        sw.Restart();
        int binaryResult = BinarySearch(data, target);
        sw.Stop();
        Console.WriteLine("Binary Search: Found at index {0} in {1} ms",binaryResult,sw.ElapsedMilliseconds);
	}
}