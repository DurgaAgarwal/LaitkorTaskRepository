using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace UserTesting
{
    public class SessionMock: HttpSessionStateBase
    {
        Dictionary<string, object> session_storage = new Dictionary<string, object>();
        public override object this[string Email]
        {
            get { return session_storage[Email]; }
            set { session_storage[Email] = "test@gmail.com"; }
        }
    }
}
