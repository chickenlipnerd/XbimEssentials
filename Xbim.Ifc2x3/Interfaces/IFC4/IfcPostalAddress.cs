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
	public partial class @IfcPostalAddress : IIfcPostalAddress
	{
		Ifc4.MeasureResource.IfcLabel? IIfcPostalAddress.InternalLocation 
		{ 
			get
			{
				if (!InternalLocation.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(InternalLocation.Value);
			} 
			set
			{
				InternalLocation = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}
		IEnumerable<Xbim.Ifc4.MeasureResource.IfcLabel> IIfcPostalAddress.AddressLines 
		{ 
			get
			{
				foreach (var member in AddressLines)
				{
					yield return new Ifc4.MeasureResource.IfcLabel((string)member);
				}
			} 
		}
		Ifc4.MeasureResource.IfcLabel? IIfcPostalAddress.PostalBox 
		{ 
			get
			{
				if (!PostalBox.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(PostalBox.Value);
			} 
			set
			{
				PostalBox = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}
		Ifc4.MeasureResource.IfcLabel? IIfcPostalAddress.Town 
		{ 
			get
			{
				if (!Town.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(Town.Value);
			} 
			set
			{
				Town = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}
		Ifc4.MeasureResource.IfcLabel? IIfcPostalAddress.Region 
		{ 
			get
			{
				if (!Region.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(Region.Value);
			} 
			set
			{
				Region = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}
		Ifc4.MeasureResource.IfcLabel? IIfcPostalAddress.PostalCode 
		{ 
			get
			{
				if (!PostalCode.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(PostalCode.Value);
			} 
			set
			{
				PostalCode = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}
		Ifc4.MeasureResource.IfcLabel? IIfcPostalAddress.Country 
		{ 
			get
			{
				if (!Country.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(Country.Value);
			} 
			set
			{
				Country = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}
	//## Custom code
	//##
	}
}