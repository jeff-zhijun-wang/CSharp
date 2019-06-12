namespace _24_Visitor
{
    public interface IVisitor
    {
        void visit(Computer computer);
        void visit(Mouse mouse);
        void visit(Keyboard keyboard);
        void visit(Monitor monitor);
        //void visit(IPart part);
    }
}
