using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PT_FinalProject
{
    public class MySubmit
    {
        private static MySubmit submit = new MySubmit();

        private List<MyGuest> guest = new List<MyGuest>();

        public static MySubmit GetSubmit()
        {
            return submit;
        }

        public IEnumerable<MyGuest> GetAllguest()
        {
            return guest;
        }

        public void AddResponse(MyGuest response)
        {
            guest.Add(response);
        }
    }
}