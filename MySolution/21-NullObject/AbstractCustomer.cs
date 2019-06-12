using System;

namespace _21_NullObject
{
    public abstract class AbstractCustomer
    {
        protected String name;
        public abstract Boolean isNil();
        public abstract String getName();
    }

    public class RealCustomer : AbstractCustomer
    {
        public RealCustomer(string name)
        {
            this.name = name;
        }

        public override string getName()
        {
            return name;
        }

        public override bool isNil()
        {
            return false;
        }
    }

    public class NullCustomer : AbstractCustomer
    {

        public override string getName()
        {
            return "not available in Customer Database";
        }

        public override bool isNil()
        {
            return true;
        }
    }


    public class CustomerFactory
    {

        public static string[] names = { "Rob", "Joe", "Julie" };

        public static AbstractCustomer getCustomer(string name)
        {

            for (int i = 0; i < names.Length; i++)
            {
                if (names[i].Equals(name))
                {
                    return new RealCustomer(name);
                }
            }
            return new NullCustomer();
        }
    }
}
