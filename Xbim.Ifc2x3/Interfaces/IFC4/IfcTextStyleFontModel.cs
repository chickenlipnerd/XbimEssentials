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
	public partial class @IfcTextStyleFontModel : IIfcTextStyleFontModel
	{
		IEnumerable<Xbim.Ifc4.PresentationAppearanceResource.IfcTextFontName> IIfcTextStyleFontModel.FontFamily 
		{ 
			get
			{
			foreach (var member in FontFamily)
			{
				yield return new Ifc4.PresentationAppearanceResource.IfcTextFontName((string)member);
			}
			} 
		}
		Ifc4.PresentationAppearanceResource.IfcFontStyle? IIfcTextStyleFontModel.FontStyle 
		{ 
			get
			{
				if (!FontStyle.HasValue) return null;
				return new Ifc4.PresentationAppearanceResource.IfcFontStyle(FontStyle.Value);
			} 
		}
		Ifc4.PresentationAppearanceResource.IfcFontVariant? IIfcTextStyleFontModel.FontVariant 
		{ 
			get
			{
				if (!FontVariant.HasValue) return null;
				return new Ifc4.PresentationAppearanceResource.IfcFontVariant(FontVariant.Value);
			} 
		}
		Ifc4.PresentationAppearanceResource.IfcFontWeight? IIfcTextStyleFontModel.FontWeight 
		{ 
			get
			{
				if (!FontWeight.HasValue) return null;
				return new Ifc4.PresentationAppearanceResource.IfcFontWeight(FontWeight.Value);
			} 
		}
		Ifc4.PresentationAppearanceResource.IfcSizeSelect IIfcTextStyleFontModel.FontSize 
		{ 
			get
			{
				if (FontSize == null) return null;
				if (FontSize is MeasureResource.IfcRatioMeasure) 
					return new Ifc4.MeasureResource.IfcRatioMeasure((double)(MeasureResource.IfcRatioMeasure)FontSize);
				if (FontSize is MeasureResource.IfcLengthMeasure) 
					return new Ifc4.MeasureResource.IfcLengthMeasure((double)(MeasureResource.IfcLengthMeasure)FontSize);
				if (FontSize is MeasureResource.IfcDescriptiveMeasure) 
					return new Ifc4.MeasureResource.IfcDescriptiveMeasure((string)(MeasureResource.IfcDescriptiveMeasure)FontSize);
				if (FontSize is MeasureResource.IfcPositiveLengthMeasure) 
					return new Ifc4.MeasureResource.IfcPositiveLengthMeasure((double)(MeasureResource.IfcPositiveLengthMeasure)FontSize);
				if (FontSize is MeasureResource.IfcNormalisedRatioMeasure) 
					return new Ifc4.MeasureResource.IfcNormalisedRatioMeasure((double)(MeasureResource.IfcNormalisedRatioMeasure)FontSize);
				if (FontSize is MeasureResource.IfcPositiveRatioMeasure) 
					return new Ifc4.MeasureResource.IfcPositiveRatioMeasure((double)(MeasureResource.IfcPositiveRatioMeasure)FontSize);
				return null;
			} 
		}
	}
}