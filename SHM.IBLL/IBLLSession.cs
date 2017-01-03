

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SHM.IBLL
{
	public partial interface IBLLSession
    {
		ISYS_ActionBLL ISYS_ActionBLL{get;set;}
		ISYS_DepartmentBLL ISYS_DepartmentBLL{get;set;}
		ISYS_ITEMMENUBLL ISYS_ITEMMENUBLL{get;set;}
		ISYS_ROLEBLL ISYS_ROLEBLL{get;set;}
		ISYS_ROLEACTIONMAPPINGBLL ISYS_ROLEACTIONMAPPINGBLL{get;set;}
		ISYS_USERINFOBLL ISYS_USERINFOBLL{get;set;}
		ISYS_USERROLEMAPPINGBLL ISYS_USERROLEMAPPINGBLL{get;set;}
    }

}