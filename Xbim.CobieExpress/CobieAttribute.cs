// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using Xbim.Common;
using Xbim.Common.Exceptions;
using Xbim.CobieExpress.Interfaces;
using Xbim.CobieExpress;
//## Custom using statements
//##

namespace Xbim.CobieExpress.Interfaces
{
	/// <summary>
    /// Readonly interface for CobieAttribute
    /// </summary>
	// ReSharper disable once PartialTypeWithSinglePart
	public partial interface @ICobieAttribute : ICobieReferencedObject
	{
		string @Name { get;  set; }
		string @Description { get;  set; }
		ICobieStageType @Stage { get;  set; }
		IAttributeValue @Value { get;  set; }
		string @Unit { get;  set; }
		IEnumerable<string> @AllowedValues { get; }
		CobieExternalObject @PropertySet  { get ; }
	
	}
}

namespace Xbim.CobieExpress
{
	[ExpressType("Attribute", 31)]
	// ReSharper disable once PartialTypeWithSinglePart
	public  partial class @CobieAttribute : CobieReferencedObject, IInstantiableEntity, ICobieAttribute, IContainsEntityReferences, IEquatable<@CobieAttribute>
	{
		#region ICobieAttribute explicit implementation
		string ICobieAttribute.Name { 
			get { return @Name; } 
 
			set { Name = value;}
		}	
		string ICobieAttribute.Description { 
			get { return @Description; } 
 
			set { Description = value;}
		}	
		ICobieStageType ICobieAttribute.Stage { 
			get { return @Stage; } 
 
 
			set { Stage = value as CobieStageType;}
		}	
		IAttributeValue ICobieAttribute.Value { 
			get { return @Value; } 
 
 
			set { Value = value as AttributeValue;}
		}	
		string ICobieAttribute.Unit { 
			get { return @Unit; } 
 
			set { Unit = value;}
		}	
		IEnumerable<string> ICobieAttribute.AllowedValues { 
			get { return @AllowedValues; } 
		}	
		 
		#endregion

		//internal constructor makes sure that objects are not created outside of the model/ assembly controlled area
		internal CobieAttribute(IModel model) : base(model) 		{ 
			Model = model; 
			_allowedValues = new OptionalItemSet<string>( this, 0,  11);
		}

		#region Explicit attribute fields
		private string _name;
		private string _description;
		private CobieStageType _stage;
		private AttributeValue _value;
		private string _unit;
		private OptionalItemSet<string> _allowedValues;
		#endregion
	
		#region Explicit attribute properties
		[EntityAttribute(6, EntityAttributeState.Mandatory, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 6)]
		public string @Name 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _name;
				((IPersistEntity)this).Activate(false);
				return _name;
			} 
			set
			{
				SetValue( v =>  _name = v, _name, value,  "Name", 6);
			} 
		}	
		[EntityAttribute(7, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 7)]
		public string @Description 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _description;
				((IPersistEntity)this).Activate(false);
				return _description;
			} 
			set
			{
				SetValue( v =>  _description = v, _description, value,  "Description", 7);
			} 
		}	
		[EntityAttribute(8, EntityAttributeState.Optional, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 8)]
		public CobieStageType @Stage 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _stage;
				((IPersistEntity)this).Activate(false);
				return _stage;
			} 
			set
			{
				SetValue( v =>  _stage = v, _stage, value,  "Stage", 8);
			} 
		}	
		[EntityAttribute(9, EntityAttributeState.Mandatory, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 9)]
		public AttributeValue @Value 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _value;
				((IPersistEntity)this).Activate(false);
				return _value;
			} 
			set
			{
				SetValue( v =>  _value = v, _value, value,  "Value", 9);
			} 
		}	
		[EntityAttribute(10, EntityAttributeState.Optional, EntityAttributeType.None, EntityAttributeType.None, -1, -1, 10)]
		public string @Unit 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _unit;
				((IPersistEntity)this).Activate(false);
				return _unit;
			} 
			set
			{
				SetValue( v =>  _unit = v, _unit, value,  "Unit", 10);
			} 
		}	
		[EntityAttribute(11, EntityAttributeState.Optional, EntityAttributeType.List, EntityAttributeType.None, 0, -1, 11)]
		public OptionalItemSet<string> @AllowedValues 
		{ 
			get 
			{
				if(ActivationStatus != ActivationStatus.NotActivated) return _allowedValues;
				((IPersistEntity)this).Activate(false);
				return _allowedValues;
			} 
		}	
		#endregion


		#region Derived attributes
		[EntityAttribute(0, EntityAttributeState.Derived, EntityAttributeType.Class, EntityAttributeType.None, -1, -1, 0)]
		public CobieExternalObject @PropertySet 
		{
			get 
			{
				//## Getter for PropertySet
			    return ExternalObject;
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
				case 1: 
				case 2: 
				case 3: 
				case 4: 
					base.Parse(propIndex, value, nestedIndex); 
					return;
				case 5: 
					_name = value.StringVal;
					return;
				case 6: 
					_description = value.StringVal;
					return;
				case 7: 
					_stage = (CobieStageType)(value.EntityVal);
					return;
				case 8: 
					_value = (AttributeValue)(value.EntityVal);
					return;
				case 9: 
					_unit = value.StringVal;
					return;
				case 10: 
					_allowedValues.InternalAdd(value.StringVal);
					return;
				default:
					throw new XbimParserException(string.Format("Attribute index {0} is out of range for {1}", propIndex + 1, GetType().Name.ToUpper()));
			}
		}
		#endregion

		#region Equality comparers and operators
        public bool Equals(@CobieAttribute other)
	    {
	        return this == other;
	    }

	    public override bool Equals(object obj)
        {
            // Check for null
            if (obj == null) return false;

            // Check for type
            if (GetType() != obj.GetType()) return false;

            // Cast as @CobieAttribute
            var root = (@CobieAttribute)obj;
            return this == root;
        }
        public override int GetHashCode()
        {
            //good enough as most entities will be in collections of  only one model, equals distinguishes for model
            return EntityLabel.GetHashCode(); 
        }

        public static bool operator ==(@CobieAttribute left, @CobieAttribute right)
        {
            // If both are null, or both are same instance, return true.
            if (ReferenceEquals(left, right))
                return true;

            // If one is null, but not both, return false.
            if (ReferenceEquals(left, null) || ReferenceEquals(right, null))
                return false;

            return (left.EntityLabel == right.EntityLabel) && (left.Model == right.Model);

        }

        public static bool operator !=(@CobieAttribute left, @CobieAttribute right)
        {
            return !(left == right);
        }

        #endregion

		#region IContainsEntityReferences
		IEnumerable<IPersistEntity> IContainsEntityReferences.References 
		{
			get 
			{
				if (@Created != null)
					yield return @Created;
				if (@ExternalSystem != null)
					yield return @ExternalSystem;
				if (@ExternalObject != null)
					yield return @ExternalObject;
				if (@Stage != null)
					yield return @Stage;
			}
		}
		#endregion

		#region Custom code (will survive code regeneration)
		//## Custom code
		//##
		#endregion
	}
}