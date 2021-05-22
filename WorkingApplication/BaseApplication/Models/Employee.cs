using LegitClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaseApplication.Models
{
    public class Employee
    {
        /// <summary>
        /// Sample Employee just has only two Properties / Feild
        /// Even it is not case sensitive for demo purposes
        /// </summary>
        public string Name { get; set; }
        public readonly string PersonalId = DataProvider.getUniquePersonalId();
    }
}
