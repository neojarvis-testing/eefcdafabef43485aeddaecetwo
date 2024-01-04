using NUnit.Framework;
using dotnetapp.Controllers;
using dotnetapp.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Reflection;

namespace EmployeeApp.Tests
{
    [TestFixture]
    public class EmployeeControllerTests
    {
        [Test]
        public void TestCreatePostMethodReturnsIActionResult()
        {
            Assembly assembly = Assembly.Load("dotnetapp");

            // Get the types
            Type EmployeeControllerType = assembly.GetType("dotnetapp.Controllers.EmployeeController");
            Type EmployeeType = assembly.GetType("dotnetapp.Models.Employee");
            var controller = Activator.CreateInstance(EmployeeControllerType);
            MethodInfo createPostMethod = EmployeeControllerType.GetMethod("Create", new Type[] { EmployeeType });

            // Act
            var employeeInstance = Activator.CreateInstance(EmployeeType);
            var result = createPostMethod.Invoke(controller, new object[] { employeeInstance });
            Console.WriteLine(result);

            // Assert
            Assert.IsInstanceOf<IActionResult>(result, "Create (POST) method should return an IActionResult.");
        }


        [Test]
        public void Test_CreateViewFile_Exists()
        {
            string indexPath = Path.Combine(@"/home/coder/project/workspace/dotnetapp/Views/Employee", "Create.cshtml");
            bool indexViewExists = File.Exists(indexPath);

            Assert.IsTrue(indexViewExists, "Create.cshtml view file does not exist.");
        }

        [Test]
        public void Test_IndexViewFile_Exists()
        {
            string indexPath = Path.Combine(@"/home/coder/project/workspace/dotnetapp/Views/Employee", "Index.cshtml");
            bool indexViewExists = File.Exists(indexPath);

            Assert.IsTrue(indexViewExists, "Index.cshtml view file does not exist.");
        }

        [Test]
        public void Employee_Models_ClassExists()
        {
            string assemblyName = "dotnetapp";
            string typeName = "dotnetapp.Models.Employee";
            Assembly assembly = Assembly.Load(assemblyName);
            Type EmployeeType = assembly.GetType(typeName);
            Assert.IsNotNull(EmployeeType);
        }

        // Test to Check Employee Models Property id Exists with correcct datatype int    
        [Test]
        public void Employee_id_PropertyExists_ReturnExpectedDataTypes_int()
        {
            string assemblyName = "dotnetapp";
            string typeName = "dotnetapp.Models.Employee";
            Assembly assembly = Assembly.Load(assemblyName);
            Type EmployeeType = assembly.GetType(typeName);
            PropertyInfo propertyInfo = EmployeeType.GetProperty("id");
            Assert.IsNotNull(propertyInfo, "Property id does not exist in Employee class");
            Type expectedType = propertyInfo.PropertyType;
            Assert.AreEqual(typeof(int), expectedType, "Property id in Employee class is not of type int");
        }

        // Test to Check Employee Models Property Name Exists with correcct datatype string    
        [Test]
        public void Employee_Name_PropertyExists_ReturnExpectedDataTypes_string()
        {
            string assemblyName = "dotnetapp";
            string typeName = "dotnetapp.Models.Employee";
            Assembly assembly = Assembly.Load(assemblyName);
            Type EmployeeType = assembly.GetType(typeName);
            PropertyInfo propertyInfo = EmployeeType.GetProperty("Name");
            Assert.IsNotNull(propertyInfo, "Property Name does not exist in Employee class");
            Type expectedType = propertyInfo.PropertyType;
            Assert.AreEqual(typeof(string), expectedType, "Property Name in Employee class is not of type string");
        }

        // Test to Check Employee Models Property DOB Exists with correcct datatype DateTime    
        [Test]
        public void Employee_DOB_PropertyExists_ReturnExpectedDataTypes_DateTime()
        {
            string assemblyName = "dotnetapp";
            string typeName = "dotnetapp.Models.Employee";
            Assembly assembly = Assembly.Load(assemblyName);
            Type EmployeeType = assembly.GetType(typeName);
            PropertyInfo propertyInfo = EmployeeType.GetProperty("DOB");
            Assert.IsNotNull(propertyInfo, "Property DOB does not exist in Employee class");
            Type expectedType = propertyInfo.PropertyType;
            Assert.AreEqual(typeof(DateTime), expectedType, "Property DOB in Employee class is not of type DateTime");
        }

        // Test to Check Employee Models Property Gender Exists with correcct datatype string    
        [Test]
        public void Employee_Gender_PropertyExists_ReturnExpectedDataTypes_string()
        {
            string assemblyName = "dotnetapp";
            string typeName = "dotnetapp.Models.Employee";
            Assembly assembly = Assembly.Load(assemblyName);
            Type EmployeeType = assembly.GetType(typeName);
            PropertyInfo propertyInfo = EmployeeType.GetProperty("Gender");
            Assert.IsNotNull(propertyInfo, "Property Gender does not exist in Employee class");
            Type expectedType = propertyInfo.PropertyType;
            Assert.AreEqual(typeof(string), expectedType, "Property Gender in Employee class is not of type string");
        }

