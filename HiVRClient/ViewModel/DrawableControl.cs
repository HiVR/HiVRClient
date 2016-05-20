namespace HiVRClient.ViewModel
{
    using Model;

    public class DrawableControl : BaseViewModel
    {
        #region Fields

        private Drawable drawable;

        #endregion Fields

        #region Constructors

        public DrawableControl(Drawable drawable)
        {
            this.drawable = drawable;
        }

        #endregion Constructors

        #region Properties

        public DrawableType DrawableType => drawable.DrawableType;

        public double XLocation
        {
            get { return drawable.XLocation; }
            set { drawable.XLocation = value; }
        }

        public double YLocation
        {
            get { return drawable.YLocation; }
            set { drawable.YLocation = value; }
        }

        public double ZLocation
        {
            get { return drawable.ZLocation; }
            set { drawable.ZLocation = value; }
        }

        public double XRotation
        {
            get { return drawable.XRotation; }
            set { drawable.XRotation = value; }
        }

        public double YRotation
        {
            get { return drawable.YRotation; }
            set { drawable.YRotation = value; }
        }

        public double ZRotation
        {
            get { return drawable.ZRotation; }
            set { drawable.ZRotation = value; }
        }

        public double XScale
        {
            get { return drawable.XScale; }
            set { drawable.XScale = value; }
        }

        public double YScale
        {
            get { return drawable.YScale; }
            set { drawable.YScale = value; }
        }

        public double ZScale
        {
            get { return drawable.ZScale; }
            set { drawable.ZScale = value; }
        }

        #endregion Properties
    }
}