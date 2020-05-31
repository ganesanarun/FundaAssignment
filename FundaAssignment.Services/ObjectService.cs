using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using FundaAssignment.Repository;

namespace FundaAssignment.Services
{
    public class ObjectService : IObjectService
    {
        private IObjectRepository _objectRepository;
        public ObjectService(IObjectRepository objectRepository)
        {
            _objectRepository = objectRepository;
        }
        public async Task< IEnumerable<Entities.Object>> GetTop10MakelaarsInAmsterdam()
        {
            return await _objectRepository.GetObjects();
        }
    }
}
