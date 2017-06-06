namespace _01.Students_Results
{
    using System;

    public class StudentsResults
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            string[][] lines = new string[n][];

            for (int i = 0; i < n; i++)
            {
                lines[i]= Console.ReadLine().Split(new char[] { '-', ',' }, StringSplitOptions.RemoveEmptyEntries);
            }

            Console.WriteLine("Name      |   CAdv|   COOP| AdvOOP|Average|");
            for (int i = 0; i < n; i++)
            {
                string name = lines[i][0];
                double CAdv = double.Parse(lines[i][1]);
                double COOP = double.Parse(lines[i][2]);
                double AdvOOP = double.Parse(lines[i][3]);
                double average = (CAdv + COOP + AdvOOP) / 3;
                Console.WriteLine(string.Format("{0, -10}|{1, 7:F2}|{2, 7:F2}|{3, 7:F2}|{4, 7:F4}|", name, CAdv, COOP, AdvOOP, average));
            }
        }
    }
}
