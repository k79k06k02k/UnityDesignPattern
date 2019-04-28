
public enum OperationType
{
    Add,
    Sub,
    Mul,
    Div
}

public class OperationFactory
{
    public static OperationBase CreateOperate(OperationType operationType, float numberA, float numberB)
    {
        switch (operationType)
        {
            case OperationType.Add:
                return new OperationAdd(numberA, numberB);

            case OperationType.Sub:
                return new OperationSub(numberA, numberB);

            case OperationType.Mul:
                return new OperationMul(numberA, numberB);

            case OperationType.Div:
                return new OperationDiv(numberA, numberB);
        }

        return null;
    }
}
