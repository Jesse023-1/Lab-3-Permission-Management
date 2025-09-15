using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_3_Permission_Management
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Add 4 users with none permissions (Admin, operator, manager,senior)
            User operatorUser = new User("operator");
            User SeniorUser = new User("senior");
            User managerUser = new User("manager");
            User adminUser = new User("admin");
            /**
             * 
             * Add read permission to operatorUser look at line 25 to line 31
             * Add read, write, execute permissions to manager
             * Add read, write permissions to senior
             * Add full permission(read,write,execution) to admin
             */
            operatorUser.AddPermission(Permissions.Read);
            if(operatorUser.HasPermission(Permissions.Read))
                Console.WriteLine("Operator has read permission");
            else
                Console.WriteLine("Operator does not have read permission");

            //Code for Remove permission for testing
            /*
            operatorUser.RemovePermission(Permissions.Read);
            if (operatorUser.HasPermission(Permissions.Read))
                Console.WriteLine("Operator has read permission");
            else
                Console.WriteLine("Operator does not have read permission");
            */

            managerUser.AddPermission(Permissions.Execute);
            managerUser.multiplyPermission(Permissions.Read, Permissions.Write);
            if (managerUser.HasPermission(Permissions.Read) && managerUser.HasPermission(Permissions.Write) 
                && managerUser.HasPermission(Permissions.Execute))
                Console.WriteLine("Manager has read, write, execute permission");
            else
                Console.WriteLine("Manager does not have read & write permission");

            SeniorUser.multiplyPermission(Permissions.Read,Permissions.Write);
            if (SeniorUser.HasPermission(Permissions.Read) &&  SeniorUser.HasPermission(Permissions.Write))
                Console.WriteLine("Senior has read & write permission");
            else
                Console.WriteLine("Senior does not have read & write permission");
            
            //Code for removeMultiplyPermission for testing
            /*
            SeniorUser.removeMultiplyPermission(Permissions.Read, Permissions.Write);
            if (SeniorUser.HasPermission(Permissions.Read) && SeniorUser.HasPermission(Permissions.Write))
                Console.WriteLine("Senior has read & write permission");
            else
                Console.WriteLine("Senior does not have read & write permission");
            */

            adminUser.AddPermission (Permissions.Admin);
            if (adminUser.HasPermission(Permissions.Read) && adminUser.HasPermission(Permissions.Write)
                && adminUser.HasPermission(Permissions.Execute))
                Console.WriteLine("Admin has read, write, & execute permission");
            else
                Console.WriteLine("Admin does not have read, write, & execute permission");

            //removeMultiplyPermission test. Result keeps Read. 
            /*
            adminUser.removeMultiplyPermission(Permissions.Write,Permissions.Execute);
            if (adminUser.HasPermission(Permissions.Read) && adminUser.HasPermission(Permissions.Write)
                && adminUser.HasPermission(Permissions.Execute))
                Console.WriteLine("Admin has read, write, & execute permission");
            else if (adminUser.HasPermission(Permissions.Read))
                Console.WriteLine("Admin has read permission");
            else
                Console.WriteLine("Admin does not have read, write, & execute permission");
            */
            /**
             * Look at tasks description in lab3.1 and complete the remaining tasks
             */




        }
    }
}
