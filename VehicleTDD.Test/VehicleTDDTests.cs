using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleTDD.Test
{[TestFixture]
    class VehicleTDDTests
    {

        [Test]
        public void VehicleTDD_Ctor() {
            var Vehicle = new Vehicle(" ");
            var result = Vehicle.GetName;
            Assert.That(result, Is.EqualTo(" "));
        }

    }//class end
}//namespace end