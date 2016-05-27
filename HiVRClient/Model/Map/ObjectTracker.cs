// <copyright file="ObjectTracker.cs" company="HiVR">
//     HiVR All rights reserved.
// </copyright>
namespace HiVRClient.Model.Map
{
    using SerializedObjects;
    using Utilities;

    /// <summary>
    /// Static class which keeps track of all relevant objects in the Unity world.
    /// </summary>
    public static class ObjectTracker
    {
        #region Fields

        /// <summary>
        /// The HashSet of static objects.
        /// </summary>
        private static ConcurrentHashSet<SerializableTransformObject> staticObjects = new ConcurrentHashSet<SerializableTransformObject>();

        /// <summary>
        /// The HashSet of dynamic objects.
        /// </summary>
        private static ConcurrentHashSet<SerializableTransformObject> dynamicObjects = new ConcurrentHashSet<SerializableTransformObject>();

        #endregion Fields

        #region Methods

        /// <summary>
        /// Adds a static object to the tracking HashSet.
        /// </summary>
        /// <param name="staticObject">the object that is added to the HashSet</param>
        public static void AddStaticObject(SerializableTransformObject staticObject)
        {
            staticObjects.Add(staticObject);
        }

        /// <summary>
        /// Removes a static object from the tracking HashSet.
        /// </summary>
        /// <param name="staticObject">the object that is removed from the HashSet</param>
        public static void RemoveStaticObject(SerializableTransformObject staticObject)
        {
            staticObjects.Remove(staticObject);
        }

        /// <summary>
        /// Returns a HashSet of all static objects.
        /// </summary>
        /// <returns>returns the HashSet with all the static objects</returns>
        public static ConcurrentHashSet<SerializableTransformObject> GetStaticObjects()
        {
            return staticObjects;
        }

        /// <summary>
        /// Adds a dynamic object to the tracking HashSet.
        /// </summary>
        /// <param name="dynamicObject">the dynamic object that is added to the HashSet</param>
        public static void AddDynamicObject(SerializableTransformObject dynamicObject)
        {
            dynamicObjects.Add(dynamicObject);
        }

        /// <summary>
        /// Removes a dynamic object from the tracking HashSet.
        /// </summary>
        /// <param name="dynamicObject">the dynamic object that is removed from the HashSet</param>
        public static void RemoveDynamicObject(SerializableTransformObject dynamicObject)
        {
            dynamicObjects.Remove(dynamicObject);
        }

        /// <summary>
        /// Returns a HashSet of all dynamic objects.
        /// </summary>
        /// <returns>returns the HashSet with all the dynamic objects</returns>
        public static ConcurrentHashSet<SerializableTransformObject> GetDynamicObjects()
        {
            return dynamicObjects;
        }

        #endregion Methods
    }
}