using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageChange
{
	public class DamageSender
	{
		private		DamageCalculator	m_kDamageCalculator		= null;

		public DamageSender( DamageCalculator kDamageCalculator )
		{
			m_kDamageCalculator		= kDamageCalculator;
		}

		public void Initialize()
		{

		}

		public void SendDamage( GameActor kFrom, GameActor kTo )
		{
			float	a_fFromPower		= m_kDamageCalculator.CaculateDamage( kFrom );
			float	a_fToHp				= kTo.Hp;
			float	a_fDamageResult		= a_fToHp - a_fFromPower;
			bool	a_bIsDeath			= false;

			kTo.Hp			= a_fDamageResult;  
			a_bIsDeath		= kTo.IsDeath;

			if( a_bIsDeath == true )
			{
				//어떤 역할을 해준다.

			}
		}
	}
}
