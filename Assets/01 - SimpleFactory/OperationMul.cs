
public class OperationMul : OperationBase
{
    public OperationMul(float numberA, float numberB) : base(numberA, numberB)
    {
    }

    public override float GetResult()
    {
        return numberA * numberB;
    }
}
