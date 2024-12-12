
#region Problem 1

//int[] arr1 = new int[5];
//int[] arr2 = new int[] {1,2,3,4,5};
//int[] arr3 = [1,2,3,4,5];
//foreach (int i in arr2)
//{
//    Console.Write($" {i} ");
//}
// 0 is the default value assigned to array elements in C#
#endregion

#region Problem 2
//int[] arr1 = new int[] { 10, 20, 30, 40, 50 };
//int[] arr2 = new int[] { 1, 2, 3, 4, 5 };

//Console.WriteLine($" arr1 ==> {arr1.GetHashCode()}");
//Console.WriteLine($" arr2 ==> {arr2.GetHashCode()}");
//arr2 = arr1;
//Console.WriteLine("after shallow copy");
//Console.WriteLine($" arr1 ==> {arr1.GetHashCode()}");
//Console.WriteLine($" arr2 ==> {arr2.GetHashCode()}");
// **if change any thing in arr1 it will affect in arr2**
//arr1[0] = 100;
//foreach( int i in arr2)
//{
//    Console.WriteLine(i);
//}

//Console.WriteLine($" arr1 ==> {arr1.GetHashCode()}");
//Console.WriteLine($" arr2 ==> {arr2.GetHashCode()}");
//arr2 = (int[]) arr1.Clone();
//Console.WriteLine("after shallow copy");
//Console.WriteLine($" arr1 ==> {arr1.GetHashCode()}");
//Console.WriteLine($" arr2 ==> {arr2.GetHashCode()}");
// // **if change any thing in arr1 it will not affect in arr2**
//arr1[0] = 100;
//foreach( int i in arr2)
//{
//    Console.WriteLine(i);
//}

// ** arr1.Clone() ==> if you want to create new array with same value , arr1.copy() if ypu want to copy value to another array or copy some of them only

#endregion

#region Problem 3

//int[,] arr = new int[3, 4]; 
//for (int i = 0; i < arr.GetLength(0); i++)
//{
//    for (int j = 0; j < arr.GetLength(1); j++)
//    {
//        arr[i, j] = int.Parse( Console.ReadLine());
//    }
//}

//for (int i = 0; i < arr.GetLength(0); i++)
//{
//    for (int j = 0; j < arr.GetLength(1); j++)
//    {
//        Console.Write( $" {arr[i, j]} " );
//    }
//    Console.WriteLine();
//}

// getlength() ==> get num of ROWs or Columns But length() get number of all attributes
#endregion

#region Problem 4
//int[] arr5 = [0,10,7,9,5];
//Console.WriteLine("before method");
//foreach (int i in arr5)
//{
//    Console.Write($" {i} " );
//}
//Array.Sort(arr5);
//Console.WriteLine();
//Console.WriteLine("After sort method");
//foreach (int i in arr5)
//{
//    Console.Write($" {i} ");
//}

//Console.WriteLine();
//foreach (int i in arr5)
//{
//    Console.Write($" {i} ");
//}
//Array.Reverse(arr5);
//Console.WriteLine();
//Console.WriteLine("After Reverse method");
//foreach (int i in arr5)
//{
//    Console.Write($" {i}");
//}

//Console.WriteLine();
//foreach (int i in arr5)
//{
//    Console.Write($" {i}");
//}Console.WriteLine();

//Console.WriteLine("After copy method");
//int[] arr2 = new int [5];
//Array.Copy(arr5, arr2 , arr2.Length);
//foreach (int i in arr2)
//{
//    Console.Write($" {i} ");
//}
//Console.WriteLine("After clear method");
//Array.Clear(arr5);
//foreach (int i in arr5)
//{
//    Console.Write($" {i}");
//}
// Array.ConstrainedCopy() Specialized for constrained copying with type safety but Array.Copy() is General-purpose copying of array elements 
#endregion

#region Problem 5
//int[] array = [0,10,7,9,5];
//for (int i = 0; i < array.Length; i++)
//{
//    Console.Write($" {array[i]} ");
//}
//Console.WriteLine();

////=======================
//foreach (int i in array)
//{
//    Console.Write($" { i } ");
//}
//Console.WriteLine();
////========================
//int x = array.Length-1;
//while(x>= 0)
//{
//    Console.Write($" {array[x]} " );
//    x--;
//}

// simpler, more readable syntax ,Makes the code safer and easier to maintain .

#endregion

