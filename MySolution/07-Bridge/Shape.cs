namespace _07_Bridge
{
    public abstract class Shape
    {
        protected IDrawApi drawAPI;

        protected Shape(IDrawApi drawAPI)
        {
            this.drawAPI = drawAPI;
        }
        public abstract void draw();
    }

    public class Circle : Shape
    {
        private int x, y, radius;

        public Circle(int x, int y, int radius, IDrawApi drawAPI):base(drawAPI)
        {
            this.x = x;
            this.y = y;
            this.radius = radius;
        }

        public override void draw()
        {
            drawAPI.drawCircle(radius, x, y);
        }
    }
}
