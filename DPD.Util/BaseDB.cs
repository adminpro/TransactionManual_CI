using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;

namespace DPD.Util
{
    public class BaseDB<T> where T:class
    {
        public List<T> Lists { get; set; }
        public BaseDB(string dbFilePath)
        {
            this.Lists = (from c in System.IO.File.ReadAllLines(Assembly.GetExecutingAssembly().Location.Replace("DPD.Util.dll", dbFilePath))
                          where !c.StartsWith("#")
                          select GetItem(c)).ToList();
        }

        protected virtual T GetItem(string line)
        {
            string[] arr = line.Split(new char[] { '|' });
            Type type = typeof(T);
            object o = Activator.CreateInstance(type);

            int i = 0;
            foreach (PropertyInfo item in type.GetProperties())
            {
                type.InvokeMember(item.Name, BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.Public, null, o, new object[] { arr[i++] });
            }
            //string text = (string)type.InvokeMember("Text", BindingFlags.GetProperty | BindingFlags.Instance | BindingFlags.Public, null, o, new object[] { });
            
            return (T)o;
        }
    }
}
