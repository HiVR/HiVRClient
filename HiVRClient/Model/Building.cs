namespace HiVRClient.Model
{
    public class Building : Drawable
    {
        #region Constructors

        public Building(int id, double xlocation, double ylocation, double zlocation) : base(id, DrawableType.Building, xlocation, ylocation, zlocation)
        {
        }

        #endregion Constructors
    }
}