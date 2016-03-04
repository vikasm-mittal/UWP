using System.Threading.Tasks;

namespace HelloMVVMLight.Model
{
    public interface IDataService
    {
        Task<DataItem> GetData();
    }
}