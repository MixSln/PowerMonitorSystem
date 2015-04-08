using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Practices.EnterpriseLibrary.Data;
using Microsoft.Practices.EnterpriseLibrary.Data.Sql;
using System.Data.Common;
using System.Data;

using PowerDistributionSystem.Model;

namespace PowerDistributionSystem.Controller
{
    public class DistributionController
    {
        static Database db = null;

        public DistributionController() { }
        public DistributionController(Database db) { DistributionController.db = db; }

        public Distribution GetDistribution(int distId)
        {
            Distribution dist = new Distribution();
            DbCommand cmd = db.GetSqlStringCommand(@"SELECT [distId],[distName],[nickName],[distAddress],[distDesc],[contact_primary],[phoneNumber_primary],[contact_bak1]
        ,[phoneNumber_bak1],[contact_bak2],[phoneNumber_bak2] FROM [dbo].[distribution] where distId = @distId ");
            db.AddInParameter(cmd, "@distId", DbType.Int32, distId);
            IDataReader r = db.ExecuteReader(cmd);
            if (r.Read())
            {
                dist.DistId = distId;
                dist.DistName = r[1].ToString();
                dist.NickName = r[2].ToString();
                dist.DistAddress = r[3].ToString();
                dist.DistDesc = r[4].ToString();
                dist.Contact_primary = r[5].ToString();
                dist.PhoneNumber_primary = r[6].ToString();
                dist.Contact_bak1 = r[7].ToString();
                dist.PhoneNumber_bak1 = r[8].ToString();
                dist.Contact_bak2 = r[9].ToString();
                dist.PhoneNumber_bak2 = r[10].ToString();
            }
            return dist;
        }

        public bool AddDistribution(Distribution dist)
        {
            bool result = true;

            DbCommand cmd = db.GetSqlStringCommand(@"INSERT INTO [PowerMonitor].[dbo].[distribution]([distName],[nickName],[distAddress],[distDesc]
                ,[contact_primary],[phoneNumber_primary],[contact_bak1],[phoneNumber_bak1],[contact_bak2],[phoneNumber_bak2])
                VALUES(@distName,@nickName, @distAddress,@distDesc,@contact_primary,@phoneNumber_primary
                    ,@contact_bak1,@phoneNumber_bak1,@contact_bak2,@phoneNumber_bak2) ");

            db.AddInParameter(cmd, "@distName", DbType.String, dist.DistName);
            db.AddInParameter(cmd, "@nickName", DbType.String, dist.NickName);
            db.AddInParameter(cmd, "@distAddress", DbType.String, dist.DistAddress);
            db.AddInParameter(cmd, "@distDesc", DbType.String, dist.DistDesc);
            db.AddInParameter(cmd, "@contact_primary", DbType.String, dist.Contact_primary);
            db.AddInParameter(cmd, "@phoneNumber_primary", DbType.String, dist.PhoneNumber_primary);
            db.AddInParameter(cmd, "@contact_bak1", DbType.String, dist.Contact_bak1);
            db.AddInParameter(cmd, "@phoneNumber_bak1", DbType.String, dist.PhoneNumber_bak1);
            db.AddInParameter(cmd, "@contact_bak2", DbType.String, dist.Contact_bak2);
            db.AddInParameter(cmd, "@phoneNumber_bak2", DbType.String, dist.PhoneNumber_bak2);

            db.ExecuteNonQuery(cmd);

            return result;
        }
    }
}
