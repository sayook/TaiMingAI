﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaiMingAI.DataHelper;
using TaiMingAI.Manager.DAL;
using TaiMingAI.Manager.Model;

namespace TaiMingAI.Manager.BLL
{
    public class NavbarBll
    {
        /// <summary>
        /// 获取导航菜单列表
        /// </summary>
        /// <param name="isAll">是否获取全部数据</param>
        /// <returns>菜单列表 List_NavBar</returns>
        internal List<NavBardb> GetNavbarList(bool isAll)
        {
            NavbarDal navbarDal = new NavbarDal();
            var list = navbarDal.GetNavbarList();
            if (list == null || list.Count == 0) return list;
            if (!isAll)
            {
                list = list.FindAll(x => x.IsShow);
            }
            return list;
        }

        internal bool InsertNavber(NavBardb navBar)
        {
            NavbarDal navbarDal = new NavbarDal();
            return navbarDal.InsertNavber(navBar);
        }

        internal bool UpdateNavber(NavBardb navBar)
        {
            NavbarDal navbarDal = new NavbarDal();
            return navbarDal.UpdateNavber(navBar);
        }
    }
}
