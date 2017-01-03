 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SHM.Models;
using SHM.IDAL;
namespace SHM.DAL
{
	public partial class SYS_ActionDAL : BaseDAL<SYS_Action>,ISYS_ActionDAL
    {
    }
	public partial class SYS_DepartmentDAL : BaseDAL<SYS_Department>,ISYS_DepartmentDAL
    {
    }
	public partial class SYS_ITEMMENUDAL : BaseDAL<SYS_ITEMMENU>,ISYS_ITEMMENUDAL
    {
    }
	public partial class SYS_ROLEDAL : BaseDAL<SYS_ROLE>,ISYS_ROLEDAL
    {
    }
	public partial class SYS_ROLEACTIONMAPPINGDAL : BaseDAL<SYS_ROLEACTIONMAPPING>,ISYS_ROLEACTIONMAPPINGDAL
    {
    }
	public partial class SYS_USERINFODAL : BaseDAL<SYS_USERINFO>,ISYS_USERINFODAL
    {
    }
	public partial class SYS_USERROLEMAPPINGDAL : BaseDAL<SYS_USERROLEMAPPING>,ISYS_USERROLEMAPPINGDAL
    {
    }
}