namespace backend.repositories;

public class ContactRepository : IContactRepository
    {
        private IList<Contact> _contacts;

        public ContactRepository() {
            this._contacts = new List<Contact>(){
                new Contact(1,"odio@icloud.net","Martha Adkins"),
                new Contact(2,"ipsum.donec@outlook.ca","Caryn Coolier"),
                new Contact(3,"pharetra.sed@outlook.edu","Rana Alston"),
                new Contact(4,"sed.congue@aol.ca","Deirdre Davidson"),
                new Contact(5,"sed@icloud.ca","Amena Hickman"),
                new Contact(6,"pharetra.sed@outlook.edu.br","Luis Cooley"),
                new Contact(7,"amin.m@aol.com.br","Amin Mohamed"),
                new Contact(8,"el.dodson@icloud.com","Ellie-Louise Dodson"),
                new Contact(9,"ubaid.richard@ig.com.br","Ubaid Richard"),
                new Contact(10,"landon.g@gmail.com","Landon Galloway")
            };
        }

        public IEnumerable<Contact> All()
            => this._contacts.ToArray();

        public IEnumerable<Contact> FindBy(string fullName)
            => this._contacts.Where(c => c.FullName.ToLower().Contains(fullName.ToLower())).ToArray();

    }