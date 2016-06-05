// <copyright file="ObjectTracker.cs" company="HiVR">
//     HiVR All rights reserved.
// </copyright>
namespace HiVRClient.Model.Map
{
    using SerializedObjects;
    using System.Collections.Concurrent;
    using Utilities;

    /// <summary>
    /// Static class which keeps track of all relevant objects in the Unity world.
    /// </summary>
    public static class ObjectTracker
    {
        #region Fields

        /// <summary>
        /// The ConcurrentDictionary of static objects.
        /// </summary>
        private static ConcurrentDictionary<int, SerializableTransformObject> staticObjects = new ConcurrentDictionary<int, SerializableTransformObject>();

        /// <summary>
        /// The ConcurrentDictionary of dynamic objects.
        /// </summary>
        private static ConcurrentDictionary<int, SerializableTransformObject> dynamicObjects = new ConcurrentDictionary<int, SerializableTransformObject>();

        #endregion Fields

        #region Methods

        /// <summary>
        /// Adds a static object to the tracking HashSet.
        /// </summary>
        /// <param name="staticObject">the object that is added to the HashSet</param>
        public static void AddStaticObject(SerializableTransformObject staticObject)
        {
            staticObjects.AddOrUpdate(staticObject.id, staticObject, (key, existingVal) => { return staticObject; } );
        }

        /// <summary>
        /// Removes a static object from the tracking HashSet.
        /// </summary>
        /// <param name="staticObject">the object that is removed from the HashSet</param>
        public static bool RemoveStaticObject(SerializableTransformObject staticObject)
        {
            SerializableTransformObject removedStaticObject;
            return staticObjects.TryRemove(staticObject.id, out removedStaticObject);
        }

        /// <summary>
        /// Returns a HashSet of all static objects.
        /// </summary>
        /// <returns>returns the HashSet with all the static objects</returns>
        public static ConcurrentDictionary<int, SerializableTransformObject> GetStaticObjects()
        {
            return staticObjects;
        }

        /// <summary>
        /// Adds a dynamic object to the tracking HashSet.
        /// </summary>
        /// <param name="dynamicObject">the dynamic object that is added to the HashSet</param>
        public static void AddDynamicObject(SerializableTransformObject dynamicObject)
        {
            dynamicObjects.AddOrUpdate(dynamicObject.id, dynamicObject, (key, existingVal) => { return dynamicObject; });
        }

        /// <summary>
        /// Removes a dynamic object from the tracking HashSet.
        /// </summary>
        /// <param name="dynamicObject">the dynamic object that is removed from the HashSet</param>
        public static bool RemoveDynamicObject(SerializableTransformObject dynamicObject)
        {
            SerializableTransformObject removedDynamicObject;
            return dynamicObjects.TryRemove(dynamicObject.id, out removedDynamicObject);
        }

        /// <summary>
        /// Returns a HashSet of all dynamic objects.
        /// </summary>
        /// <returns>returns the HashSet with all the dynamic objects</returns>
        public static ConcurrentDictionary<int, SerializableTransformObject> GetDynamicObjects()
        {
            return dynamicObjects;
        }

        #endregion Methods
    }
}