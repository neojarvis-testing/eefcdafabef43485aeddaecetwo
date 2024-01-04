using System.Numerics;
using Microsoft.Data.SqlClient;
using System.Reflection;
using Microsoft.AspNetCore.Mvc;
using NUnit.Framework;

namespace TestProject
{
    public class Tests
    {

        // Test to check whether Employee Models Class exists
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

        // Test to check whether EmployeeController Controllers Class exists
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

        // Test to Check EmployeeController Controllers Method Index Returns ActionResult
        [Test]
        public void EmployeeController_Index_MethodReturns_ActionResult()
        {
            string assemblyName = "dotnetapp";
            string typeName = "dotnetapp.Controllers.EmployeeController";
            Assembly assembly = Assembly.Load(assemblyName);
            Type EmployeeControllerType = assembly.GetType(typeName);
            MethodInfo methodInfo = EmployeeControllerType.GetMethod("Index");
            Assert.AreEqual(typeof(ActionResult), methodInfo.ReturnType, "Method Index in EmployeeController class is not of type ActionResult");
        }

        // Test to Check EmployeeController Controllers Method Create Exists
        [Test]
        public void EmployeeController_Create_Method_with_NoParams_Exists()
        {
            string assemblyName = "dotnetapp";
            string typeName = "dotnetapp.Controllers.EmployeeController";
            Assembly assembly = Assembly.Load(assemblyName);
            Type EmployeeControllerType = assembly.GetType(typeName);
            MethodInfo methodInfo = EmployeeControllerType.GetMethod("Create", Type.EmptyTypes);
            Assert.IsNotNull(methodInfo, "Method Create does not exist in EmployeeController class");
        }

        // Test to Check EmployeeController Controllers Method Create with no parameter Returns ActionResult
        [Test]
        public void EmployeeController_Create_Method_with_NoParams_Returns_ActionResult()
        {
            string assemblyName = "dotnetapp";
            string typeName = "dotnetapp.Controllers.EmployeeController";
            Assembly assembly = Assembly.Load(assemblyName);
            Type EmployeeControllerType = assembly.GetType(typeName);
            MethodInfo methodInfo = EmployeeControllerType.GetMethod("Create", Type.EmptyTypes);
            Assert.AreEqual(typeof(ActionResult), methodInfo.ReturnType, "Method Create in EmployeeController class is not of type ActionResult");
        }

        // Test to Check EmployeeController Controllers Method Create with no parameter Returns ActionResult
        [Test]
        public void EmployeeController_Create_Method_with_Employee_Parameter_Returns_ActionResult()
        {
            string assemblyName = "dotnetapp";
            string typeName = "dotnetapp.Controllers.EmployeeController";
            string typeName1 = "dotnetapp.Models.Employee";
            Assembly assembly = Assembly.Load(assemblyName);
            Type EmployeeControllerType = assembly.GetType(typeName);
            Type EmployeeModelType = assembly.GetType(typeName1);
            MethodInfo methodInfo = EmployeeControllerType.GetMethod("Create", new[] { EmployeeModelType });
            Assert.AreEqual(typeof(ActionResult), methodInfo.ReturnType, "Method Create in EmployeeController class is not of type ActionResult");
            object instanceOfController = Activator.CreateInstance(EmployeeControllerType);
            object instanceOfModel = Activator.CreateInstance(EmployeeModelType);
            object result = methodInfo.Invoke(instanceOfController, new object[] { instanceOfModel });
            Assert.IsNotNull(result);
        }

        // Test to Check EmployeeController Controllers Method Search Exists
        [Test]
        public void EmployeeController_Search_MethodExists()
        {
            string assemblyName = "dotnetapp";
            string typeName = "dotnetapp.Controllers.EmployeeController";
            Assembly assembly = Assembly.Load(assemblyName);
            Type EmployeeControllerType = assembly.GetType(typeName);
            MethodInfo methodInfo = EmployeeControllerType.GetMethod("Search");
            Assert.IsNotNull(methodInfo, "Method Search does not exist in EmployeeController class");
        }

        // Test to Check EmployeeController Controllers Method Search Returns ActionResult
        [Test]
        public void EmployeeController_Search_MethodReturns_ActionResult()
        {
            string assemblyName = "dotnetapp";
            string typeName = "dotnetapp.Controllers.EmployeeController";
            Assembly assembly = Assembly.Load(assemblyName);
            Type EmployeeControllerType = assembly.GetType(typeName);
            MethodInfo methodInfo = EmployeeControllerType.GetMethod("Search");
            Assert.AreEqual(typeof(ActionResult), methodInfo.ReturnType, "Method Search in EmployeeController class is not of type ActionResult");
        }

        // Test to Check EmployeeController Controllers Method Search with parameter string Returns ActionResult
        [Test]
        public void EmployeeController_Search_Method_Invokes_with_string_Param_Returns_ActionResult()
        {
            string assemblyName = "dotnetapp";
            string typeName = "dotnetapp.Controllers.EmployeeController";
            Assembly assembly = Assembly.Load(assemblyName);
            Type EmployeeControllerType = assembly.GetType(typeName);
            object instance = Activator.CreateInstance(EmployeeControllerType);
            MethodInfo methodInfo = EmployeeControllerType.GetMethod("Search", new Type[] { typeof(string) });
            object result = methodInfo.Invoke(instance, new object[] { default(string) });
            Assert.IsNotNull(result, "Result should not be null");
        }

        [Test]
        public void ShouldUseADONET_Classes_SqlCommand()
        {
            string assemblyName = "dotnetapp";
            string typeName = "dotnetapp.Controllers.EmployeeController";
            Assembly assembly1 = Assembly.Load(assemblyName);
            Type CarserviceControllerType = assembly1.GetType(typeName);
            var assembly = Assembly.GetAssembly(CarserviceControllerType);
            var types = assembly.GetTypes();

            // Act
            var containsSqlCommand = types.Any(type =>
                type.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public)
                    .SelectMany(method => method.GetMethodBody()?.LocalVariables.Cast<LocalVariableInfo>() ?? Enumerable.Empty<LocalVariableInfo>())
                    .Any(variable => variable.LocalType == typeof(SqlCommand))
            );

            // Assert
            Assert.IsTrue(containsSqlCommand, "SqlCommand is not used in the application.");
        }

        [Test]
        public void ShouldUseADONET_Classes_SqlConnection()
        {
            string assemblyName = "dotnetapp";
            string typeName = "dotnetapp.Controllers.EmployeeController";
            Assembly assembly1 = Assembly.Load(assemblyName);
            Type CarserviceControllerType = assembly1.GetType(typeName);
            var assembly = Assembly.GetAssembly(CarserviceControllerType);
            var types = assembly.GetTypes();

            // Act
            var containsSqlConnection = types.Any(type =>
                type.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Public)
                    .SelectMany(method => method.GetMethodBody()?.LocalVariables.Cast<LocalVariableInfo>() ?? Enumerable.Empty<LocalVariableInfo>())
                    .Any(variable => variable.LocalType == typeof(SqlConnection))
            );

            // Assert
            Assert.IsTrue(containsSqlConnection, "SqlConnection is not used in the application.");
        }


    }
}


