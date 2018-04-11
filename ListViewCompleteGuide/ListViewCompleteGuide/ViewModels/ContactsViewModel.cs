using ListViewCompleteGuide.Models;
using ReactiveUI;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace ListViewCompleteGuide.ViewModels
{
    public class ContactsViewModel : ReactiveObject
    {
        private Contact _selectedCOntact;
        public Contact SelectedContact
        {
            get { return _selectedCOntact; }
            set { this.RaiseAndSetIfChanged(ref  _selectedCOntact , value); }
        }

        public List<ListViewGrouping<Contact>> AllContacts { get; set; } = new List<ListViewGrouping<Contact>>();
        ListViewGrouping<Contact> Family;
        ListViewGrouping<Contact> Friends;
        ListViewGrouping<Contact> Work;

        public ContactsViewModel()
        {
            Family = new ListViewGrouping<Contact>("Family", "Family")
            {
                new Contact{IsFamily = true, Email = "mum@gmail.com", Name = "Mum" },
                new Contact{IsFamily = true, Email = "dad@gmail.com", Name = "Dad" },
                new Contact{IsFamily = true, Email = "bro@gmail.com", Name = "Bro" },
                new Contact{IsFamily = true, Email = "sis@gmail.com", Name = "Sis" },
            };
            Friends = new ListViewGrouping<Contact>("Friends", "Friends")
            {

                new Contact{IsFirend = true, Email = "ratchel@gmail.com", Name = "Ratchel" },
                new Contact{IsFirend = true, Email = "Ed@gmail.com", Name = "Ed" },
                new Contact{IsFirend = true, Email = "dina@gmail.com", Name = "Dina" },
                new Contact{IsFirend = true, Email = "joe@gmail.com", Name = "Jow" },
            };
            Work = new ListViewGrouping<Contact>("Work", "Work")
            {
                new Contact{IsWork = true, Email = "peter@gmail.com", Name = "Mr Peter" },
                new Contact{IsWork = true, Email = "john@gmail.com", Name = "Dr John" },
                new Contact{IsWork = true, Email = "melissa@gmail.com", Name = "Mrs Melissa" },
                new Contact{IsWork = true, Email = "reva@gmail.com", Name = "Mrs Reva" },
            };

            AllContacts.Add(Friends);
            AllContacts.Add(Family);
            AllContacts.Add(Work);
        }
    }
}
