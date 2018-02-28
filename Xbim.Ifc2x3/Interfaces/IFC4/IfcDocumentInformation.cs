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
using Xbim.Common;

// ReSharper disable once CheckNamespace
namespace Xbim.Ifc2x3.ExternalReferenceResource
{
	public partial class @IfcDocumentInformation : IIfcDocumentInformation
	{

		[CrossSchemaAttribute(typeof(IIfcDocumentInformation), 1)]
		Ifc4.MeasureResource.IfcIdentifier IIfcDocumentInformation.Identification 
		{ 
			get
			{
				//## Handle return of Identification for which no match was found
			    return new Ifc4.MeasureResource.IfcIdentifier(DocumentId);
			    //##
			} 
			set
			{
				//## Handle setting of Identification for which no match was found
				DocumentId = new MeasureResource.IfcIdentifier(value);
				//##
				NotifyPropertyChanged("Identification");
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcDocumentInformation), 2)]
		Ifc4.MeasureResource.IfcLabel IIfcDocumentInformation.Name 
		{ 
			get
			{
				return new Ifc4.MeasureResource.IfcLabel(Name);
			} 
			set
			{
				Name = new MeasureResource.IfcLabel(value);
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcDocumentInformation), 3)]
		Ifc4.MeasureResource.IfcText? IIfcDocumentInformation.Description 
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

		[CrossSchemaAttribute(typeof(IIfcDocumentInformation), 4)]
		Ifc4.ExternalReferenceResource.IfcURIReference? IIfcDocumentInformation.Location 
		{ 
			get
			{
				//## Handle return of Location for which no match was found
			    var reference = DocumentReferences.FirstOrDefault(r => r.Location != null);
			    return reference != null
			        ? new Ifc4.ExternalReferenceResource.IfcURIReference(reference.Location)
			        : null;
			    //##
			} 
			set
			{
				//## Handle setting of Location for which no match was found
                var reference = DocumentReferences.FirstOrDefault(r => r.Location != null);
			    if (!value.HasValue)
			    {
			        if (reference != null)
			            reference.Location = null;
			    }
			    else
			    {
                    if (reference == null)
                    {
                        reference = Model.Instances.New<IfcDocumentReference>();
                        DocumentReferences.Add(reference);
                    }
			        reference.Location = value.Value.ToString();
			    }
				//##
				NotifyPropertyChanged("Location");
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcDocumentInformation), 5)]
		Ifc4.MeasureResource.IfcText? IIfcDocumentInformation.Purpose 
		{ 
			get
			{
				if (!Purpose.HasValue) return null;
				return new Ifc4.MeasureResource.IfcText(Purpose.Value);
			} 
			set
			{
				Purpose = value.HasValue ? 
					new MeasureResource.IfcText(value.Value) :  
					 new MeasureResource.IfcText?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcDocumentInformation), 6)]
		Ifc4.MeasureResource.IfcText? IIfcDocumentInformation.IntendedUse 
		{ 
			get
			{
				if (!IntendedUse.HasValue) return null;
				return new Ifc4.MeasureResource.IfcText(IntendedUse.Value);
			} 
			set
			{
				IntendedUse = value.HasValue ? 
					new MeasureResource.IfcText(value.Value) :  
					 new MeasureResource.IfcText?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcDocumentInformation), 7)]
		Ifc4.MeasureResource.IfcText? IIfcDocumentInformation.Scope 
		{ 
			get
			{
				if (!Scope.HasValue) return null;
				return new Ifc4.MeasureResource.IfcText(Scope.Value);
			} 
			set
			{
				Scope = value.HasValue ? 
					new MeasureResource.IfcText(value.Value) :  
					 new MeasureResource.IfcText?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcDocumentInformation), 8)]
		Ifc4.MeasureResource.IfcLabel? IIfcDocumentInformation.Revision 
		{ 
			get
			{
				if (!Revision.HasValue) return null;
				return new Ifc4.MeasureResource.IfcLabel(Revision.Value);
			} 
			set
			{
				Revision = value.HasValue ? 
					new MeasureResource.IfcLabel(value.Value) :  
					 new MeasureResource.IfcLabel?() ;
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcDocumentInformation), 9)]
		IIfcActorSelect IIfcDocumentInformation.DocumentOwner 
		{ 
			get
			{
				if (DocumentOwner == null) return null;
				var ifcorganization = DocumentOwner as ActorResource.IfcOrganization;
				if (ifcorganization != null) 
					return ifcorganization;
				var ifcperson = DocumentOwner as ActorResource.IfcPerson;
				if (ifcperson != null) 
					return ifcperson;
				var ifcpersonandorganization = DocumentOwner as ActorResource.IfcPersonAndOrganization;
				if (ifcpersonandorganization != null) 
					return ifcpersonandorganization;
				return null;
			} 
			set
			{
				if (value == null)
				{
					DocumentOwner = null;
					return;
				}	
				var ifcorganization = value as ActorResource.IfcOrganization;
				if (ifcorganization != null) 
				{
					DocumentOwner = ifcorganization;
					return;
				}
				var ifcperson = value as ActorResource.IfcPerson;
				if (ifcperson != null) 
				{
					DocumentOwner = ifcperson;
					return;
				}
				var ifcpersonandorganization = value as ActorResource.IfcPersonAndOrganization;
				if (ifcpersonandorganization != null) 
				{
					DocumentOwner = ifcpersonandorganization;
					return;
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcDocumentInformation), 10)]
		IItemSet<IIfcActorSelect> IIfcDocumentInformation.Editors 
		{ 
			get
			{
			
				return new Common.Collections.ProxyItemSet<ActorResource.IfcActorSelect, IIfcActorSelect>(Editors);
			} 
		}

		[CrossSchemaAttribute(typeof(IIfcDocumentInformation), 11)]
		Ifc4.DateTimeResource.IfcDateTime? IIfcDocumentInformation.CreationTime 
		{ 
			get
			{
				//## Handle return of CreationTime for which no match was found
			    return CreationTime != null
			        ? new Ifc4.DateTimeResource.IfcDateTime(CreationTime.ToISODateTimeString())
			        : null;
				//##
			} 
			set
			{
				//## Handle setting of CreationTime for which no match was found
                if (!value.HasValue)
                {
                    CreationTime = null;
                    return;
                }
                System.DateTime d = value.Value;
                CreationTime = Model.Instances.New<DateTimeResource.IfcDateAndTime>(dt =>
                {
                    dt.DateComponent = Model.Instances.New<DateTimeResource.IfcCalendarDate>(date =>
                    {
                        date.YearComponent = d.Year;
                        date.MonthComponent = d.Month;
                        date.DayComponent = d.Day;
                    });
                    dt.TimeComponent = Model.Instances.New<DateTimeResource.IfcLocalTime>(t =>
                    {
                        t.HourComponent = d.Hour;
                        t.MinuteComponent = d.Minute;
                        t.SecondComponent = d.Second;
                    });
                });
				//##
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcDocumentInformation), 12)]
		Ifc4.DateTimeResource.IfcDateTime? IIfcDocumentInformation.LastRevisionTime 
		{ 
			get
			{
				//## Handle return of LastRevisionTime for which no match was found
                return LastRevisionTime != null
                    ? new Ifc4.DateTimeResource.IfcDateTime(LastRevisionTime.ToISODateTimeString())
                    : null;
				//##
			} 
			set
			{
				//## Handle setting of LastRevisionTime for which no match was found
                if (!value.HasValue)
                {
                    LastRevisionTime = null;
                    return;
                }
                System.DateTime d = value.Value;
                LastRevisionTime = Model.Instances.New<DateTimeResource.IfcDateAndTime>(dt =>
                {
                    dt.DateComponent = Model.Instances.New<DateTimeResource.IfcCalendarDate>(date =>
                    {
                        date.YearComponent = d.Year;
                        date.MonthComponent = d.Month;
                        date.DayComponent = d.Day;
                    });
                    dt.TimeComponent = Model.Instances.New<DateTimeResource.IfcLocalTime>(t =>
                    {
                        t.HourComponent = d.Hour;
                        t.MinuteComponent = d.Minute;
                        t.SecondComponent = d.Second;
                    });
                });
				//##
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcDocumentInformation), 13)]
		Ifc4.MeasureResource.IfcIdentifier? IIfcDocumentInformation.ElectronicFormat 
		{ 
			get
			{
				//## Handle return of ElectronicFormat for which no match was found
			    if (ElectronicFormat == null) return null;
			    if (ElectronicFormat.MimeContentType.HasValue)
                    return new Ifc4.MeasureResource.IfcIdentifier(ElectronicFormat.MimeContentType.Value);
			    if (!ElectronicFormat.FileExtension.HasValue) return null;

			    string ext = ElectronicFormat.FileExtension.Value;
			    ext = ext.Trim('.').ToLowerInvariant();
			    string mime;
			    return MimeTypeLookUp.Types.TryGetValue(ext, out mime) ? mime : null;
			    //##
			} 
			set
			{
				//## Handle setting of ElectronicFormat for which no match was found
			    if (!value.HasValue)
			    {
			        if (ElectronicFormat == null)
			            return;
			        ElectronicFormat.MimeContentType = null;
			        return;
			    }
			    if (ElectronicFormat == null)
			        ElectronicFormat = Model.Instances.New<IfcDocumentElectronicFormat>();
			    ElectronicFormat.MimeContentType = value.Value.ToString();

			    //##
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcDocumentInformation), 14)]
		Ifc4.DateTimeResource.IfcDate? IIfcDocumentInformation.ValidFrom 
		{ 
			get
			{
				//## Handle return of ValidFrom for which no match was found
                return ValidFrom != null
                    ? new Ifc4.DateTimeResource.IfcDate(ValidFrom.ToISODateTimeString())
                    : null;
				//##
			} 
			set
			{
				//## Handle setting of ValidFrom for which no match was found
                if (!value.HasValue)
                {
                    ValidFrom = null;
                    return;
                }
                System.DateTime date = value.Value;
                ValidFrom = Model.Instances.New<DateTimeResource.IfcCalendarDate>(d =>
                {
                    d.YearComponent = date.Year;
                    d.MonthComponent = date.Month;
                    d.DayComponent = date.Day;
                });
				//##
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcDocumentInformation), 15)]
		Ifc4.DateTimeResource.IfcDate? IIfcDocumentInformation.ValidUntil 
		{ 
			get
			{
				//## Handle return of ValidUntil for which no match was found
                return ValidUntil != null
                    ? new Ifc4.DateTimeResource.IfcDate(ValidUntil.ToISODateTimeString())
                    : null;
				//##
			} 
			set
			{
				//## Handle setting of ValidUntil for which no match was found
                if (!value.HasValue)
                {
                    ValidUntil = null;
                    return;
                }
                System.DateTime date = value.Value;
                ValidUntil = Model.Instances.New<DateTimeResource.IfcCalendarDate>(d =>
                {
                    d.YearComponent = date.Year;
                    d.MonthComponent = date.Month;
                    d.DayComponent = date.Day;
                });
				//##
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcDocumentInformation), 16)]
		Ifc4.Interfaces.IfcDocumentConfidentialityEnum? IIfcDocumentInformation.Confidentiality 
		{ 
			get
			{
				//## Custom code to handle enumeration of Confidentiality
				//##
				switch (Confidentiality)
				{
					case IfcDocumentConfidentialityEnum.PUBLIC:
						return Ifc4.Interfaces.IfcDocumentConfidentialityEnum.PUBLIC;
					case IfcDocumentConfidentialityEnum.RESTRICTED:
						return Ifc4.Interfaces.IfcDocumentConfidentialityEnum.RESTRICTED;
					case IfcDocumentConfidentialityEnum.CONFIDENTIAL:
						return Ifc4.Interfaces.IfcDocumentConfidentialityEnum.CONFIDENTIAL;
					case IfcDocumentConfidentialityEnum.PERSONAL:
						return Ifc4.Interfaces.IfcDocumentConfidentialityEnum.PERSONAL;
					case IfcDocumentConfidentialityEnum.USERDEFINED:
						//## Optional custom handling of Confidentiality == .USERDEFINED. 
						//##
						return Ifc4.Interfaces.IfcDocumentConfidentialityEnum.USERDEFINED;
					case IfcDocumentConfidentialityEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcDocumentConfidentialityEnum.NOTDEFINED;
					case null: 
						return null;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of Confidentiality
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcDocumentConfidentialityEnum.PUBLIC:
						Confidentiality = IfcDocumentConfidentialityEnum.PUBLIC;
						return;
					case Ifc4.Interfaces.IfcDocumentConfidentialityEnum.RESTRICTED:
						Confidentiality = IfcDocumentConfidentialityEnum.RESTRICTED;
						return;
					case Ifc4.Interfaces.IfcDocumentConfidentialityEnum.CONFIDENTIAL:
						Confidentiality = IfcDocumentConfidentialityEnum.CONFIDENTIAL;
						return;
					case Ifc4.Interfaces.IfcDocumentConfidentialityEnum.PERSONAL:
						Confidentiality = IfcDocumentConfidentialityEnum.PERSONAL;
						return;
					case Ifc4.Interfaces.IfcDocumentConfidentialityEnum.USERDEFINED:
						Confidentiality = IfcDocumentConfidentialityEnum.USERDEFINED;
						return;
					case Ifc4.Interfaces.IfcDocumentConfidentialityEnum.NOTDEFINED:
						Confidentiality = IfcDocumentConfidentialityEnum.NOTDEFINED;
						return;
					
					case null:
						Confidentiality = null;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}

		[CrossSchemaAttribute(typeof(IIfcDocumentInformation), 17)]
		Ifc4.Interfaces.IfcDocumentStatusEnum? IIfcDocumentInformation.Status 
		{ 
			get
			{
				//## Custom code to handle enumeration of Status
				//##
				switch (Status)
				{
					case IfcDocumentStatusEnum.DRAFT:
						return Ifc4.Interfaces.IfcDocumentStatusEnum.DRAFT;
					case IfcDocumentStatusEnum.FINALDRAFT:
						return Ifc4.Interfaces.IfcDocumentStatusEnum.FINALDRAFT;
					case IfcDocumentStatusEnum.FINAL:
						return Ifc4.Interfaces.IfcDocumentStatusEnum.FINAL;
					case IfcDocumentStatusEnum.REVISION:
						return Ifc4.Interfaces.IfcDocumentStatusEnum.REVISION;
					case IfcDocumentStatusEnum.NOTDEFINED:
						return Ifc4.Interfaces.IfcDocumentStatusEnum.NOTDEFINED;
					case null: 
						return null;
					
					default:
						throw new System.ArgumentOutOfRangeException();
				}
			} 
			set
			{
				//## Custom code to handle setting of enumeration of Status
				//##
				switch (value)
				{
					case Ifc4.Interfaces.IfcDocumentStatusEnum.DRAFT:
						Status = IfcDocumentStatusEnum.DRAFT;
						return;
					case Ifc4.Interfaces.IfcDocumentStatusEnum.FINALDRAFT:
						Status = IfcDocumentStatusEnum.FINALDRAFT;
						return;
					case Ifc4.Interfaces.IfcDocumentStatusEnum.FINAL:
						Status = IfcDocumentStatusEnum.FINAL;
						return;
					case Ifc4.Interfaces.IfcDocumentStatusEnum.REVISION:
						Status = IfcDocumentStatusEnum.REVISION;
						return;
					case Ifc4.Interfaces.IfcDocumentStatusEnum.NOTDEFINED:
						Status = IfcDocumentStatusEnum.NOTDEFINED;
						return;
					
					case null:
						Status = null;
						return;
					default:
						throw new System.ArgumentOutOfRangeException();
				}
				
			}
		}
		IEnumerable<IIfcRelAssociatesDocument> IIfcDocumentInformation.DocumentInfoForObjects 
		{ 
			get
			{
				return Model.Instances.Where<IIfcRelAssociatesDocument>(e => (e.RelatingDocument as IfcDocumentInformation) == this, "RelatingDocument", this);
			} 
		}
		IEnumerable<IIfcDocumentReference> IIfcDocumentInformation.HasDocumentReferences 
		{ 
			get
			{
				return Model.Instances.Where<IIfcDocumentReference>(e => (e.ReferencedDocument as IfcDocumentInformation) == this, "ReferencedDocument", this);
			} 
		}
		IEnumerable<IIfcDocumentInformationRelationship> IIfcDocumentInformation.IsPointedTo 
		{ 
			get
			{
				return Model.Instances.Where<IIfcDocumentInformationRelationship>(e => e.RelatedDocuments != null &&  e.RelatedDocuments.Contains(this), "RelatedDocuments", this);
			} 
		}
		IEnumerable<IIfcDocumentInformationRelationship> IIfcDocumentInformation.IsPointer 
		{ 
			get
			{
				return Model.Instances.Where<IIfcDocumentInformationRelationship>(e => (e.RelatingDocument as IfcDocumentInformation) == this, "RelatingDocument", this);
			} 
		}
	//## Custom code
	//##
	}
}