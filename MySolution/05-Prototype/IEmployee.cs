namespace _05_Prototype
{
    public abstract class Employee
    {
        public abstract Employee Clone();

        public string Name { get; set; }
        public string Role { get; set; }
    }


    public class Typist : Employee
    {
        public int WordsPerMinute { get; set; }

        public override Employee Clone()
        {
            return (Employee)MemberwiseClone();
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}wpm", Name, Role, WordsPerMinute);
        }
    }


    public class Developer : Employee
    {
        public string PreferredLanguage { get; set; }

        public override Employee Clone()
        {
              return (Employee)MemberwiseClone();
            //return (Employee)this.Clone();
        }

        public override string ToString()
        {
            return string.Format("{0} - {1} - {2}", Name, Role, PreferredLanguage);
        }
    }
 

}
