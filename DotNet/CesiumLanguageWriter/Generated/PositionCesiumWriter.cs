// This file was generated automatically by GenerateFromSchema.  Do NOT edit it.
// https://github.com/AnalyticalGraphicsInc/czml-writer

using CesiumLanguageWriter.Advanced;
using System;
using System.Collections.Generic;

namespace CesiumLanguageWriter
{
    /// <summary>
    /// Writes a <c>Position</c> to a <see cref="CesiumOutputStream" />.  A <c>Position</c> is defines a position.  The position can optionally vary over time.
    /// </summary>
    public class PositionCesiumWriter : CesiumInterpolatablePropertyWriter<PositionCesiumWriter>
    {
        /// <summary>
        /// The name of the <c>referenceFrame</c> property.
        /// </summary>
        public const string ReferenceFramePropertyName = "referenceFrame";

        /// <summary>
        /// The name of the <c>cartesian</c> property.
        /// </summary>
        public const string CartesianPropertyName = "cartesian";

        /// <summary>
        /// The name of the <c>cartographicRadians</c> property.
        /// </summary>
        public const string CartographicRadiansPropertyName = "cartographicRadians";

        /// <summary>
        /// The name of the <c>cartographicDegrees</c> property.
        /// </summary>
        public const string CartographicDegreesPropertyName = "cartographicDegrees";

        /// <summary>
        /// The name of the <c>cartesianVelocity</c> property.
        /// </summary>
        public const string CartesianVelocityPropertyName = "cartesianVelocity";

        /// <summary>
        /// The name of the <c>reference</c> property.
        /// </summary>
        public const string ReferencePropertyName = "reference";

        private readonly Lazy<ICesiumInterpolatableValuePropertyWriter<Cartesian>> m_asCartesian;
        private readonly Lazy<ICesiumInterpolatableValuePropertyWriter<Cartographic>> m_asCartographicRadians;
        private readonly Lazy<ICesiumInterpolatableValuePropertyWriter<Cartographic>> m_asCartographicDegrees;
        private readonly Lazy<ICesiumInterpolatableValuePropertyWriter<Motion<Cartesian>>> m_asCartesianVelocity;
        private readonly Lazy<ICesiumValuePropertyWriter<Reference>> m_asReference;

        /// <summary>
        /// Initializes a new instance.
        /// </summary>
        public PositionCesiumWriter(string propertyName)
            : base(propertyName)
        {
            m_asCartesian = new Lazy<ICesiumInterpolatableValuePropertyWriter<Cartesian>>(CreateCartesianAdaptor, false);
            m_asCartographicRadians = new Lazy<ICesiumInterpolatableValuePropertyWriter<Cartographic>>(CreateCartographicRadiansAdaptor, false);
            m_asCartographicDegrees = new Lazy<ICesiumInterpolatableValuePropertyWriter<Cartographic>>(CreateCartographicDegreesAdaptor, false);
            m_asCartesianVelocity = new Lazy<ICesiumInterpolatableValuePropertyWriter<Motion<Cartesian>>>(CreateCartesianVelocityAdaptor, false);
            m_asReference = new Lazy<ICesiumValuePropertyWriter<Reference>>(CreateReferenceAdaptor, false);
        }

        /// <summary>
        /// Initializes a new instance as a copy of an existing instance.
        /// </summary>
        /// <param name="existingInstance">The existing instance to copy.</param>
        protected PositionCesiumWriter(PositionCesiumWriter existingInstance)
            : base(existingInstance)
        {
            m_asCartesian = new Lazy<ICesiumInterpolatableValuePropertyWriter<Cartesian>>(CreateCartesianAdaptor, false);
            m_asCartographicRadians = new Lazy<ICesiumInterpolatableValuePropertyWriter<Cartographic>>(CreateCartographicRadiansAdaptor, false);
            m_asCartographicDegrees = new Lazy<ICesiumInterpolatableValuePropertyWriter<Cartographic>>(CreateCartographicDegreesAdaptor, false);
            m_asCartesianVelocity = new Lazy<ICesiumInterpolatableValuePropertyWriter<Motion<Cartesian>>>(CreateCartesianVelocityAdaptor, false);
            m_asReference = new Lazy<ICesiumValuePropertyWriter<Reference>>(CreateReferenceAdaptor, false);
        }

