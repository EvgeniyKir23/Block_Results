﻿
string[] array1 = new string[4] {"Hello", "2", "world", ":-)"};
string[] array2 = new string[array1.Length];
void Array(string[] array1, string[] array2)
{
    int result = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[result] = array1[i];
        result++;
        }
    }
}