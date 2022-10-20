using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSInstructor.Models
{
    public class ScenarioModel
    {
        #region "Fields"
        public string Id { get; set; }

        public string Scenario_Name { get; set; }

        public string Db_Name { get; set; }

        public string Create_Time { get; set; }

        public string Is_Active { get; set; }

        public string Is_Exist { get; set; }
        #endregion
    }
}
