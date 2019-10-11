using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace SharpKatas.Pages.Chop
{
    public class ChopModel : PageModel
    {
        public void OnGet()
        {

        }

        public int IterativeChop(int target, int[] sortedArray)
        {
            if (sortedArray.Length == 0) return -1;

            var start = 0;
            var stop = sortedArray.Length - 1;
            var mid = (int)Math.Floor((double)start + stop / 2);

            while (sortedArray[mid] != target && start < stop)
            {
                if (target < sortedArray[mid])
                    stop = mid - 1;
                else
                    start = mid + 1;

                mid = (int)Math.Floor(((double)start + stop) / 2);
            }

            return sortedArray[mid] != target ? -1 : mid;
        }
    }
}
