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
namespace Xbim.Ifc2x3.ProfileResource
{
	public partial class @IfcRectangleHollowProfileDef : IIfcRectangleHollowProfileDef
	{
		Ifc4.MeasureResource.IfcPositiveLengthMeasure IIfcRectangleHollowProfileDef.WallThickness 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(WallThickness);
			} 
		}
		Ifc4.MeasureResource.IfcNonNegativeLengthMeasure? IIfcRectangleHollowProfileDef.InnerFilletRadius 
		{ 
			get
			{
				if (!InnerFilletRadius.HasValue) return null;
				return new Ifc4.MeasureResource.IfcNonNegativeLengthMeasure(InnerFilletRadius.Value);
			} 
		}
		Ifc4.MeasureResource.IfcNonNegativeLengthMeasure? IIfcRectangleHollowProfileDef.OuterFilletRadius 
		{ 
			get
			{
				if (!OuterFilletRadius.HasValue) return null;
				return new Ifc4.MeasureResource.IfcNonNegativeLengthMeasure(OuterFilletRadius.Value);
			} 
		}
	}
}