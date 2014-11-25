using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.SharePoint;

namespace Document_Version_Manager
{
    public class SPListItemVersionWrapper 
    {
        public SPListItemVersion Version { get; set; }
        public override string ToString()
        {
            return Version.ListItem.Title + "|" + Version.VersionLabel;
        }
        public SPListItemVersionWrapper(SPListItemVersion version)
        {
            Version = version;
        }
    }
}
