using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using YP.Models;

namespace YP
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public Enrollee SelectedEnrollee { get; set; }
        
        public ObservableCollection<Enrollee> Enrollees { get; set; }
        public Context Context { get; set; }

        public MainWindow()
        {
            Context = new();
            Enrollees = new ObservableCollection<Enrollee>(Context.Enrollee.ToList());
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            start start = new(Context);
            start.ShowDialog();
            Enrollees.Clear();
            Context.Enrollee.ToList().ForEach(e => Enrollees.Add(e));
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Context.Enrollee.Remove(SelectedEnrollee);
            Enrollees.Remove(SelectedEnrollee);
            Context.SaveChanges();
            SelectedEnrollee = null;

        }

        private void ListBox_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (SelectedEnrollee == null)
                return;
            InformationWindow informationWindow = new(SelectedEnrollee, Context);
            informationWindow.ShowDialog();
        }
    }


}
