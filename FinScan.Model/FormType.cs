using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinScan.Model;
public enum FormType
{
	[Description("10-Q")]
	F10_Q,
	[Description("10-K")]
	F10_K
}
