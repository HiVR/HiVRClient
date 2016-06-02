using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiVRClient.Model
{
    /// <summary>
    /// This class implements a Player.
    /// </summary>
    public class Actor : Drawable
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Actor"/> class.
        /// </summary>
        /// <param name="id">the id of the drawable actor</param>
        /// <param name="xlocation">the x coordinate of the actor</param>
        /// <param name="ylocation">the y coordinate of the actor</param>
        /// <param name="zlocation">the z coordinate of the actor</param>
        public Actor(int id, double xlocation, double ylocation, double zlocation) : base(id, xlocation, ylocation, zlocation)
        {
        }

    }
}
