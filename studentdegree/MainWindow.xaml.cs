using studentdegree.Data;
using studentdegree.model;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace studentdegree
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        DegreeContext _con=new DegreeContext();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(usernamebox.Text)||!string.IsNullOrWhiteSpace(Passwordbox.Text))
            {
             
            string username = usernamebox.Text.Trim();
            string password = Passwordbox.Text.Trim();

            using (var context = new DegreeContext())
            {
                var student = context.students .FirstOrDefault(s => s.stdusername == username && s.stdpassword == password);

                if (student != null)
                {
                    myTextBlock_Copy.Text = ""; 
                        homePage home=new homePage();
                        home.Show();
                }
                else
                {
                    myTextBlock.Text = "";
                    myTextBlock_Copy.Text = "Invalid username or password!";
                }
            }
        }
            else
            {
                MessageBox.Show("enter all data");
            }
        }
    }
}