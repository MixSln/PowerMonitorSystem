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
    class DeviceController
    {
         static Database db = null;

        public DeviceController() { }
        public DeviceController(Database db) { DeviceController.db = db; }

        public Device GetDevice(int devId)
        {
            Device device = new Device();
            DbCommand cmd = db.GetSqlStringCommand(@"SELECT [devId]
                  ,[devName]
                  ,[addressCode]
                  ,[current_max]
                  ,[current_warning]
                  ,[voltage_warning_high]
                  ,[voltage_warning_low]
                  ,[devStatus]
              FROM [dbo].[device] where devId = @devId ");
            db.AddInParameter(cmd, "@devId", DbType.Int32, devId);
            IDataReader r = db.ExecuteReader(cmd);
            if (r.Read())
            {
                device.DevId = devId;
                device.DevName = r[1].ToString();
                device.AddressCode = r[2].ToString();
                device.MaxCurrent = float.Parse(r[3].ToString());
                device.WarningCurrent = float.Parse(r[4].ToString());
                device.WarningVoltageHigh = float.Parse(r[5].ToString());
                device.WarningVoltageLow = float.Parse(r[6].ToString());
                device.DevStatus = r[7].ToString().Equals("Y")?"Active":"Inactive";
            }
            return device;
        }

        public IList<Device> GetDeviceList()
        {
            Device device = new Device();
            IList<Device> deviceList = new List<Device>();
            DbCommand cmd = db.GetSqlStringCommand(@"SELECT [devId]
                  ,[devName]
                  ,[addressCode]
                  ,[current_max]
                  ,[current_warning]
                  ,[voltage_warning_high]
                  ,[voltage_warning_low]
                  ,[devStatus]
              FROM [dbo].[device]");
            IDataReader r = db.ExecuteReader(cmd);
            while (r.Read())
            {
                device.DevId = int.Parse(r[0].ToString());
                device.DevName = r[1].ToString();
                device.AddressCode = r[2].ToString();
                device.MaxCurrent = float.Parse(r[3].ToString());
                device.WarningCurrent = float.Parse(r[4].ToString());
                device.WarningVoltageHigh = float.Parse(r[5].ToString());
                device.WarningVoltageLow = float.Parse(r[6].ToString());
                device.DevStatus = r[7].ToString().Equals("Y") ? "Active" : "Inactive";


                deviceList.Add(device);
            }
            return deviceList;
        }

        public bool AddDevice(Device device)
        {
            DbCommand cmd = db.GetSqlStringCommand(@"INSERT INTO [dbo].[device]
                       ([devName]
                       ,[addressCode]
                       ,[current_max]
                       ,[current_warning]
                       ,[voltage_warning_high]
                       ,[voltage_warning_low]
                       ,[devStatus])
                 VALUES
                       (@devName
                       ,@addressCode
                       ,@current_max
                       ,@current_warning
                       ,@voltage_warning_high
                       ,@voltage_warning_low
                       ,@devStatus) ");

            db.AddInParameter(cmd, "@devName", DbType.String, device.DevName);
            db.AddInParameter(cmd, "@addressCode", DbType.String, device.AddressCode);
            db.AddInParameter(cmd, "@current_max", DbType.Decimal, device.MaxCurrent);
            db.AddInParameter(cmd, "@current_warning", DbType.Decimal, device.WarningCurrent);
            db.AddInParameter(cmd, "@voltage_warning_high", DbType.Decimal, device.WarningVoltageHigh);
            db.AddInParameter(cmd, "@voltage_warning_low", DbType.Decimal, device.WarningVoltageLow);
            db.AddInParameter(cmd, "@devStatus", DbType.String, device.DevStatus.Equals("Active")?"A":"I");
            

            int r = db.ExecuteNonQuery(cmd);

            return r == 0;
        }

        public bool SaveDevice(Device device)
        {
            bool result = true;

            DbCommand cmd = db.GetSqlStringCommand(@"UPDATE [dbo].[device]
                   SET [devName] = @devName
                      ,[addressCode] = @addressCode
                      ,[current_max] = @current_max
                      ,[current_warning] = @current_warning
                      ,[voltage_warning_high] = @voltage_warning_high
                      ,[voltage_warning_low] = @voltage_warning_low
                      ,[devStatus] = @devStatus
                 WHERE devId = @devId");

            db.AddInParameter(cmd, "@devName", DbType.String, device.DevName);
            db.AddInParameter(cmd, "@addressCode", DbType.String, device.AddressCode);
            db.AddInParameter(cmd, "@current_max", DbType.Decimal, device.MaxCurrent);
            db.AddInParameter(cmd, "@current_warning", DbType.Decimal, device.WarningCurrent);
            db.AddInParameter(cmd, "@voltage_warning_high", DbType.Decimal, device.WarningVoltageHigh);
            db.AddInParameter(cmd, "@voltage_warning_low", DbType.Decimal, device.WarningVoltageLow);
            db.AddInParameter(cmd, "@devStatus", DbType.String, device.DevStatus.Equals("Active") ? "A" : "I");
            db.AddInParameter(cmd, "@devId", DbType.Int32, device.DevId);

            db.ExecuteNonQuery(cmd);

            return result;
        }
    }
}
