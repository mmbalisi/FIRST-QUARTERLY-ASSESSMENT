using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
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

namespace MarkBalisi.FIRST_QUARTERLY_ASSESSMENT.Personal_Info
{
    /// <summary>
    /// Interaction logic for PersonalInfoWindows.xaml
    /// </summary>
    public partial class PersonalInfoWindows : Window
    {
        public PersonalInfoWindows()
        {
            InitializeComponent();
            PersonalInfo personalInfo = new PersonalInfo();
            using (StreamReader r = new StreamReader("Data\\json6.json"))
            {
                string json = r.ReadToEnd();
                personalInfo = JsonConvert.DeserializeObject<PersonalInfo>(json);
            }
            lblPeronalInfoId.Content = "Id: " + personalInfo.id;
            lblPeronalInfoName.Content = "Name: " + personalInfo.name;
            lblPeronalInfoBorn.Content = "Born: " + personalInfo.born;
        }
    }
}
