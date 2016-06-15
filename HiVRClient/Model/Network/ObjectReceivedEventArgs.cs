// <copyright file="ObjectReceivedEventArgs.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>
namespace HiVRClient.Model.Network
{
    using SerializedObjects;
    using System;

    /// <summary>
    /// Contains a serializable object.
    /// </summary>
    public class ObjectReceivedEventArgs : EventArgs
    {
        #region Constructors

        /// <summary>
        /// Initializes a new instance of the <see cref="ObjectReceivedEventArgs"/> class.
        /// </summary>
        /// <param name="serializableTransformObject">the <see cref="SerializableTransformObject"/> this class contains</param>
        public ObjectReceivedEventArgs(SerializableTransformObject serializableTransformObject)
        {
            this.SerializableTransformObject = serializableTransformObject;
        }

        #endregion Constructors

        #region Properties

        /// <summary>
        /// Gets or sets serializable object.
        /// </summary>
        public SerializableTransformObject SerializableTransformObject { get; set; }

        #endregion Properties
    }
}