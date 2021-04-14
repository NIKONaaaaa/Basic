namespace CompanyUsers
{
    using System;
    using System.Collections.Generic;
    class StartUp
    {
        static void Main()
        {
            SortedDictionary<string, List<string>> companyList = new SortedDictionary<string, List<string>>();
            string[] commandInput = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
            while (commandInput[0] != "End")
            {
                if (!companyList.ContainsKey(commandInput[0]))
                {
                    companyList.Add(commandInput[0], new List<string>() { commandInput[1] });
                }
                else if (!companyList[commandInput[0]].Contains(commandInput[1]))
                {
                    companyList[commandInput[0]].Add(commandInput[1]);
                }
                commandInput = Console.ReadLine().Split(" -> ", StringSplitOptions.RemoveEmptyEntries);
            }
            foreach (KeyValuePair<string, List<string>> company in companyList)
            {
                Console.WriteLine(company.Key);
                foreach (string employeeID in company.Value)
                {
                    Console.WriteLine(string.Join(Environment.NewLine, $"-- {employeeID}"));
                }
            }
        }
    }
}