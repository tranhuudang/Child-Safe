using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChildSafe
{
    public static class ChildSafeAsset
    {
        public static string downloadedFiltersFolder = "FilterBase";
        public static string onDutyFilters = "OnDuty";
        public static string hostFiltersCollection = "https://raw.githubusercontent.com/zeroclubvn/Host-Filters-Collection/main/Host-Filters-Collection.xml";
        public static string blackList = "Blacklist";
        public static string blackList_D = "Blacklist-D"; // file while in disable mode
        public static string whiteList = "Whitelist";
        public static string whiteList_D = "Whitelist-D";
        public static string host = Path.GetPathRoot(Environment.SystemDirectory) + @"Windows\System32\drivers\etc\hosts";
        public static string defaultChildSafeBaseFilter = "ChildSafeBaseFilter";
        public static string defaultChildSafeBaseFilter_Url = "https://raw.githubusercontent.com/zeroclubvn/Vietnamese-Trash-Websites-Filter/main/adult_websites";
        public static string defaultDownloadInstaller= "https://github.com/zeroclubvn/ChildSafe/raw/master/ChildSafe/Setup/ChildSafe_Setup.msi";
        public static string setupName="ChildSafe_Setup.msi";
        public static string updater="ChildSafeUpdater.exe";
        public static string updateInfo= "https://raw.githubusercontent.com/zeroclubvn/ChildSafe/master/ChildSafe/updateInfo.xml";
        public static string github_page= "https://github.com/zeroclubvn/ChildSafe";
        public static string github_issue= "https://github.com/zeroclubvn/ChildSafe/issues";
        public static string blacklist= "Blacklist";
            }
}
