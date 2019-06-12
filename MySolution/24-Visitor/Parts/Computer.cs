namespace _24_Visitor
{
    public class Computer : IPart
    {

        IPart[] parts;
        public Computer()
        {
            parts = new IPart[] { new Mouse(), new Keyboard(), new Monitor() };
        }

        public void accept(IVisitor Visitor)
        {
            for (int i = 0; i < parts.Length; i++)
            {
                parts[i].accept(Visitor);
            }
            Visitor.visit(this);
        }
    }

}

