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
namespace Xbim.Ifc2x3.SharedBldgElements
{
	public partial class @IfcWindow : IIfcWindow
	{
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcWindow.OverallHeight 
		{ 
			get
			{
				if (!OverallHeight.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(OverallHeight.Value);
			} 
		}
		Ifc4.MeasureResource.IfcPositiveLengthMeasure? IIfcWindow.OverallWidth 
		{ 
			get
			{
				if (!OverallWidth.HasValue) return null;
				return new Ifc4.MeasureResource.IfcPositiveLengthMeasure(OverallWidth.Value);
			} 
		}
		Ifc4.SharedBldgElements.IfcWindowTypeEnum? IIfcWindow.PredefinedType 
		{ 
			get
			{
				//## Handle return of PredefinedType for which no match was found
				//TODO: Handle return of PredefinedType for which no match was found
				throw new System.NotImplementedException();
				//##
			} 
		}
		Ifc4.SharedBldgElements.IfcWindowTypePartitioningEnum? IIfcWindow.PartitioningType 
		{ 
			get
			{
				//## Handle return of PartitioningType for which no match was found
				//TODO: Handle return of PartitioningType for which no match was found
				throw new System.NotImplementedException();
				//##
			} 
		}
		Ifc4.MeasureResource.IfcLabel? IIfcWindow.UserDefinedPartitioningType 
		{ 
			get
			{
				//## Handle return of UserDefinedPartitioningType for which no match was found
				//TODO: Handle return of UserDefinedPartitioningType for which no match was found
				throw new System.NotImplementedException();
				//##
			} 
		}
	}
}