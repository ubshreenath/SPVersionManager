using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;
using System.IO;

namespace SPDocIntegrator
{
    class Program
    {
        static void Main(string[] args)
        {
            string siteUrl, libName;
            StreamWriter log;
            if(File.Exists("app.log")){
                log = new StreamWriter("app.log", true);
            }
            else{
                log = File.CreateText("app.log");
                log.WriteLine("Item Title | File Name | Created Date | Modified Date");
            }
            if (args.Length != 2)
            {
                Console.WriteLine("Enter Site URL: ");
                siteUrl = Console.ReadLine();
                Console.WriteLine("Enter Library Name: ");
                libName = Console.ReadLine();
            }
            else
            {
                siteUrl = args[0];
                libName = args[1];
            }

            using (SPSite site = new SPSite(siteUrl))
            using (SPWeb web = site.OpenWeb())
            {
                SPList lib = web.Lists[libName];
                SPListItemCollection items = lib.Items;
                foreach (SPListItem item in items)
                {
                    DateTime created = (DateTime)item["Created"];
                    DateTime modified = (DateTime)item["Modified"];
                    if (created > modified)
                    {
                        item["Created"] = modified;
                        item["Modified"] = modified;
                        item.Update();
                        log.WriteLine(String.Format("{0} | {1} | {2} | {3}", item.Url, item.File.Name, created, modified));
                    }
                }
            }

            log.Close();
            log.Dispose();
            Console.WriteLine("Operation completed successfully");
        }
    }
}
