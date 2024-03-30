

namespace NU_Society_Link.Models{
    public class Student{
        public string RollNum { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string Batch { get; set; }

        public Student(string rollNum, string name, string email, string contact, string batch){
            RollNum = rollNum;
            Name = name;
            Email = email;
            Contact = contact;
            Batch = batch;
        }
    }
}