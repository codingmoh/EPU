using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace Backoffice.CustomForms
{
    public class NativeTreeView : TreeView
    {
        [DllImport("uxtheme.dll", CharSet = CharSet.Unicode)]
        private extern static int SetWindowTheme(
            IntPtr hWnd,
            string pszSubAppName,
            string pszSubIdList
        );

        protected override void CreateHandle()
        {
            base.CreateHandle();
            SetWindowTheme(this.Handle, "explorer", null);
        }
    }
}
