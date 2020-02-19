namespace Project_4
{
    interface IDiscreteIntegration
    {
        double TrapezoidalMethod(int Precision);
        double SimpsonMethod(int Precision);
    }
}
