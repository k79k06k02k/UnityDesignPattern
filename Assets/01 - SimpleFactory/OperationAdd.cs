
public class OperationAdd : OperationBase
{
    public OperationAdd(float numberA, float numberB) : base(numberA, numberB)
    {
    }

    public override float GetResult()
    {
        return numberA + numberB;
    }
}
