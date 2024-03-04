using System;
using System.Collections.Generic;

namespace api.entities {
public class AppUser
    {
        public int Id { get; set; }
        public string deployed_url { get; set; }
        public DateTime paid_till { get; set; }
        public DateTime created { get; set; }
        public string username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string user_role { get; set; }
        public string active { get; set; }
        public string contributor_id { get; set; }
        public string center_id { get; set; }
        public string photoUrl { get; set; }
        public string email { get; set; }
       
    }
}