using System.Collections.Generic;
using System.Windows.Forms;
using System.Reflection;

namespace Utils.Authority
{
    public static class AuthorityControl
    {
        private static IList<string> accessStringList = new List<string>();
        private static Dictionary<string, string> controlAccesstring = new Dictionary<string, string>();

        public static string userId { get; set; }
        public static string passwd { get; set; }
        public static string systmePrifex { get; set; }

        public static void InitializeAuthority(object obj)
        {
            string fieldPrefix = obj.GetType().FullName.Replace('.', ':') + ":";
            FieldInfo[] fieldInfo = obj.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (FieldInfo fi in fieldInfo)
            {
      //          System.Console.WriteLine(fieldPrefix +"   "+ fi.FieldType.ToString());
                switch (fi.FieldType.Name)
                {
                    case "ToolStripMenuItem":
                        ToolStripItem toolStripItem = (ToolStripItem)fi.GetValue(obj);
                        if (toolStripItem != null && !IsAceessed(fieldPrefix + fi.Name))
                            toolStripItem.Enabled = false;
                        break;

                    case "Button":
                        Button toolButtonItem = (Button)fi.GetValue(obj);
                        if (toolButtonItem != null && !IsAceessed(fieldPrefix + fi.Name))
                            toolButtonItem.Enabled = false;
                        break;
                    case "Panel":
                        //Panel panelItem = (Panel)fi.GetValue(obj);
                        //if (panelItem != null && !IsAceessed(fieldPrefix + fi.Name))
                        //    panelItem.Visible = false;
                        break;
                    case "TreeView":
                        TreeView treeViewItem = (TreeView)fi.GetValue(obj);
                        if (treeViewItem != null)
                        {
                            for (int i = 0; i < treeViewItem.Nodes.Count; ++i)
                            {
                                if (!IsAceessed(fieldPrefix + fi.Name + ':' + treeViewItem.Nodes[i].Name))
                                {
                                    treeViewItem.Nodes[i--].Remove();
                                }
                            }
                        }
                        break;
                    default:
                        break;
                }
            }
        }

        public static bool IsAceessControl(string toolId)
        {
            return controlAccesstring.ContainsKey(toolId);
        }

        public static bool IsAceessed(string toolId)
        {
            if (IsAceessControl(toolId))
            {
                string value;
                controlAccesstring.TryGetValue(toolId, out value);
                if (!accessStringList.Contains(value))
                {
                    return false;
                }
            }
            return true;
        }

        public static void LoadUserAccessString(IList<string> accessList)
        {
            accessStringList = accessList;
        }

        public static void LoadControlAccessString(Dictionary<string, string> accessStringMap)
        {
            controlAccesstring = accessStringMap;
        }

        public static void LoadUserProfile(string id, string password, string prifex)
        {
            userId = id.Trim();
            passwd = password.Trim();
            systmePrifex = prifex.Trim();
        }
    }
}