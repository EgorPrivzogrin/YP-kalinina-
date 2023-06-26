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
    /// Логика взаимодействия для Enrollee.xaml
    /// </summary>
    public partial class start : Window
    {
        public Context Context { get; set; }
        public start(Context context)
        {
            DataContext = new Enrollee();
            InitializeComponent();
            Context = context;
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
                Context.Enrollee.Add(DataContext as Enrollee);
                Context.SaveChanges();
            
            Close();
        }
    }
}
