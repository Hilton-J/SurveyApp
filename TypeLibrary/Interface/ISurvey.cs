using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeLibrary.Models;
using TypeLibrary.ViewModels;

namespace TypeLibrary.Interface
{
    public interface ISurvey
    {
        bool AddResponse(ParticipantRespons iResponse);
        List<GetResponses> GetData();
    }
}
