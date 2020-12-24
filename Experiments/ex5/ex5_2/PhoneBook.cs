using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5_2 {
    class PhoneBook {
        private string name;
        private string number;
        private string email;
        public PhoneBook(string name, string number, string email) {
            this.Name = name;
            this.Number = number;
            this.Email = email;
        }
        public string Name { get; set; }
        public string Number { get; set; }
        public string Email { get; set; }
    }
}
