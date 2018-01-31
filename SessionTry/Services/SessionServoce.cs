using SessionTry.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SessionTry.Services
{
    public class SessionServoce
    {
        public SessionServoce(ThingModel thingModel)
        {
            ThingModel = thingModel;
        }

        public ThingModel ThingModel { get; set; }


        public void Add(string username)
        {
            ThingModel.Name = username;
        }
    }
}
