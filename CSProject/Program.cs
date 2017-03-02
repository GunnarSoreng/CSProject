using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CSProject
{
    // My version of the final project from the book
    // "Learn C# in one day and learn it well" by Jamie Chan (2015)
    // 
    // 01.03.2017
    //
    // edit

    class Program
    {
        static void Main(string[] args)
        {

            #region Initialize local variables

            List<Staff> myStaff = new List<Staff>();
            FileReader fr = new FileReader();
            int month = 0;
            int year = 0;

            #endregion

            #region Get user input for year/month

            while (year == 0)
            {
                Console.Write("Please enter the year: ");
                try
                {
                    year = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong format.");
                }
            }

            while (month == 0)
            {
                Console.Write("Please enter the month: ");
                try
                {
                    month = Convert.ToInt32(Console.ReadLine());
                    if (month < 1 || month > 12)
                    {
                        Console.WriteLine("Month must be between 1 and 12.");
                        month = 0;
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong format.");

                }
            }

            #endregion

            #region User inputs hours worked for each staff member

            // Reads the file of staff into a list of Staff objects
            myStaff = fr.ReadFile();

            for (int i = 0; i < myStaff.Count; i++)
            {
                try
                {
                    Console.Write("\nEnter hours worked for {0}: ", myStaff[i].NameOfStaff);
                    myStaff[i].HoursWorked = Convert.ToInt32(Console.ReadLine());
                    myStaff[i].CalculatePay();
                    Console.WriteLine(myStaff[i].ToString());

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    // To repeat asking about the same staff members hours:
                    i--;
                }
            }

            #endregion

            #region Write payslips to files

            PaySlip ps = new PaySlip(month,year);
            ps.GeneratePaySlip(myStaff);

            #endregion

            #region Generate summary file

            ps.GenerateSummary(myStaff);

            #endregion

            #region End credits

            Console.WriteLine("Thank you for using PaySoft...");
            Console.Read();

            #endregion

        }
    }

    #region Staff class

    //
    //
    //     Staff class
    //
    //


    class Staff
    {
        //
        // Fields
        //
        private float hourlyRate;
        private int hWorked;

        //
        // Properties
        //
        public float TotalPay { get; protected set; }
        public float BasicPay { get; private set; }
        public string NameOfStaff { get; private set; }
        public int HoursWorked
        {
            get { return hWorked; }
            set
            {
                if (value > 0)
                    hWorked = value;
                else
                    hWorked = 0;
            }
        }

        //
        // Constructor
        //

        public Staff(string name, float rate)
        {
            NameOfStaff = name;
            hourlyRate = rate;
        }

        //
        // Methods
        //
        public virtual void CalculatePay()
        {
            Console.WriteLine("Calculating Pay...");
            BasicPay = hWorked * hourlyRate;
            TotalPay = BasicPay;
        }

        public override string ToString()
        {
            return "\nName: " + NameOfStaff +
                "\nHourly Rate: " + hourlyRate +
                "\nHours Worked: " + HoursWorked +
                "\nBasic Pay: " + BasicPay +
                "\nTotal Pay: " + TotalPay + "\n";
        }
    }

    #endregion

    #region Manager class

    //
    //
    //     Manager class
    //
    //

    class Manager : Staff
    {
        //
        // Fields
        //
        private const float managerHourlyRate = 50;

        //
        // Properties
        //
        public int Allowance { get; private set; }

        //
        // Constructor
        //
        // Sending name,managerHourlyRate to base class Staff
        public Manager(string name) : base(name, managerHourlyRate)
        {

        }

        //
        // Methods
        //
        public override void CalculatePay()
        {
            base.CalculatePay();

            Allowance = 0;

            if (HoursWorked > 160)
            {
                Allowance = 1000;
                TotalPay = BasicPay + Allowance;
            }
        }

        public override string ToString()
        {
            return "\nName: " + NameOfStaff +
                "\nHourly Rate: " + managerHourlyRate +
                "\nHours Worked: " + HoursWorked +
                "\nBasic Pay: " + BasicPay +
                "\nAllowance: "+ Allowance +
                "\nTotal Pay: " + TotalPay + "\n";
        }
    }

    #endregion

    #region Admin class

    //
    //
    //     Admin class
    //
    //


    class Admin : Staff
    {
        //
        // Fields
        //
        private const float overtimeRate = 15.5f;
        private const float adminHourlyRate = 30f;

        //
        // Properties
        //
        public float Overtime { get; private set; }

        //
        // Constructor
        //
        public Admin(string name) : base(name, adminHourlyRate)
        {

        }

        //
        // Methods
        //
        public override void CalculatePay()
        {
            base.CalculatePay();
            if (HoursWorked > 160)
            {
                Overtime = overtimeRate * (HoursWorked - 160);
                TotalPay = BasicPay + Overtime;
            }

        }

        public override string ToString()
        {
            return "\nName: " + NameOfStaff +
                "\nHourly Rate: " + adminHourlyRate +
                "\nHours Worked: " + HoursWorked +
                "\nBasic Pay: " + BasicPay +
                "\nOvertime: " + Overtime +
                "\nTotal Pay: " + TotalPay + "\n";
        }

    }

    #endregion

    #region Filereader class

    //
    //
    //     FileReader class
    //
    //


    class FileReader
    {
        //
        // Methods
        //
        public List<Staff> ReadFile()
        {
            List<Staff> myStaff = new List<Staff>();
            string[] result = new string[2];
            string path = "staff.txt";
            string[] separator = { ", " };

            // File syntax:
            // Name, Position

            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (sr.EndOfStream != true)
                    {
                        result = sr.ReadLine().Split(separator, StringSplitOptions.RemoveEmptyEntries);
                        if (result[1] == "Manager")
                        {
                            myStaff.Add(new Manager(result[0]));
                        }
                        else if (result[1] == "Admin")
                        {
                            myStaff.Add(new Admin(result[0]));
                        }
                    }
                    sr.Close();
                }
            }
            else
            {
                Console.WriteLine("File {0} not found.", path);
            }
            return myStaff;

        }
    } 
    #endregion

    #region PaySlip class

    //
    //
    //     PaySlip class
    //
    //


    class PaySlip
    {
        //
        // Fields
        //
        private int month;
        private int year;

        //
        // Enum
        //
        enum MonthsOfYear
        {
            JAN = 1,
            FEB = 2,
            MAR = 3,
            APR = 4,
            MAY = 5,
            JUN = 6,
            JUL = 7,
            AUG = 8,
            SEP = 9,
            OCT = 10,
            NOV = 11,
            DEC = 12
        }

        //
        // Constructor
        //
        public PaySlip(int payMonth, int payYear)
        {
            month = payMonth;
            year = payYear;
        }

        //
        // Methods
        //
        public void GeneratePaySlip(List<Staff> myStaff)
        {
            string path;
            if (myStaff != null)
            {
                foreach (Staff f in myStaff)
                {
                    try
                    {
                        if (f.NameOfStaff != null)
                        {
                            path = f.NameOfStaff + ".txt";
                        }
                        else
                        {
                            break;
                        }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                        break;
                        //throw;
                    }
                    if (f.NameOfStaff != null)
                    {
                        path = f.NameOfStaff + ".txt";
                    } else
                    {
                        break;
                    }
                    using (StreamWriter sw = new StreamWriter(path))
                    {
                        sw.WriteLine("PAYSLIP FOR {0} {1}", (MonthsOfYear)month, year);
                        sw.WriteLine("==========================");
                        sw.WriteLine("Name of Staff: {0}", f.NameOfStaff);
                        sw.WriteLine("Hours Worked: {0}", f.HoursWorked);
                        sw.WriteLine("");
                        sw.WriteLine("Basic Pay: {0:C}", f.BasicPay);
                        if (f.GetType() == typeof(Manager))
                        {
                            sw.WriteLine("Allowance: {0:C}", ((Manager)f).Allowance);
                        }
                        else if (f.GetType() == typeof(Admin))
                        {
                            sw.WriteLine("Overtime:  {0:C}", ((Admin)f).Overtime);

                        }
                        sw.WriteLine("");
                        sw.WriteLine("==========================");
                        sw.WriteLine("Total Pay: {0:C}", f.TotalPay);
                        sw.WriteLine("==========================");
                        sw.WriteLine("");
                        sw.WriteLine("Thank you for using PaySoft.");

                        sw.Close();
                    }

                }
            }
        }

        public void GenerateSummary(List<Staff> myStaff)
        {
            if (myStaff != null)
            {
                try
                {
                    var result =
                        from staff in myStaff
                        where staff.HoursWorked < 10
                        orderby staff.NameOfStaff ascending
                        select new { staff.NameOfStaff, staff.HoursWorked };
                    string path = "summary.txt";
                    if (result != null)
                    {
                        using (StreamWriter sw = new StreamWriter(path))
                        {
                            sw.WriteLine("Staff with less than 10 working hours");
                            sw.WriteLine("");
                            foreach (var person in result)
                            {
                                sw.WriteLine("Name of Staff: {0}, Hours Worked: {1}", person.NameOfStaff, person.HoursWorked);
                            }

                            sw.Close();
                        }
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    
                    return;
                    // throw;
                }
            }
        }

        public override string ToString()
        {
            return "month = " + month + " year = " + year;
        }

    }


    #endregion

}
