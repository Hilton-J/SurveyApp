using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TypeLibrary.Interface;
using TypeLibrary.Models;
using TypeLibrary.ViewModels;
using System.Data.SqlClient;
using System.Data;

namespace DAL1
{
    public class DBAccess : ISurvey
    {
        #region Insert()
        public bool AddResponse(ParticipantRespons iResponse)
        {
            List<SqlParameter> param = new List<SqlParameter>();
            foreach (var prop in iResponse.GetType().GetProperties())
            {
                if (prop.GetValue(iResponse) != null)
                {
                    param.Add(new SqlParameter("@" + prop.Name.ToString(), prop.GetValue(iResponse)));
                }
            }
            return SqlHelper.NonQuery("sp_InsertResponse", CommandType.StoredProcedure, param.ToArray());
        }
        #endregion Insert()
        #region Select()
        public List<GetResponses> GetData()
        {
            List<GetResponses> list = new List<GetResponses>();
            using (DataTable table = SqlHelper.Select("sp_GetData", CommandType.StoredProcedure))
            {
                if(table.Rows.Count > 0)
                {
                    foreach (DataRow row in table.Rows) 
                    {
                        GetResponses re = new GetResponses
                        {
                            //ID = Guid.Parse(row["ID"].ToString()),
                            TotalSurvey = Convert.ToInt32(row["TotalSurveys"]),
                            Average = Convert.ToDecimal(row["Average"]),
                            Oldest = Convert.ToInt32(row["Oldest"]),
                            Youngest = Convert.ToInt32(row["Youngest"]),
                            Pizza = Convert.ToDecimal(row["Pizza"]),
                            Pasta = Convert.ToDecimal(row["Pasta"]),
                            PapWors = Convert.ToDecimal(row["PapWors"]),
                            EatOut = Convert.ToDecimal(row["EatOut"]),
                            Movies = Convert.ToDecimal(row["Movie"]),
                            Radio = Convert.ToDecimal(row["Radio"]),
                            WatchTV = Convert.ToDecimal(row["WatchTV"])
                        };
                        list.Add(re);
                    }
                }
            }
            return list;
        }
        #endregion Select()
    }
}
