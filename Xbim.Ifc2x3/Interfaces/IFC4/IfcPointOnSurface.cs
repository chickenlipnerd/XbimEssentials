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
namespace Xbim.Ifc2x3.GeometryResource
{
	public partial class @IfcPointOnSurface : IIfcPointOnSurface
	{
		IIfcSurface IIfcPointOnSurface.BasisSurface 
		{ 
			get
			{
				return BasisSurface;
			} 
		}
		Ifc4.MeasureResource.IfcParameterValue IIfcPointOnSurface.PointParameterU 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcParameterValue(PointParameterU);
			} 
		}
		Ifc4.MeasureResource.IfcParameterValue IIfcPointOnSurface.PointParameterV 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcParameterValue(PointParameterV);
			} 
		}
	}
}