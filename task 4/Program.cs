Console.WriteLine("Task 1");
int[] numbers = { 3, 7, 2, 9, 5, 1 };
int sum = 0;
foreach (int num in numbers)
{
    sum += num;
}
Console.WriteLine("Sum = " + sum);

Console.WriteLine("Task 2");
int[] temps = { 12, -3, 45, 0, 28, -10, 33 };
Array.Sort(temps);
int min = temps[0];
int max = temps[temps.Length - 1];
Console.WriteLine("Min = " + min + ", Max = " + max);

Console.WriteLine("Task 3.1");
string[] words = { "apple", "banana", "cherry", "date" };
for (int i = 0; i < words.Length / 2; i++)
{
    string tem = words[i];
    words[i] = words[words.Length - 1 - i];
    words[words.Length - 1 - i] = tem;
}
foreach (string w in words)
{
    Console.Write(w + " ");
}

Console.WriteLine("");
Console.WriteLine("Task 3.2");
string[] word = { "apple", "banana", "cherry", "date" };
Array.Reverse(word);
foreach (string w in word)
{
    Console.Write(w + " ");
}

Console.WriteLine("");
Console.WriteLine("Task 4");
int[] data = { 4, 7, 2, 11, 6, 9, 14, 3, 8 };
int even = 0;
int odd = 0;
foreach (int num in data)
{
    if (num % 2 == 0)
        even++;
    else
        odd++;
}
Console.WriteLine("Even = " + even + ", Odd = " + odd);

Console.WriteLine("Task 5");
int[] raw = { 1, 3, 2, 3, 5, 1, 4, 2, 5 };
List<int> unique = new List<int>();
foreach (int num in raw)
{
    if (!unique.Contains(num))
    {
        unique.Add(num);
    }
}
foreach (int n in unique)
{
    Console.Write(n + " ");
}

Console.WriteLine("");
Console.WriteLine("Task 6");
int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
int k = 3;
int[] result = Rotateleft(arr, k);
foreach (int n in result)
{
    Console.Write(n + " ");
}
static int[] Rotateleft(int[] arr, int k)
{
    int n = arr.Length;
    k = k % n;
    int[] newArr = new int[n];
    int index = 0;
    for (int i = k; i < n; i++)
    {
        newArr[index++] = arr[i];
    }
    for (int i = 0; i < k; i++)
    {
        newArr[index++] = arr[i];
    }
    return newArr;
}