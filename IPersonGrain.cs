using System.Threading.Tasks;

namespace Orleans.Template
{
    public interface IPersonGrain : IGrainWithStringKey
    {
        Task SayHelloAsync();
    }
}
