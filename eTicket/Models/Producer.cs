﻿
using System.ComponentModel.DataAnnotations;

namespace eTicket.Models
{
    public class Producer
    {
        [Key]
        public int ActorId { get; set; }
        public string ProfilePictureURL { get; set; }
        public string FullName { get; set; }
        public string Bio { get; set; }

    }
}
