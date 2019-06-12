namespace _24_Visitor
{
    public class Monitor : IPart
    {

        public void accept(IVisitor Visitor)
        {
            Visitor.visit(this);
        }
    }

}

