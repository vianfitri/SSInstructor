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

        public string ScenarioName { get; set; }

        public string DbName { get; set; }

        public string CreateTime { get; set; }

        public string IsActive { get; set; }

        public string IsExist { get; set; }
        #endregion
    }
}
