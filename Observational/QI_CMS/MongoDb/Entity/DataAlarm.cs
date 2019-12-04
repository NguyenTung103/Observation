using Core.Entities;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ES_CapDien.MongoDb.Entity
{
    public class DataAlarm : MongoBaseEntity
    {
        [BsonId]
        public ObjectId _id { get; set; }        
        [BsonDateTimeOptions]
        [BsonElement("DateCreate")]
        public DateTime DateCreate { get; set; }
        [BsonElement("IsSEQ")]
        public bool IsSEQ { get; set; }
        [BsonElement("Device_Id")]
        public int Device_Id { get; set; }
        [BsonElement("AMATI")]
        public bool AMATI { get; set; }
        [BsonElement("AMIHU")]
        public bool AMIHU { get; set; }
        [BsonElement("AMADR")]
        public bool AMADR { get; set; }
        [BsonElement("AMAFL")]
        public bool AMAFL { get; set; }
        [BsonElement("AMAFR")]
        public bool AMAFR { get; set; }
        [BsonElement("AMIPS")]
        public bool AMIPS { get; set; }
        [BsonElement("AMIAL")]
        public bool AMIAL { get; set; }
        [BsonElement("AMIAH")]
        public bool AMIAH { get; set; }
        [BsonElement("AMIAP")]
        public bool AMIAP { get; set; }
        [BsonElement("AMIAC")]
        public bool AMIAC { get; set; }
        [BsonElement("AMIGN")]
        public bool AMIGN { get; set; }
        [BsonElement("AMIAR")]
        public bool AMIAR { get; set; }
        [BsonElement("AMIL1")]
        public bool AMIL1 { get; set; }
        [BsonElement("AMIH1")]
        public bool AMIH1 { get; set; }
        [BsonElement("AMIT1")]
        public bool AMIT1 { get; set; }
        [BsonElement("AMIL2")]
        public bool AMIL2 { get; set; }
        [BsonElement("AMIH2")]
        public bool AMIH2 { get; set; }
        [BsonElement("AMIT2")]
        public bool AMIT2 { get; set; }
    }
}