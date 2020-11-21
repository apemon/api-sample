using api_sample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace api_sample.Services
{
    public interface IPersonService
    {
        List<PersonModel> ListAllPerson();
    }
}
