using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dlekomze.AbstrakteKlassen
{
	public abstract class Form
	{
		#region Properties
		public double PosX { get; set; }
		public double PosY { get; set; }
		#endregion

		#region Constructors
		protected Form(double posX, double posY)
		{
			PosX = posX;
			PosY = posY;
		}
		#endregion

		#region Methods
		public abstract double BerechnenFlaeche();
		public abstract double BerechnenUmfang();
		#endregion
	}
}
