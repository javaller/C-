using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] tokens_a0 = Console.ReadLine().Split(' ');
        int a0 = Convert.ToInt32(tokens_a0[0]);
        int a1 = Convert.ToInt32(tokens_a0[1]);
        int a2 = Convert.ToInt32(tokens_a0[2]);
        string[] tokens_b0 = Console.ReadLine().Split(' ');
        int b0 = Convert.ToInt32(tokens_b0[0]);
        int b1 = Convert.ToInt32(tokens_b0[1]);
        int b2 = Convert.ToInt32(tokens_b0[2]);
        int a_res = 0;
        int b_res = 0;
                
        if (a0 > b0) {a_res++;}
        else if (a0 < b0){ b_res++;}
        else {}
        if (a1 > b1) {a_res++;}
        else if (a1 < b1){ b_res++;}
        else {}
        if (a2 > b2) {a_res++;}
        else if (a2 < b2){ b_res++;}
        else {}       
        Console.WriteLine(a_res.ToString() + ' ' + b_res.ToString());
    }
}
