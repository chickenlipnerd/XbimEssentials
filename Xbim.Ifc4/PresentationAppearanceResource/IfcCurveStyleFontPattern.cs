// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.PresentationDefinitionResource;
using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.PresentationAppearanceResource;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcCurveStyleFontPattern
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcCurveStyleFontPattern : IIfcPresentationItem
	{
		IfcLengthMeasure @VisibleSegmentLength { get;  set; }
		IfcPositiveLengthMeasure @InvisibleSegmentLength { get;  set; }
	
	}
}

namespace Xbim.Ifc4.PresentationAppearanceResource
{
	[ExpressType("IfcCurveStyleFontPattern", 637)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcCurveStyleFontPattern : IfcPresentationItem, IInstantiableEntity, IIfcCurveStyleFontPattern, IEquatable<@IfcCurveStyleFontPattern>
	{
		#region IIfcCurveStyleFontPattern explicit implementation
		IfcLengthMeasure IIfcCurveStyleFontPattern.VisibleSegmentLength { 
			get { return @VisibleSegmentLength; } 
 
			set { VisibleSegmentLength = value;}
		}	
		IfcPositiveLengthMeasure IIfcCurveStyleFontPattern.InvisibleSegmentLength { 
			get { return @InvisibleSegmentLength; } 
 
			set { InvisibleSegmentLength = value;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcCurveStyleFontPattern(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcLengthMeasure _visibleSegmentLength;
		private IfcPositiveLengthMeasure _invisibleSegmentLength;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(1, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 1)]
		public IfcLengthMeasure @VisibleSegmentLength 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _visibleSegmentLength;
				((IPersistEntity)this).Activate(false);
				return _visibleSegmentLength;
			} 
			set
			{
				SetValue( v =>  _visibleSegmentLength = v, _visibleSegmentLength, value,  "VisibleSegmentLength", 1);
			} 
		}	
		[EntityAttribute(2, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 2)]
		public IfcPositiveLengthMeasure @InvisibleSegmentLength 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _invisibleSegmentLength;
				((IPersistEntity)this).Activate(false);
				return _invisibleSegmentLength;
			} 
			set
			{
				SetValue( v =>  _invisibleSegmentLength = v, _invisibleSegmentLength, value,  "InvisibleSegmentLength", 2);
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
					_visibleSegmentLength = value.RealVal;
					return;
				case 1: 
					_invisibleSegmentLength = value.RealVal;
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcCurveStyleFontPattern other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcCurveStyleFontPattern
            var root = (@IfcCurveStyleFontPattern)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcCurveStyleFontPattern left, @IfcCurveStyleFontPattern right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcCurveStyleFontPattern left, @IfcCurveStyleFontPattern right)
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