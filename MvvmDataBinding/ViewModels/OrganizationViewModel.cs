using Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template10.Mvvm;

namespace MvvmDataBinding.ViewModels
{
    public class OrganizationViewModel
    {
        private FakeService context = new FakeService();
        private ObservableCollection<Person> people = new ObservableCollection<Person>();
        public OrganizationViewModel()
        {
            people = new ObservableCollection<Person>(context.GetPeopleAsync().Result);
            DeleteCommand = new DelegateCommand(OnDelete, CanDelete);
        }

        public DelegateCommand DeleteCommand { get; private set; }

        public ObservableCollection<Person> People
        {
            get { return people; }
            set { people = value; }
        }

        // Need selected list item code here....

        private bool CanDelete()
        {
            return true;
        }

        private void OnDelete()
        {
            
        }

    }
}