        // Test to Check Employee Models Property Department Exists with correcct datatype string    
        [Test]
        public void Employee_Department_PropertyExists_ReturnExpectedDataTypes_string()
        {
            string assemblyName = "dotnetapp";
            string typeName = "dotnetapp.Models.Employee";
            Assembly assembly = Assembly.Load(assemblyName);
            Type EmployeeType = assembly.GetType(typeName);
            PropertyInfo propertyInfo = EmployeeType.GetProperty("Department");
            Assert.IsNotNull(propertyInfo, "Property Department does not exist in Employee class");
            Type expectedType = propertyInfo.PropertyType;
            Assert.AreEqual(typeof(string), expectedType, "Property Department in Employee class is not of type string");
        }

        // Test to Check Employee Models Property Position Exists with correcct datatype string    
        [Test]
        public void Employee_Position_PropertyExists_ReturnExpectedDataTypes_string()
        {
            string assemblyName = "dotnetapp";
            string typeName = "dotnetapp.Models.Employee";
            Assembly assembly = Assembly.Load(assemblyName);
            Type EmployeeType = assembly.GetType(typeName);
            PropertyInfo propertyInfo = EmployeeType.GetProperty("Position");
            Assert.IsNotNull(propertyInfo, "Property Position does not exist in Employee class");
            Type expectedType = propertyInfo.PropertyType;
            Assert.AreEqual(typeof(string), expectedType, "Property Position in Employee class is not of type string");
        }

        // Test to Check Employee Models Property salary Exists with correcct datatype decimal    
        [Test]
        public void Employee_salary_PropertyExists_ReturnExpectedDataTypes_decimal()
        {
            string assemblyName = "dotnetapp";
            string typeName = "dotnetapp.Models.Employee";
            Assembly assembly = Assembly.Load(assemblyName);
            Type EmployeeType = assembly.GetType(typeName);
            PropertyInfo propertyInfo = EmployeeType.GetProperty("salary");
            Assert.IsNotNull(propertyInfo, "Property salary does not exist in Employee class");
            Type expectedType = propertyInfo.PropertyType;
            Assert.AreEqual(typeof(decimal), expectedType, "Property salary in Employee class is not of type decimal");
        }

        // Test to Check Employee Models Property Email Exists with correcct datatype string    
        [Test]
        public void Employee_Email_PropertyExists_ReturnExpectedDataTypes_string()
        {
            string assemblyName = "dotnetapp";
            string typeName = "dotnetapp.Models.Employee";
            Assembly assembly = Assembly.Load(assemblyName);
            Type EmployeeType = assembly.GetType(typeName);
            PropertyInfo propertyInfo = EmployeeType.GetProperty("Email");
            Assert.IsNotNull(propertyInfo, "Property Email does not exist in Employee class");
            Type expectedType = propertyInfo.PropertyType;
            Assert.AreEqual(typeof(string), expectedType, "Property Email in Employee class is not of type string");
        }

        // Test to Check Employee Models Property phoneNumber Exists with correcct datatype string    
        [Test]
        public void Employee_phoneNumber_PropertyExists_ReturnExpectedDataTypes_string()
        {
            string assemblyName = "dotnetapp";
            string typeName = "dotnetapp.Models.Employee";
            Assembly assembly = Assembly.Load(assemblyName);
            Type EmployeeType = assembly.GetType(typeName);
            PropertyInfo propertyInfo = EmployeeType.GetProperty("phoneNumber");
            Assert.IsNotNull(propertyInfo, "Property phoneNumber does not exist in Employee class");
            Type expectedType = propertyInfo.PropertyType;
            Assert.AreEqual(typeof(string), expectedType, "Property phoneNumber in Employee class is not of type string");
        }

        // Test to Check Employee Models Property Address Exists with correcct datatype string    
        [Test]
        public void Employee_Address_PropertyExists_ReturnExpectedDataTypes_string()
        {
            string assemblyName = "dotnetapp";
            string typeName = "dotnetapp.Models.Employee";
            Assembly assembly = Assembly.Load(assemblyName);
            Type EmployeeType = assembly.GetType(typeName);
            PropertyInfo propertyInfo = EmployeeType.GetProperty("Address");
            Assert.IsNotNull(propertyInfo, "Property Address does not exist in Employee class");
            Type expectedType = propertyInfo.PropertyType;
            Assert.AreEqual(typeof(string), expectedType, "Property Address in Employee class is not of type string");
        }

