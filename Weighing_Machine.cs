public enum EPrecision
{
    inti,
    floati,
    duble
}

public class WeighingMachine
{
    //private EPrecision _Precisao;
    private int myVar;
    public int MyProperty
    {
        get { return myVar; }
        set
        {
            if (value <= 0)
            { myVar = 0; }
            else if (value <= 7)
            {
                myVar = 1;
            }
            else
            {
                myVar = 2;
            }
        }
    }

    private double _Weight;
    public double Weight
    {
        get { return _Weight; }
        set
        {
            if (value < 0)
                _Weight = 0;
            else
                _Weight = value;
        }
    }

    private double _TareAdjustment;
    public double TareAdjustment
    {
        get { return _TareAdjustment; }
        set
        {
            _TareAdjustment = value;
            _Weight = _Weight + value;
        }
    }

    public WeighingMachine(int i)

    {
        TareAdjustment = 5;
        MyProperty = i;
    }


}