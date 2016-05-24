using System;
using System.Runtime.Serialization;

namespace HiVRClient.Model.Network.Serializable
{
    [Serializable]
    public class SerializableVector3 : ISerializable
    {
        public float x { get; set; }
        public float y { get; set; }
        public float z { get; set; }

        public SerializableVector3()
        {
        }

        // Serialization
        void ISerializable.GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("x", this.x);
            info.AddValue("y", this.y);
            info.AddValue("z", this.z);
        }

        // Deserialization
        public SerializableVector3(SerializationInfo info, StreamingContext context)
        {

            x = (float)info.GetValue("x", typeof(float));
            y = (float)info.GetValue("y", typeof(float));
            z = (float)info.GetValue("z", typeof(float));
        }
    }
}
