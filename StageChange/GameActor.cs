using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StageChange
{
	public abstract class GameActor
	{
		public		float		Hp{ get{ return m_fHp; } set{ m_fHp = value; } }
		public		float		Power{ get{ return m_fPower; } }
		public		bool		IsDeath{ get{ return (m_fHp <= 0); }}

		protected	float		m_fHp;
		protected	float		m_fPower;
	}
}
