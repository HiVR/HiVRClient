// <copyright file="SerializableConverter.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>

namespace HiVRClient.Utility
{
    using Model;
    using SerializedObjects;
    using System;
    using System.Windows.Media.Media3D;
    using ViewModel;

    /// <summary>
    /// Contains methods to convert serializable objects to a format WPF can work with.
    /// </summary>
    public static class SerializableConverter
    {
        #region Methods

        /// <summary>
        /// Converts a <see cref="SerializableTransformObject"/> to a <see cref="DrawableControl"/>.
        /// </summary>
        /// <param name="serializableTransformObject">the <see cref="SerializableTransformObject"/> object to convert</param>
        /// <returns>the <see cref="DrawableControl"/> object</returns>
        public static DrawableControl CreateDrawableControlFromSerializableObject(SerializableTransformObject serializableTransformObject)
        {
            switch (serializableTransformObject.Type)
            {
                case SerializableType.Building:
                    return new BuildingControl(
                        new Building(
                            serializableTransformObject.Id,
                            ConvertSerializableVector3ToVector3D(serializableTransformObject.Position),
                            ConvertSerializableVector3ToVector3D(serializableTransformObject.Rotation),
                            ConvertSerializableVector3ToVector3D(serializableTransformObject.Scale)));

                case SerializableType.Car:
                    return new CarControl(
                        new Car(
                            serializableTransformObject.Id,
                            ConvertSerializableVector3ToVector3D(serializableTransformObject.Position),
                            ConvertSerializableVector3ToVector3D(serializableTransformObject.Rotation),
                            ConvertSerializableVector3ToVector3D(serializableTransformObject.Scale)));

                case SerializableType.Garden:
                    return new GardenControl(
                        new Garden(
                            serializableTransformObject.Id,
                            ConvertSerializableVector3ToVector3D(serializableTransformObject.Position),
                            ConvertSerializableVector3ToVector3D(serializableTransformObject.Rotation),
                            ConvertSerializableVector3ToVector3D(serializableTransformObject.Scale)));

                case SerializableType.Bench:
                    return new BenchControl(
                        new Bench(
                            serializableTransformObject.Id,
                            ConvertSerializableVector3ToVector3D(serializableTransformObject.Position),
                            ConvertSerializableVector3ToVector3D(serializableTransformObject.Rotation),
                            ConvertSerializableVector3ToVector3D(serializableTransformObject.Scale)));

                case SerializableType.Television:
                    return new TelevisionControl(
                        new Television(
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