namespace devops_demo.Core.Contracts
{
    public interface ICounterService
    {
        int GetCount();
        void Increment();
    }
}