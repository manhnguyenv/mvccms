﻿namespace DesignWeb_Project.Areas.Admin.Models.DataModel
{
    public class PermissionAction
    {
        public int PermissionID { get; set; }
        public string PermissionName { get; set; }
        public string Description { get; set; }
        public bool IsGranted { get; set; }
    }
}