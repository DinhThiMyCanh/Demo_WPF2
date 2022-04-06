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

namespace Demo_WPF2
{
    /// <summary>
    /// Interaction logic for DataTemplate.xaml
    /// </summary>
    public partial class DataTemplate : Window
    {
        public DataTemplate()
        {
            InitializeComponent();
            List<Person> persons = new List<Person>();
            persons.Add(new Person() { Age = 10, Name = "Yin" });
            persons.Add(new Person() { Age = 11, Name = "Yang" });
            persons.Add(new Person() { Age = 12, Name = "Yo" });

            this.DataContext = persons;
        }
    }
}
