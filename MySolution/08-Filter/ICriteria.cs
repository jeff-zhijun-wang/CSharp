using System;
using System.Collections.Generic;
using System.Text;

namespace _08_Filter
{
    interface ICriteria
    {
        List<Person> meetCriteria(List<Person> persons);
    }

    public class MaleCriteria : ICriteria
    {
        public List<Person> meetCriteria(List<Person> persons)
        {
            List<Person> selectedPersons = new List<Person>();
            foreach (Person person in persons)
            {
                if (person.Gender.ToUpper().Equals("MALE"))
                    selectedPersons.Add(person);
            }
            return selectedPersons;
        }
    }

    public class FemaleCriteria : ICriteria
    {
        public List<Person> meetCriteria(List<Person> persons)
        {
            List<Person> selectedPersons = new List<Person>();
            foreach (Person person in persons)
            {
                if (person.Gender.ToUpper().Equals("FEMALE"))
                    selectedPersons.Add(person);
            }
            return selectedPersons;
        }
    }
    public class SingleCriteria : ICriteria
    {
        public List<Person> meetCriteria(List<Person> persons)
        {
            List<Person> selectedPersons = new List<Person>();
            foreach (Person person in persons)
            {
                if (person.Marital.ToUpper().Equals("SINGLE"))
                    selectedPersons.Add(person);
            }
            return selectedPersons;
        }
    }

    public class MarriedCriteria : ICriteria
    {
        public List<Person> meetCriteria(List<Person> persons)
        {
            List<Person> selectedPersons = new List<Person>();
            foreach (Person person in persons)
            {
                if (person.Marital.ToUpper().Equals("MARRIED"))
                    selectedPersons.Add(person);
            }
            return selectedPersons;
        }
    }

}




