
// 2.
// string name=Console.ReadLine();
// int age=Convert.ToInt32(Console.ReadLine());
// int ball=Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(name);
// Console.WriteLine(age);
// if(ball>=50)
// Console.WriteLine("Passed");
// else if(ball<50)
// Console.WriteLine("Failed");



// CLASS
// 1.
// int[] arr = [1, 2, 3, 0, 4, 2, 1, 3, 0];
// int maxx = int.MinValue;
// for (int i = 0; i <= arr.Length - 1; i++)
// {
//     if (arr[i] > maxx)
//     {
//         maxx = arr[i];
//     }
//     if (arr[i] == 0)
//     {
//         Console.WriteLine(maxx);
//         // break;
//     }
// };



// 2.
// double num1 = Convert.ToDouble(Console.ReadLine());
// double num2 = Convert.ToDouble(Console.ReadLine());
// double sum = 1;
// for (int i = 1; i <= num2; i++)
// {
//     sum += Math.Pow(num1, i);
// };
// Console.WriteLine(sum);


// 3.
// int[] arr = [2, 10, 6, 0, 8, 1, 0, 2, 3, 0, 0];
// int sum=0;
// for (int i = 0; i <= arr.Length - 1; i++)
// {
//     sum += arr[i];
//     if(arr[i]==0 && arr[i + 1] == 0)
//     {
//         Console.WriteLine(sum);
//         break;
//     }
// }




// 4.
// int n = Convert.ToInt32(Console.ReadLine());
// int[] arr = new int[n];
// int cnt = 0;
// for (int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt16(Console.ReadLine());
// }
// for (int i = 0; i < n - 1; i++)
// {
//     if (arr[i] > 0 && arr[i + 1] > 0 || arr[i] < 0 && arr[i + 1] < 0)
//     {
//         cnt++;
//         break;
//     }
// }
// if (cnt > 0)
// {
//     System.Console.WriteLine("Yes");
// }
// else
// {
//     Console.WriteLine("NO");
// }



// 5. ------------------------------------------
// int[] arr = [1,2,3,1,5,3,];
// string sum = "";
// for (int i = 0; i < arr.Length; i++)
// {
//     int count=0;
//     for (int j = 0; j < arr.Length ; j++)
//     {
//         if (arr[i] == arr[j])
//         {
//             count ++;
//         }
//     }
//     if (count > 1)
//     {
//         sum+=arr[i]+" ";
//     }
// }
// Console.WriteLine(sum);


// 6.
// int n=Convert.ToInt32(Console.ReadLine());
// int [] arr=new int[n];
// int min = int.MaxValue;
// for(int i = 0; i < n; i++)
// {
//     arr[i]=Convert.ToInt16(Console.ReadLine());
// }
// for(int i = 0; i < n; i++)
// {
//     if (arr[i] < min)
//     {
//         min=arr[i];
//     }
// }
// System.Console.WriteLine(min);



// 7.
// int sum = 0;
// int cnt = 0;
// while (true)
// {
//     Console.WriteLine("Give a number:");
//     Console.Write("> ");
//     int num = Convert.ToInt32(Console.ReadLine());
//     if (num == 0)
//     {
//         cnt--;
//         break;
//     }
//     sum += num;
//     cnt++;
// }
// Console.WriteLine($"Sum of numbers: {sum}");
// Console.WriteLine($"Count of numbers: {cnt}");



// 8.
// double num = Convert.ToDouble(Console.ReadLine());
// double sum = 0;
// double sum2 = 1;
// for (; num > 0; num = Math.Floor(num / 10))
// {
//     double n = num % 10;
//     sum += n;
//     sum2 *= n;
// }
// Console.WriteLine(sum);
// Console.WriteLine(sum2);



// 9.
// double num = Convert.ToInt32(Console.ReadLine());
// string sum = "";
// for (; num > 0; num = Math.Floor(num / 10))
// {
//     sum += num % 10;
// }
// Console.WriteLine(sum);



// 10.
// int n = Convert.ToInt16(Console.ReadLine());
// int[] arr = new int[n];
// string res = "";
// for (int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt16(Console.ReadLine());
// }
// for (int i = 0; i < arr.Length; i++)
// {
//     int cnt = 0;
//     for (int j = 1; j <= arr[i]; j++)
//     {
//         if (arr[i] % j == 0)
//         {
//             cnt++;
//         }
//     }
//     if (cnt > 2)
//     {
//         res += arr[i] + " ";
//     }
// }
// Console.WriteLine(res);




