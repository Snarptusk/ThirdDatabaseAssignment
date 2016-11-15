using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThirdDatabaseAssignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Person> people = new List<Person>();
        List<Adress> adressList = new List<Adress>();

        Person SelectedPerson = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadContacts();
        }

        private void LoadContacts()
        {
            lstContacts.Items.Clear();
            people.Clear();

            using (var db = new PersonContext())
            {
                var persons = (from p in db.Persons
                               orderby p.PersonID
                               select p).ToArray();

                foreach (var item in persons)
                {
                    lstContacts.Items.Add(item);
                    people.Add(item);
                }
            }
        }

        private void cmdNew_Click(object sender, EventArgs e)
        {
            using (var db = new PersonContext())
            {
                var person = new Person
                {
                    Name = txtName.Text,
                    Email = txtEmail.Text
                };
                var adress = new Adress
                {
                    Home = txtStreetAdress1.Text,
                    Work = txtStreetAdress2.Text,
                    Other = txtStreetAdress3.Text,
                    City = txtCity.Text
                };

                adressList.Add(adress);

                var phoneNr = new Phone
                {
                    Home = txtPhoneNr1.Text,
                    Cellphone = txtPhoneNr2.Text,
                    Other = txtPhoneNr3.Text
                };

                people.Add(person);

                db.Persons.Add(person);
                db.Adresses.Add(adress);
                db.Phones.Add(phoneNr);
                db.SaveChanges();

                lstContacts.Items.Add(person.Name);
            }

            txtName.Clear();
            txtCity.Clear();
            txtPhoneNr1.Clear();
            txtPhoneNr2.Clear();
            txtPhoneNr3.Clear();
            txtEmail.Clear();
            txtCity.Clear();
            txtStreetAdress1.Clear();
            txtStreetAdress2.Clear();
            txtStreetAdress3.Clear();

            LoadContacts();
        }

        private void cmdDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (var db = new PersonContext())
                {
                    SelectedPerson = (Person)lstContacts.SelectedItem;

                    var deletedPerson = db.Persons.Find(SelectedPerson.PersonID);

                    db.Persons.Remove(deletedPerson);

                    db.SaveChanges();

                    lstContacts.Items.Remove(SelectedPerson.Name);
                }
            }
            catch { }
            LoadContacts();
        }
    }
}
