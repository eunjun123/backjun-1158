using System;
using System.Linq;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            using (var prnt = new System.IO.StreamWriter(Console.OpenStandardOutput()))
            {
                var input = Console.ReadLine().Split(' ');
                var num = int.Parse(input[0]);
                var distance = int.Parse(input[1]);
                int count = 0;
                var savebool = new bool[num + 1];
                System.Text.StringBuilder sb = new System.Text.StringBuilder();
                sb.Append("<");
                for (int i = 1; i <= num; i++)
                {
                    for (int j = 1; j <= distance; j++)
                    {
                        do
                        {
                            count++;
                            if (count > num)
                            {
                                count = count % num;
                            }
                        }
                        while (savebool[count]);
                    }
                    if (i == num)
                    {
                        sb.Append(string.Format("{0}>", count));
                    }
                    else
                    {
                        sb.Append(string.Format("{0}, ", count));
                    }
                    savebool[count] = true;
                }
                prnt.Write(sb.ToString());
            }
        }
    }
