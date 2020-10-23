using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using PlasmaFinder.Helper;
using PlasmaFinder.Models;

namespace PlasmaFinder.Controllers
{
    [Authorize]
    public class PlasmaUsersController : ApiController
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        //To add details 
    public IHttpActionResult Post([FromBody] PlasmaUser plasmaUser)
        {
            var user = new PlasmaUser()
            {
                Username = plasmaUser.Username,
                BloodGroup = plasmaUser.BloodGroup,
                Email = plasmaUser.Email,
                Phone = plasmaUser.Phone,
                Location = plasmaUser.Location,
                Date = plasmaUser.Date,
            };
            db.PlasmaUsers.Add(user);
            db.SaveChanges();
            return StatusCode(HttpStatusCode.Created);
        }
   //To Get Blood based On BloodGroup and Location
    public IEnumerable<PlasmaUser> Get(String bloodGroup,String location)
    {
         var plasmaUsers=   db.PlasmaUsers.Where(user => user.BloodGroup.StartsWith(bloodGroup) && user.Location.StartsWith(location));
            return plasmaUsers;
    }

     //To get all blood donar details
        public IEnumerable<PlasmaUser> Get()
        {
           var latestUsers= db.PlasmaUsers.OrderByDescending(user => user.Date);
            return latestUsers;
        }
    }
}