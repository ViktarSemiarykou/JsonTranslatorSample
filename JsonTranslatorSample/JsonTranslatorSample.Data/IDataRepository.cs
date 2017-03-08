using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using JsonTranslatorSample.Data.Dto;

namespace JsonTranslatorSample.Data
{
    public interface IDataRepository
    {
        Task<DataObject> GetAsync();
    }
}
