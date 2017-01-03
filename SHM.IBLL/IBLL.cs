 
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SHM.Models;
namespace SHM.IBLL
{
	public partial interface ISYS_ActionBLL : IBaseBLL<SYS_Action>
    {
    }

	public partial interface ISYS_DepartmentBLL : IBaseBLL<SYS_Department>
    {
    }

	public partial interface ISYS_ITEMMENUBLL : IBaseBLL<SYS_ITEMMENU>
    {
    }

	public partial interface ISYS_ROLEBLL : IBaseBLL<SYS_ROLE>
    {
    }

	public partial interface ISYS_ROLEACTIONMAPPINGBLL : IBaseBLL<SYS_ROLEACTIONMAPPING>
    {
    }

	public partial interface ISYS_USERINFOBLL : IBaseBLL<SYS_USERINFO>
    {
    }

	public partial interface ISYS_USERROLEMAPPINGBLL : IBaseBLL<SYS_USERROLEMAPPING>
    {
    }


}