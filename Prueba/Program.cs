// See https://aka.ms/new-console-template for more information

/* You are given a read only array of n positive integers from 1 to n.
Each integer appears exactly once except A which appears twice and B which is missing.
Return A and B.

Note that in your output A should precede B.

Example:
Input:[3 1 2 5 3]
Output:[3, 4]
A = 3, B = 4 */

int[] arr = new int[5] { 3, 1, 2, 5, 3 };

var orderAsc = arr.OrderBy(x => x).ToList();

int number = 0;
int duplicated = 0;
int missingNumber = 0;

for (int i = 0; i < orderAsc.Count() ; i++)
{
    if (orderAsc[i] == number)
    {
        duplicated = orderAsc[i];
    }

    if (orderAsc[i] - number == 2)
    {
        missingNumber = orderAsc[i] - 1;
    }

    number = orderAsc[i];
}

Console.WriteLine($"[A: {duplicated}, B: {missingNumber}]");
