namespace _08_Filter
{
    public class Person
    {

 //       private string name;
 //       private string gender;
 //       private string maritalStatus;

        public Person(string name, string gender, string maritalStatus)
        {
            this.Name = name;
            this.Gender = gender;
            this.Marital = maritalStatus;
        }

        public string Name
        {
            get;
            set;
        }
        public string Gender
        {
            get;
            set;
        }
        public string Marital
        {
            get;
            set;
        }
    }



}
