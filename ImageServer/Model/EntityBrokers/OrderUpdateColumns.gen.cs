#region License

// Copyright (c) 2013, ClearCanvas Inc.
// All rights reserved.
// http://www.clearcanvas.ca
//
// This file is part of the ClearCanvas RIS/PACS open source project.
//
// The ClearCanvas RIS/PACS open source project is free software: you can
// redistribute it and/or modify it under the terms of the GNU General Public
// License as published by the Free Software Foundation, either version 3 of the
// License, or (at your option) any later version.
//
// The ClearCanvas RIS/PACS open source project is distributed in the hope that it
// will be useful, but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General
// Public License for more details.
//
// You should have received a copy of the GNU General Public License along with
// the ClearCanvas RIS/PACS open source project.  If not, see
// <http://www.gnu.org/licenses/>.

#endregion

// This file is auto-generated by the ClearCanvas.Model.SqlServer.CodeGenerator project.

namespace ClearCanvas.ImageServer.Model.EntityBrokers
{
    using System;
    using System.Xml;
    using ClearCanvas.Dicom;
    using ClearCanvas.ImageServer.Enterprise;

   public partial class OrderUpdateColumns : EntityUpdateColumns
   {
       public OrderUpdateColumns()
       : base("Order")
       {}
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="ServerPartitionGUID")]
        public ServerEntityKey ServerPartitionKey
        {
            set { SubParameters["ServerPartitionKey"] = new EntityUpdateColumn<ServerEntityKey>("ServerPartitionKey", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="OrderStatusEnum")]
        public OrderStatusEnum OrderStatusEnum
        {
            set { SubParameters["OrderStatusEnum"] = new EntityUpdateColumn<OrderStatusEnum>("OrderStatusEnum", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="InsertTime")]
        public DateTime InsertTime
        {
            set { SubParameters["InsertTime"] = new EntityUpdateColumn<DateTime>("InsertTime", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="UpdatedTime")]
        public DateTime UpdatedTime
        {
            set { SubParameters["UpdatedTime"] = new EntityUpdateColumn<DateTime>("UpdatedTime", value); }
        }
       [DicomField(DicomTags.AccessionNumber, DefaultValue = DicomFieldDefault.Null)]
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="AccessionNumber")]
        public String AccessionNumber
        {
            set { SubParameters["AccessionNumber"] = new EntityUpdateColumn<String>("AccessionNumber", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="ScheduledDateTime")]
        public DateTime ScheduledDateTime
        {
            set { SubParameters["ScheduledDateTime"] = new EntityUpdateColumn<DateTime>("ScheduledDateTime", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="RequestedProcedureCodeGUID")]
        public ServerEntityKey RequestedProcedureCodeKey
        {
            set { SubParameters["RequestedProcedureCodeKey"] = new EntityUpdateColumn<ServerEntityKey>("RequestedProcedureCodeKey", value); }
        }
       [DicomField(DicomTags.Priority, DefaultValue = DicomFieldDefault.Null)]
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="Priority")]
        public String Priority
        {
            set { SubParameters["Priority"] = new EntityUpdateColumn<String>("Priority", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="PatientClass")]
        public String PatientClass
        {
            set { SubParameters["PatientClass"] = new EntityUpdateColumn<String>("PatientClass", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="ReasonForStudy")]
        public String ReasonForStudy
        {
            set { SubParameters["ReasonForStudy"] = new EntityUpdateColumn<String>("ReasonForStudy", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="PointOfCare")]
        public String PointOfCare
        {
            set { SubParameters["PointOfCare"] = new EntityUpdateColumn<String>("PointOfCare", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="Room")]
        public String Room
        {
            set { SubParameters["Room"] = new EntityUpdateColumn<String>("Room", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="Bed")]
        public String Bed
        {
            set { SubParameters["Bed"] = new EntityUpdateColumn<String>("Bed", value); }
        }
       [DicomField(DicomTags.StudyInstanceUid, DefaultValue = DicomFieldDefault.Null)]
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="StudyInstanceUid")]
        public String StudyInstanceUid
        {
            set { SubParameters["StudyInstanceUid"] = new EntityUpdateColumn<String>("StudyInstanceUid", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="EnteredByStaffGUID")]
        public ServerEntityKey EnteredByStaffKey
        {
            set { SubParameters["EnteredByStaffKey"] = new EntityUpdateColumn<ServerEntityKey>("EnteredByStaffKey", value); }
        }
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="ReferringStaffGUID")]
        public ServerEntityKey ReferringStaffKey
        {
            set { SubParameters["ReferringStaffKey"] = new EntityUpdateColumn<ServerEntityKey>("ReferringStaffKey", value); }
        }
       [DicomField(DicomTags.PatientsName, DefaultValue = DicomFieldDefault.Null)]
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="PatientsName")]
        public String PatientsName
        {
            set { SubParameters["PatientsName"] = new EntityUpdateColumn<String>("PatientsName", value); }
        }
       [DicomField(DicomTags.PatientId, DefaultValue = DicomFieldDefault.Null)]
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="PatientId")]
        public String PatientId
        {
            set { SubParameters["PatientId"] = new EntityUpdateColumn<String>("PatientId", value); }
        }
       [DicomField(DicomTags.IssuerOfPatientId, DefaultValue = DicomFieldDefault.Null)]
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="IssuerOfPatientId")]
        public String IssuerOfPatientId
        {
            set { SubParameters["IssuerOfPatientId"] = new EntityUpdateColumn<String>("IssuerOfPatientId", value); }
        }
    }
}
