using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Interfaces;
using UiPath.Activities.Contracts;
using _360DegreeTestSuiteDemo;
using System.Data;
using _360DegreeTestSuiteDemo.ObjectRepository;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.Excel;
using UiPath.Excel.Activities;
using UiPath.Excel.Activities.API;
using UiPath.Excel.Activities.API.Models;
using UiPath.Orchestrator.Client.Models;
using UiPath.Testing;
using UiPath.Testing.Activities.TestData;
using UiPath.Testing.Activities.TestDataQueues.Enums;
using UiPath.Testing.Enums;
using UiPath.UIAutomationNext.API.Contracts;
using UiPath.UIAutomationNext.API.Models;
using UiPath.UIAutomationNext.Enums;

[assembly: WorkflowRunnerServiceAttribute(typeof(WorkflowRunnerService))]
namespace _360DegreeTestSuiteDemo
{
    public class WorkflowRunnerService
    {
        private readonly ICodedWorkflowServices _services;
        public WorkflowRunnerService(ICodedWorkflowServices services)
        {
            _services = services;
        }

        /// <summary>
        /// Invokes the CODED TESTCASES/Selectors/Computer Vision Selection Screen.xaml
        /// </summary>
        public void Computer_Vision_Selection_Screen()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"CODED TESTCASES\Selectors\Computer Vision Selection Screen.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the BATCH/Verify Job Output in CSV file.xaml
        /// </summary>
        public void Verify_Job_Output_in_CSV_file()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"BATCH\Verify Job Output in CSV file.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the TERMINAL/Verify Stream File Content.xaml
        /// </summary>
        public void Verify_Stream_File_Content()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"TERMINAL\Verify Stream File Content.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the TERMINAL/Submit Job.xaml
        /// </summary>
        public void Submit_Job()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"TERMINAL\Submit Job.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the DESKTOP/Update User.xaml
        /// </summary>
        public void Update_User()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"DESKTOP\Update User.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the BATCH/Verify Job Output in PDF file.xaml
        /// </summary>
        public void Verify_Job_Output_in_PDF_file()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"BATCH\Verify Job Output in PDF file.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the API/Verify Pet Name.xaml
        /// </summary>
        public void Verify_Pet_Name()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"API\Verify Pet Name.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Workspace/TestCase.xaml
        /// </summary>
        public void TestCase()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Workspace\TestCase.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the TERMINAL/Verify Stream File Content - Copy (1).xaml
        /// </summary>
        public void Verify_Stream_File_Content___Copy__1_()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"TERMINAL\Verify Stream File Content - Copy (1).xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the DESKTOP/Snippets/Login.xaml
        /// </summary>
        public void Login(string user, string password)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"DESKTOP\Snippets\Login.xaml", new Dictionary<string, object>{{"user", user}, {"password", password}}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the DATABASE/Query Database.xaml
        /// </summary>
        public void Query_Database()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"DATABASE\Query Database.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Apply For Loan.xaml
        /// </summary>
        public void Apply_For_Loan()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Apply For Loan.xaml", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the CODED TESTCASES/Selectors/Type_Options.cs
        /// </summary>
        public void Type_Options()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"CODED TESTCASES\Selectors\Type_Options.cs", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the CODED TESTCASES/Selectors/Click Options.cs
        /// </summary>
        public void Click_Options()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"CODED TESTCASES\Selectors\Click Options.cs", new Dictionary<string, object>{}, default, default, default, GetAssemblyName());
        }

        private string GetAssemblyName()
        {
            var assemblyProvider = _services.Container.Resolve<ILibraryAssemblyProvider>();
            return assemblyProvider.GetLibraryAssemblyName(GetType().Assembly);
        }
    }
}