namespace _24_Visitor
{
    public class Keyboard : IPart
    {
        public void accept(IVisitor Visitor)
        {
            Visitor.visit(this);
        }
    }

}

