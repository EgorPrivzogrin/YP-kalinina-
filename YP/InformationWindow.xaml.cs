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
using YP.Models;

namespace YP
{
    /// <summary>
    /// Логика взаимодействия для InformationWindow.xaml
    /// </summary>
    public partial class InformationWindow : Window
    {
        public Context Context { get; set; }
        public InformationWindow(Enrollee enrollee, Context context)
        {
            Context = context;
            DataContext = enrollee;
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Context.SaveChanges();

            Close();
        }
    }
}
