// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc2x3.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc2x3.Interfaces;
using Xbim.Ifc2x3.GeometryResource;
//## Custom using statements
//##

namespace Xbim.Ifc2x3.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcCartesianPoint
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcCartesianPoint : IIfcPoint, IfcTrimmingSelect
	{
		IEnumerable<IfcLengthMeasure> @Coordinates { get; }
	
	}
}

namespace Xbim.Ifc2x3.GeometryResource
{
	[ExpressType("IfcCartesianPoint", 410)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCartesianPoint : IfcPoint, IInstantiableEntity, IIfcCartesianPoint, IEquatable<@IfcCartesianPoint>
	{
		#region IIfcCartesianPoint explicit implementation
		IEnumerable<IfcLengthMeasure> IIfcCartesianPoint.Coordinates { 
			get { return @Coordinates; } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCartesianPoint(IModel model) : base(model) 		{ 
			Model = model; 
			_coordinates = new ItemSet<IfcLengthMeasure>( this, 3,  1);
		}

		#region Explicit attribute fields
		private ItemSet<IfcLengthMeasure> _coordinates;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.List, EntityAttributeType.None, 1, 3, 3)]
		public ItemSet<IfcLengthMeasure> @Coordinates 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _coordinates;
				((IPersistEntity)this).Activate(false);
				return _coordinates;
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 0)]
		public override IfcDimensionCount @Dim 
		{
			get 
			{
				//## Getter for Dim
                return Coordinates.Count;
				//##
			}
		}

		#endregion



		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_coordinates.InternalAdd(value.RealVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCartesianPoint other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcCartesianPoint
            var root = (@IfcCartesianPoint)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcCartesianPoint left, @IfcCartesianPoint right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcCartesianPoint left, @IfcCartesianPoint right)
        {
            return !(left == right);
        }

        public static bool operator ==(@IfcCartesianPoint left, IfcTrimmingSelect right)
		{
			return left == right as @IfcCartesianPoint;
		}

		public static bool operator !=(@IfcCartesianPoint left, IfcTrimmingSelect right)
		{
			return !(left == right);
		}

        #endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}