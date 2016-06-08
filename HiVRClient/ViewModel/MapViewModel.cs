// <copyright file="MapViewModel.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.ViewModel
{
    using System.Windows.Threading;
    using System.Windows;
    using System;
    using System.Collections.ObjectModel;

    /// <summary>
    /// Contains the view model of the actual map.
    /// </summary>
    public class MapViewModel : BaseViewModel
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MapViewModel"/> class.
        /// </summary>
        public MapViewModel()
        {
            var bottomBuilding = new Model.Building(0, 815, 675, 0);
            var topLeftBuilding = new Model.Building(1, 115, 50, 0);
            var lowerLeftBuilding = new Model.Building(2, 0, 600, 0);
            var topRightBuilding = new Model.Building(3, 830, 70, 0);

            bottomBuilding.XScale = 2.88;
            bottomBuilding.YScale = 1;
            topLeftBuilding.XScale = 0.716;
            topLeftBuilding.YScale = 1.2;
            topRightBuilding.XScale = 3.1;
            topRightBuilding.YScale = 0.7;
            lowerLeftBuilding.XScale = 1.5;
            lowerLeftBuilding.YScale = 3.1;

            var car1 = new Model.Car(4, 720, 830, 0);
            var car2 = new Model.Car(5, 350, 70, 0);
            var tree = new Model.Tree(6, 1310, 385, 0);

            var bench1 = new Model.Bench(6, 1253, 385, 0);
            var bench2 = new Model.Bench(7, 1253, 492, 0);
            var bench3 = new Model.Bench(8, 1540, 385, 0);
            var bench4 = new Model.Bench(9, 1540, 492, 0);            

            this.Drawables = new ObservableCollection<DrawableControl>() {                
                new BuildingControl(topLeftBuilding),
                new BuildingControl(bottomBuilding),
                new BuildingControl(lowerLeftBuilding),
                new BuildingControl(topRightBuilding),
                new CarControl(car1),
                new CarControl(car2),
                new TreeControl(tree),
                new BenchControl(bench1),
                new BenchControl(bench2),
                new BenchControl(bench3),
                new BenchControl(bench4),
                new ActorControl(new Model.Actor(1, 400, 400, 400))
            };

            DispatcherTimer updateLocationTimer = new DispatcherTimer();

            updateLocationTimer.Tick += new EventHandler(updateLocationTimerTimer_Tick);
            updateLocationTimer.Interval = new TimeSpan(0, 0, 0, 2, 0);
            updateLocationTimer.Start();

            ////for testing
            DispatcherTimer otherTimer = new DispatcherTimer();

            otherTimer.Tick += new EventHandler(otherTimer_Tick);
            otherTimer.Interval = new TimeSpan(0, 0, 0, 0, 100);
            otherTimer.Start();
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets the collection of draw.
        /// </summary>
        public ObservableCollection<DrawableControl> Drawables { get; set; }

        #endregion Properties

        /// <summary>
        /// dispatcherTimer_Tick
        /// </summary>
        private void otherTimer_Tick(object sender, EventArgs e)
        {            
            foreach (DrawableControl dc in Drawables)
            {
                if (dc is ActorControl)
                {                    
                    ((ActorControl)dc).UpdateMapPosition();
                }                
            }
        }

        /// <summary>
        /// otherTimer_Tick
        /// </summary>
        private void updateLocationTimerTimer_Tick(object sender, EventArgs e)
        {
            Random rd = new Random();

            foreach (DrawableControl dc in Drawables)
            {
                if (dc is ActorControl)
                {
                    ((ActorControl)dc).UpdatePosition(dc.XLocation + rd.Next(-30, 30), dc.YLocation + rd.Next(-30, 30));
                }                
            }
        }
    }
}