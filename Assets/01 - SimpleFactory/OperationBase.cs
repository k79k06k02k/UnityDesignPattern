
public abstract class OperationBase
{
    public float numberA { get; set; }
    public float numberB { get; set; }


    public OperationBase(float numberA, float numberB)
    {
        this.numberA = numberA;
        this.numberB = numberB;
    }

    public abstract float GetResult();
}
