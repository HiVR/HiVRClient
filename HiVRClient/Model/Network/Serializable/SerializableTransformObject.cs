using System;
using System.Runtime.Serialization;

namespace HiVRClient.Model.Network.Serializable
{
    [Serializable]
    public class SerializableTransformObject : ISerializable
    {
        public int id { get; set; }
        public int type { get; set; }
        public bool isStatic { get; set; }

        public SerializableVector3 position { get; set; }
        public SerializableVector3 scale { get; set; }
        public SerializableVector4 rotation { get; set; }

        public SerializableTransformObject()
        {
        }

        // Serialization
        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            if (info == null)
                throw new System.ArgumentNullException("info");

            info.AddValue("id", id);
            info.AddValue("type", type);
            info.AddValue("isStatic", isStatic);
            info.AddValue("position", position);
            info.AddValue("scale", scale);
            info.AddValue("rotation", rotation);
        }

        // Deserialization
        public SerializableTransformObject(SerializationInfo info, StreamingContext context)
        {
            id = (int)info.GetValue("id", typeof(int));
            type = (int)info.GetValue("type", typeof(int));
            isStatic = (bool)info.GetValue("isStatic", typeof(bool));
            position = (SerializableVector3)info.GetValue("position", typeof(SerializableVector3));
            scale = (SerializableVector3)info.GetValue("scale", typeof(SerializableVector3));
            rotation = (SerializableVector4)info.GetValue("rotation", typeof(SerializableVector4));
        }
    }
}
