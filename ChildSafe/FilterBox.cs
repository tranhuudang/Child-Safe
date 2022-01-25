using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace ChildSafe
{
    class FilterBox
    {
        /// <summary>
        /// Get all the available filters in the XML document record
        /// </summary>
        /// <returns>List<Filter> or null if get nothing</returns>
        public List<Filter> getOnlineListFilter()
        {
            List<Filter> list = new List<Filter>();

            try
            {
                // read from file the collection of all available filter in a xml file then fetch it in flowlist
                XmlDocument filters = new XmlDocument();
                filters.Load(ChildSafeAsset.hostFiltersCollection);
                XmlNodeList nodes = filters.GetElementsByTagName("filter");
                foreach (XmlNode note in nodes)
                {
                    string name = note["name"].InnerText;
                    string description = note["description"].InnerText;
                    string linkFile = note["path"].InnerText;
                    string update = note["update"].InnerText;
                    string licence = note["licence"].InnerText;
                    // add filters and it's description in to list
                    list.Add(new Filter(name, description, linkFile, update, licence));
                }
            }
            catch (Exception)
            {
                return null;
                throw;
            }
            return list;
        }
        /// <summary>
        /// Return a array of string which is the name of downloaded filter in app folder
        /// </summary>
        /// <returns>List<string> or null if find nothing</returns>
        public List<string> getDownloadedFilter()
        {
            List<string> listDownloadedFilters = new List<string>();
            // get all the file name in BaseFilter folder and put it in combobox list downloaded filters
            if (Directory.Exists(ChildSafeAsset.downloadedFiltersFolder))
            {
                string[] downloadedFilters = Directory.GetFiles(ChildSafeAsset.downloadedFiltersFolder);
                foreach (string file in downloadedFilters)
                {
                    string filterName = file.Substring(file.LastIndexOf('\\') + 1).Replace('_', ' ');
                    listDownloadedFilters.Add(filterName);
                }
                return listDownloadedFilters;
            }
            else
                return null;
        }
        /// <summary>
        /// Take list filter from a listbox and then read all text in list filter and copy its contents to one file name OnDuty
        /// </summary>
        /// <param name="listOnDutyFilters"></param>
        /// <returns>true if success</returns>
        public bool sendToPendingList(ListBox listOnDutyFilters)
        {
            try
            {
                // read all text in chose filter and copy its contents to one file name OnDuty
                // when we back to home and hit start, app will looking for OnDuty file to move all web to hosts
                foreach (string filterName in listOnDutyFilters.Items)
                {

                    string filterContents = File.ReadAllText(ChildSafeAsset.downloadedFiltersFolder + "\\" + filterName.Replace(' ', '_'));
                    File.AppendAllText(ChildSafeAsset.onDutyFilters, filterContents);
                }
                // add blacklist content to OnDuty file
                if (File.Exists(ChildSafeAsset.blackList))
                {
                    string blackList = File.ReadAllText(ChildSafeAsset.blackList);
                    File.AppendAllText(ChildSafeAsset.onDutyFilters, blackList);
                }
                if(File.Exists(ChildSafeAsset.whiteList))
                {
                    string[] whitelist = File.ReadAllLines(ChildSafeAsset.whiteList);
                    string onDutyAfterWhiteList = File.ReadAllText(ChildSafeAsset.onDutyFilters);
                    foreach (string whiteLine in whitelist)
                    {
                        onDutyAfterWhiteList.Replace(whiteLine, "");
                    }
                    File.WriteAllText(ChildSafeAsset.onDutyFilters, onDutyAfterWhiteList);
                }    
                return true;
            }
            catch (Exception)
            {
                return false;
                throw;
            }
        }
        /// <summary>
        /// Get info about filter
        /// </summary>
        /// <param name="filterName"></param>
        /// <returns>string</returns>
        public string getDownloadedFilterInfo(string filterName)
        {
            string info = "Can't fetch data";
            XmlDocument filters = new XmlDocument();
            filters.Load(ChildSafeAsset.hostFiltersCollection);
            XmlNodeList nodes = filters.GetElementsByTagName("filter");
            foreach (XmlNode note in nodes)
            {
                string name = note["name"].InnerText;
                string compareName = name.Substring(name.LastIndexOf('\\') + 1).Replace('_', ' ');
                if (filterName == compareName)
                {
                    string description = note["description"].InnerText;
                    string linkFile = note["path"].InnerText;
                    string update = note["update"].InnerText;
                    string licence = note["licence"].InnerText;
                    info =    "Name: " + name + "\n\n"
                            + "Description: " + description + "\n\n"
                            + "Update: " + update + "\n"
                            + "Licence: " + licence;
                }
            }
            return info;
        }

    }

}
