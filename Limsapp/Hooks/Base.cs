using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Limsapp.Hooks
{
  public  class Base<T>
    {
        private static T _priobj;
        public static T CurrentPage
        {
            get
            {
                return _priobj;
            }
            set
            {
                _priobj = value;
            }
        }

        //public static object Priob;

        public static void GetInstance<T>()
        {
            if (Base<T>.CurrentPage == null || Base<T>.CurrentPage.GetType() != typeof(T))
            {
                T page = (T)Activator.CreateInstance(typeof(T));
                PageFactory.InitElements(HookInitilization.driver, page);
                Base<T>.CurrentPage = page;
            }
            //else
            //{
               //return Base<T>.Priob;
            //}
            //return page;
        }
    }
}
