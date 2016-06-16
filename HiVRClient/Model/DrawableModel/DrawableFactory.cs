// <copyright file="DrawableFactory.cs" company="HiVR">
// Copyright (c) 2016 HiVR All Rights Reserved
// </copyright>

namespace HiVRClient.Model.DrawableModel
{
    using System.Windows.Media.Media3D;

    /// <summary>
    /// Create drawable classes with corrected vectors.
    /// </summary>
    public class DrawableFactory
    {
        #region Methods

        /// <summary>
        /// Initializes a new instance of the <see cref="Building"/> class.
        /// </summary>
        /// <param name="id">the id of the drawable Building</param>
        /// <param name="position">the position of the Building</param>
        /// <param name="rotation">the rotation of the Building</param>
        /// <param name="scale">the scale coordinate of the Building</param>
        /// <returns>the building instance</returns>
        public Building GetBuilding(int id, Vector3D position, Vector3D rotation, Vector3D scale)
        {
            var correctedPosition = this.AddIndividuals(position, Building.DefaultPosition);
            var correctedRotation = this.AddIndividuals(rotation, Building.DefaultRotation);
            var correctedScale = this.MultiplyIndividuals(scale, Building.DefaultScale);

            return new Building(id, correctedPosition, correctedRotation, correctedScale);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Bench"/> class.
        /// </summary>
        /// <param name="id">the id of the drawable Bench</param>
        /// <param name="position">the position of the Bench</param>
        /// <param name="rotation">the rotation of the Bench</param>
        /// <param name="scale">the scale coordinate of the Bench</param>
        /// <returns>the bench instance</returns>
        public Bench GetBench(int id, Vector3D position, Vector3D rotation, Vector3D scale)
        {
            var correctedPosition = this.AddIndividuals(position, Bench.DefaultPosition);
            var correctedRotation = this.AddIndividuals(rotation, Bench.DefaultRotation);
            var correctedScale = this.MultiplyIndividuals(scale, Bench.DefaultScale);

            return new Bench(id, correctedPosition, correctedRotation, correctedScale);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Car"/> class.
        /// </summary>
        /// <param name="id">the id of the drawable Car</param>
        /// <param name="position">the position of the Car</param>
        /// <param name="rotation">the rotation of the Car</param>
        /// <param name="scale">the scale coordinate of the Car</param>
        /// <returns>the car instance</returns>
        public Car GetCar(int id, Vector3D position, Vector3D rotation, Vector3D scale)
        {
            var correctedPosition = this.AddIndividuals(position, Car.DefaultPosition);
            var correctedRotation = this.AddIndividuals(rotation, Car.DefaultRotation);
            var correctedScale = this.MultiplyIndividuals(scale, Car.DefaultScale);

            return new Car(id, correctedPosition, correctedRotation, correctedScale);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Garden"/> class.
        /// </summary>
        /// <param name="id">the id of the drawable Garden</param>
        /// <param name="position">the position of the Garden</param>
        /// <param name="rotation">the rotation of the Garden</param>
        /// <param name="scale">the scale coordinate of the Garden</param>
        /// <returns>the garden instance</returns>
        public Garden GetGarden(int id, Vector3D position, Vector3D rotation, Vector3D scale)
        {
            var correctedPosition = this.AddIndividuals(position, Garden.DefaultPosition);
            var correctedRotation = this.AddIndividuals(rotation, Garden.DefaultRotation);
            var correctedScale = this.MultiplyIndividuals(scale, Garden.DefaultScale);

            return new Garden(id, correctedPosition, correctedRotation, correctedScale);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Television"/> class.
        /// </summary>
        /// <param name="id">the id of the drawable Television</param>
        /// <param name="position">the position of the Television</param>
        /// <param name="rotation">the rotation of the Television</param>
        /// <param name="scale">the scale coordinate of the Television</param>
        /// <returns>the television instance</returns>
        public Television GetTelevision(int id, Vector3D position, Vector3D rotation, Vector3D scale)
        {
            var correctedPosition = this.AddIndividuals(position, Television.DefaultPosition);
            var correctedRotation = this.AddIndividuals(rotation, Television.DefaultRotation);
            var correctedScale = this.MultiplyIndividuals(scale, Television.DefaultScale);

            return new Television(id, correctedPosition, correctedRotation, correctedScale);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Character"/> class.
        /// </summary>
        /// <param name="id">the id of the drawable Character</param>
        /// <param name="position">the position of the Character</param>
        /// <param name="rotation">the rotation of the Character</param>
        /// <param name="scale">the scale coordinate of the Character</param>
        /// <returns>the character instance</returns>
        public Character GetCharacter(int id, Vector3D position, Vector3D rotation, Vector3D scale)
        {
            var correctedPosition = this.AddIndividuals(position, Character.DefaultPosition);
            var correctedRotation = this.AddIndividuals(rotation, Character.DefaultRotation);
            var correctedScale = this.MultiplyIndividuals(scale, Character.DefaultScale);

            return new Character(id, correctedPosition, correctedRotation, correctedScale);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Patient"/> class.
        /// </summary>
        /// <param name="id">the id of the drawable Patient</param>
        /// <param name="position">the position of the Patient</param>
        /// <param name="rotation">the rotation of the Patient</param>
        /// <param name="scale">the scale coordinate of the Patient</param>
        /// <returns>the patient instance</returns>
        public Patient GetPatient(int id, Vector3D position, Vector3D rotation, Vector3D scale)
        {
            var correctedPosition = this.AddIndividuals(position, Patient.DefaultPosition);
            var correctedRotation = this.AddIndividuals(rotation, Patient.DefaultRotation);
            var correctedScale = this.MultiplyIndividuals(scale, Patient.DefaultScale);

            return new Patient(id, correctedPosition, correctedRotation, correctedScale);
        }

        /// <summary>
        /// Multiplies individual fields of two vectors.
        /// </summary>
        /// <param name="first">the first vector</param>
        /// <param name="second">the second vector</param>
        /// <returns>the multiplied vector</returns>
        private Vector3D MultiplyIndividuals(Vector3D first, Vector3D second)
        {
            return new Vector3D(first.X * second.X, first.Y * second.Y, first.Z * second.Z);
        }

        /// <summary>
        /// Adds individual fields of two vectors.
        /// </summary>
        /// <param name="first">the first vector</param>
        /// <param name="second">the second vector</param>
        /// <returns>the added vector</returns>
        private Vector3D AddIndividuals(Vector3D first, Vector3D second)
        {
            return new Vector3D(first.X + second.X, first.Y + second.Y, first.Z + second.Z);
        }

        #endregion Methods
    }
}