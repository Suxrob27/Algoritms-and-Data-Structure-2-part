using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    public class Solution
    {
        public int Search(int[] nums, int target)
        {
            int min = 0;
            int max = nums.Length - 1;
            while (min <= max)
            {
                
                int mid = (min + max) / 2;
                  if (target == nums[mid])
                  {
                    return mid++;
                  }
                else if (target < nums[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;

        }
    }
    public class Program
    {
        static void Main(string[] args)
        {
            //BST bST = new BST();
            //bST.insert(324);
            //bST.insert(2);
            //bST.insert(34);
            //bST.insert(8);
            //bST.insert(34);
            //bST.insert(98);
            //bST.insert(12);
            //bST.insert(94);
            //bST.contains(94);
            
            Solution solution = new Solution();
            int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9 ,10,20,30,40,50,60,70,80,90,100};    
            solution.Search(array,40);
            
        }
    }
}
