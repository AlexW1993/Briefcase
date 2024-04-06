using System.Collections.Generic;

namespace Portfolio.Models
{
    public class ProgrammingTechnologies
    {
        public List<string> Languages { get; set; }
        public List<string> Software { get; set; }
        public List<string> Frameworks { get; set; }
        public List<string> VersionControl { get; set; }
        public List<string> Architectures { get; set; }
        public List<string> WorkMethods { get; set; }
        public List<string> Diagrams { get; set; }
        public List<string> APIS { get; set; }
        public List<string> Tests { get; set; }
        public List<string> Others { get; set; }

        public ProgrammingTechnologies()
        {
            Languages = GetLanguages();
            Software = GetSoftware();
            Frameworks = GetFrameworks();
            VersionControl = GetVersionControl();
            Architectures = GetArchitectures();
            WorkMethods = GetWorkMethods();
            Diagrams = GetDiagrams();
            APIS = GetAPIS();
            Others = GetOthers();
            Tests = GetTests(); 
        }

        private List<string> GetLanguages() 
        {
            string[] languages = {
                "C#", "HTML", "CSS", "SQL", "MySQL", "XAML", "Java", "Kotlin" 
            };

            return languages.ToList();
        }

        private List<string> GetSoftware()
        {
            string[] software = {
                "Visual Studio 2022", "Android Studio", "IntelliJ IDEA", "SQL Server Manager Studio", "MySQL Workbench", "Visual Paradigm", " Microsoft Visio"
            };

            return software.ToList();
        }

        private List<string> GetFrameworks()
        {
            string[] frameworks = {
                "ASP.NET", "Bootstrap", "Knockout.js", "Blazor", "WPF", "LINQ"
            };

            return frameworks.ToList();
        }

        private List<string> GetVersionControl()
        {
            string[] versionControl = {
                "Azure DevOps", "GitHub"
            };

            return versionControl.ToList();
        }

        private List<string> GetArchitectures()
        {
            string[] architectures = {
                "MVC", "MVP"
            };

            return architectures.ToList();
        }

        private List<string> GetWorkMethods()
        {
            string[] workMethods = {
                "Agil(SCRUM)", "Kanban"};

            return workMethods.ToList();
        }

        private List<string> GetDiagrams()
        {
            string[] diagrams = {
                "UML", "ERD", "DFD", "MCD"
            };

            return diagrams.ToList();
        }

        private List<string> GetAPIS()
        {
            string[] apis = {
                "SOAP", "RESTFul"
            };

            return apis.ToList();
        }

        private List<string> GetTests()
        {
            string[] tests = {
                "Unit Testing"
            };

            return tests.ToList();
        }

        private List<string> GetOthers()
        {
            string[] others = {
                "Zoho CRM", "JIRA", "Outlook", "Microsoft Office", "Microsoft Excel","Microsoft PowerPoint"
            };

            return others.ToList();
        }
    }
}
