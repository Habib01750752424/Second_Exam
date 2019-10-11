using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exam_4.Repository;
using Exam_4.Models;
namespace Exam_4.BLL
{
    class MobileManager
    {
        private MobileRepositiry _mobileRepositiry=new MobileRepositiry();

        public bool Add(Mobile mobile)
        {
            return _mobileRepositiry.AddMobile(mobile);
        }

        public bool IsImeiExist(Mobile mobile)
        {
            return _mobileRepositiry.IsImeiExists(mobile);
        }

        public Mobile GetByImei(string imei)
        {
            return _mobileRepositiry.GetByImei(imei);
        }

        public List<Mobile> GetByPriceRange(string range1, string range2)
        {
            return _mobileRepositiry.GetByPriceRange(range1, range2);
        }
    }
}
