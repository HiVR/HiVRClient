// <copyright file="SerializableConverter.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>

namespace HiVRClient.Utility
{
    using Model.DrawableModel;
    using SerializedObjects;
    using System;
    using System.Windows.Media.Media3D;
    using ViewModel.DrawableViewModel;

    /// <summary>
    /// Contains methods to convert serializable objects to a format WPF can work with.
    /// </summary>
    public static class SerializableConverter
    {
        #region Fields

        /// <summary>
        /// The drawable factory used to create drawables.
        /// </summary>
        private static DrawableFactory drawableFactory;

        #endregion Fields

        #region Methods

        /// <summary>
        /// Converts a <see cref="SerializableTransformObject"/> to a <see cref="DrawableControl"/>.
        /// </summary>
        /// <param name="serializableTransformObject">the <see cref="SerializableTransformObject"/> object to convert</param>
        /// <returns>the <see cref="DrawableControl"/> object</returns>
        public static DrawableControl CreateDrawableControlFromSerializableObject(SerializableTransformObject serializableTransformObject)
        {
            if (drawableFactory == null)
            {
                drawableFactory = new DrawableFactory();
            }

            switch (serializableTransformObject.Type)
            {
                case SerializableType.Building:
                    return new BuildingControl(
                        drawableFactory.GetBuilding(
                            serializableTransformObject.Id,
                            ConvertSerializableVector3ToVector3D(serializableTransformObject.Position),
                            ConvertSerializableVector3ToVector3D(serializableTransformObject.Rotation),
                            ConvertSerializableVector3ToVector3D(serializableTransformObject.Scale)));

                case SerializableType.Car:
                    return new CarControl(
                        drawableFactory.GetCar(
                            serializableTransformObject.Id,
                            ConvertSerializableVector3ToVector3D(serializableTransformObject.Position),
                            ConvertSerializableVector3ToVector3D(serializableTransformObject.Rotation),
                            ConvertSerializableVector3ToVector3D(serializableTransformObject.Scale)));

                case SerializableType.Garden:
                    return new GardenControl(
                        drawableFactory.GetGarden(
                            serializableTransformObject.Id,
                            ConvertSerializableVector3ToVector3D(serializableTransformObject.Position),
                            ConvertSerializableVector3ToVector3D(serializableTransformObject.Rotation),
                            ConvertSerializableVector3ToVector3D(serializableTransformObject.Scale)));

                case SerializableType.Bench:
                    return new BenchControl(
                        drawableFactory.GetBench(
                            serializableTransformObject.Id,
                            ConvertSerializableVector3ToVector3D(serializableTransformObject.Position),
                            ConvertSerializableVector3ToVector3D(serializableTransformObject.Rotation),
                            ConvertSerializableVector3ToVector3D(serializableTransformObject.Scale)));

                case SerializableType.Television:
                    return new TelevisionControl(
                        drawableFactory.GetTelevision(
                            serializableTransformObject.Id,
                            ConvertSerializableVector3ToVector3D(serializableTransformObject.Position),
                            ConvertSerializableVector3ToVector3D(serializableTransformObject.Rotation),
                            ConvertSerializableVector3ToVector3D(serializableTransformObject.Scale)));

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        /// <summary>
        /// Converts <see cref="SerializableVector3"/> to <see cref="Vector3D"/>.
        /// </summary>
        /// <param name="svector">the <see cref="SerializableVector3"/> to convert</param>
        /// <returns>the <see cref="Vector3D"/></returns>
        public static Vector3D ConvertSerializableVector3ToVector3D(SerializableVector3 svector)
        {
            return new Vector3D(svector.X, svector.Y, svector.Z);
        }

        #endregion Methods
    }
}