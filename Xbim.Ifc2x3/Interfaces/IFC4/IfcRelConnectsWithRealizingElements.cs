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
namespace Xbim.Ifc2x3.ProductExtension
{
	public partial class @IfcRelConnectsWithRealizingElements : IIfcRelConnectsWithRealizingElements
	{
		IEnumerable<IIfcElement> IIfcRelConnectsWithRealizingElements.RealizingElements 
		{ 
			get
			{
			foreach (var member in RealizingElements)
			{
				yield return member as IIfcElement;
			}
			} 
		}
		Ifc4.MeasureResource.IfcLabel? IIfcRelConnectsWithRealizingElements.ConnectionType 
		{ 
			get
			{
				if (!ConnectionType.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(ConnectionType.Value);
			} 
		}
	}
}