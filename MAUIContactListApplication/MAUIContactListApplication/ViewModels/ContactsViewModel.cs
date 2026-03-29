
using MAUIContactListApplication.Models;
using System.Collections.ObjectModel;
using System.Collections.Generic;


namespace MAUIContactListApplication.ViewModels;

public class ContactsViewModel
{
    public ObservableCollection<ContactGroup> GroupedContacts { get; set; }
    public ContactsViewModel()
    {
        var contacts = new List<Contact>
        {
            new Contact { Name = "Avery Locks", Email = "averylocks@email.com", Phone = "777-1001", Description = "Web Developer", Image = "Girl1.png" },
            new Contact { Name = "Alan Ping", Email = "alanping@email.com", Phone = "777-1002", Description = "Computer Programmer", Image = "Boy1.png" },
            new Contact { Name = "Aria Cook", Email = "ariacook@email.com", Phone = "777-1003", Description = "Software Engineer", Image = "Girl2.png" },

            new Contact { Name = "Brock Walls", Email = "brockwalls@email.com", Phone = "777-2001", Description = "System Administrator", Image = "Boy2.png" },
            new Contact { Name = "Blair Van", Email = "blairvan@email.com", Phone = "777-2002", Description = "Network Architect", Image= "Girl1.png" },
            new Contact { Name = "Brad Rooks", Email = "bradrooks@email.com", Phone = "777-2003", Description = "Network Administrator", Image = "Boy1.png" },

            new Contact { Name = "Carter Tales", Email = "cartertales@email.com", Phone = "777-3001", Description = "Senior Solutions Engineer", Image = "Boy1.png" },
            new Contact { Name = "Camila Seeker", Email = "camilaseeker@email.com", PhoneNumber = "777-3002", Description = "Digital Forensics Analyst", Image = "Gril2.png" },
            new Contact { Name = "Carson Miles", Email = "carsonmiles@email.com", PhoneNumber = "777-3003", Description = "Information Assurance Analyst", Image = "Boy2.png" },

            new Contact { Name = "Declan Hawk", Email = "declanhawk@email.com", Phone = "777-4001", Description = "IT Coordinator", Image = "Boy2.png" },
            new Contact { Name = "Doris Wan", Email = "doriswan@email.com", Phone = "777-4002", Description = "Computer Systems Manager", Image = "Girl1.png" },
            new Contact { Name = "Dominic Fort", Email = "dominicfort@email.com", Phone = "777-4003", Description = "Software QA Analyst", Image = "Boy1.png" },

            new Contact { Name = "Eric Young", Email = "ericyoung@email.com", Phone = "777-5001", Description = "Product Owner", Image = "Boy1.png" },
            new Contact { Name = "Emily Fox", Email = "emilyfox@email.com", Phone = "777-5002", Description = "IT Manager", Image = "Girl2.png" },
            new Contact { Name = "Emmett Adams", Email = "emmettadams@email.com", Phone = "777-5003", Description = "Cloud Strategy Specialist", Image = "Boy2.png" },

        };

        var grouped = contacts
            .GroupBy(c => c.Name[0])
            .OrderBy(g => g.Key)
            .Select(g => new ContactGroup(g.Key.ToString(), g));

        GroupedContacts = new ObservableCollection<ContactGroup>(grouped);
    }
}