#region  Problem 6
//int number;
//do
//{
//    Console.WriteLine("enter odd number");
//    int.TryParse(Console.ReadLine(), out number);
//} while (number % 2 == 0);
//Console.WriteLine($"NUMBER IS => {number}");
//* To make sure it gives the required data type to avoid any problems. *
#endregion

#region  Problem 7
//int[,] arr = new int[4,3];
//Console.WriteLine("Enter Element of Matrix");
//for (int i = 0; i < arr.GetLength(0); i++)
//{
//    for (int j = 0; j < arr.GetLength(1); j++)
//    {
//        arr[i,j]= int.Parse(Console.ReadLine());
//    }
//}
//for (int i = 0; i < arr.GetLength(0); i++)
//{
//    for (int j = 0; j < arr.GetLength(1); j++)
//    {
//        Console.Write($" {arr[i, j]} ");
//    }
//    Console.WriteLine();
//}
// you can set elements by this way
//int[,] array = {
//            { 1, 22, 333 },
//            { 4444, 55, 6 },
//            { 7, 8888, 99 }
//        };
#endregion

#region Problem 8
//Console.WriteLine("enter a month number");
//int month_num = int.Parse(Console.ReadLine());
//int.TryParse(Console.ReadLine(), out int month_num);
//string month_name = null;
//if (month_num == 1)
//{
//    month_name = "January";
//}
//else if (month_num == 2)
//{
//    month_name = "February";
//}
//else if (month_num == 3)
//{
//    month_name = "March";
//}
//else if (month_num == 4)
//{
//    month_name = "April";
//}
//else if (month_num == 5)
//{
//    month_name = "May";
//}
//else if (month_num == 6)
//{
//    month_name = "June";
//}
//else if (month_num == 7)
//{
//    month_name = "July";
//}
//else if (month_num == 8)
//{
//    month_name = "August";
//}
//else if (month_num == 9)
//{
//    month_name = "September";
//}
//else if (month_num == 10)
//{
//    month_name = "October";
//}
//else if (month_num == 11)
//{
//    month_name = "November";
//}
//else if (month_num == 12)
//{
//    month_name = "December";
//}
//Console.WriteLine($" Month is {month_name}");
//int.TryParse(Console.ReadLine(), out int month_num);
//string month_name = null;
//switch (month_num)
//{

//    case 1:
//        month_name = "January";
//        break;

//    case 2:
//        month_name = "February";
//        break;
//    case 3:
//        month_name = "March";
//        break;
//    case 4:
//        month_name = "April";
//        break;
//    case 5:
//        month_name = "May";
//        break;
//    case 6:
//        month_name = "June";
//        break;
//    case 7:
//        month_name = "July";
//        break;
//    case 8:
//        month_name = "August";
//        break;
//    case 9:
//        month_name = "September";
//        break;
//    case 10:
//        month_name = "October";
//        break;
//    case 11:
//        month_name = "November";
//        break;
//    case 12:
//        month_name = "December";
//        break;
//}
//Console.WriteLine(month_name);  
// switch is better in many times becuase it can be faster than if-else and more readability
#endregion

#region Problem 9
//int[] arr = { 5, 1, 9, 7, 9 };
//Array.Sort(arr);
//Console.WriteLine(Array.IndexOf(arr, 9)); // بتقرا من الاول للاخر
//Console.WriteLine(Array.LastIndexOf(arr, 9)); // بتقرا من الاخر للاول
//QuickSort
//HeapSort
//Insertion Sort
#endregion

#region Problem 10
//int[] arr = { 1, 2, 3, 4, 5 };
//int sum = 0;
//for (int i = 0; i < arr.Length; i++)
//{
//    sum += arr[i];
//}
//Console.WriteLine(sum);
// * with foreach *
//foreach (int i in arr)
//{
//sum += arr[i-1]; 
//}
//Console.WriteLine(sum);
#endregion

#region problem 11
//class program { 
//static void Main () {
//    Console.WriteLine(" Enter number of day");
//       DayOfWeek day =(DayOfWeek) Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
//        Console.WriteLine(day.ToString());
//}
//}
//public enum DayOfWeek : int
//{
//    Monday = 1, Tuesday, Wednesday ,
//    Thursday , Friday , Saturday, Sunday 
//}
// IF USER ENTER A VALUE OUTSIDE THE RANGE , WILL PRINT THIS VALUE 
#endregion
