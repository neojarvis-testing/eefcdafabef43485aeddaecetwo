#!/bin/bash  
if [ ! -d "/home/coder/project/workspace/dotnetapp/" ]
then
    cp -r /home/coder/project/workspace/nunit/dotnetapp /home/coder/project/workspace/;
fi
if [ -d "/home/coder/project/workspace/dotnetapp/" ]
then
    echo "project folder present"
    # checking for src folder
    if [ -d "/home/coder/project/workspace/dotnetapp/" ]
    then
        cp -r /home/coder/project/workspace/nunit/test/TestProject /home/coder/project/workspace/dotnetapp/;
        cp -r /home/coder/project/workspace/nunit/test/dotnetapp.sln /home/coder/project/workspace/dotnetapp/;
        cd /home/coder/project/workspace/dotnetapp || exit;
        dotnet clean;
        dotnet build && dotnet test -l "console;verbosity=normal";
    else
        echo "Employee_Models_ClassExists FAILED";
        echo "Employee_id_PropertyExists_ReturnExpectedDataTypes_int FAILED";
        echo "Employee_Name_PropertyExists_ReturnExpectedDataTypes_string FAILED";
        echo "Employee_DOB_PropertyExists_ReturnExpectedDataTypes_DateTime FAILED";
        echo "Employee_Gender_PropertyExists_ReturnExpectedDataTypes_string FAILED";
        echo "Employee_Department_PropertyExists_ReturnExpectedDataTypes_string FAILED";
        echo "Employee_Position_PropertyExists_ReturnExpectedDataTypes_string FAILED";
        echo "Employee_salary_PropertyExists_ReturnExpectedDataTypes_decimal FAILED";
        echo "Employee_Email_PropertyExists_ReturnExpectedDataTypes_string FAILED";
        echo "Employee_phoneNumber_PropertyExists_ReturnExpectedDataTypes_string FAILED";
        echo "Employee_Address_PropertyExists_ReturnExpectedDataTypes_string FAILED";
        echo "EmployeeController_Controllers_ClassExists FAILED";
        echo "EmployeeController_Index_MethodExists FAILED";
        echo "EmployeeController_Index_MethodReturns_ActionResult FAILED";
        echo "EmployeeController_Create_Method_with_NoParams_Exists FAILED";
        echo "EmployeeController_Create_Method_with_NoParams_Returns_ActionResult FAILED";
        echo "EmployeeController_Create_Method_with_Employee_Parameter_Returns_ActionResult FAILED";
        echo "EmployeeController_Search_MethodExists FAILED";
        echo "EmployeeController_Search_MethodReturns_ActionResult FAILED";
        echo "EmployeeController_Search_Method_Invokes_with_string_Param_Returns_ActionResult FAILED";
        echo "ShouldUseADONET_Classes_SqlCommand FAILED";
        echo "ShouldUseADONET_Classes_SqlConnection FAILED";
    fi
else
    echo "Employee_Models_ClassExists FAILED";
    echo "Employee_id_PropertyExists_ReturnExpectedDataTypes_int FAILED";
    echo "Employee_Name_PropertyExists_ReturnExpectedDataTypes_string FAILED";
    echo "Employee_DOB_PropertyExists_ReturnExpectedDataTypes_DateTime FAILED";
    echo "Employee_Gender_PropertyExists_ReturnExpectedDataTypes_string FAILED";
    echo "Employee_Department_PropertyExists_ReturnExpectedDataTypes_string FAILED";
    echo "Employee_Position_PropertyExists_ReturnExpectedDataTypes_string FAILED";
    echo "Employee_salary_PropertyExists_ReturnExpectedDataTypes_decimal FAILED";
    echo "Employee_Email_PropertyExists_ReturnExpectedDataTypes_string FAILED";
    echo "Employee_phoneNumber_PropertyExists_ReturnExpectedDataTypes_string FAILED";
    echo "Employee_Address_PropertyExists_ReturnExpectedDataTypes_string FAILED";
    echo "EmployeeController_Controllers_ClassExists FAILED";
    echo "EmployeeController_Index_MethodExists FAILED";
    echo "EmployeeController_Index_MethodReturns_ActionResult FAILED";
    echo "EmployeeController_Create_Method_with_NoParams_Exists FAILED";
    echo "EmployeeController_Create_Method_with_NoParams_Returns_ActionResult FAILED";
    echo "EmployeeController_Create_Method_with_Employee_Parameter_Returns_ActionResult FAILED";
    echo "EmployeeController_Search_MethodExists FAILED";
    echo "EmployeeController_Search_MethodReturns_ActionResult FAILED";
    echo "EmployeeController_Search_Method_Invokes_with_string_Param_Returns_ActionResult FAILED";
    echo "ShouldUseADONET_Classes_SqlCommand FAILED";
    echo "ShouldUseADONET_Classes_SqlConnection FAILED";
fi
