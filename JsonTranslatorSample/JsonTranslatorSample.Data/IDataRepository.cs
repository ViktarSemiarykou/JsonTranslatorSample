using System.Threading.Tasks;
using JsonTranslatorSample.Data.Dto;

namespace JsonTranslatorSample.Data
{
    public interface IDataRepository
    {
        Task<DataObject> GetAsync();
    }
}
