using System;

namespace YF.Life.Permissions
{
    public static class LifePermissions
    {
        public const string GroupName = "Life";

        //Add your own permission names. Example:
        //public const string MyPermission1 = GroupName + ".MyPermission1";

        public static string[] GetAll()
        {
            //Return an array of all permissions
            return Array.Empty<string>();
        }
    }
}