        [Test]
        public void EmployeeController_Controllers_ClassExists()
        {
            string assemblyName = "dotnetapp";
            string typeName = "dotnetapp.Controllers.EmployeeController";
            Assembly assembly = Assembly.Load(assemblyName);
            Type EmployeeControllerType = assembly.GetType(typeName);
            Assert.IsNotNull(EmployeeControllerType);
        }

        // Test to Check EmployeeController Controllers Method Index Exists
        [Test]
        public void EmployeeController_Index_MethodExists()
        {
            string assemblyName = "dotnetapp";
            string typeName = "dotnetapp.Controllers.EmployeeController";
            Assembly assembly = Assembly.Load(assemblyName);
            Type EmployeeControllerType = assembly.GetType(typeName);
            MethodInfo methodInfo = EmployeeControllerType.GetMethod("Index");
            Assert.IsNotNull(methodInfo, "Method Index does not exist in EmployeeController class");
        }

        // Test to Check EmployeeController Controllers Method Create Exists
        [Test]
        public void EmployeeController_Create_MethodExists()
        {
            string assemblyName = "dotnetapp";
            string typeName = "dotnetapp.Controllers.EmployeeController";
            Assembly assembly = Assembly.Load(assemblyName);
            Type EmployeeControllerType = assembly.GetType(typeName);
            Type employeeType = assembly.GetType("dotnetapp.Models.Employee");

            // Specify the parameter types and modifiers
            Type[] parameterTypes = { employeeType };
            MethodInfo methodInfo = EmployeeControllerType.GetMethod("Create", parameterTypes);
            Assert.IsNotNull(methodInfo, "Method Create does not exist in EmployeeController class");
        }

        [Test]
        public void EmployeeController_Search_MethodExists()
        {
            string assemblyName = "dotnetapp";
            string typeName = "dotnetapp.Controllers.EmployeeController";
            Assembly assembly = Assembly.Load(assemblyName);
            Type EmployeeControllerType = assembly.GetType(typeName);
            Type employeeType = assembly.GetType("dotnetapp.Models.Employee");

            // Specify the parameter types and modifiers
            Type[] parameterTypes = { typeof(string) };
            MethodInfo methodInfo = EmployeeControllerType.GetMethod("Search", parameterTypes);
            Assert.IsNotNull(methodInfo, "Method Create does not exist in EmployeeController class");


            // Create an instance of EmployeeController (assuming it has a parameterless constructor)
            object employeeControllerInstance = Activator.CreateInstance(EmployeeControllerType);

            // Specify the argument values to pass to the Search method
            object[] arguments = { "YourSearchString" }; // Replace "YourSearchString" with the actual search string

            // Invoke the Search method
            object result = methodInfo.Invoke(employeeControllerInstance, arguments);

            Assert.IsNotNull(result, "Search method returned null");
        }

        // Test to Check EmployeeController Controllers Method Edit Exists
        //[Test]
        //public void EmployeeController_Edit_MethodExists()
        //{
        //    string assemblyName = "dotnetapp";
        //    string typeName = "dotnetapp.Controllers.EmployeeController";
        //    Assembly assembly = Assembly.Load(assemblyName);
        //    Type EmployeeControllerType = assembly.GetType(typeName);
        //    MethodInfo methodInfo = EmployeeControllerType.GetMethod("Edit", new Type[] { typeof(int) });
        //    Assert.IsNotNull(methodInfo, "Method Edit does not exist in EmployeeController class");
        //}

        //// Test to Check EmployeeController Controllers Method Delete Exists
        //[Test]
        //public void EmployeeController_Delete_MethodExists()
        //{
        //    string assemblyName = "dotnetapp";
        //    string typeName = "dotnetapp.Controllers.EmployeeController";
        //    Assembly assembly = Assembly.Load(assemblyName);
        //    Type EmployeeControllerType = assembly.GetType(typeName);
        //    MethodInfo methodInfo = EmployeeControllerType.GetMethod("Delete");
        //    Assert.IsNotNull(methodInfo, "Method Delete does not exist in EmployeeController class");
        //}

        //[Test]
        //public void EmployeeController_Edit_Method_Returns_NotFoundResult_When_Id_is_not_existing()
        //{
        //    string assemblyName = "dotnetapp";
        //    string typeName = "dotnetapp.Controllers.EmployeeController";
        //    Assembly assembly = Assembly.Load(assemblyName);
        //    Type EmployeeControllerType = assembly.GetType(typeName);
        //    var controller = Activator.CreateInstance(EmployeeControllerType);

        //    MethodInfo methodInfo = EmployeeControllerType.GetMethod("Edit", new Type[] { typeof(int) });
        //    // Act
        //    var result = methodInfo.Invoke(controller, new object[] { 100 });
        //    Console.WriteLine(result);
        //    // Assert
        //    Assert.IsNotNull(result);
        //    Assert.IsInstanceOf<NotFoundResult>(result);
        //}

    }
}