        /// <inheritdoc />
        public override PositionCesiumWriter Clone()
        {
            return new PositionCesiumWriter(this);
        }

        /// <summary>
        /// Writes the value expressed as a <c>referenceFrame</c>, which is the reference frame in which cartesian positions are specified. Possible values are "FIXED" and "INERTIAL".  If not specified, the default value is FIXED.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteReferenceFrame(string value)
        {
            const string PropertyName = ReferenceFramePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            Output.WriteValue(value);
        }

        /// <summary>
        /// Writes the value expressed as a <c>cartesian</c>, which is the position specified as a three-dimensional Cartesian value, <c>[X, Y, Z]</c>, in meters relative to the <c>referenceFrame</c>.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteCartesian(Cartesian value)
        {
            const string PropertyName = CartesianPropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteCartesian3(Output, value);
        }

        /// <summary>
        /// Writes the value expressed as a <c>cartesian</c>, which is the position specified as a three-dimensional Cartesian value, <c>[X, Y, Z]</c>, in meters relative to the <c>referenceFrame</c>.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteCartesian(IList<JulianDate> dates, IList<Cartesian> values)
        {
            WriteCartesian(dates, values, 0, dates.Count);
        }

        /// <summary>
        /// Writes the value expressed as a <c>cartesian</c>, which is the position specified as a three-dimensional Cartesian value, <c>[X, Y, Z]</c>, in meters relative to the <c>referenceFrame</c>.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteCartesian(IList<JulianDate> dates, IList<Cartesian> values, int startIndex, int length)
        {
            const string PropertyName = CartesianPropertyName;
            OpenIntervalIfNecessary();
            CesiumWritingHelper.WriteCartesian3(Output, PropertyName, dates, values, startIndex, length);
        }

        /// <summary>
        /// Writes the value expressed as a <c>cartographicRadians</c>, which is the position specified in Cartographic WGS84 coordinates, <c>[Longitude, Latitude, Height]</c>, where Longitude and Latitude are in radians and Height is in meters.
        /// </summary>
        /// <param name="value">The interval.</param>
        public void WriteCartographicRadians(Cartographic value)
        {
            const string PropertyName = CartographicRadiansPropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteCartographic(Output, value);
        }

        /// <summary>
        /// Writes the value expressed as a <c>cartographicRadians</c>, which is the position specified in Cartographic WGS84 coordinates, <c>[Longitude, Latitude, Height]</c>, where Longitude and Latitude are in radians and Height is in meters.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteCartographicRadians(IList<JulianDate> dates, IList<Cartographic> values)
        {
            WriteCartographicRadians(dates, values, 0, dates.Count);
        }

        /// <summary>
        /// Writes the value expressed as a <c>cartographicRadians</c>, which is the position specified in Cartographic WGS84 coordinates, <c>[Longitude, Latitude, Height]</c>, where Longitude and Latitude are in radians and Height is in meters.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The position corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteCartographicRadians(IList<JulianDate> dates, IList<Cartographic> values, int startIndex, int length)
        {
            const string PropertyName = CartographicRadiansPropertyName;
            OpenIntervalIfNecessary();
            CesiumWritingHelper.WriteCartographic(Output, PropertyName, dates, values, startIndex, length);
        }

        /// <summary>
        /// Writes the value expressed as a <c>cartographicDegrees</c>, which is the position specified in Cartographic WGS84 coordinates, <c>[Longitude, Latitude, Height]</c>, where Longitude and Latitude are in degrees and Height is in meters.
        /// </summary>
        /// <param name="value">The interval.</param>
        public void WriteCartographicDegrees(Cartographic value)
        {
            const string PropertyName = CartographicDegreesPropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteCartographic(Output, value);
        }

        /// <summary>
        /// Writes the value expressed as a <c>cartographicDegrees</c>, which is the position specified in Cartographic WGS84 coordinates, <c>[Longitude, Latitude, Height]</c>, where Longitude and Latitude are in degrees and Height is in meters.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteCartographicDegrees(IList<JulianDate> dates, IList<Cartographic> values)
        {
            WriteCartographicDegrees(dates, values, 0, dates.Count);
        }

