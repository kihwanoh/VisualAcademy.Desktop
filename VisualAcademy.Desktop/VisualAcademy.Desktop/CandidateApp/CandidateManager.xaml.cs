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

namespace VisualAcademy.Desktop.CandidateApp
{
    /// <summary>
    /// CandidateManager.xaml에 대한 상호 작용 논리
    /// </summary>
    public partial class CandidateManager : Window
    {
        public CandidateManager()
        {
            InitializeComponent();
        }

        private void btnAddCandidate_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("직원 후보자");
            btnAddCandidate.Content = $"후보자 추가 완료 {DateTime.Now.Second}";
        }
    }
}
