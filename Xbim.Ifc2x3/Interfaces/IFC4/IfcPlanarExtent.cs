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
namespace Xbim.Ifc2x3.PresentationResource
{
	public partial class @IfcPlanarExtent : IIfcPlanarExtent
	{
		Ifc4.MeasureResource.IfcLengthMeasure IIfcPlanarExtent.SizeInX 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcLengthMeasure(SizeInX);
			} 
		}
		Ifc4.MeasureResource.IfcLengthMeasure IIfcPlanarExtent.SizeInY 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcLengthMeasure(SizeInY);
			} 
		}
	}
}