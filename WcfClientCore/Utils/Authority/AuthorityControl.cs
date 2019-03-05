using System.Collections.Generic;
using System.Windows.Forms;
using System.Reflection;
using WCFModels.Message;
using Syncfusion.Windows.Forms.Tools;

namespace WcfClientCore.Utils.Authority
{
    public static class AuthorityControl
    {
        private static IList<string> accessStringList = new List<string>();
        private static Dictionary<string, string> controlAccesstring = new Dictionary<string, string>();
        private static UserProfile userProfile;

        public static void InitializeAuthority(object obj)
        {
            string fieldPrefix = obj.GetType().FullName.Replace('.', ':') + ":";
            FieldInfo[] fieldInfo = obj.GetType().GetFields(BindingFlags.NonPublic | BindingFlags.Instance);

            foreach (FieldInfo fi in fieldInfo)
            {
//                System.Console.WriteLine(fieldPrefix +"   "+ fi.FieldType.ToString());
                switch (fi.FieldType.Name)
                {
                    case "ToolStripMenuItem":
                        ToolStripItem toolStripItem = (ToolStripItem)fi.GetValue(obj);
                        if (toolStripItem != null && !IsAceessed(fieldPrefix + fi.Name))
                            toolStripItem.Enabled = false;
                        else
                            toolStripItem.Enabled = true;
                        break;

                    case "Button":
                        Button toolButtonItem = (Button)fi.GetValue(obj);
                        if (toolButtonItem != null && !IsAceessed(fieldPrefix + fi.Name))
                            toolButtonItem.Enabled = false;
                        else
                            toolButtonItem.Enabled = true;
                        break;
                    case "DockingManager":
                        DockingManager dockItem = (DockingManager)fi.GetValue(obj);
                        foreach (Control q in dockItem.ControlsArray)
                        {
                            if(q != null && !IsAceessed(fieldPrefix + q.Name))
                                dockItem.SetDockVisibility(q, false);
                            else
                                dockItem.SetDockVisibility(q, true);
                        }
                        break;
                    case "TreeView":
                        TreeView treeViewItem = (TreeView)fi.GetValue(obj);
                        if (treeViewItem != null && treeViewItem.Parent.Visible)
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

        public static void LoadUserProfile(UserProfile profile)
        {
            userProfile = profile;
        }

        public static UserProfile GetUserProfile()
        {
            return userProfile;
        }
    }
}