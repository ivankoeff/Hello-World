using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace EmployeesAsignment
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaring the path to the text file
            string filePath = "employees.txt";
           
            //Creating ArrayLists where each column of the text file will be held.
            ArrayList emloyeeID = new ArrayList();
            ArrayList projectID = new ArrayList();
            ArrayList dateFrom = new ArrayList();
            ArrayList dateTo = new ArrayList();

            //Extracting the columns from the text file (CSV)           
            using (StreamReader reader = new StreamReader(filePath))
            {
                string line = reader.ReadLine();
                char[] separators = new char[] { ',', ' ' };

                while (line != null)
                {     
                    string[] values = line.Split(separators, StringSplitOptions.RemoveEmptyEntries);
                                        
                    emloyeeID.Add(values[0]);
                    projectID.Add(values[1]);
                    dateFrom.Add(values[2]);
                    dateTo.Add(values[3]);

                    line = reader.ReadLine();
                }
            }

            //Checks if there is NULL date
            for(int i=0; i<dateTo.Capacity;i++)
            {
                if (dateTo[i].Equals("NULL"))
                {
                    DateTime dt = new DateTime();
                    dt = DateTime.Now;
                    dateTo[i] = dt.ToString();
                }
            }

            //Converting the ArrayLists to the proper data types
            for (int i=1; i<emloyeeID.Capacity; i++)
            {                  
                emloyeeID[i] = Convert.ToInt32(emloyeeID[i]);
                projectID[i] = Convert.ToInt32(projectID[i]);
                dateFrom[i] = Convert.ToDateTime(dateFrom[i]);
                dateTo[i] = Convert.ToDateTime(dateTo[i]);
            }

            //Showing the lists of data as table
            for (int i = 0; i < emloyeeID.Count; i++)
            {
                Console.Write(emloyeeID[i] +" ");
                Console.Write(projectID[i] + " ");
                Console.Write(dateFrom[i] + " ");
                Console.WriteLine(dateTo[i] + " ");
            }

            //Checking who are working together on the same project and for how long
            int project=0;
            int firstEmployee=0;
            int secondEmployee=0;
            long workingPeriodOfFirstEmployee =0;
            long workingPeriodOfSecondEmployee =0;

            for(int i=1; i<projectID.Count-1; i++)
            {                
                for(int k=i+1; k<projectID.Count; k++)
                {
                    if ((int)projectID[i] == (int)projectID[k])
                    {
                        project = (int)projectID[i];
                        firstEmployee = (int)emloyeeID[i];
                        secondEmployee = (int)emloyeeID[k];
                        workingPeriodOfFirstEmployee = ((DateTime)dateTo[i] - (DateTime)dateFrom[i]).Ticks;
                        workingPeriodOfSecondEmployee = ((DateTime)dateTo[k] - (DateTime)dateFrom[k]).Ticks;

                        var spanfirst = TimeSpan.FromTicks(workingPeriodOfFirstEmployee);
                        var spansecond = TimeSpan.FromTicks(workingPeriodOfSecondEmployee);
                        
                        // Assuming 30 day months, rounded to nearest
                        int approximateMonths = (int)Math.Round(spanfirst.TotalDays / 30.0);
                        int approximateMonthsSecond = (int)Math.Round(spansecond.TotalDays / 30.0);

                        //Evaluating the time employees has worked together
                        DateTime startWorkingTogether = new DateTime();
                        DateTime endWorkingTogether = new DateTime();

                        int firstEmployeeEndedBeforSecondEmployeeStarted, secondEmplyeeEndedBeforeFirstEmployeeStarted;
                        firstEmployeeEndedBeforSecondEmployeeStarted = DateTime.Compare((DateTime)dateTo[i], (DateTime)dateFrom[k]);
                        secondEmplyeeEndedBeforeFirstEmployeeStarted = DateTime.Compare((DateTime)dateTo[k], (DateTime)dateFrom[i]);

                        if(firstEmployeeEndedBeforSecondEmployeeStarted>0)
                        {
                            Console.WriteLine($"Employees {firstEmployee} and {secondEmployee} were working on the same project {project}, but not at the same time.");
                        }
                        else
                        {
                            startWorkingTogether = (DateTime)dateFrom[k];
                        }

                        if(secondEmplyeeEndedBeforeFirstEmployeeStarted>0)
                        {
                            Console.WriteLine($"Employees {firstEmployee} and {secondEmployee} were working on the same project {project}, but not at the same time.");
                        }
                        else
                        {
                            startWorkingTogether = (DateTime)dateFrom[i];
                        }
                        if(firstEmployeeEndedBeforSecondEmployeeStarted==0)
                        {
                            Console.WriteLine($"Employee {firstEmployee} ended his work on project {project} on the same date as employee {secondEmployee} started - on {dateTo[i]}");
                        }
                        if (secondEmplyeeEndedBeforeFirstEmployeeStarted == 0)
                        {
                            Console.WriteLine($"Employee {secondEmployee} ended his work on project {project} on the same date as employee {firstEmployee} started  - on {dateTo[k]}");
                        }

                        int endDateComparison = DateTime.Compare((DateTime)dateTo[i], (DateTime)dateTo[k]);
                        if(endDateComparison<0)
                        {
                            endWorkingTogether = (DateTime)dateTo[i];
                        }
                        else
                        {
                            endWorkingTogether = (DateTime)dateTo[k];
                        }

                        long workingTogetherSpan = (endWorkingTogether - startWorkingTogether).Ticks;
                        var spanWorkingTogether = TimeSpan.FromTicks(workingTogetherSpan);

                        // Assuming 30 day months, rounded to nearest
                        int approximateMonthsWorkingTogether = (int)Math.Round(spanWorkingTogether.TotalDays / 30.0);



                        Console.WriteLine($"Employees {firstEmployee} and {secondEmployee} are working on project {project}.");
                        Console.WriteLine($"Employee {firstEmployee} has worked on project {project} - {approximateMonths} months.");
                        Console.WriteLine($"Employee {secondEmployee} has worked on project {project} - {approximateMonthsSecond} months.");
                        Console.WriteLine($"Both employees {firstEmployee} and {secondEmployee} were working on project {project} within {approximateMonthsWorkingTogether} months.");
                    }
                }
            }

          




            Console.ReadKey();
        }
    }
}
