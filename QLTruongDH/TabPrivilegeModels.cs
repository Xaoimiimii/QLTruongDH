using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLTruongDH
{
    public class PrivilegeInfo
    {
        public string PrivilegeName { get; set; }
        public bool WithGrantOption { get; set; }
        public List<string> Columns { get; set; }

        public PrivilegeInfo(string privilegeName, bool withGrantOption, List<string> columns)
        {
            PrivilegeName = privilegeName;
            WithGrantOption = withGrantOption;
            Columns = columns;
        }
    }

    public class TablePrivilege
    {
        public string TableName { get; set; }
        public List<PrivilegeInfo> Privileges { get; set; }

        public TablePrivilege(string tableName)
        {
            TableName = tableName;
            Privileges = new List<PrivilegeInfo>();
        }
    }
}
