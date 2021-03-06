﻿using ES_CapDien.AppCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ES_CapDien.MongoDb.Service
{
    public class DataObservationMongoService
    {
        DataObservationMongoData data = new DataObservationMongoData();
        public List<Models.Entity.Data> GetDataByDay(out int totalRow)
        {
            List<Models.Entity.Data> list = new List<Models.Entity.Data>();
            DateTime from = DateTime.Today;
            DateTime to = DateTime.Today.AddDays(1);
            list = data.FindAll(i => i.DateCreate < to && i.DateCreate > from).ToList();
            totalRow = list.Count();            
            return list;
        }
        public List<Models.Entity.Data> GetDataPaging(DateTime fromDate,DateTime toDate, int skip, int limit, out int total)
        {
            List<Models.Entity.Data> list = new List<Models.Entity.Data>();           
            list = data.FindOption(i => i.DateCreate < toDate && i.DateCreate > fromDate, limit, skip,out long totalRow).OrderByDescending(i => i.DateCreate).ToList();
            total = Convert.ToInt32(totalRow);
            return list;
        }
        public List<Models.Entity.Data> GetDataPagingByDeviceId(DateTime fromDate, DateTime toDate, int deviceId, int skip, int limit, out int total)
        {
            List<Models.Entity.Data> list = new List<Models.Entity.Data>();
            list = data.FindOption(i => i.DateCreate < toDate && i.DateCreate > fromDate && i.Device_Id == deviceId, limit, skip, out long totalRow).OrderByDescending(i => i.DateCreate).ToList();
            total = Convert.ToInt32(totalRow);
            return list;
        }
    }
}