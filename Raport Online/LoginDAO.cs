using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raport_Online
{
    class LoginDAO
    {
        private fixraporEntities context = new fixraporEntities();

        public LoginDAO()
        {

        }

        public int add(LOGIN login)
        {
            var result = 0;
            try
            {
                context.LOGIN.Add(login);
                result=context.SaveChanges();
            }
            catch
            {
                result = -1;
            }
            return result;
        }

        public int edit(int id, LOGIN login)
        {
            var result = 0;
            try
            {
                var exsitinglogin = context.LOGIN.Find(id);
                exsitinglogin.PASSWORD = login.PASSWORD;
                exsitinglogin.USERNAME = login.USERNAME;

                result = context.SaveChanges();
            }
            catch
            {
                result = -1;
            }

            return result;
        }


        public LOGIN detail(int id)
        {
            return context.LOGIN.Find(id);
        }

        public int delete(int id, bool isPermanent)
        {
            int result = 0;

            try
            {
                var exsitinglogin = context.LOGIN.Find(id);
                if (!isPermanent)
                {
                    //exsitinglogin.ModifiedDate = DateTime.Now;
                    exsitinglogin.USERNAME = exsitinglogin.USERNAME;
                }

                else
                {
                    context.LOGIN.Remove(exsitinglogin);
                }

                result = context.SaveChanges();
            }
            catch
            {
                result = -1;
            }
            return result;
        }

        public List<LOGIN> getAll()
        {
            return context.LOGIN.ToList();
        }

    }
}
