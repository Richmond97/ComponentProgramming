﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Component_A_ClassLibrary
{
    public partial class EditEmployee : Component
    {
        DataClasses1DataContext db = new DataClasses1DataContext();

        public EditEmployee()
        {
            InitializeComponent();
        }

        public EditEmployee(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public void searchEmployee(DataGridView table, TextBox searchQ)
        {
            try
            {
                var varQueryID = (from a in db.employees
                             where String.IsNullOrWhiteSpace(searchQ.Text)
                             || a.FirstName.Contains(searchQ.Text.Trim())
                             select a).ToList();
                table.DataSource = varQueryID;

            }
            catch (Exception e)
            {
                MessageBox.Show($"{e}");
                throw;
            }
            

        }    
    }
}
