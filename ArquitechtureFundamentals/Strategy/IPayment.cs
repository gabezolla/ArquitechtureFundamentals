namespace ArchitectureStudies.Strategy
{
    public interface IPayment
    {
        void ProcessPayment(Request request);
    }
}
