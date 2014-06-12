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

namespace ClearCanvas.ImageServer.Model
{
    using System;
    using System.Xml;
    using ClearCanvas.Dicom;
    using ClearCanvas.Enterprise.Core;
    using ClearCanvas.ImageServer.Enterprise;
    using ClearCanvas.ImageServer.Enterprise.Command;
    using ClearCanvas.ImageServer.Model.EntityBrokers;

    [Serializable]
    public partial class Order: ServerEntity
    {
        #region Constructors
        public Order():base("Order")
        {}
        public Order(
             ServerEntityKey _serverPartitionKey_
            ,OrderStatusEnum _orderStatusEnum_
            ,DateTime _insertTime_
            ,DateTime _updatedTime_
            ,String _accessionNumber_
            ,DateTime _scheduledDateTime_
            ,ServerEntityKey _requestedProcedureCodeKey_
            ,String _priority_
            ,String _patientClass_
            ,String _reasonForStudy_
            ,String _pointOfCare_
            ,String _room_
            ,String _bed_
            ,String _studyInstanceUid_
            ,ServerEntityKey _enteredByStaffKey_
            ,ServerEntityKey _referringStaffKey_
            ,String _patientsName_
            ,String _patientId_
            ,String _issuerOfPatientId_
            ):base("Order")
        {
            ServerPartitionKey = _serverPartitionKey_;
            OrderStatusEnum = _orderStatusEnum_;
            InsertTime = _insertTime_;
            UpdatedTime = _updatedTime_;
            AccessionNumber = _accessionNumber_;
            ScheduledDateTime = _scheduledDateTime_;
            RequestedProcedureCodeKey = _requestedProcedureCodeKey_;
            Priority = _priority_;
            PatientClass = _patientClass_;
            ReasonForStudy = _reasonForStudy_;
            PointOfCare = _pointOfCare_;
            Room = _room_;
            Bed = _bed_;
            StudyInstanceUid = _studyInstanceUid_;
            EnteredByStaffKey = _enteredByStaffKey_;
            ReferringStaffKey = _referringStaffKey_;
            PatientsName = _patientsName_;
            PatientId = _patientId_;
            IssuerOfPatientId = _issuerOfPatientId_;
        }
        #endregion

        #region Public Properties
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="ServerPartitionGUID")]
        public ServerEntityKey ServerPartitionKey
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="OrderStatusEnum")]
        public OrderStatusEnum OrderStatusEnum
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="InsertTime")]
        public DateTime InsertTime
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="UpdatedTime")]
        public DateTime UpdatedTime
        { get; set; }
        [DicomField(DicomTags.AccessionNumber, DefaultValue = DicomFieldDefault.Null)]
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="AccessionNumber")]
        public String AccessionNumber
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="ScheduledDateTime")]
        public DateTime ScheduledDateTime
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="RequestedProcedureCodeGUID")]
        public ServerEntityKey RequestedProcedureCodeKey
        { get; set; }
        [DicomField(DicomTags.Priority, DefaultValue = DicomFieldDefault.Null)]
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="Priority")]
        public String Priority
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="PatientClass")]
        public String PatientClass
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="ReasonForStudy")]
        public String ReasonForStudy
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="PointOfCare")]
        public String PointOfCare
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="Room")]
        public String Room
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="Bed")]
        public String Bed
        { get; set; }
        [DicomField(DicomTags.StudyInstanceUid, DefaultValue = DicomFieldDefault.Null)]
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="StudyInstanceUid")]
        public String StudyInstanceUid
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="EnteredByStaffGUID")]
        public ServerEntityKey EnteredByStaffKey
        { get; set; }
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="ReferringStaffGUID")]
        public ServerEntityKey ReferringStaffKey
        { get; set; }
        [DicomField(DicomTags.PatientsName, DefaultValue = DicomFieldDefault.Null)]
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="PatientsName")]
        public String PatientsName
        { get; set; }
        [DicomField(DicomTags.PatientId, DefaultValue = DicomFieldDefault.Null)]
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="PatientId")]
        public String PatientId
        { get; set; }
        [DicomField(DicomTags.IssuerOfPatientId, DefaultValue = DicomFieldDefault.Null)]
        [EntityFieldDatabaseMappingAttribute(TableName="Order", ColumnName="IssuerOfPatientId")]
        public String IssuerOfPatientId
        { get; set; }
        #endregion

        #region Static Methods
        static public Order Load(ServerEntityKey key)
        {
            using (var context = new ServerExecutionContext())
            {
                return Load(context.ReadContext, key);
            }
        }
        static public Order Load(IPersistenceContext read, ServerEntityKey key)
        {
            var broker = read.GetBroker<IOrderEntityBroker>();
            Order theObject = broker.Load(key);
            return theObject;
        }
        static public Order Insert(Order entity)
        {
            using (var update = PersistentStoreRegistry.GetDefaultStore().OpenUpdateContext(UpdateContextSyncMode.Flush))
            {
                Order newEntity = Insert(update, entity);
                update.Commit();
                return newEntity;
            }
        }
        static public Order Insert(IUpdateContext update, Order entity)
        {
            var broker = update.GetBroker<IOrderEntityBroker>();
            var updateColumns = new OrderUpdateColumns();
            updateColumns.ServerPartitionKey = entity.ServerPartitionKey;
            updateColumns.OrderStatusEnum = entity.OrderStatusEnum;
            updateColumns.InsertTime = entity.InsertTime;
            updateColumns.UpdatedTime = entity.UpdatedTime;
            updateColumns.AccessionNumber = entity.AccessionNumber;
            updateColumns.ScheduledDateTime = entity.ScheduledDateTime;
            updateColumns.RequestedProcedureCodeKey = entity.RequestedProcedureCodeKey;
            updateColumns.Priority = entity.Priority;
            updateColumns.PatientClass = entity.PatientClass;
            updateColumns.ReasonForStudy = entity.ReasonForStudy;
            updateColumns.PointOfCare = entity.PointOfCare;
            updateColumns.Room = entity.Room;
            updateColumns.Bed = entity.Bed;
            updateColumns.StudyInstanceUid = entity.StudyInstanceUid;
            updateColumns.EnteredByStaffKey = entity.EnteredByStaffKey;
            updateColumns.ReferringStaffKey = entity.ReferringStaffKey;
            updateColumns.PatientsName = entity.PatientsName;
            updateColumns.PatientId = entity.PatientId;
            updateColumns.IssuerOfPatientId = entity.IssuerOfPatientId;
            Order newEntity = broker.Insert(updateColumns);
            return newEntity;
        }
        #endregion
    }
}
