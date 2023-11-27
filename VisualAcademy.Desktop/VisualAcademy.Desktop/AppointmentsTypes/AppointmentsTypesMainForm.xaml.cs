using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using VisualAcademy.Desktop.Models;

namespace VisualAcademy.Desktop.AppointmentTypes
{
    /// <summary>
    /// AppointmentsTypesMainForm.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class AppointmentsTypesMainForm : Window
    {
        private readonly List<AppointmentType> _appointmentsTypes;

        //Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True;Connect Timeout=60;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False
        //    "Data Source=(localdb)\\MSSQLLocalDB;Integrated Security=True;Connect Timeout=60;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;" +
        //    "Multi Subnet Failover=False";
        private readonly string _connectionString =
            "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AppointmentDatabase;Integrated Security=True;Connect Timeout=60;Encrypt=True;Trust Server Certificate=False;Application Intent=ReadWrite;" +
            "Multi Subnet Failover=False";
        //  "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=AppointmentDatabase;Integrated Security=True";
        public AppointmentsTypesMainForm()
        {
            InitializeComponent();

            _appointmentsTypes = new List<AppointmentType>();
            AppointmentTypesListView.ItemsSource = _appointmentsTypes;
            LoadData();
        }

        private void LoadData()
        {
            _appointmentsTypes.Clear();

            using (var connection = new SqlConnection(_connectionString))
            {
                connection.Open();

                var command = new SqlCommand("SELECT Id, AppointmentTypeName, IsActive FROM AppointmentTypes", connection);

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var id = (int)reader["Id"];
                        var name = (string)reader["AppointmentTypeName"];
                        var isActive = (bool)reader["IsActive"];

                        var appointmentType = new AppointmentType
                        {
                            Id = id,
                            AppointmentTypeName = name,
                            IdActive = isActive
                        };
                        _appointmentsTypes.Add(appointmentType);
                    }
                }
                AppointmentTypesListView.Items.Refresh();
            }
        }

        private void AddButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void EditButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
