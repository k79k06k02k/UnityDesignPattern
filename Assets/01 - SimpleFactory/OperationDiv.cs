
public class OperationDiv : OperationBase
{
    public OperationDiv(float numberA, float numberB) : base(numberA, numberB)
    {
    }

    public override float GetResult()
    {
        return numberA / numberB;
    }
}
