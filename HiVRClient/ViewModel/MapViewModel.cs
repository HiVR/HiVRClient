// <copyright file="MapViewModel.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.ViewModel
{
    using Model;
    using System.Collections.ObjectModel;

    /// <summary>
    /// Contains the view model of the actual map
    /// </summary>
    public class MapViewModel : BaseViewModel
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MapViewModel"/> class
        /// </summary>
        public MapViewModel()
        {
            // Positions and dimension of each static Object in the Static map.
            var bottomBuilding = new Building(0, 815, 675, 0);       
            var topLeftBuilding = new Building(1, 115, 50, 0);
            var lowerLeftBuilding = new Building(2, 0, 600, 0);
            var topRightBuilding = new Building(3, 830, 70, 0);

            // Proper scaling for Sizes
            bottomBuilding.XScale = 2.88;
            bottomBuilding.YScale = 1;
            topLeftBuilding.XScale = 0.716;
            topLeftBuilding.YScale = 1.2;
            topRightBuilding.XScale = 3.1;
            topRightBuilding.YScale = 0.7;
            lowerLeftBuilding.XScale = 1.5;
            lowerLeftBuilding.YScale = 3.1;


            var car1 = new Car(4, 720, 830, 0);
            var car2 = new Car(5, 350, 70, 0);
            var tree = new Tree(6, 1310, 385, 0);

            var bench1 = new Bench(6, 1253, 385, 0);
            var bench2 = new Bench(7, 1253, 492, 0);
            var bench3 = new Bench(8, 1540, 385, 0);
            var bench4 = new Bench(9, 1540, 492, 0);

            var actor1 = new Actor(10, 543, 294, 0);
            var actor2 = new Actor(11, 593, 272, 0);
            var actor3 = new Actor(12, 588, 323, 0);
            var actor4 = new Actor(13, 529, 603, 0);
            var actor5 = new Actor(14, 558, 646, 0);
            var actor6 = new Actor(15, 1730, 384, 0);
            var actor7 = new Actor(16, 1761, 420, 0);

            var user = new User(17, 930, 470,0);

            // Apply the proper scaling to each static object.           


            //Draw the objects on the map.
            this.Drawables = new ObservableCollection<DrawableControl>()
            {
                new DrawableControl(topLeftBuilding),
                new DrawableControl(bottomBuilding),
                new DrawableControl(lowerLeftBuilding),
                new DrawableControl(topRightBuilding),
                new DrawableControl(actor1),
                new DrawableControl(actor2),
                new DrawableControl(actor3),
                new DrawableControl(actor4),
                new DrawableControl(actor5),
                new DrawableControl(actor6),
                new DrawableControl(actor7),
                new DrawableControl(user),
                new DrawableControl(car1),
                new DrawableControl(car2),
                new DrawableControl(tree),
                new DrawableControl(bench1),
                new DrawableControl(bench2),
                new DrawableControl(bench3),
                new DrawableControl(bench4)
            };                                 
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the collection of draw
        /// </summary>
        public ObservableCollection<DrawableControl> Drawables { get; set; }

        #endregion Properties
    }
}