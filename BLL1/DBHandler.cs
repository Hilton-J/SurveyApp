using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeLibrary.Interface;
using DAL1;
using TypeLibrary.ViewModels;
using TypeLibrary.Models;

namespace BLL1
{
    public class DBHandler : ISurvey
    {
        DBAccess db = new DBAccess();
        public List<GetResponses> GetData() => db.GetData();
        public bool AddResponse(ParticipantRespons iResponse)
        {
            return db.AddResponse(iResponse);
        }
    }
}
