using Lab03InterfaceApp.InsiteInternational;

namespace Lab03InterfaceApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DoDbOperations(new CustomerDAL());
            DoDbOperations(new EmployeeDAL());
            DoDbOperations(new DepartmentDAL());
        }

        //polymorphic
        static void DoDbOperations(ICrudable obj) {

            Console.WriteLine("Doing differnt db operations");
            obj.Create();
            obj.Read();
            obj.Update();
            obj.Delete();
            Console.WriteLine();
            
        }

    }
}
