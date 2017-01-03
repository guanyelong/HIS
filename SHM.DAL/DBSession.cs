
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SHM.IDAL;

namespace SHM.DAL
{
	public partial class DBSession:IDBSession
    {
		#region 01 数据接口 ISYS_ActionDAL
		ISYS_ActionDAL iSYS_ActionDAL;
		public ISYS_ActionDAL ISYS_ActionDAL
		{
			get
			{
				if(iSYS_ActionDAL==null)
					iSYS_ActionDAL= new SYS_ActionDAL();
				return iSYS_ActionDAL;
			}
			set
			{
				iSYS_ActionDAL= value;
			}
		}
		#endregion

		#region 02 数据接口 ISYS_DepartmentDAL
		ISYS_DepartmentDAL iSYS_DepartmentDAL;
		public ISYS_DepartmentDAL ISYS_DepartmentDAL
		{
			get
			{
				if(iSYS_DepartmentDAL==null)
					iSYS_DepartmentDAL= new SYS_DepartmentDAL();
				return iSYS_DepartmentDAL;
			}
			set
			{
				iSYS_DepartmentDAL= value;
			}
		}
		#endregion

		#region 03 数据接口 ISYS_ITEMMENUDAL
		ISYS_ITEMMENUDAL iSYS_ITEMMENUDAL;
		public ISYS_ITEMMENUDAL ISYS_ITEMMENUDAL
		{
			get
			{
				if(iSYS_ITEMMENUDAL==null)
					iSYS_ITEMMENUDAL= new SYS_ITEMMENUDAL();
				return iSYS_ITEMMENUDAL;
			}
			set
			{
				iSYS_ITEMMENUDAL= value;
			}
		}
		#endregion

		#region 04 数据接口 ISYS_ROLEDAL
		ISYS_ROLEDAL iSYS_ROLEDAL;
		public ISYS_ROLEDAL ISYS_ROLEDAL
		{
			get
			{
				if(iSYS_ROLEDAL==null)
					iSYS_ROLEDAL= new SYS_ROLEDAL();
				return iSYS_ROLEDAL;
			}
			set
			{
				iSYS_ROLEDAL= value;
			}
		}
		#endregion

		#region 05 数据接口 ISYS_ROLEACTIONMAPPINGDAL
		ISYS_ROLEACTIONMAPPINGDAL iSYS_ROLEACTIONMAPPINGDAL;
		public ISYS_ROLEACTIONMAPPINGDAL ISYS_ROLEACTIONMAPPINGDAL
		{
			get
			{
				if(iSYS_ROLEACTIONMAPPINGDAL==null)
					iSYS_ROLEACTIONMAPPINGDAL= new SYS_ROLEACTIONMAPPINGDAL();
				return iSYS_ROLEACTIONMAPPINGDAL;
			}
			set
			{
				iSYS_ROLEACTIONMAPPINGDAL= value;
			}
		}
		#endregion

		#region 06 数据接口 ISYS_USERINFODAL
		ISYS_USERINFODAL iSYS_USERINFODAL;
		public ISYS_USERINFODAL ISYS_USERINFODAL
		{
			get
			{
				if(iSYS_USERINFODAL==null)
					iSYS_USERINFODAL= new SYS_USERINFODAL();
				return iSYS_USERINFODAL;
			}
			set
			{
				iSYS_USERINFODAL= value;
			}
		}
		#endregion

		#region 07 数据接口 ISYS_USERROLEMAPPINGDAL
		ISYS_USERROLEMAPPINGDAL iSYS_USERROLEMAPPINGDAL;
		public ISYS_USERROLEMAPPINGDAL ISYS_USERROLEMAPPINGDAL
		{
			get
			{
				if(iSYS_USERROLEMAPPINGDAL==null)
					iSYS_USERROLEMAPPINGDAL= new SYS_USERROLEMAPPINGDAL();
				return iSYS_USERROLEMAPPINGDAL;
			}
			set
			{
				iSYS_USERROLEMAPPINGDAL= value;
			}
		}
		#endregion

    }

}