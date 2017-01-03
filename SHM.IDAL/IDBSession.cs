
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SHM.IDAL
{
	public partial interface IDBSession
    {
		ISYS_ActionDAL ISYS_ActionDAL{get;set;}
		ISYS_DepartmentDAL ISYS_DepartmentDAL{get;set;}
		ISYS_ITEMMENUDAL ISYS_ITEMMENUDAL{get;set;}
		ISYS_ROLEDAL ISYS_ROLEDAL{get;set;}
		ISYS_ROLEACTIONMAPPINGDAL ISYS_ROLEACTIONMAPPINGDAL{get;set;}
		ISYS_USERINFODAL ISYS_USERINFODAL{get;set;}
		ISYS_USERROLEMAPPINGDAL ISYS_USERROLEMAPPINGDAL{get;set;}
    }

}