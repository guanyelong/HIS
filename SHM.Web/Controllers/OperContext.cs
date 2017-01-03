using SHM.IBLL;
using SHM.Spring;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SHM.Web.Controllers
{
    public class OperContext
    {
        //初始化创建对象
        private IBLLSession iBllSession;
        public IBLLSession BllSession
        {
            get
            {
                if (iBllSession == null)
                {
                    IBLLSessionFactory bllSessionFactory = SpringHelper.GetObject<IBLLSessionFactory>("BLLSessionFactory");
                    iBllSession = bllSessionFactory.GetBLLSesson();
                }
                return iBllSession;
            }
        }
    }
}