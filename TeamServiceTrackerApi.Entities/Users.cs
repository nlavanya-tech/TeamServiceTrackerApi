using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TeamServiceTrackerApi.Entities
{
  public class Users
    {
        [Key]
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string UserType { get; set; }
        public string Status { get; set; }
        public string InterviewStatus { get; set; }
        public string ReportingTo { get; set; }
        public string Mobile { get; set; }

    }
}