        /// <summary>
        /// Writes the value expressed as a <c>cartographicDegrees</c>, which is the position specified in Cartographic WGS84 coordinates, <c>[Longitude, Latitude, Height]</c>, where Longitude and Latitude are in degrees and Height is in meters.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The position corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteCartographicDegrees(IList<JulianDate> dates, IList<Cartographic> values, int startIndex, int length)
        {
            const string PropertyName = CartographicDegreesPropertyName;
            OpenIntervalIfNecessary();
            CesiumWritingHelper.WriteCartographic(Output, PropertyName, dates, values, startIndex, length);
        }

        /// <summary>
        /// Writes the value expressed as a <c>cartesianVelocity</c>, which is the position and velocity specified as a three-dimensional Cartesian value and its derivative, <c>[X, Y, Z, dX, dY, dZ]</c>, in meters relative to the <c>referenceFrame</c>.
        /// </summary>
        /// <param name="value">The value.</param>
        public void WriteCartesianVelocity(Motion<Cartesian> value)
        {
            const string PropertyName = CartesianVelocityPropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteCartesian3Velocity(Output, value);
        }

        /// <summary>
        /// Writes the value expressed as a <c>cartesianVelocity</c>, which is the position and velocity specified as a three-dimensional Cartesian value and its derivative, <c>[X, Y, Z, dX, dY, dZ]</c>, in meters relative to the <c>referenceFrame</c>.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        public void WriteCartesianVelocity(IList<JulianDate> dates, IList<Motion<Cartesian>> values)
        {
            WriteCartesianVelocity(dates, values, 0, dates.Count);
        }

        /// <summary>
        /// Writes the value expressed as a <c>cartesianVelocity</c>, which is the position and velocity specified as a three-dimensional Cartesian value and its derivative, <c>[X, Y, Z, dX, dY, dZ]</c>, in meters relative to the <c>referenceFrame</c>.
        /// </summary>
        /// <param name="dates">The dates at which the value is specified.</param>
        /// <param name="values">The values corresponding to each date.</param>
        /// <param name="startIndex">The index of the first element to write.</param>
        /// <param name="length">The number of elements to write.</param>
        public void WriteCartesianVelocity(IList<JulianDate> dates, IList<Motion<Cartesian>> values, int startIndex, int length)
        {
            const string PropertyName = CartesianVelocityPropertyName;
            OpenIntervalIfNecessary();
            CesiumWritingHelper.WriteCartesian3Velocity(Output, PropertyName, dates, values, startIndex, length);
        }

