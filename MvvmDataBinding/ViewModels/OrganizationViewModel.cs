﻿using Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Template10.Mvvm;

namespace MvvmDataBinding.ViewModels
{
    public class OrganizationViewModel : ViewModelBase
    {
        private FakeService context = new FakeService();
        private ObservableCollection<Person> people = new ObservableCollection<Person>();
        public OrganizationViewModel()
        {
            people = new ObservableCollection<Person>(context.GetPeopleAsync().Result);
            DeleteCommand = new DelegateCommand(OnDelete, CanDelete);
            AddCommand = new DelegateCommand(OnAdd, CanAdd);
        }

        public DelegateCommand DeleteCommand { get; private set; }

        public DelegateCommand AddCommand { get; private set; }

        public ObservableCollection<Person> People
        {
            get { return people; }
            set { people = value; }
        }

        // Need selected list item code here....
        private Person selectedPerson;

        public Person SelectedPerson
        {
            get { return selectedPerson; }
            set
            {
                selectedPerson = value;
                DeleteCommand.RaiseCanExecuteChanged();
            }
        }


        private bool CanDelete()
        {
            return SelectedPerson != null;
        }

        private async void OnDelete()
        {
            Person person = SelectedPerson;
            people.Remove(person);
            await context.DeletePersonAsync(person);
        }


        private bool CanAdd()
        {
            return true;
        }

        private void OnAdd()
        {
            
        }

    }
}
