namespace ArchitectureStudies.Observer
{
    public interface IInvestor
    {
        public string Name { get; }
        public void SendNotification(Stock stock);
    }
}
