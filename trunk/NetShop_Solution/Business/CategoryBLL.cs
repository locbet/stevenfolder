using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Business.DAL;
using Entity;

namespace Business
{
    public class CategoryBLL : CategoryDAL
    {
        public List<CategoryInfo> GetFirst()
        {
            return base.GetCategories(0, 0);
        }
        public List<CategoryInfo> GetSecond(int parentid)
        {
            return base.GetCategories(parentid, 1);
        }
        public List<CategoryInfo> GetThird(int parentid)
        {
            return base.GetCategories(parentid, 2);
        }
    }
}
