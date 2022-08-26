using ContactsApp.Classes;
using SQLite;
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

namespace ContactsApp
{
    /// <summary>
    /// Interaction logic for ContactWindow.xaml
    /// </summary>
    public partial class ContactWindow : Window
    {
        public ContactWindow()
        {
            InitializeComponent();

            
        }

        private void SaveButton_Click(object sender, RoutedEventArgs e)
        {
            // save contact
            Contact contact = new Contact()
            {
                NameContact = TxtName.Text,
                EmailContact = TxtEmail.Text,
                PhoneContact = TxtPhone.Text
            };

            string databaseName = "Contacts.db";
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string databasePath = System.IO.Path.Combine(databaseName, folderPath);

            SQLiteConnection connection = new SQLiteConnection(databasePath);



            Close();
           
        }
    }
}
