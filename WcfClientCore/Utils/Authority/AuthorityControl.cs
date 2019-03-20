using System.Collections.Generic;
using System.Windows.Forms;
using System.Reflection;
using WCFModels.Message;
using Syncfusion.Windows.Forms.Tools;
using WCFModels.Frame;

namespace WcfClientCore.Utils.Authority
{
    public static class AuthorityControl
    {
        private static List<string> accessStringList = new List<string>();
        private static Dictionary<string, string> controlAccesstring = new Dictionary<string, string>();
        private static UserProfile userProfile;
        private static List<UserFavorite> userFavoriteContrlList = new List<UserFavorite>();

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

        public static void LoadUserAccessString(List<string> accessList)
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

        public static List<UserFavorite> GetUserFavorite()
        {
            return userFavoriteContrlList;
        }

        public static void LoadUserFavoriteList(List<UserFavorite> favoriteCtlList)
        {
            //check authority
            foreach (UserFavorite q in favoriteCtlList)
            {
                if (IsAceessed(q.ControlId))
                {
                    userFavoriteContrlList.Add(q);
                }
            }
        }

        public static void RemoveUserFavorite(UserFavorite model)
        {
            foreach (UserFavorite q in userFavoriteContrlList)
            {
                if (q.ControlId.Equals(model.ControlId))
                {
                    userFavoriteContrlList.Remove(model);
                    break;
                }
            }
        }

        public static void AddUserFavorite(UserFavorite model)
        {
            foreach (UserFavorite q in userFavoriteContrlList)
            {
                if (q.ControlId.Equals(model.ControlId))
                {
                    return;
                }
            }
            userFavoriteContrlList.Add(model);
        }
    }
}