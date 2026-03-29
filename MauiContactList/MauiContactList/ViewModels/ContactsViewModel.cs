using MauiContactList.Models;
using System.Collections.ObjectModel;
using System.Linq;

namespace MauiContactList.ViewModels
{
    public class ContactsViewModel
    {
        public ObservableCollection<ContactGroup> GroupedContacts { get; set; }

        public ContactsViewModel()
        {
            var contacts = GenerateContacts();

            var grouped = contacts
                .GroupBy(c => c.Name[0])
                .OrderBy(g => g.Key)
                .Select(g => new ContactGroup(g.Key.ToString(), g));

            GroupedContacts = new ObservableCollection<ContactGroup>(grouped);
        }

        private List<Contact> GenerateContacts()
        {
            return new List<Contact>
            {
                // A Group
                new Contact { Name="Avery Locks", Email="avery@email.com", Phone="777-1001", Description="Web Developer", Image="Girl1.png" },
                new Contact { Name="Alan Ping", Email="alan@email.com", Phone="777-1002", Description="Software Engineer", Image="Boy1.png" },
                new Contact { Name="Aria Cook", Email="aria@email.com", Phone="777-1003", Description="UI/UX Designer", Image="Girl2.png" },

                // B Group
                new Contact { Name="Brock Walls", Email="brock@email.com", Phone="777-2001", Description="System Administrator", Image="Boy2.png" },
                new Contact { Name="Blair Van", Email="blair@email.com", Phone="777-2002", Description="Cloud Architect", Image="Girl1.png" },
                new Contact { Name="Brad Rooks", Email="brad@email.com", Phone="777-2003", Description="Network Engineer", Image="Boy1.png" },

                // C Group
                new Contact { Name="Carter Tales", Email="carter@email.com", Phone="777-3001", Description="Security Analyst", Image="Boy1.png" },
                new Contact { Name="Camila Seeker", Email="camila@email.com", Phone="777-3002", Description="Digital Forensics Specialist", Image="Girl2.png" },
                new Contact { Name="Carson Miles", Email="carson@email.com", Phone="777-3003", Description="DevOps Engineer", Image="Boy2.png" },

                // D Group
                new Contact { Name="Declan Hawk", Email="declan@email.com", Phone="777-4001", Description="IT Manager", Image="Boy2.png" },
                new Contact { Name="Doris Wan", Email="doris@email.com", Phone="777-4002", Description="Database Administrator", Image="Girl1.png" },
                new Contact { Name="Dominic Fort", Email="dominic@email.com", Phone="777-4003", Description="QA Analyst", Image="Boy1.png" },

                // E Group
                new Contact { Name="Eric Young", Email="eric@email.com", Phone="777-5001", Description="Product Owner", Image="Boy1.png" },
                new Contact { Name="Emily Fox", Email="emily@email.com", Phone="777-5002", Description="IT Consultant", Image="Girl2.png" },
                new Contact { Name="Emmett Adams", Email="emmett@email.com", Phone="777-5003", Description="Cloud Strategist", Image="Boy2.png" }
            };
        }
    }
}