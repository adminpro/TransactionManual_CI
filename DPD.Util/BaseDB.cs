using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.IO;

namespace DPD.Util
{
    public class BaseDB<T> where T : class
    {
        public List<T> Lists { get; set; }
        public string DBName { get; set; }
        public string Version { get; set; }
        public string Update { get; set; }
        public string Expiration { get; set; }
        public string Hash { get; set; }
        public string Reference { get; set; }
        public string[] Fields { get; set; }
        public string[] Key { get; set; }
        protected readonly char[] CharSpliter = { '|' };

        public BaseDB()
        {

        }

        public BaseDB(string dbFilePath, string startWith)
        {
            //System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            //sw.Start();

            string[] dbText = System.IO.File.ReadAllLines(Assembly.GetExecutingAssembly().Location.Replace("DPD.Util.dll", dbFilePath));
            //this.Lists = (from c in dbText.Skip(7)
            //              where c.StartsWith(startWith)
            //              select GetItem(c)).ToList();
            this.Lists = new List<T>();
            int begin = -1, count = 0;
            for (int i = 7; i < dbText.Length; i++)
            {
                //if (dbText[i][0] != startWith[0] && dbText[i][1] != startWith[1])
                //    continue;
                if (dbText[i].IndexOf(startWith) == 0)
                {
                    count++;
                }
                else if (count > 0)
                {
                    begin = i - count;
                    break;
                }
            }
            if (count > 0)
            {
                if (begin == -1)
                    begin = dbText.Length - count;
                this.Lists = (from c in dbText.Skip(begin).Take(count)
                              select GetItem(c)).ToList();
            }
            //sw.Stop();
            //System.Diagnostics.Trace.WriteLine(sw.ElapsedMilliseconds);
        }

        public BaseDB(string dbFilePath)
        {
            //this.Lists = new List<T>();

            //StringBuilder sbDbText = new StringBuilder();
            //using (StreamReader reader = new StreamReader(Assembly.GetExecutingAssembly().Location.Replace("DPD.Util.dll", dbFilePath)))
            //{
            //    this.DBName = reader.ReadLine().Replace("#Filename: ", string.Empty);
            //    this.Version = reader.ReadLine().Replace("#Version: ", string.Empty);
            //    this.Expiration = reader.ReadLine().Replace("#Expiration: ", string.Empty);
            //    this.Hash = reader.ReadLine().Replace("#Hash: ", string.Empty);
            //    this.Reference = reader.ReadLine().Replace("#Reference: ", string.Empty);
            //    this.Fields = reader.ReadLine().Replace("#Fields: ", string.Empty).Replace("-", "_").Split(CharSpliter, StringSplitOptions.RemoveEmptyEntries);
            //    this.Key = reader.ReadLine().Replace("#Key: ", string.Empty).Replace("-", "_").Split(CharSpliter, StringSplitOptions.RemoveEmptyEntries);
            //    while (!reader.EndOfStream)
            //    {
            //        this.Lists.Add(GetItem(reader.ReadLine()));
            //    }
            //}

            //using (TextReader reader = File.OpenText(Assembly.GetExecutingAssembly().Location.Replace("DPD.Util.dll", dbFilePath)))
            //{
            //    string result = reader.ReadToEnd();

            //    string[] dbText = result.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries); ;
            //    if (dbText.Length == 0)
            //        throw new NullReferenceException("DB file is null.");

            //    int i = 0;

            //    this.DBName = dbText[i++].Replace("#Filename: ", string.Empty);
            //    this.Version = dbText[i++].Replace("#Version: ", string.Empty);
            //    if (dbText[i].IndexOf("#Update: ") == 0)
            //        this.Update = dbText[i++].Replace("#Update: ", string.Empty);
            //    this.Expiration = dbText[i++].Replace("#Expiration: ", string.Empty);
            //    this.Hash = dbText[i++].Replace("#Hash: ", string.Empty);
            //    this.Reference = dbText[i++].Replace("#Reference: ", string.Empty);
            //    this.Fields = dbText[i++].Replace("#Fields: ", string.Empty).Replace("-", "_").Split(CharSpliter, StringSplitOptions.RemoveEmptyEntries);
            //    this.Key = dbText[i++].Replace("#Key: ", string.Empty).Replace("-", "_").Split(CharSpliter, StringSplitOptions.RemoveEmptyEntries);
            //    //System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            //    //sw.Start();
            //    this.Lists = (from c in dbText.Skip(i)
            //                  select GetItem(c)).ToList();
            //}

            string[] dbText = System.IO.File.ReadAllLines(Assembly.GetExecutingAssembly().Location.Replace("DPD.Util.dll", dbFilePath));
            if (dbText.Length == 0)
                throw new NullReferenceException("DB file is null.");

            int i = 0;

            this.DBName = dbText[i++].Replace("#Filename: ", string.Empty);
            this.Version = dbText[i++].Replace("#Version: ", string.Empty);
            if (dbText[i].IndexOf("#Update: ") == 0)
                this.Update = dbText[i++].Replace("#Update: ", string.Empty);
            this.Expiration = dbText[i++].Replace("#Expiration: ", string.Empty);
            this.Hash = dbText[i++].Replace("#Hash: ", string.Empty);
            this.Reference = dbText[i++].Replace("#Reference: ", string.Empty);
            this.Fields = dbText[i++].Replace("#Fields: ", string.Empty).Replace("-", "_").Split(CharSpliter, StringSplitOptions.RemoveEmptyEntries);
            this.Key = dbText[i++].Replace("#Key: ", string.Empty).Replace("-", "_").Split(CharSpliter, StringSplitOptions.RemoveEmptyEntries);
            //System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            //sw.Start();
            this.Lists = (from c in dbText.Skip(i)
                          select GetItem(c)).ToList();

            //sw.Stop();
            //System.Diagnostics.Trace.WriteLine(sw.ElapsedMilliseconds);
        }

        protected virtual T GetItem(string line)
        {
            string[] arr = line.Split(CharSpliter);

            Type type = typeof(T);
            object o = Activator.CreateInstance(type);

            int i = 0;
            foreach (string itemName in Fields)
            {
                type.InvokeMember(itemName, BindingFlags.SetProperty | BindingFlags.Instance | BindingFlags.Public, null, o, new object[] { arr[i++] });
            }
            //string text = (string)type.InvokeMember("Text", BindingFlags.GetProperty | BindingFlags.Instance | BindingFlags.Public, null, o, new object[] { });

            return (T)o;
        }
        public override string ToString()
        {
            return string.Format("#Filename: {0}\r\n#Version: {1}\r\n#Expiration: {2}\r\n#Hash: {3}\r\n#Reference: {4}\r\n#Fields: {5}\r\n#Key: {6}",
                this.DBName,
                this.Version,
                this.Expiration,
                this.Hash,
                this.Reference,
                string.Join("|", this.Fields),
                string.Join("|", this.Key));
            //return base.ToString();
        }
    }
}
