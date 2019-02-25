using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageChange
{
	public class DamageCalculator
	{
		public DamageCalculator()
		{

		}

		public void Initialize()
		{

		}

		public float CaculateDamage( GameActor kAttacker )
		{
			return kAttacker.Power;
		}
	}
}
