
 
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SHM.Models;
namespace SHM.IDAL
{
	public partial interface ISYS_ActionDAL : IBaseDAL<SYS_Action>
    {
    }

	public partial interface ISYS_DepartmentDAL : IBaseDAL<SYS_Department>
    {
    }

	public partial interface ISYS_ITEMMENUDAL : IBaseDAL<SYS_ITEMMENU>
    {
    }

	public partial interface ISYS_ROLEDAL : IBaseDAL<SYS_ROLE>
    {
    }

	public partial interface ISYS_ROLEACTIONMAPPINGDAL : IBaseDAL<SYS_ROLEACTIONMAPPING>
    {
    }

	public partial interface ISYS_USERINFODAL : IBaseDAL<SYS_USERINFO>
    {
    }

	public partial interface ISYS_USERROLEMAPPINGDAL : IBaseDAL<SYS_USERROLEMAPPING>
    {
    }


}