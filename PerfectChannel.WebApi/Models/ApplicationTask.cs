using System;
using Microsoft.AspNetCore.Identity;

namespace PerfectChannel.WebApi.Models
{
    public class ApplicationTask : IdentityUser
    {
        public ApplicationTask()
        {
            Description = "";
            Name = "";
            Status = "";
        }
        public string Description
        {
            get;
            set;
        }

        public string Name
        {
            get;
            set;
        }
        public string Status
        {
            get;
            set;
        }
    }
}
