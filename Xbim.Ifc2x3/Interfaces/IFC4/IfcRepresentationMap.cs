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
	public partial class @IfcRepresentationMap : IIfcRepresentationMap
	{
		Ifc4.GeometryResource.IfcAxis2Placement IIfcRepresentationMap.MappingOrigin 
		{ 
			get
			{
				if (MappingOrigin == null) return null;
				var ifcaxis2placement2d = MappingOrigin as IfcAxis2Placement2D;
				if (ifcaxis2placement2d != null) 
					return ifcaxis2placement2d;
				var ifcaxis2placement3d = MappingOrigin as IfcAxis2Placement3D;
				if (ifcaxis2placement3d != null) 
					return ifcaxis2placement3d;
				return null;
			} 
		}
		IIfcRepresentation IIfcRepresentationMap.MappedRepresentation 
		{ 
			get
			{
				return MappedRepresentation;
			} 
		}
		IEnumerable<IIfcShapeAspect> IIfcRepresentationMap.HasShapeAspects 
		{ 
			get
			{
				return Model.Instances.Where<IIfcShapeAspect>(e => (e.PartOfProductDefinitionShape as IfcRepresentationMap) == this);
			} 
		}
		IEnumerable<IIfcMappedItem> IIfcRepresentationMap.MapUsage 
		{ 
			get
			{
				return Model.Instances.Where<IIfcMappedItem>(e => (e.MappingSource as IfcRepresentationMap) == this);
			} 
		}
	}
}