        /// <summary>
        /// Writes the value expressed as a <c>reference</c>, which is the position specified as a reference to another property.
        /// </summary>
        /// <param name="value">The reference.</param>
        public void WriteReference(Reference value)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, value);
        }

        /// <summary>
        /// Writes the value expressed as a <c>reference</c>, which is the position specified as a reference to another property.
        /// </summary>
        /// <param name="value">The earliest date of the interval.</param>
        public void WriteReference(string value)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, value);
        }

        /// <summary>
        /// Writes the value expressed as a <c>reference</c>, which is the position specified as a reference to another property.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyName">The property on the referenced object.</param>
        public void WriteReference(string identifier, string propertyName)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, identifier, propertyName);
        }

        /// <summary>
        /// Writes the value expressed as a <c>reference</c>, which is the position specified as a reference to another property.
        /// </summary>
        /// <param name="identifier">The identifier of the object which contains the referenced property.</param>
        /// <param name="propertyNames">The hierarchy of properties to be indexed on the referenced object.</param>
        public void WriteReference(string identifier, string[] propertyNames)
        {
            const string PropertyName = ReferencePropertyName;
            OpenIntervalIfNecessary();
            Output.WritePropertyName(PropertyName);
            CesiumWritingHelper.WriteReference(Output, identifier, propertyNames);
        }

        /// <summary>
        /// Returns a wrapper for this instance that implements <see cref="ICesiumInterpolatableValuePropertyWriter{T}" /> to write a value in <c>Cartesian</c> format.  Because the returned instance is a wrapper for this instance, you may call <see cref="ICesiumElementWriter.Close" /> on either this instance or the wrapper, but you must not call it on both.
        /// </summary>
        /// <returns>The wrapper.</returns>
        public ICesiumInterpolatableValuePropertyWriter<Cartesian> AsCartesian()
        {
            return m_asCartesian.Value;
        }

        private ICesiumInterpolatableValuePropertyWriter<Cartesian> CreateCartesianAdaptor()
        {
            return new CesiumInterpolatableWriterAdaptor<PositionCesiumWriter, Cartesian>(this, (me, value) => me.WriteCartesian(value), (me, dates, values, startIndex, length) => me.WriteCartesian(dates, values, startIndex, length));
        }

        /// <summary>
        /// Returns a wrapper for this instance that implements <see cref="ICesiumInterpolatableValuePropertyWriter{T}" /> to write a value in <c>CartographicRadians</c> format.  Because the returned instance is a wrapper for this instance, you may call <see cref="ICesiumElementWriter.Close" /> on either this instance or the wrapper, but you must not call it on both.
        /// </summary>
        /// <returns>The wrapper.</returns>
        public ICesiumInterpolatableValuePropertyWriter<Cartographic> AsCartographicRadians()
        {
            return m_asCartographicRadians.Value;
        }

        private ICesiumInterpolatableValuePropertyWriter<Cartographic> CreateCartographicRadiansAdaptor()
        {
            return new CesiumInterpolatableWriterAdaptor<PositionCesiumWriter, Cartographic>(this, (me, value) => me.WriteCartographicRadians(value), (me, dates, values, startIndex, length) => me.WriteCartographicRadians(dates, values, startIndex, length));
        }

        /// <summary>
        /// Returns a wrapper for this instance that implements <see cref="ICesiumInterpolatableValuePropertyWriter{T}" /> to write a value in <c>CartographicDegrees</c> format.  Because the returned instance is a wrapper for this instance, you may call <see cref="ICesiumElementWriter.Close" /> on either this instance or the wrapper, but you must not call it on both.
        /// </summary>
        /// <returns>The wrapper.</returns>
        public ICesiumInterpolatableValuePropertyWriter<Cartographic> AsCartographicDegrees()
        {
            return m_asCartographicDegrees.Value;
        }

        private ICesiumInterpolatableValuePropertyWriter<Cartographic> CreateCartographicDegreesAdaptor()
        {
            return new CesiumInterpolatableWriterAdaptor<PositionCesiumWriter, Cartographic>(this, (me, value) => me.WriteCartographicDegrees(value), (me, dates, values, startIndex, length) => me.WriteCartographicDegrees(dates, values, startIndex, length));
        }

        /// <summary>
        /// Returns a wrapper for this instance that implements <see cref="ICesiumInterpolatableValuePropertyWriter{T}" /> to write a value in <c>CartesianVelocity</c> format.  Because the returned instance is a wrapper for this instance, you may call <see cref="ICesiumElementWriter.Close" /> on either this instance or the wrapper, but you must not call it on both.
        /// </summary>
        /// <returns>The wrapper.</returns>
        public ICesiumInterpolatableValuePropertyWriter<Motion<Cartesian>> AsCartesianVelocity()
        {
            return m_asCartesianVelocity.Value;
        }

        private ICesiumInterpolatableValuePropertyWriter<Motion<Cartesian>> CreateCartesianVelocityAdaptor()
        {
            return new CesiumInterpolatableWriterAdaptor<PositionCesiumWriter, Motion<Cartesian>>(this, (me, value) => me.WriteCartesianVelocity(value), (me, dates, values, startIndex, length) => me.WriteCartesianVelocity(dates, values, startIndex, length));
        }

        /// <summary>
        /// Returns a wrapper for this instance that implements <see cref="ICesiumValuePropertyWriter{T}" /> to write a value in <c>Reference</c> format.  Because the returned instance is a wrapper for this instance, you may call <see cref="ICesiumElementWriter.Close" /> on either this instance or the wrapper, but you must not call it on both.
        /// </summary>
        /// <returns>The wrapper.</returns>
        public ICesiumValuePropertyWriter<Reference> AsReference()
        {
            return m_asReference.Value;
        }

        private ICesiumValuePropertyWriter<Reference> CreateReferenceAdaptor()
        {
            return new CesiumWriterAdaptor<PositionCesiumWriter, Reference>(this, (me, value) => me.WriteReference(value));
        }

    }
}
