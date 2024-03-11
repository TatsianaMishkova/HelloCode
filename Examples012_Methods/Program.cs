// // Vid 1
// // void Method()
// // {
// //     Console.WriteLine("Yes");
// // }
// // Method();


// // Vid 2
// void Method2(string msg)
// {
//     Console.WriteLine(msg);
// }
// // Method2(msg: "Tekst soobscheniya");

// void Method21(string msg, int count)
// {
//     int i = 0;
//     while(i < count)
//     {
//         Console.WriteLine(msg);
//         i++;
//     }
// }
// //Method21("Tekst", 4);
// //Method21(count: 4, msg: "new tekst");

// //Vid 3

// int Method3()
// {
//     return DateTime.Now.Year;
// }

// int year = Method3();
// Console.WriteLine(year);

// //Vid 4


// // string Method4(int count, string text)
// // {
// //     int i = 0;
// //     string result = string.Empty;

// //     while (i < count)
// //     {
// //         result = result + text;
// //         i++;
// //     }
// //     return result;
// // }
// // string res = Method4(10, "rest");
// // Console.WriteLine(res);



// string Method4(int count, string text)
// {
//     string result = String.Empty;
// for(int i = 0; i < count; i++)
//     {
//         result = result + text;
//     }
//     return result;
// }
// string res = Method4(10, "rest");
// //Console.WriteLine(res);

// for (int i = 2; i <= 10; i++)
// {
//     for (int k = 2; k <= 10; k++)
//     {
//         Console.WriteLine($"{i} * {k} = {i * k}");
//     }
//     Console.WriteLine();
// }

// Задача   замена букв

// string text = "- Я думаю, - сказал князь, улыбаясь - что, "
//             + "ежели бы вас послали вместо нашего милого Винценгероде,"
//             + "вы бы взяли приступом согласие прусского короля. "
//             + "Вы так красноречивы. Вы дадите мне чаю?";
// // string s = "qwerty"
// //             012
// // s[3] // r

// string Replace(string text, char oldValue, char newValue)
// {
//     string result = String.Empty;

//     int length = text.Length;
//     for (int i = 0; i < length; i++)
//     {
//         if(text[i] == oldValue) result = result + $"{newValue}";
//         else result = result + $"{text[i]}";
//     }
//     return result;
// }
// string newText = Replace(text, ' ', '|');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'к', 'К');
// Console.WriteLine(newText);
// Console.WriteLine();
// newText = Replace(newText, 'с', 'С');
// // Console.WriteLine(newText);


// int[] arr = {1, 5, 9, 3, 7, 4, 3, 3, 2};

// void PrintArray(int[] array)
// {
//     int count = array.Length;

//     for (int i = 0; i < count; i++)
//     {
//         Console.Write($"{array[i]} ");
//     }
//     Console.WriteLine();
// }

// //PrintArray(arr);

// void SelectionSort(int[] array)
// {
//     for (int i = 0; i < array.Length; i++){
//         int minPosition = i;
        
//         for(int k = i + 1; k < array.Length; k++){
//             if(array[k] < array[minPosition]) minPosition = k;
//         }
        
//         int temporary = array[i];
//         array[i] = array[minPosition];
//         array[minPosition] = temporary;
//     }
// }

// PrintArray(arr);
// SelectionSort(arr);

// PrintArray(arr);
