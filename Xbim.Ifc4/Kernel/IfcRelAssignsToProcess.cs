// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.MeasureResource;
using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.Ifc4.Interfaces;
using Xbim.Ifc4.Kernel;
//## Custom using statements
//##

namespace Xbim.Ifc4.Interfaces
{
	/// <summary>
    /// Readonly interface for IfcRelAssignsToProcess
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @IIfcRelAssignsToProcess : IIfcRelAssigns
	{
		IIfcProcessSelect @RelatingProcess { get;  set; }
		IIfcMeasureWithUnit @QuantityInProcess { get;  set; }
	
	}
}

namespace Xbim.Ifc4.Kernel
{
	[ExpressType("IfcRelAssignsToProcess", 249)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @IfcRelAssignsToProcess : IfcRelAssigns, IInstantiableEntity, IIfcRelAssignsToProcess, IContainsEntityReferences, IContainsIndexedReferences, IEquatable<@IfcRelAssignsToProcess>
	{
		#region IIfcRelAssignsToProcess explicit implementation
		IIfcProcessSelect IIfcRelAssignsToProcess.RelatingProcess { 
			get { return @RelatingProcess; } 
 
 
			set { RelatingProcess = value as IfcProcessSelect;}
		}	
		IIfcMeasureWithUnit IIfcRelAssignsToProcess.QuantityInProcess { 
			get { return @QuantityInProcess; } 
 
 
			set { QuantityInProcess = value as IfcMeasureWithUnit;}
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal IfcRelAssignsToProcess(IModel model) : base(model) 		{ 
			Model = model; 
		}

		#region Explicit attribute fields
		private IfcProcessSelect _relatingProcess;
		private IfcMeasureWithUnit _quantityInProcess;
		#endregion
	
		#region Explicit attribute properties
		[IndexedProperty]
		[EntityAttribute(7, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 7)]
		public IfcProcessSelect @RelatingProcess 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _relatingProcess;
				((IPersistEntity)this).Activate(false);
				return _relatingProcess;
			} 
			set
			{
				SetValue( v =>  _relatingProcess = v, _relatingProcess, value,  "RelatingProcess", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 8)]
		public IfcMeasureWithUnit @QuantityInProcess 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _quantityInProcess;
				((IPersistEntity)this).Activate(false);
				return _quantityInProcess;
			} 
			set
			{
				SetValue( v =>  _quantityInProcess = v, _quantityInProcess, value,  "QuantityInProcess", 8);
			} 
		}	
		#endregion





		#region IPersist implementation
		public  override void Parse(int propIndex, IPropertyValue value, int[] nestedIndex)
		{
			switch (propIndex)
			{
				case 0: 
				case 1: 
				case 2: 
				case 3: 
				case 4: 
				case 5: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 6: 
					_relatingProcess = (IfcProcessSelect)(value.EntityVal);
					return;
				case 7: 
					_quantityInProcess = (IfcMeasureWithUnit)(value.EntityVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@IfcRelAssignsToProcess other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @IfcRelAssignsToProcess
            var root = (@IfcRelAssignsToProcess)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@IfcRelAssignsToProcess left, @IfcRelAssignsToProcess right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@IfcRelAssignsToProcess left, @IfcRelAssignsToProcess right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@OwnerHistory != null)
					yield return @OwnerHistory;
				foreach(var entity in @RelatedObjects)
					yield return entity;
				if (@RelatingProcess != null)
					yield return @RelatingProcess;
				if (@QuantityInProcess != null)
					yield return @QuantityInProcess;
			}
		}
		#endregion


		#region IContainsIndexedReferences
        IEnumerable<IPersistEntity> IContainsIndexedReferences.IndexedReferences 
		{ 
			get
			{
				foreach(var entity in @RelatedObjects)
					yield return entity;
				if (@RelatingProcess != null)
					yield return @RelatingProcess;
				
			} 
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}