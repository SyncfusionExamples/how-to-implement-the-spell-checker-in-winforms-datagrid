using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Enums;
using Syncfusion.WinForms.DataGrid.Events;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SfDataGridDemo
{
    public partial class Form1 : Form
    {
        Random r = new Random();
        public DataTable dt;
        public Form1()
        {
            InitializeComponent();

            dt = new DataTable();
            dt.Columns.Add("EmployeeID", typeof(int));
            dt.Columns.Add("EmployeeName", typeof(string));
            dt.Columns.Add("Destination", typeof(string));
            dt.Columns.Add("Notes", typeof(string));

            for (int i = 0; i < 10; i++)
            {
                System.Data.DataRow row = dt.NewRow();
                var name = employeeName[r.Next(employeeName.Count() - 1)];
                var destinaton = title[r.Next(title.Count() - 1)];
                var notes = notesContent[i];
                row[0] = 1000 + i;
                row[1] = name;
                row[2] = destinaton;
                row[3] = notes;
                dt.Rows.Add(row);
            }
            this.sfDataGrid1.AllowResizingColumns = true;
            this.sfDataGrid1.AutoGenerateColumns = false;
            this.sfDataGrid1.AutoSizeColumnsMode = AutoSizeColumnsMode.Fill;
            this.sfDataGrid1.DataSource = dt;
            this.sfDataGrid1.CellRenderers.Add("SpellCheck", new SpellCheckCellRenderer(this.sfDataGrid1));
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "EmployeeID", HeaderText= "Employee ID" });
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "EmployeeName", HeaderText= "Employee Name" });
            this.sfDataGrid1.Columns.Add(new GridTextColumn() { MappingName = "Destination", HeaderText= "Destination" });
            this.sfDataGrid1.Columns.Add(new GridSpellCheckColumn() { MappingName = "Notes", HeaderText= "Notes" });
        }

        private string[] notesContent = new string[]
        {
                "Sampe",
                "Value",
                "Infrmation",
                "Component",
                "Presence",
                "Sucess",
                "Technical",
                "Speific",
                "Situation",
                "Pofessional"
        };

        private string[] employeeName = new string[]
         {
                "Sean Jacobson",
                "Phyllis Allen",
                "Marvin Allen",
                "Michael Allen",
                "Cecil Allison",
                "Oscar Alpuerto",
                "Sandra Altamirano",
                "Selena Alvarad",
                "Emilio Alvaro",
                "Maxwell Amland",
                "Mae Anderson",
                "Ramona Antrim",
                "Sabria Appelbaum",
                "Hannah Arakawa",
                "Kyley Arbelaez",
                "Tom Johnston",
                "Thomas Armstrong",
                "John Arthur",
                "Chris Ashton",
                "Teresa Atkinson",
                "John Ault",
                "Robert Avalos",
                "Stephen Ayers",
                "Phillip Bacalzo",
                "Gustavo Achong",
                "Catherine Abel",
                "Kim Abercrombie",
                "Humberto Acevedo",
                "Pilar Ackerman",
                "Frances Adams",
                "Margar Smith",
                "Carla Adams",
                "Jay Adams",
                "Ronald Adina",
                "Samuel Agcaoili",
                "James Aguilar",
                "Robert Ahlering",
                "Francois Ferrier",
                "Kim Akers",
                "Lili Alameda",
                "Amy Alberts",
                "Anna Albright",
                "Milton Albury",
                "Paul Alcorn",
                "Gregory Alderson",
                "J. Phillip Alexander",
                "Michelle Alexander",
                "Daniel Blanco",
                "Cory Booth",
                "James Bailey"
         };

        private string[] title = new string[]
           {
                "Marketing Assistant",
                "Engineering Manager",
                "Senior Tool Designer",
                "Tool Designer",
                "Marketing Manager",
                "Production Supervisor - WC60",
                "Production Technician - WC10",
                "Design Engineer",
                "Production Technician - WC10",
                "Design Engineer",
                "Vice President of Engineering",
                "Production Technician - WC10",
                "Production Supervisor - WC50",
                "Production Technician - WC10",
                "Production Supervisor - WC60",
                "Production Technician - WC10",
                "Production Supervisor - WC60",
                "Production Technician - WC10",
                "Production Technician - WC30",
                "Production Control Manager",
                "Production Technician - WC45",
                "Production Technician - WC45",
                "Production Technician - WC30",
                "Production Supervisor - WC10",
                "Production Technician - WC20",
                "Production Technician - WC40",
                "Network Administrator",
                "Production Technician - WC50",
                "Human Resources Manager",
                "Production Technician - WC40",
                "Production Technician - WC30",
                "Production Technician - WC30",
                "Stocker",
                "Shipping and Receiving Clerk",
                "Production Technician - WC50",
                "Production Technician - WC60",
                "Production Supervisor - WC50",
                "Production Technician - WC20",
                "Production Technician - WC45",
                "Quality Assurance Supervisor",
                "Information Services Manager",
                "Production Technician - WC50",
                "Master Scheduler",
                "Production Technician - WC40",
                "Marketing Specialist",
                "Recruiter",
                "Production Technician - WC50",
                "Maintenance Supervisor",
                "Production Technician - WC30",
           };
    }
}


