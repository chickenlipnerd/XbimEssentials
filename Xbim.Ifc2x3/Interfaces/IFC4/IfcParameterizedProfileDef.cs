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
	public partial class @IfcParameterizedProfileDef : IIfcParameterizedProfileDef
	{
		IIfcAxis2Placement2D IIfcParameterizedProfileDef.Position 
		{ 
			get
			{
				return Position;
			} 
			set
			{
				Position = value as GeometryResource.IfcAxis2Placement2D;
				
			}
		}
	//## Custom code
	//##
	}
}