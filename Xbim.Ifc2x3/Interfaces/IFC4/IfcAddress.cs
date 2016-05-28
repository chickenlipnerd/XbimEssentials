// ------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool Xbim.CodeGeneration 
//  
//     Changes to this file may cause incorrect behaviour and will be lost if
//     the code is regenerated.
// </auto-generated>
// ------------------------------------------------------------------------------

using Xbim.Ifc4.Interfaces;
using System.Collections.Generic;
using System.Linq;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.ActorResource
{
	public partial class @IfcAddress : IIfcAddress
	{
		Ifc4.Interfaces.IfcAddressTypeEnum? IIfcAddress.Purpose 
		{ 
			get
			{
				switch (Purpose)
				{
					case IfcAddressTypeEnum.OFFICE:
						return Ifc4.Interfaces.IfcAddressTypeEnum.OFFICE;
					
					case IfcAddressTypeEnum.SITE:
						return Ifc4.Interfaces.IfcAddressTypeEnum.SITE;
					
					case IfcAddressTypeEnum.HOME:
						return Ifc4.Interfaces.IfcAddressTypeEnum.HOME;
					
					case IfcAddressTypeEnum.DISTRIBUTIONPOINT:
						return Ifc4.Interfaces.IfcAddressTypeEnum.DISTRIBUTIONPOINT;
					
					case IfcAddressTypeEnum.USERDEFINED:
						//## Optional custom handling of Purpose == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcAddressTypeEnum.USERDEFINED;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				switch (value)
				{
					case Ifc4.Interfaces.IfcAddressTypeEnum.OFFICE:
						Purpose = IfcAddressTypeEnum.OFFICE;
						return;
					
					case Ifc4.Interfaces.IfcAddressTypeEnum.SITE:
						Purpose = IfcAddressTypeEnum.SITE;
						return;
					
					case Ifc4.Interfaces.IfcAddressTypeEnum.HOME:
						Purpose = IfcAddressTypeEnum.HOME;
						return;
					
					case Ifc4.Interfaces.IfcAddressTypeEnum.DISTRIBUTIONPOINT:
						Purpose = IfcAddressTypeEnum.DISTRIBUTIONPOINT;
						return;
					
					case Ifc4.Interfaces.IfcAddressTypeEnum.USERDEFINED:
						Purpose = IfcAddressTypeEnum.USERDEFINED;
						return;
					
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
		Ifc4.MeasureResource.IfcText? IIfcAddress.Description 
		{ 
			get
			{
				if (!Description.HasValue) return null;
				return new Ifc4.MeasureResource.IfcText(Description.Value);
			} 
			set
			{
				Description = value.HasValue ? 
					new MeasureResource.IfcText(value.Value) :  
					 new MeasureResource.IfcText?() ;
				
			}
		}
		Ifc4.MeasureResource.IfcLabel? IIfcAddress.UserDefinedPurpose 
		{ 
			get
			{
				if (!UserDefinedPurpose.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(UserDefinedPurpose.Value);
			} 
			set
			{
				UserDefinedPurpose = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}
		IEnumerable<IIfcPerson> IIfcAddress.OfPerson 
		{ 
			get
			{
				return Model.Instances.Where<IIfcPerson>(e => e.Addresses != null &&  e.Addresses.Contains(this), "Addresses", this);
			} 
		}
		IEnumerable<IIfcOrganization> IIfcAddress.OfOrganization 
		{ 
			get
			{
				return Model.Instances.Where<IIfcOrganization>(e => e.Addresses != null &&  e.Addresses.Contains(this), "Addresses", this);
			} 
		}
	//## Custom code
	//##
	}
}