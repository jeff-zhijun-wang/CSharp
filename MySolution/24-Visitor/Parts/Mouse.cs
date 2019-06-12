namespace _24_Visitor
{
    public class Mouse : IPart
    {
        public void accept(IVisitor Visitor)
        {
            Visitor.visit(this);
        }
    }

}

