using System;

namespace HiVRClient.Model
{
    public abstract class Drawable
    {
        #region Constructors

        protected Drawable(int id, DrawableType type, double xlocation, double ylocation, double zlocation)
        {
            this.Id = id;
            this.DrawableType = type;
            this.XLocation = xlocation;
            this.YLocation = ylocation;
            this.ZLocation = zlocation;
        }

        #endregion Constructors

        #region Properties

        public int Id { get; }
        public DrawableType DrawableType { get; }

        public double XLocation { get; set; }
        public double YLocation { get; set; }
        public double ZLocation { get; set; }

        public double XRotation { get; set; }
        public double YRotation { get; set; }
        public double ZRotation { get; set; }

        public double XScale { get; set; } = 1;
        public double YScale { get; set; } = 1;
        public double ZScale { get; set; } = 1;

        #endregion Properties
    }
}