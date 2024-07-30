void Main()
{
 
 int[] array = new int[6];
 Random rand = new Random();
 Console.Write("Исходный массив: ");
 for (int i = 0; i < array.Length; i++)
 {
 array[i] = rand.Next(0, 10); 
 Console.Write(array[i] + " "); 
 }

Console.WriteLine();

Console.Write("Перевернутый массив: ");
ReverseArray(array, array.Length - 1);
 Console.WriteLine();

}

void ReverseArray(int[] array, int i)
{

if (i < 0) return; 
 Console.Write(array[i] + " ");
 ReverseArray(array, i - 1);
  
}


Main();