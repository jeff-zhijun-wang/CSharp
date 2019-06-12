namespace _22_Strategy
{
    public interface Strategy
    {
        int doOperation(int num1, int num2);
    }

    public class OperationAdd : Strategy
    {
        public int doOperation(int num1, int num2)
        {
            return num1 + num2;
        }
    }

    public class OperationSubstract : Strategy
    {
        public int doOperation(int num1, int num2)
        {
            return num1 - num2;
        }
    }

    public class OperationMultipy : Strategy
    {
        public int doOperation(int num1, int num2)
        {
            return num1 * num2;
        }
    }

    public class Context
    {
        private Strategy strategy;

        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public int executeStrategy(int num1, int num2)
        {
            return strategy.doOperation(num1, num2);
        }
    }
}
