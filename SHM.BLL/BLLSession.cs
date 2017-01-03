
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SHM.IBLL;

namespace SHM.BLL
{
	public partial class BLLSession:IBLLSession
    {
		#region 01 业务接口 ISYS_ActionDAL
		ISYS_ActionBLL iSYS_ActionBLL;
		public ISYS_ActionBLL ISYS_ActionBLL
		{
			get
			{
				if(iSYS_ActionBLL==null)
					iSYS_ActionBLL= new SYS_ActionService();
				return iSYS_ActionBLL;
			}
			set
			{
				iSYS_ActionBLL= value;
			}
		}
		#endregion

		#region 02 业务接口 ISYS_DepartmentDAL
		ISYS_DepartmentBLL iSYS_DepartmentBLL;
		public ISYS_DepartmentBLL ISYS_DepartmentBLL
		{
			get
			{
				if(iSYS_DepartmentBLL==null)
					iSYS_DepartmentBLL= new SYS_DepartmentService();
				return iSYS_DepartmentBLL;
			}
			set
			{
				iSYS_DepartmentBLL= value;
			}
		}
		#endregion

		#region 03 业务接口 ISYS_ITEMMENUDAL
		ISYS_ITEMMENUBLL iSYS_ITEMMENUBLL;
		public ISYS_ITEMMENUBLL ISYS_ITEMMENUBLL
		{
			get
			{
				if(iSYS_ITEMMENUBLL==null)
					iSYS_ITEMMENUBLL= new SYS_ITEMMENUService();
				return iSYS_ITEMMENUBLL;
			}
			set
			{
				iSYS_ITEMMENUBLL= value;
			}
		}
		#endregion

		#region 04 业务接口 ISYS_ROLEDAL
		ISYS_ROLEBLL iSYS_ROLEBLL;
		public ISYS_ROLEBLL ISYS_ROLEBLL
		{
			get
			{
				if(iSYS_ROLEBLL==null)
					iSYS_ROLEBLL= new SYS_ROLEService();
				return iSYS_ROLEBLL;
			}
			set
			{
				iSYS_ROLEBLL= value;
			}
		}
		#endregion

		#region 05 业务接口 ISYS_ROLEACTIONMAPPINGDAL
		ISYS_ROLEACTIONMAPPINGBLL iSYS_ROLEACTIONMAPPINGBLL;
		public ISYS_ROLEACTIONMAPPINGBLL ISYS_ROLEACTIONMAPPINGBLL
		{
			get
			{
				if(iSYS_ROLEACTIONMAPPINGBLL==null)
					iSYS_ROLEACTIONMAPPINGBLL= new SYS_ROLEACTIONMAPPINGService();
				return iSYS_ROLEACTIONMAPPINGBLL;
			}
			set
			{
				iSYS_ROLEACTIONMAPPINGBLL= value;
			}
		}
		#endregion

		#region 06 业务接口 ISYS_USERINFODAL
		ISYS_USERINFOBLL iSYS_USERINFOBLL;
		public ISYS_USERINFOBLL ISYS_USERINFOBLL
		{
			get
			{
				if(iSYS_USERINFOBLL==null)
					iSYS_USERINFOBLL= new SYS_USERINFOService();
				return iSYS_USERINFOBLL;
			}
			set
			{
				iSYS_USERINFOBLL= value;
			}
		}
		#endregion

		#region 07 业务接口 ISYS_USERROLEMAPPINGDAL
		ISYS_USERROLEMAPPINGBLL iSYS_USERROLEMAPPINGBLL;
		public ISYS_USERROLEMAPPINGBLL ISYS_USERROLEMAPPINGBLL
		{
			get
			{
				if(iSYS_USERROLEMAPPINGBLL==null)
					iSYS_USERROLEMAPPINGBLL= new SYS_USERROLEMAPPINGService();
				return iSYS_USERROLEMAPPINGBLL;
			}
			set
			{
				iSYS_USERROLEMAPPINGBLL= value;
			}
		}
		#endregion

    }

}