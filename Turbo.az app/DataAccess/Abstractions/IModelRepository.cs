using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Turbo.az_app.Entities.Mapping;

namespace Turbo.az_app.DataAccess.Abstractions
{
    public interface IModelRepository:IRepository<Model>
    {
        ICollection<Model> GetAllId(int id);
    }
}
