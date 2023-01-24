using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class DistinctAndAscending
    {
        List<int> _listInt1 = new List<int>()
        {
            1,2,7000,5,7,100,10,13
        };


        public void MakeListDistinctAndAscending()
        {
            Console.WriteLine("Please give me a list of numbers seperated by space, i will order them by ascending");
            string userString = Console.ReadLine();

            List<string> userList = new(userString.Split(' '));
            List<int> listInt = new List<int>();
            foreach (string item in userList)
            {
                int UserNum = int.Parse(item);
                listInt.Add(UserNum);
            }

            var distinctAscendingCollection = listInt.OrderBy(l => l).Distinct().ToList();
            foreach (var number in distinctAscendingCollection)
            {
                Console.WriteLine(number);
            }
        }
    }

