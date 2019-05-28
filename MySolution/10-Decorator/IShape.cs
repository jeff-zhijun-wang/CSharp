using System;

namespace _10_Decorator
{
    public interface IShape
    {
        void Draw();
    }

    public class Rectangle : IShape
    {
        public void Draw()
        {
            Console.WriteLine("Rectangle");
        }
    }

    public class Circle: IShape
    {
        public void Draw()
        {
            Console.WriteLine("Circle");
        }
    }

    public abstract class DecoratedShape : IShape
    {
        protected IShape decoratedShape;
        public DecoratedShape(IShape shape)
        {
            this.decoratedShape = shape;
        }
        public abstract void Draw();
    }

    public class RedDocoratedShape : DecoratedShape
    {
        public RedDocoratedShape(IShape shape) : base(shape)
        {
        }

        public override void Draw()
        {
            decoratedShape.Draw();
            setRedBorder(decoratedShape);
        }

        private void setRedBorder(IShape decoratedShape)
        {
            Console.WriteLine("Border Color: Red");
        }
    }

}
