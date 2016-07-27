using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static void Main(String[] args) {
          int n = Convert.ToInt32(Console.ReadLine());
          for (int i = 0; i < n; i++) { 
               string[] arr_temp_1 = Console.ReadLine().Split(' '); 
               int[] arr_1 = Array.ConvertAll(arr_temp_1,Int32.Parse); 
//            int[] arr_1 = {12,16};
            int min_side;
            int max_side;
            int qnt = arr_1[1]*arr_1[0];
            if (arr_1[0] == arr_1[1]) qnt = 1;
            else {
                if (arr_1[0] > arr_1[1]){
                   min_side = arr_1[1];
                   max_side = arr_1[0];
                }                
                else {
                   min_side = arr_1[0];
                   max_side = arr_1[1];                    
                }
                for (int j = min_side; j >= 2; j--){
                    if (max_side % j == 0) {
                        qnt = (min_side*max_side)/(j*j);
                    }
                }                
            } 
            Console.WriteLine(qnt.ToString() );
          }                         
       } 
}
