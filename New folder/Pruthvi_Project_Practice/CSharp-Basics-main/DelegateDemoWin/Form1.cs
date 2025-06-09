using System;

namespace DelegateDemoWin
{
    public partial class Form1 : Form
    {
        //PersonFormat personFormat;
        Func<Person, string> personFormat;
        Action<List<Person>> personAction;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFilterData_Click(object sender, EventArgs e)
        {
            peopleListBox.Items.Clear();
            if (chkBoxAction.Checked)
            {
                AssignAction();
                var people = PersonRespository.GetPeople();
                personAction(people);
            }
            else
            {
                AssignDelegate();
                var peolple = PersonRespository.GetPeople();

                foreach (Person person in peolple)
                {
                    peopleListBox.Items.Add(person.ToString(personFormat));
                }
            }

        }
        private void AssignAction()
        {
            personAction = null;
            if (chkBoxAvgRating.Checked)
                personAction += p => peopleListBox.Items.Add(p.Average(r => r.Rating));
            if (chkBoxMinRating.Checked)
                personAction += p => peopleListBox.Items.Add(p.Min(r => r.Rating));
            if (chkBoxMaxRating.Checked)
                personAction += p => peopleListBox.Items.Add(p.Max(r => r.Rating));
        }

        private void AssignDelegate()
        {
            if (rdbDefault.Checked)
                personFormat = person => person.ToString(); 
            else if (rdbLastName.Checked)
                personFormat = person => person.LastName.ToUpper();
            else if (rdbFirstName.Checked)
                personFormat = person => person.FirstName.ToLower();
            else if (rdbFullName.Checked)
                personFormat = person => string.Format($"{person.LastName}, {person.FirstName}");
        }
    }
}
