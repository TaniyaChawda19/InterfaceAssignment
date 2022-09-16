namespace InterfaceAssignment
{

    interface GovtRules
    {
        void EmployeePf(double basicSalary);
        string LeaveDetails();
        double gratuityAmount(float serviceCompleted, double basicSalary);

    }
    class TCS : GovtRules
    {
        int empid;
        string name;
        string dept;
        string desg;
        int basicSalary;
        float serviceCompleted;


       public TCS(int empid, string name, string dept, string desg, int basicSalary,float serviceCompleted)
        {
            this.empid = empid;
            this.name = name;
            this.dept = dept;
            this.desg = desg;
            this.basicSalary = basicSalary;
            this.serviceCompleted = serviceCompleted;
        }
        public int EmpId { get { return empid; } }
        public string Name { get { return name; } }
        public string Dept { get { return dept; } }
        public string Desg { get { return desg; } }
        public int BasicSalary { get { return basicSalary; } }

        public float ServiceCompleted { get { return serviceCompleted; } }

        public void EmployeePf(double basicSalary)
        {
            Console.WriteLine("Total Contribution to PF : " + 0.12 * basicSalary);
            Console.WriteLine("Employer Contribution to PF : " + 0.0833 * basicSalary);
            Console.WriteLine("Employee Contribution to PF : " + 0.0367 * basicSalary);
            


        }
        public string LeaveDetails()
        {
            return "1 day of Casual Leave per month. \n12 days of Sick Leave Per Year. \n10 days of Privilage leave per year ";

        }

        public double gratuityAmount(float serviceCompleted, double basicSalary)
        {
            if(serviceCompleted >5 && serviceCompleted < 10)
            {
                return basicSalary;
            }
            else if(serviceCompleted>10 && serviceCompleted<20)
            {
                return 2 * basicSalary;
            }
            else if (serviceCompleted == 20 || serviceCompleted>20)
            {
                return 3*basicSalary;
            }
            else
            {
                return 0;
            }
        }

    }

    class Accenture: GovtRules
    {
        int empid;
        string name;
        string dept;
        string desg;
        int basicSalary;
        


        public Accenture(int empid, string name, string dept, string desg, int basicSalary)
        {
            this.empid = empid;
            this.name = name;
            this.dept = dept;
            this.desg = desg;
            this.basicSalary = basicSalary;
  
        }
        public int EmpId { get { return empid; } }
        public string Name { get { return name; } }
        public string Dept { get { return dept; } }
        public string Desg { get { return desg; } }
        public int BasicSalary { get { return basicSalary; } }


        public void EmployeePf(double basicSalary)
        {
            Console.WriteLine("Total Contribution to PF : " + 0.12 * basicSalary);
            
            



        }
        public string LeaveDetails()
        {
            return "2 day of Casual Leave per month. \n5 days of Sick Leave Per Year. \n5 days of Privilage leave per year ";

        }

        public double gratuityAmount(float serviceCompleted, double basicSalary) { return 0; }


    }


    internal class Ques1
    {
        static void Main(string[] args)
        {
            var ob = new TCS(1, "Taniya", ".Net", "Senior Analyst", 21000, 6);
            Console.WriteLine("Employee Id : " +ob.EmpId);
            Console.WriteLine("Employee Name : "+ob.Name);
            Console.WriteLine("Department : " + ob.Dept);
            Console.WriteLine("Designation : " + ob.Desg);
            Console.WriteLine("Basic Salary : " + ob.BasicSalary);
            Console.WriteLine("Service Completed : " + ob.ServiceCompleted);
            ob.EmployeePf(ob.BasicSalary);
            Console.WriteLine(ob.LeaveDetails());
            Console.WriteLine("Gratuity Amount : "+ ob.gratuityAmount(ob.ServiceCompleted, ob.BasicSalary));


            Console.WriteLine("");
            var ob1 = new Accenture(2, "A", "JAVA", "Software Engineer", 28000);

            Console.WriteLine("Employee Id : " + ob1.EmpId);
            Console.WriteLine("Employee Name : " + ob1.Name);
            Console.WriteLine("Department : " + ob1.Dept);
            Console.WriteLine("Designation : " + ob1.Desg);
            Console.WriteLine("Basic Salary : " + ob1.BasicSalary);
            ob1.EmployeePf(ob1.BasicSalary);
            Console.WriteLine(ob1.LeaveDetails());
        }


    }

/*-----------------------------------------------------------------*/

    public abstract class A
    {
        public abstract int dailyValue(int dailyvalue);

        public int MonthlySalesValue(int dailySalesValue) //non-abstaract
        {
            return 30 * dailySalesValue;
        }       

    }

    interface B
    {
        int yearlysales(int monthlysales);
    }

    public class C : A, B
    {
        public int dailyvalue;

        public C(int dailyvalue)
        {
            this.dailyvalue = dailyvalue;
        }
       override public int dailyValue(int dailyvalue)
        {
            return dailyvalue;
        }

        public int yearlysales(int monthlysales)
        {
            return 12 * monthlysales;
        }
    }

    class ques2
    {
        static void Main(string[] args)
        {
            var ob=new C(400);
            Console.WriteLine("Daily sales : " + ob.dailyValue(ob.dailyvalue));
            Console.WriteLine("Monthly sales : " + ob.MonthlySalesValue(ob.dailyvalue));
            Console.WriteLine("Yearly sales : "+ob.yearlysales(ob.MonthlySalesValue(ob.dailyvalue)));
        }
    }
}