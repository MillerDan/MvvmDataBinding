using Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmDataBinding.ViewModels
{
    public class OrganizationViewModel
    {
        private FakeService context = new FakeService();
        private ObservableCollection<Person> people = new ObservableCollection<Person>();
        public OrganizationViewModel()
        {
            people = new ObservableCollection<Person>(context.GetPeopleAsync().Result);
        }

        public ObservableCollection<Person> People
        {
            get { return people; }
            set { people = value; }
        }
    }
}