// HOME
// 1.
// double n=Convert.ToDouble(Console.ReadLine());
// if(n <= 100)
// {
//     Console.WriteLine(n+((n/100)*5));
// }
// if(n > 100 && n<=200)
// {
//     Console.WriteLine(n+((n/100)*7));
// }
// if (n > 200)
// {
//     Console.WriteLine(n+((n/100)*10));
// }



// 2.
// int n=Convert.ToInt16(Console.ReadLine());
// int [] arr =new int [n];
// int cnt=1;
// string str="";
// for(int i = 0; i < n; i++)
// {
//     arr[i]=Convert.ToInt16(Console.ReadLine());
// }
// for(int i = 0; i < n - 1; i++)
// {
//     str+=arr[i]+"*";
//     cnt*=arr[i];
// }
// System.Console.WriteLine($"{str}{arr[arr.Length-1]} = {cnt*arr[arr.Length-1]}");



// 3.
// int n = Convert.ToInt16(Console.ReadLine());
// int[] arr = new int[n];
// int max = int.MinValue;
// int index=0;
// for (int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt16(Console.ReadLine());
// }
// for (int i = 0; i < n; i++)
// {
//     if (arr[i] > max)
//     {
//         max = arr[i];
//         index=i;
//     }
// }
// System.Console.WriteLine(index);




// 4.
// int n = Convert.ToInt16(Console.ReadLine());
// int[] arr = new int[n];
// string res = "";
// for (int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt16(Console.ReadLine());
// }
// for (int i = 0; i < n; i++)
// {
//     int cnt = 0;
//     for (int j = 0; j < n; j++)
//     {
//         if (arr[i] == arr[j])
//         {
//             cnt++;
//         }
//     }
//     if (cnt == 1)
//     {
//         res += arr[i] + " ";
//     }
// }
// System.Console.WriteLine(res);



// 5.
// int n = Convert.ToInt16(Console.ReadLine());
// int[] arr = new int[n];
// int min = int.MaxValue;
// int index=0;
// for (int i = 0; i < n; i++)
// {
//     arr[i] = Convert.ToInt16(Console.ReadLine());
// }
// for (int i = 0; i < n; i++)
// {
//     if (arr[i] < min)
//     {
//         min = arr[i];
//         index=i;
//     }
// }
// System.Console.WriteLine(index);


// 6.
// int n=Convert.ToInt16(Console.ReadLine());
// int [] arr=new int[n];
// int cnt=0;
// for(int i = 0; i < n; i++)
// {
//     arr[i]=Convert.ToInt16(Console.ReadLine());
// }
// for(int i = 1; i < n; i++)
// {
//     if(arr[i]>arr[i-1] && arr[i] > arr[i + 1])
//     {
//         cnt++;
//     }
// }
// System.Console.WriteLine(cnt);


// 7.
// int n=Convert.ToInt16(Console.ReadLine());
// int [] arr=new int [n];
// for(int i = 0; i < n; i++)
// {
//     arr[i]=Convert.ToInt16(Console.ReadLine());
// }
// for(int i = n-1; i >= 0; i--)
// {
//     if(arr[i]>0 && arr[i-1]>0 || arr[i]<0 && arr[i-1]<0)
//     {
//         Console.WriteLine($"{arr[i]} {arr[i-1]}");
//         break;
//     }
// }



// 8.
// int n=Convert.ToInt16(Console.ReadLine());
// int [] arr=new int[n];
// for(int i = 0; i < n; i++)
// {
//     arr[i]=Convert.ToInt16(Console.ReadLine());
// }
// for(int i = 0; i < n; i++)
// {
//     if (arr[i] % 2 != 0)
//     {
//         Console.Write($"{i} ");
//     }
// }




// 9.




// 10.
// int n=Convert.ToInt16(Console.ReadLine());
// int [] arr=new int [n];
// for(int i = 0; i < n; i++)
// {
//     arr[i]=Convert.ToInt16(Console.ReadLine());
// }
// for(int i = 0; i < n; i++)
// {
//     if (arr[i] % 2 != 0)
//     {
//         Console.Write($"{arr[i]*arr[i]} ");
//     }
// }