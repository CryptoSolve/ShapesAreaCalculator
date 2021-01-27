namespace ShapesAreaCalculatorLibrary
{
    public abstract class Shape
    {
        protected string type;

        public override string ToString()
        {
            return type;
        }
    }
}