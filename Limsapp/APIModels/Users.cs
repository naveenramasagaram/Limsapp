using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limsapp.APIModels
{
  public  class Users
    {
        public object createdAt { get; set; }
        public string employee_firstname { get; set; }
        public string employee_lastname { get; set; }
        public string employee_phonenumbe { get; set; }
        public string ademployee_emaildress { get; set; }
        public string citemployee_addressy { get; set; }
        public string stateemployee_dev_level { get; set; }
        public string employee_gender { get; set; }
        public DateTime employee_hire_date { get; set; }
        public bool employee_onleave { get; set; }
        public List<object> tech_stack { get; set; }
        public List<object> project { get; set; }
        public string id { get; set; }
    }
}
