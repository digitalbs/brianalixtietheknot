using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrianandAlix.DataLayers
{
    public class RSVP_Query
    {
        public static List<string> QueryGuests()
        {
            List<string> group = new List<string>();
            using (var context = new BrianAlixDataModelContainer())
            {
                var people = from c in context.People
                             where c.FirstName == "Brian"
                             select
                                 new { c.FirstName, c.LastName };
               
            }

            return group;
        }
    }
}
