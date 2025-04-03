﻿using CSharpEgitimKampi301.EntitiyLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpEgitimKampi301.DataAccessLayer.Abstract
{
    public interface IAdminDal : IGenericDal<Admin>
    {
        // Buraya Admin'e özel metotlar yazılabilir.
        // Örneğin: List<Admin> GetAdminsByRole(string role);
    }
}
