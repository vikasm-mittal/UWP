using System.Threading.Tasks;

namespace Jewelry.Model
{
    public interface IDataService
    {
        Task<DataItem> GetData();
    }
}