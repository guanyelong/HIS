//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;

namespace SHM.Models
{
	public partial class SYS_USERROLEMAPPING
	{
		public SYS_USERROLEMAPPING MiniItem(bool isMini = true){
			return new SYS_USERROLEMAPPING(){
				ID = this.ID,
				ROLEID = this.ROLEID,
				USERID = this.USERID,
				CREATEDATE = this.CREATEDATE,
			};
		}
	}
}
