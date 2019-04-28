
public class OperationSub : OperationBase
{
    public OperationSub(float numberA, float numberB) : base(numberA, numberB)
    {
    }

    public override float GetResult()
    {
        return numberA - numberB;
    }
}
