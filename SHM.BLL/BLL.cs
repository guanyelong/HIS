 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SHM.Models;
using SHM.IBLL;
namespace SHM.BLL
{
	public partial class SYS_ActionService : BaseBLL<SYS_Action>,ISYS_ActionBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ISYS_ActionDAL;
		}
    }
	public partial class SYS_DepartmentService : BaseBLL<SYS_Department>,ISYS_DepartmentBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ISYS_DepartmentDAL;
		}
    }
	public partial class SYS_ITEMMENUService : BaseBLL<SYS_ITEMMENU>,ISYS_ITEMMENUBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ISYS_ITEMMENUDAL;
		}
    }
	public partial class SYS_ROLEService : BaseBLL<SYS_ROLE>,ISYS_ROLEBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ISYS_ROLEDAL;
		}
    }
	public partial class SYS_ROLEACTIONMAPPINGService : BaseBLL<SYS_ROLEACTIONMAPPING>,ISYS_ROLEACTIONMAPPINGBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ISYS_ROLEACTIONMAPPINGDAL;
		}
    }
	public partial class SYS_USERINFOService : BaseBLL<SYS_USERINFO>,ISYS_USERINFOBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ISYS_USERINFODAL;
		}
    }
	public partial class SYS_USERROLEMAPPINGService : BaseBLL<SYS_USERROLEMAPPING>,ISYS_USERROLEMAPPINGBLL
    {
		public override void SetiDal()
		{
			idal = DbSession.ISYS_USERROLEMAPPINGDAL;
		}
    }
}