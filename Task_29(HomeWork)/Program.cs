// Напишите программу, которая задаёт массив
// из 8 элементов и выводит их на экран.


int[] nums = new int[8];
var numRnd = new Random();
for (int i = 0; i < nums.Length; i++)
{
    nums[i] = numRnd.Next(0, 100);
    Console.Write(nums[i] + " ");
}