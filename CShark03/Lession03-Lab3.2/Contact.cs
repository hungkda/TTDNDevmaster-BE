using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lession03_Lab3._2
{
    internal class Contact
    {
        private int id;
        private string firstName;
        private string lastName;
        private string address;
        private string phoneNumber;
        private string email;

        //constructor
        public Contact() { }
        public Contact(int id, string firstName, string lastName, string address, string phoneNumber, string email)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.email = email;
        }

        public int Id { get { return id; } set { id = value; } }
        public string FirstName { get { return firstName; } set { firstName = value; } }
        public string LastName { get { return lastName; } set { firstName = value; } }
        public string Address { get { return address; } set { firstName = value; } }
        public string PhoneNumber { get { return phoneNumber; } set { phoneNumber = value; } }
        public string Email { get { return email; } set { email = value; } }

        public void Display()
        {
            Console.WriteLine("Thông tin: ");
            Console.WriteLine("Mã số: " + id);
            Console.WriteLine("Tên: " + firstName + " " + lastName);
            Console.WriteLine("Địa chỉ: " + address);
            Console.WriteLine("SDT: " + phoneNumber);
            Console.WriteLine("Mail: " + email);

        }
    }
}
