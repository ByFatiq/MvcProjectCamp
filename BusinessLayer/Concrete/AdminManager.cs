﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;

namespace BusinessLayer.Concrete
{
   public class AdminManager : IAdminService
   {
       IAdminDal _adminDal;

       public AdminManager(IAdminDal adminDal)
       {
           _adminDal = adminDal;
       }


        public List<Admin> GetAdminList()
        {
            throw new NotImplementedException();
        }

        public void AdminAddBl(Admin admin)
        {
            throw new NotImplementedException();
        }

        public Admin GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void AdminDelete(Admin admin)
        {
            throw new NotImplementedException();
        }

        public void AdminUpdate(Admin admin)
        {
            throw new NotImplementedException();
        }
    }
}
