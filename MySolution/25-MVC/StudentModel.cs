using System;

namespace _25_MVC
{
    public class StudentModel
    {
        private String rollNo;
        private String name;

        public String getRollNo()
        {
            return rollNo;
        }

        public void setRollNo(String rollNo)
        {
            this.rollNo = rollNo;
        }

        public String getName()
        {
            return name;
        }

        public void setName(String name)
        {
            this.name = name;
        }
    }
}
