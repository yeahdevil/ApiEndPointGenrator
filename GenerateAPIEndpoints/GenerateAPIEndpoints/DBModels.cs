using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateAPIEndpoints.DBModels
{
    [Table("emailNotificationEvents")]
    public class tbl_Email_Notification_Events
    {
        [Key]
        public int EventID
        {
            get;
            set;
        }
        [Searchable(1)]
        public string EventName
        {
            get;
            set;
        }
        [Searchable(2)]
        public bool? IsActive
        {
            get;
            set;
        }
    }
    public class tbl_RFPCustomWtUnit
    {
        public int RFPCustomWtUnitID
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public string rfp_CustomWtUnitCode
        {
            get;
            set;
        }
        public string rfp_CustomWtUnitDesc
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
    }
    public class tbl_Docs_DecimalPlaceSettingTemplate
    {
        public int DecimalPlaceSettingID
        {
            get;
            set;
        }
        public string FieldName
        {
            get;
            set;
        }
        public int? DecimalPlace
        {
            get;
            set;
        }
        public string TabName
        {
            get;
            set;
        }
    }
    public class tbl_PRA_Contractor
    {
        public int ContractorID
        {
            get;
            set;
        }
        public string Depot_Code
        {
            get;
            set;
        }
        public string Depot_Description
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsDeleted
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public string StateCode
        {
            get;
            set;
        }
    }
    public class tbl_CertificateTemplate
    {
        public int CertificateTemplateID
        {
            get;
            set;
        }
        public string CertTemp_Code
        {
            get;
            set;
        }
        public string CertTemp_Description
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public string Commodity
        {
            get;
            set;
        }
        public string Commodity_desc
        {
            get;
            set;
        }
    }
    public class tbl_User_EmailNotifications
    {
        public Guid EmailNotificationSettingID
        {
            get;
            set;
        }
        public string NotificationKey
        {
            get;
            set;
        }
        public bool? NotificationValue
        {
            get;
            set;
        }
        public int? UserID
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public string NotificationDisplayLabel
        {
            get;
            set;
        }
        public string EmailAddresses
        {
            get;
            set;
        }
        public int? EmailTemplateID
        {
            get;
            set;
        }
        public int? AppID
        {
            get;
            set;
        }
        public string FieldName
        {
            get;
            set;
        }
        public string FieldValue
        {
            get;
            set;
        }
        public int? MyOrAllRecord
        {
            get;
            set;
        }
        public int? DisplayOrder
        {
            get;
            set;
        }
        public Guid? BatchID
        {
            get;
            set;
        }
    }
    public class tbl_EmailHeaderFooter
    {
        public int EmailHeaderFooterID
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public string Subject
        {
            get;
            set;
        }
        public string Body
        {
            get;
            set;
        }
        public bool? IsHeader
        {
            get;
            set;
        }
        public bool? IsFooter
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
    }
    public class tbl_RFPcut
    {
        public int RFPcutID
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public string cut_code
        {
            get;
            set;
        }
        public string cut_description
        {
            get;
            set;
        }
        public string cut_comodity
        {
            get;
            set;
        }
        public string bone_in_indicator
        {
            get;
            set;
        }
        public string chemical_lean_indicator
        {
            get;
            set;
        }
        public string beefveal_indicator
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public string cut_comodity_desc
        {
            get;
            set;
        }
    }
    public class tbl_Docs_DocManager_InviteUser
    {
        public long InviteID
        {
            get;
            set;
        }
        public string FirstName
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
        public string Comment
        {
            get;
            set;
        }
        public int? InvitedBy
        {
            get;
            set;
        }
        public int? InvitedByCompany
        {
            get;
            set;
        }
        public DateTime? InvitedDate
        {
            get;
            set;
        }
        public bool? IsJoin
        {
            get;
            set;
        }
        public int? JoinId
        {
            get;
            set;
        }
        public DateTime? JoinDate
        {
            get;
            set;
        }
        public bool? IsOtherCompanyUser
        {
            get;
            set;
        }
    }
    public class tbl_PRA_DangerousGoods
    {
        public int GoodsID
        {
            get;
            set;
        }
        public int? PRAHeaderID
        {
            get;
            set;
        }
        public int? PRAContainerLineID
        {
            get;
            set;
        }
        public string Exporter_reference
        {
            get;
            set;
        }
        public int LineNo
        {
            get;
            set;
        }
        public string Flashpoint_Temperature
        {
            get;
            set;
        }
        public string IMDG_Class
        {
            get;
            set;
        }
        public string IMDG_Page
        {
            get;
            set;
        }
        public string IMDG_Version
        {
            get;
            set;
        }
        public string UNDG_Number
        {
            get;
            set;
        }
        public string Packing_Group
        {
            get;
            set;
        }
        public string Technical_Name
        {
            get;
            set;
        }
        public string Contact_Person
        {
            get;
            set;
        }
        public string Phone_Number
        {
            get;
            set;
        }
        public string Net_Weight
        {
            get;
            set;
        }
        public string PRAContainerID
        {
            get;
            set;
        }
        public string ShipmentFolderDetailID
        {
            get;
            set;
        }
    }
    public class tbl_Docs_DocumentOutputType
    {
        public int DocumentOutputTypeID
        {
            get;
            set;
        }
        public string DocumentID
        {
            get;
            set;
        }
        public string DocumentOutputType
        {
            get;
            set;
        }
        public string DocumentOutputTypeDesc
        {
            get;
            set;
        }
        public string DisplayOutputType
        {
            get;
            set;
        }
        public bool? IsDefault
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsDeleted
        {
            get;
            set;
        }
        public int? UserID
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public string ReportType
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public string SelectedDocumentOutputType
        {
            get;
            set;
        }
        public bool? IsWaterMark
        {
            get;
            set;
        }
        public string WaterMarkImagePath
        {
            get;
            set;
        }
    }
    public class tbl_RFPCommunicationOption
    {
        public int RFPCommunicationOptionID
        {
            get;
            set;
        }
        public string SMTPFromAddress
        {
            get;
            set;
        }
        public string SMTPServerAddress
        {
            get;
            set;
        }
        public string SMTPUserName
        {
            get;
            set;
        }
        public string SMTPPassword
        {
            get;
            set;
        }
        public string SMTPRecipientAddressTest
        {
            get;
            set;
        }
        public string SMTPRecipientAddressProduction
        {
            get;
            set;
        }
        public string POP3ServerAddress
        {
            get;
            set;
        }
        public string POP3UserName
        {
            get;
            set;
        }
        public string POP3Password
        {
            get;
            set;
        }
        public bool? POP3AutomaticPolling
        {
            get;
            set;
        }
        public int? POP3PollingInterval
        {
            get;
            set;
        }
        public string HealthCertificateLocation
        {
            get;
            set;
        }
        public string ExportSystemCode
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public bool? IsProductionMode
        {
            get;
            set;
        }
        public int? AppID
        {
            get;
            set;
        }
        public int? UserID
        {
            get;
            set;
        }
        public string MailBCC
        {
            get;
            set;
        }
        public bool? IsAutoCheckReponseRequire
        {
            get;
            set;
        }
        public string ReadResponseBy
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
    }
    public class tbl_UserGroup
    {
        public int UserGroupID
        {
            get;
            set;
        }
        public string UserGroup
        {
            get;
            set;
        }
        public string Usergroup_desc
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? Createdby
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
    }
    public class tbl_EmailProvider
    {
        public int ProviderID
        {
            get;
            set;
        }
        public string UserName
        {
            get;
            set;
        }
        public string Password
        {
            get;
            set;
        }
        public int? PortNumber
        {
            get;
            set;
        }
        public string SmtpServer
        {
            get;
            set;
        }
        public int? MailMethodType
        {
            get;
            set;
        }
        public bool IsActive
        {
            get;
            set;
        }
        public string ProviderType
        {
            get;
            set;
        }
        public string ProviderKey
        {
            get;
            set;
        }
        public string From
        {
            get;
            set;
        }
        public int? RetryCounter
        {
            get;
            set;
        }
        public string CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public string ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsDefault
        {
            get;
            set;
        }
        public int? PriorityOrder
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
    }
    public class __RefactorLog
    {
        public Guid OperationKey
        {
            get;
            set;
        }
    }
    public class tbl_RFPDominantProducts
    {
        public int RFPDominantProductID
        {
            get;
            set;
        }
        public string rfp_DomProdCode
        {
            get;
            set;
        }
        public string rfp_DomProdDesc
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
    }
    public class tbl_Docs_HSCode
    {
        public int HSCodeID
        {
            get;
            set;
        }
        public string HSCode
        {
            get;
            set;
        }
        public string HSCodeDesc
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public bool? IsDeleted
        {
            get;
            set;
        }
    }
    public class tbl_PRA_LineOperator
    {
        public int LineOperatorID
        {
            get;
            set;
        }
        public string Operator_Code
        {
            get;
            set;
        }
        public string Operator_Name
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsDeleted
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public string IntraCode
        {
            get;
            set;
        }
        public string LogoFile
        {
            get;
            set;
        }
    }
    public class tbl_User
    {
        public int UserID
        {
            get;
            set;
        }
        public string FirstName
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
        public string Phone
        {
            get;
            set;
        }
        public string Mobile
        {
            get;
            set;
        }
        public string Fax
        {
            get;
            set;
        }
        public string Password
        {
            get;
            set;
        }
        public bool? IsAdmin
        {
            get;
            set;
        }
        public int? RoleID
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public bool? IsDeleted
        {
            get;
            set;
        }
        public string EDIUser
        {
            get;
            set;
        }
        public string APIKey
        {
            get;
            set;
        }
        public DateTime? ValidFrom
        {
            get;
            set;
        }
        public DateTime? Validupto
        {
            get;
            set;
        }
        public int? TimezoneID
        {
            get;
            set;
        }
        public int? UserGroupID
        {
            get;
            set;
        }
        public string CompanyType
        {
            get;
            set;
        }
        public int? CreatedFrom
        {
            get;
            set;
        }
        public string UploadSignature
        {
            get;
            set;
        }
        public int? canSubmit
        {
            get;
            set;
        }
        public bool? UseCompanyDefaultOutput
        {
            get;
            set;
        }
        public string DateFormat
        {
            get;
            set;
        }
        public int? DefaultDocumentMenuID_Old
        {
            get;
            set;
        }
        public int? IsCreatedForAgency
        {
            get;
            set;
        }
        public bool? IsAgencyUser
        {
            get;
            set;
        }
        public string COOSignatoryEmail
        {
            get;
            set;
        }
        public string COOAuthorisedSignatory
        {
            get;
            set;
        }
        public string COOSignatorySign
        {
            get;
            set;
        }
        public string NEXDOCClientToken
        {
            get;
            set;
        }
        public bool? IsAutoPassword
        {
            get;
            set;
        }
        public int? SessionTimeOut
        {
            get;
            set;
        }
        public string DefaultDocumentMenuID
        {
            get;
            set;
        }
        public int? LockTimeOut
        {
            get;
            set;
        }
        public string IMPEXAPIToken
        {
            get;
            set;
        }
        public bool? IsBpanelUser
        {
            get;
            set;
        }
        public string EmailSignature
        {
            get;
            set;
        }
        public bool? IsExternalUser
        {
            get;
            set;
        }
        public string IdentityServerUserID
        {
            get;
            set;
        }
        public bool? IsOtpEnabled
        {
            get;
            set;
        }
        public bool IsImpersonate
        {
            get;
            set;
        }
        public bool? IsCompanyUser
        {
            get;
            set;
        }
    }
    public class tbl_UserInvitationLog
    {
        public Guid UserInvitationId
        {
            get;
            set;
        }
        public string UserEmail
        {
            get;
            set;
        }
        public int CompanyId
        {
            get;
            set;
        }
        public int RoleId
        {
            get;
            set;
        }
        public int CreatedBy
        {
            get;
            set;
        }
        public bool? IsActivate
        {
            get;
            set;
        }
        public DateTime SendTime
        {
            get;
            set;
        }
        public int? UserId
        {
            get;
            set;
        }
        public string PasswordMailRecipients
        {
            get;
            set;
        }
    }
    public class tbl_ModuleName
    {
        public int ModuleID
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public string ModuleName
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
    }
    public class tbl_Company
    {
        public int CompanyID
        {
            get;
            set;
        }
        public string CompanyName
        {
            get;
            set;
        }
        public string AddressLine1
        {
            get;
            set;
        }
        public string AddressLine2
        {
            get;
            set;
        }
        public string City
        {
            get;
            set;
        }
        public string State
        {
            get;
            set;
        }
        public string Country
        {
            get;
            set;
        }
        public string PostCode
        {
            get;
            set;
        }
        public string AQISExporterNo
        {
            get;
            set;
        }
        public string ContactPerson
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
        public string Phone
        {
            get;
            set;
        }
        public string Mobile
        {
            get;
            set;
        }
        public string Fax
        {
            get;
            set;
        }
        public string ABN
        {
            get;
            set;
        }
        public string ACN
        {
            get;
            set;
        }
        public string Website
        {
            get;
            set;
        }
        public string Logo
        {
            get;
            set;
        }
        public string CSSFile
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public string BillingPackage
        {
            get;
            set;
        }
        public short? MaxRFPAllowed
        {
            get;
            set;
        }
        public int? SubscriptionStatusID
        {
            get;
            set;
        }
        public string Email2
        {
            get;
            set;
        }
        public string ReferenceNo
        {
            get;
            set;
        }
        public string Phone2
        {
            get;
            set;
        }
        public string DeclAgentNo
        {
            get;
            set;
        }
        public string SubmitOnBehalf
        {
            get;
            set;
        }
        public string RepName
        {
            get;
            set;
        }
        public string CompanyNo
        {
            get;
            set;
        }
        public string CountryCode
        {
            get;
            set;
        }
        public int? CompanyTypeID
        {
            get;
            set;
        }
        public string SenderCode
        {
            get;
            set;
        }
        public string Email1
        {
            get;
            set;
        }
        public string Phone1
        {
            get;
            set;
        }
        public string InvoiceCurrencyCode
        {
            get;
            set;
        }
        public bool? IsCalcQtyXNetwt
        {
            get;
            set;
        }
        public bool? IsCalcQtyXGrosswt
        {
            get;
            set;
        }
        public bool? IsCalcQtyXVolumewt
        {
            get;
            set;
        }
        public bool? IsCopyFromMasterOnSave
        {
            get;
            set;
        }
        public bool? DefaultEmailOption
        {
            get;
            set;
        }
        public bool? IsCalcQtyXPackedNetwt
        {
            get;
            set;
        }
        public bool? IsCalcQtyXPackedGrosswt
        {
            get;
            set;
        }
        public bool? IsCalcQtyXPackedVolumewt
        {
            get;
            set;
        }
        public bool? IsCalculatePackQty
        {
            get;
            set;
        }
        public bool? IsAgency
        {
            get;
            set;
        }
        public string ErrorEmail
        {
            get;
            set;
        }
        public string FolderPath
        {
            get;
            set;
        }
        public string SchedulerTime
        {
            get;
            set;
        }
        public double? LBSConversionFactor
        {
            get;
            set;
        }
        public bool? IsCalculateInLBS
        {
            get;
            set;
        }
        public bool? IsLBSConvFactorVisible
        {
            get;
            set;
        }
        public int? DefaultDocumentMenuID
        {
            get;
            set;
        }
        public bool? IsAutoPOReceipt
        {
            get;
            set;
        }
        public bool? IsAutoCalQty
        {
            get;
            set;
        }
        public string ImportFileTypes
        {
            get;
            set;
        }
        public bool? AllowManualUpload
        {
            get;
            set;
        }
        public string ImportXSDPath
        {
            get;
            set;
        }
        public string ProductTabViewPath
        {
            get;
            set;
        }
        public bool IsAmountWithCurrencySymbol
        {
            get;
            set;
        }
        public bool? IsMasterOutputRequired
        {
            get;
            set;
        }
        public bool? IsTotalNetWtasQty
        {
            get;
            set;
        }
        public bool? IsAutoUpdatePacingkWt
        {
            get;
            set;
        }
        public bool IsCopyContainerQty
        {
            get;
            set;
        }
        public bool? IsMixedMode
        {
            get;
            set;
        }
        public string IntraPartnerID
        {
            get;
            set;
        }
        public string IntraCustomerAlias
        {
            get;
            set;
        }
        public int? DefaultRFPUserID
        {
            get;
            set;
        }
        public int? DefaultCOOUserID
        {
            get;
            set;
        }
        public int? DefaultPRAUserID
        {
            get;
            set;
        }
        public int? DefaultDocsUserID
        {
            get;
            set;
        }
        public int? DefaultEDNUserID
        {
            get;
            set;
        }
        public bool IsUnitPriceXTotalNetWt
        {
            get;
            set;
        }
        public string AddressLine3
        {
            get;
            set;
        }
        public string AddressLine4
        {
            get;
            set;
        }
        public bool? InttraMode
        {
            get;
            set;
        }
        public bool? IsInsuredValCalcWithSubTotal
        {
            get;
            set;
        }
        public bool IsOrderNoNotCopyToOurRef
        {
            get;
            set;
        }
        public bool IsOrderNoCopyToInvoiceNo
        {
            get;
            set;
        }
        public bool IsPONoCustomerRefSame
        {
            get;
            set;
        }
        public string ServerDetail
        {
            get;
            set;
        }
        public string Directory
        {
            get;
            set;
        }
        public string OSUser
        {
            get;
            set;
        }
        public string OSUserPassword
        {
            get;
            set;
        }
        public string NEXDOCClientGroupToken
        {
            get;
            set;
        }
        public bool IsProformaHideonSO
        {
            get;
            set;
        }
        public string FTPHost
        {
            get;
            set;
        }
        public string FTPUserName
        {
            get;
            set;
        }
        public string FTPPassword
        {
            get;
            set;
        }
        public string Commodity
        {
            get;
            set;
        }
        public string EmailCompany
        {
            get;
            set;
        }
        public string InttraResponsesEmail
        {
            get;
            set;
        }
        public string XeroReferenceID
        {
            get;
            set;
        }
        public string XeroContactResponse
        {
            get;
            set;
        }
        public bool? IsExternalDomain
        {
            get;
            set;
        }
        public string Domain
        {
            get;
            set;
        }
        public string DBConnectionString
        {
            get;
            set;
        }
        public string CompanyKey
        {
            get;
            set;
        }
        public string InttraResponsesEmaileFI
        {
            get;
            set;
        }
        public int? TimezoneID
        {
            get;
            set;
        }
        public bool? IsSyncStatus
        {
            get;
            set;
        }
        public string CommunicationEmail
        {
            get;
            set;
        }
        public string ClientUserToken
        {
            get;
            set;
        }
        public int? DBConnectionID
        {
            get;
            set;
        }
        public bool? IsEnableResetPrintButton
        {
            get;
            set;
        }
        public string ReportLayoutId
        {
            get;
            set;
        }
        public bool? IsMileStoneEnable
        {
            get;
            set;
        }
        public bool? IsvisiblePartnerCategory
        {
            get;
            set;
        }
        public bool? IsvisiblePartnerTypeCategory
        {
            get;
            set;
        }
        public bool? IsEnablePaymentforDeposit
        {
            get;
            set;
        }
        public bool? IsPaymentSectiononSales
        {
            get;
            set;
        }
        public bool? IsPaymentSectiononShipment
        {
            get;
            set;
        }
        public bool? IsDepositSectiononSales
        {
            get;
            set;
        }
        public bool? IsDepositSectiononShipment
        {
            get;
            set;
        }
        public bool? IsOTPEnabled
        {
            get;
            set;
        }
        public bool? IsAPIEnabled
        {
            get;
            set;
        }
        public string IdentityServerClientID
        {
            get;
            set;
        }
    }
    public class tbl_RFPediuser
    {
        public string ediuser_no
        {
            get;
            set;
        }
        public string ediuser_desc
        {
            get;
            set;
        }
        public int RFPediuserID
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public string daffoffice_desc
        {
            get;
            set;
        }
        public string daffoffice
        {
            get;
            set;
        }
        public string ClientToken
        {
            get;
            set;
        }
    }
    public class tbl_Docs_IMOClass
    {
        public int IMOClassID
        {
            get;
            set;
        }
        public string IMOClassCode
        {
            get;
            set;
        }
        public string IMOClass
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public bool? IsDeleted
        {
            get;
            set;
        }
    }
    public class tbl_PRA_Lloyds
    {
        public int LloydsID
        {
            get;
            set;
        }
        public string Lloyds_Number
        {
            get;
            set;
        }
        public string Vessel_Name
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsDeleted
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
    }
    public class tbl_CommunicationOptionsUser
    {
        public int CommunicationUserID
        {
            get;
            set;
        }
        public int? UserID
        {
            get;
            set;
        }
        public int? RFPCommunicationOptionID
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? companyid
        {
            get;
            set;
        }
        public int? AppID
        {
            get;
            set;
        }
        public bool? IsTestMode
        {
            get;
            set;
        }
        public bool? UseAgencyCommOption
        {
            get;
            set;
        }
        public bool? IsDefault
        {
            get;
            set;
        }
        public bool? IsMixmode
        {
            get;
            set;
        }
    }
    public class tbl_Xero_Invoice
    {
        public int InvoiceID
        {
            get;
            set;
        }
        public int CompanyID
        {
            get;
            set;
        }
        public string XeroContactID
        {
            get;
            set;
        }
        public string XeroInvoiceID
        {
            get;
            set;
        }
        public string InvoiceNumber
        {
            get;
            set;
        }
        public DateTime? InvoiceDate
        {
            get;
            set;
        }
        public string InvoiceDateString
        {
            get;
            set;
        }
        public DateTime? DueDate
        {
            get;
            set;
        }
        public string DueDateString
        {
            get;
            set;
        }
        public string ReferenceNo
        {
            get;
            set;
        }
        public double? AmountDue
        {
            get;
            set;
        }
        public double? AmountPaid
        {
            get;
            set;
        }
        public double? AmountCredit
        {
            get;
            set;
        }
        public double? CurrentRate
        {
            get;
            set;
        }
        public bool? IsDiscounted
        {
            get;
            set;
        }
        public bool? HasAttachments
        {
            get;
            set;
        }
        public bool? HasErrors
        {
            get;
            set;
        }
        public string BrandingThemeID
        {
            get;
            set;
        }
        public string Status
        {
            get;
            set;
        }
        public string LineAmountTypes
        {
            get;
            set;
        }
        public double? SubTotalAmount
        {
            get;
            set;
        }
        public double? TotalTaxAmount
        {
            get;
            set;
        }
        public double? TotalAmount
        {
            get;
            set;
        }
        public string CurrencyCode
        {
            get;
            set;
        }
        public DateTime? CreatedDate
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedDate
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public string AttachedInvoiceFileName
        {
            get;
            set;
        }
        public string AttachedInvoiceFilePath
        {
            get;
            set;
        }
        public string BatchID
        {
            get;
            set;
        }
        public string XeroJSonString
        {
            get;
            set;
        }
        public string XeroInvoiceNumber
        {
            get;
            set;
        }
        public bool? IsSuccess
        {
            get;
            set;
        }
        public string StatusMessage
        {
            get;
            set;
        }
        public string ShipmentID
        {
            get;
            set;
        }
        public int? IsInvoicesSendToXeroStatus
        {
            get;
            set;
        }
        public string XeroStatus
        {
            get;
            set;
        }
        public string ExceptionXero
        {
            get;
            set;
        }
        public DateTime? BatchRunStartTime
        {
            get;
            set;
        }
        public DateTime? BatchRunEndTime
        {
            get;
            set;
        }
        public string BatchRunLogStatus
        {
            get;
            set;
        }
    }
    public class tbl_EmailTemplates
    {
        public int EmailTemplateID
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? ModuleID
        {
            get;
            set;
        }
        public int? HeaderID
        {
            get;
            set;
        }
        public int? FooterID
        {
            get;
            set;
        }
        public string EmailTitle
        {
            get;
            set;
        }
        public string FromName
        {
            get;
            set;
        }
        public string FromEmail
        {
            get;
            set;
        }
        public string CC
        {
            get;
            set;
        }
        public string BCC
        {
            get;
            set;
        }
        public string DefaultSubject
        {
            get;
            set;
        }
        public string DefaultBody
        {
            get;
            set;
        }
        public string CustomSubject
        {
            get;
            set;
        }
        public string CustomBody
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public int? SectionID
        {
            get;
            set;
        }
        public bool? IsDefault
        {
            get;
            set;
        }
        public bool? IsCompanyWide
        {
            get;
            set;
        }
        public bool IsSystemDefined
        {
            get;
            set;
        }
        public bool IsUserDefined
        {
            get;
            set;
        }
        public string EmailTemplateKey
        {
            get;
            set;
        }
        public string To
        {
            get;
            set;
        }
        public bool? IsDeleted
        {
            get;
            set;
        }
    }
    public class tbl_ahecc_master
    {
        public int ahecc_code_ID
        {
            get;
            set;
        }
        public string ahecc_code
        {
            get;
            set;
        }
        public string ahecc_description
        {
            get;
            set;
        }
        public string UnitOfMeasure
        {
            get;
            set;
        }
        public string Indicator
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public string UOMDescription
        {
            get;
            set;
        }
        public string hs_code
        {
            get;
            set;
        }
        public string hs_code_description
        {
            get;
            set;
        }
    }
    public class tbl_RFPestablishment
    {
        public string estab_no
        {
            get;
            set;
        }
        public string estab_desc
        {
            get;
            set;
        }
        public int RFPestablishmentID
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public string daffoffice_desc
        {
            get;
            set;
        }
        public string daffoffice
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }
    }
    public class tbl_Docs_ImpexSetting
    {
        public int AutoId
        {
            get;
            set;
        }
        public string Setting
        {
            get;
            set;
        }
        public string SettingValue
        {
            get;
            set;
        }
        public string HeaderName
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? OrderNo
        {
            get;
            set;
        }
        public Guid? OrderCategoryID
        {
            get;
            set;
        }
        public string DisplayName
        {
            get;
            set;
        }
        public string FieldType
        {
            get;
            set;
        }
        public bool? Ischecked
        {
            get;
            set;
        }
    }
    public class tbl_Partner
    {
        public long PartnerID
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public string PatnerCode
        {
            get;
            set;
        }
        public string PartnerName
        {
            get;
            set;
        }
        public string Phone
        {
            get;
            set;
        }
        public string Email
        {
            get;
            set;
        }
        public string CountryPostCode
        {
            get;
            set;
        }
        public string Website
        {
            get;
            set;
        }
        public string ABN
        {
            get;
            set;
        }
        public string ACN
        {
            get;
            set;
        }
        public string CompanyFax
        {
            get;
            set;
        }
        public string Street1
        {
            get;
            set;
        }
        public string Street2
        {
            get;
            set;
        }
        public string City
        {
            get;
            set;
        }
        public string State
        {
            get;
            set;
        }
        public string AddressPostCode
        {
            get;
            set;
        }
        public string CountryCode
        {
            get;
            set;
        }
        public string Country
        {
            get;
            set;
        }
        public string FName
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public string PartnerCode
        {
            get;
            set;
        }
        public string Postcode
        {
            get;
            set;
        }
        public string Phone1
        {
            get;
            set;
        }
        public string Phone2
        {
            get;
            set;
        }
        public string Fax
        {
            get;
            set;
        }
        public string Email1
        {
            get;
            set;
        }
        public string Email2
        {
            get;
            set;
        }
        public string ReferenceNo
        {
            get;
            set;
        }
        public string RepName
        {
            get;
            set;
        }
        public string DeclAgentNo
        {
            get;
            set;
        }
        public string SubmitOnBehalf
        {
            get;
            set;
        }
        public string Street3
        {
            get;
            set;
        }
        public string Street4
        {
            get;
            set;
        }
        public string exporter_RefNo
        {
            get;
            set;
        }
        public string LogoPath
        {
            get;
            set;
        }
        public string DAFFExporterNo
        {
            get;
            set;
        }
        public int? PartnerID_old
        {
            get;
            set;
        }
        public string RegisterEstablishmentNo
        {
            get;
            set;
        }
        public string RegisterEstablishmentDesc
        {
            get;
            set;
        }
        public string Brand
        {
            get;
            set;
        }
        public string EDNUserNumber
        {
            get;
            set;
        }
        public string EDIUserDesc
        {
            get;
            set;
        }
        public bool? IsInclInRateManag
        {
            get;
            set;
        }
        public string StampPath
        {
            get;
            set;
        }
        public string TracesApprovalID
        {
            get;
            set;
        }
        public string NexdocsExporterNumber
        {
            get;
            set;
        }
        public string NexdocsExporterNumberDesc
        {
            get;
            set;
        }
        public int? colesID
        {
            get;
            set;
        }
        public int? ColesCustomerMasterID
        {
            get;
            set;
        }
        public string ColesCustomerMasterName
        {
            get;
            set;
        }
        public int? ParentPartnerID
        {
            get;
            set;
        }
        public bool? IsDeleted
        {
            get;
            set;
        }
        public int? DeletedBy
        {
            get;
            set;
        }
        public DateTime? DeletedOn
        {
            get;
            set;
        }
        public bool? IsTaxexempt
        {
            get;
            set;
        }
        public bool? IsCreditLimitCheckAgainstParent
        {
            get;
            set;
        }
    }
    public class tbl_PRA_Marine_Terminals
    {
        public int Marine_TerminalsID
        {
            get;
            set;
        }
        public string Marine_terminal
        {
            get;
            set;
        }
        public string Marine_terminal_name
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsDeleted
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
    }
    public class tbl_Company_Contact
    {
        public long CompanyContactID
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public string FirstName
        {
            get;
            set;
        }
        public string LastName
        {
            get;
            set;
        }
        public string Designation
        {
            get;
            set;
        }
        public string Phone1
        {
            get;
            set;
        }
        public string Phone2
        {
            get;
            set;
        }
        public string Email1
        {
            get;
            set;
        }
        public string Email2
        {
            get;
            set;
        }
        public int? ContactTypeID
        {
            get;
            set;
        }
        public bool? IsSentToZero
        {
            get;
            set;
        }
        public bool? IsIncludeInEmails
        {
            get;
            set;
        }
    }
    public class tbl_Xero_InvoiceItems
    {
        public int InvoiceItemID
        {
            get;
            set;
        }
        public int InvoiceID
        {
            get;
            set;
        }
        public string ItemCode
        {
            get;
            set;
        }
        public string ItemDescription
        {
            get;
            set;
        }
        public string AccountType
        {
            get;
            set;
        }
        public double? UnitPrice
        {
            get;
            set;
        }
        public int? Quantity
        {
            get;
            set;
        }
        public double? DiscountPercent
        {
            get;
            set;
        }
        public double? DiscountAmount
        {
            get;
            set;
        }
        public double? TaxRate
        {
            get;
            set;
        }
        public string TaxRateName
        {
            get;
            set;
        }
        public double? Amount
        {
            get;
            set;
        }
        public string ServiceType
        {
            get;
            set;
        }
        public int? BillingItemCodeID
        {
            get;
            set;
        }
    }
    public class tbl_GeneralConfigurationSetting
    {
        public int GeneralConfigurationSettingID
        {
            get;
            set;
        }
        public string DisplayName
        {
            get;
            set;
        }
        public string ConfigurationKey
        {
            get;
            set;
        }
        public string ConfigurationValue
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? AppID
        {
            get;
            set;
        }
        public int? OrderNumber
        {
            get;
            set;
        }
    }
    public class tbl_ahecc_measure
    {
        public int ahecc_measure_ID
        {
            get;
            set;
        }
        public string ahecc_measure_code
        {
            get;
            set;
        }
        public string ahecc_measure_unit_name
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
    }
    public class tbl_RFPexport_scheme
    {
        public string exp_scheme_code
        {
            get;
            set;
        }
        public string exp_scheme_name
        {
            get;
            set;
        }
        public int RFPexport_schemeId
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
    }
    public class tbl_Docs_MasterDataFlowDefinition
    {
        public int DataFlowDefinitionID
        {
            get;
            set;
        }
        public int? DocumentMasterID
        {
            get;
            set;
        }
        public string SourceFieldName
        {
            get;
            set;
        }
        public string DestinationFieldName
        {
            get;
            set;
        }
        public string Caption
        {
            get;
            set;
        }
        public bool Copy
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public string DocumentID
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public bool? IsLine
        {
            get;
            set;
        }
    }
    public class tbl_PRA_StopCombinedVslSchedule
    {
        public int StopCombinedVslScheduleID
        {
            get;
            set;
        }
        public string UNLocCode
        {
            get;
            set;
        }
        public string TerminalID
        {
            get;
            set;
        }
        public string ETA
        {
            get;
            set;
        }
        public string ETD
        {
            get;
            set;
        }
        public string ShipName
        {
            get;
            set;
        }
        public string ShipOperatorVoyageOut
        {
            get;
            set;
        }
        public string LloydsID
        {
            get;
            set;
        }
        public string CargoCutoffDate
        {
            get;
            set;
        }
        public string ReeferCutoffDate
        {
            get;
            set;
        }
        public string Operators
        {
            get;
            set;
        }
        public string OperatorsDescription
        {
            get;
            set;
        }
        public string ShipOperatorCode
        {
            get;
            set;
        }
        public string ShipOperatorVoyageIn
        {
            get;
            set;
        }
        public string ExportReceivalCommencementDate
        {
            get;
            set;
        }
        public string ImportAvailabilityDate
        {
            get;
            set;
        }
        public string ImportStorageStartDate
        {
            get;
            set;
        }
        public string VesselType
        {
            get;
            set;
        }
        public string ActualArrivalDate
        {
            get;
            set;
        }
        public string ActualDepartDate
        {
            get;
            set;
        }
        public string VesselCode
        {
            get;
            set;
        }
        public string FirstFreeImportDate
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public bool? ToBeDeleted
        {
            get;
            set;
        }
    }
    public class tbl_Docs_InsuranceClaimSurveyors
    {
        public int InsuranceClaimSurveyorsID
        {
            get;
            set;
        }
        public string InsuranceCompany
        {
            get;
            set;
        }
        public string Country
        {
            get;
            set;
        }
        public string City
        {
            get;
            set;
        }
        public string Address
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsDeleted
        {
            get;
            set;
        }
        public string InsuranceType
        {
            get;
            set;
        }
        public string CountryCode
        {
            get;
            set;
        }
        public string DestinationPortCode
        {
            get;
            set;
        }
        public string DestinationPortDesc
        {
            get;
            set;
        }
    }
    public class tbl_CompanyAddons
    {
        public int CompanyAddonID
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public bool? IsRequirSequentialStatus
        {
            get;
            set;
        }
        public bool? IsVesselAutoUpdateRequire
        {
            get;
            set;
        }
        public bool? IsvisiblePartnerTypeCategory
        {
            get;
            set;
        }
        public bool? IsvisiblePartnerCategory
        {
            get;
            set;
        }
        public bool? IsTaxRequired
        {
            get;
            set;
        }
        public bool? IsCompoundTaxRequired
        {
            get;
            set;
        }
        public bool? IsvisibleCustomerTypeCategary
        {
            get;
            set;
        }
        public bool? IsvisibleCustomerCategory
        {
            get;
            set;
        }
        public bool? IsPriceListEnable
        {
            get;
            set;
        }
        public bool? IsPriceIncludesTax
        {
            get;
            set;
        }
        public bool? IsTaxexempt
        {
            get;
            set;
        }
        public bool IsSSOEnabled
        {
            get;
            set;
        }
        public bool? IsWhiteLabel
        {
            get;
            set;
        }
        public string WhiteLabelCompanyLogo
        {
            get;
            set;
        }
    }
    public class tbl_PartnerContact
    {
        public long PartnerContactID
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public long? PartnerID
        {
            get;
            set;
        }
        public string FName
        {
            get;
            set;
        }
        public string LName
        {
            get;
            set;
        }
        public string Designation
        {
            get;
            set;
        }
        public string Phone1
        {
            get;
            set;
        }
        public string Phone2
        {
            get;
            set;
        }
        public string Email1
        {
            get;
            set;
        }
        public string Email2
        {
            get;
            set;
        }
        public int? ContactTypeID
        {
            get;
            set;
        }
        public bool? IsDeleted
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
    }
    public class tbl_ImperialWeightUnit
    {
        public int ImperialUnitID
        {
            get;
            set;
        }
        public string ImperialWeightUnit
        {
            get;
            set;
        }
        public string ImperialWeightDesc
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
    }
    public class tbl_CompanyChemberDetails
    {
        public int CompanyChemberDetailID
        {
            get;
            set;
        }
        public string COC_ListingID
        {
            get;
            set;
        }
        public string ChamberName
        {
            get;
            set;
        }
        public int? DocumentTypeID
        {
            get;
            set;
        }
        public int? TransactionTypeID
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public bool? IsDefault
        {
            get;
            set;
        }
        public int? ChamberOfCommerceID
        {
            get;
            set;
        }
        public string SubmissionMode
        {
            get;
            set;
        }
    }
    public class tbl_API_AuthenticationDetails
    {
        public Guid AuthenticationID
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public string ModuleName
        {
            get;
            set;
        }
        public string Username
        {
            get;
            set;
        }
        public string Password
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
    }
    public class tbl_RFPImperialNetUnit
    {
        public int RFPImperialNetUnitID
        {
            get;
            set;
        }
        public string ImperialNet_unitcode
        {
            get;
            set;
        }
        public string ImperialNet_unitdesc
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
    }
    public class tbl_Docs_MenuButton_ActionRelationships
    {
        public int Id
        {
            get;
            set;
        }
        public int? MenuButtonID
        {
            get;
            set;
        }
        public string Controller
        {
            get;
            set;
        }
        public string ActionName
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
    }
    public class tbl_PRA_Train_Oper_Road_Carrier
    {
        public int Train_Oper_Road_CarrierID
        {
            get;
            set;
        }
        public string TransportType
        {
            get;
            set;
        }
        public string TransportType_Description
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsDeleted
        {
            get;
            set;
        }
    }
    public class tbl_CompanyCheckOption
    {
        public int KeyId
        {
            get;
            set;
        }
        public string KeyName
        {
            get;
            set;
        }
        public string DisplayName
        {
            get;
            set;
        }
        public bool KeyValue
        {
            get;
            set;
        }
        public int? SequenceNo
        {
            get;
            set;
        }
        public bool IsActive
        {
            get;
            set;
        }
        public int ModifiedBy
        {
            get;
            set;
        }
        public int CompanyId
        {
            get;
            set;
        }
        public DateTime ModifiedOn
        {
            get;
            set;
        }
    }
    public class tbl_EDN_Response
    {
        public int ResponseID
        {
            get;
            set;
        }
        public string ICR
        {
            get;
            set;
        }
        public string Date
        {
            get;
            set;
        }
        public string Time
        {
            get;
            set;
        }
        public string MRN
        {
            get;
            set;
        }
        public long? ICR_Inbound
        {
            get;
            set;
        }
        public string Interchange_Action_code
        {
            get;
            set;
        }
        public string Interchange_Syntax_Err_Code
        {
            get;
            set;
        }
        public string Interchange_Segment_Tag
        {
            get;
            set;
        }
        public string Interchange_Data_Element_Position
        {
            get;
            set;
        }
        public string Interchange_Compt_Data_Elet_Pos
        {
            get;
            set;
        }
        public string Num_of_segment_in_Message
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
    }
    public class tbl_ImpersonateLog
    {
        public int ImpersonateLogID
        {
            get;
            set;
        }
        public int LoginUserID
        {
            get;
            set;
        }
        public int LoginCompanyID
        {
            get;
            set;
        }
        public int ImpersonateUserID
        {
            get;
            set;
        }
        public int ImpersonateCompanyID
        {
            get;
            set;
        }
        public DateTime LoginDate
        {
            get;
            set;
        }
    }
    public class tbl_APIWebHooks
    {
        public Guid APIwebhooksId
        {
            get;
            set;
        }
        public string TriggerCondition
        {
            get;
            set;
        }
        public string URL
        {
            get;
            set;
        }
        public string AuthenticateUser
        {
            get;
            set;
        }
        public string AuthenticatePassword
        {
            get;
            set;
        }
        public int? CompanyId
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public string SharedKey
        {
            get;
            set;
        }
        public short? RetryInterval
        {
            get;
            set;
        }
        public bool? IsRetryAllowed
        {
            get;
            set;
        }
        public string SharedKeyAlias
        {
            get;
            set;
        }
    }
    public class tbl_RFPmeasurement
    {
        public int RFPmeasurementID
        {
            get;
            set;
        }
        public string measurement_unit
        {
            get;
            set;
        }
        public string measurement_type
        {
            get;
            set;
        }
        public string measurement_desc
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
    }
    public class tbl_Docs_PackageType
    {
        public int PackageTypeID
        {
            get;
            set;
        }
        public string PackageTypeDesc
        {
            get;
            set;
        }
        public string PackageTypeCode
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public bool? IsDeleted
        {
            get;
            set;
        }
    }
    public class tbl_PRA_UNDGNumber
    {
        public int UNDGNumberID
        {
            get;
            set;
        }
        public string UNDGNumberCode
        {
            get;
            set;
        }
        public string UNDGNumber_Description
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsDeleted
        {
            get;
            set;
        }
        public string UNDGClass
        {
            get;
            set;
        }
        public string UNDGTechnicalName
        {
            get;
            set;
        }
        public string UNDGGroup
        {
            get;
            set;
        }
        public string UNDGAdditionalInfo
        {
            get;
            set;
        }
    }
    public class tbl_Docs_MasterFlowType
    {
        public int MasterFlowID
        {
            get;
            set;
        }
        public string DocumentID
        {
            get;
            set;
        }
        public int? DocumentMasterID
        {
            get;
            set;
        }
        public string FlowType
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? UserID
        {
            get;
            set;
        }
    }
    public class tbl_CompanyImportSetting
    {
        public int CompanyImportSettingId
        {
            get;
            set;
        }
        public int CompanyID
        {
            get;
            set;
        }
        public string ServerDetail
        {
            get;
            set;
        }
        public string Directory
        {
            get;
            set;
        }
        public string OSUser
        {
            get;
            set;
        }
        public string OSUserPassword
        {
            get;
            set;
        }
        public string FTPHost
        {
            get;
            set;
        }
        public string FTPUserName
        {
            get;
            set;
        }
        public string FTPPassword
        {
            get;
            set;
        }
        public string ErrorEmail
        {
            get;
            set;
        }
        public string FolderPath
        {
            get;
            set;
        }
        public string SchedulerTime
        {
            get;
            set;
        }
        public string ImportFileTypes
        {
            get;
            set;
        }
        public bool? AllowManualUpload
        {
            get;
            set;
        }
        public string ImportXSDPath
        {
            get;
            set;
        }
        public string ProductTabViewPath
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public int? ModuleID
        {
            get;
            set;
        }
        public string ModifiedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public string ImportMethod
        {
            get;
            set;
        }
        public string ImportVia
        {
            get;
            set;
        }
    }
    public class tbl_Language
    {
        public int LanguageID
        {
            get;
            set;
        }
        public string Language
        {
            get;
            set;
        }
        public string CultureInfo
        {
            get;
            set;
        }
        public string DisplayName
        {
            get;
            set;
        }
        public string Icon
        {
            get;
            set;
        }
        public int Priority
        {
            get;
            set;
        }
        public bool? IsDefault
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
    }
    public class tbl_ArchiveRecordSetting
    {
        public int SettingID
        {
            get;
            set;
        }
        public string ModuleName
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public string ArchiveType
        {
            get;
            set;
        }
        public string Filter1
        {
            get;
            set;
        }
        public string Filter2
        {
            get;
            set;
        }
        public int? NoOfDays
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
    }
    public class tbl_RFPMetricUnits
    {
        public int RFPMetricUnitsID
        {
            get;
            set;
        }
        public string MetricUnits_unitcode
        {
            get;
            set;
        }
        public string MetricUnits_unitname
        {
            get;
            set;
        }
        public string MetricUnits_unitdesc
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
    }
    public class tbl_Docs_SalesOrderDataFlowDefinition
    {
        public int ID
        {
            get;
            set;
        }
        public string DocumentMasterID
        {
            get;
            set;
        }
        public string SourceFieldName
        {
            get;
            set;
        }
        public string DestinationFieldName
        {
            get;
            set;
        }
        public string Caption
        {
            get;
            set;
        }
        public bool Copy
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public bool? ForCosting
        {
            get;
            set;
        }
    }
    public class tbl_Privilege
    {
        public Guid PrivilegeID
        {
            get;
            set;
        }
        public int? RoleID
        {
            get;
            set;
        }
        public int? MenuButtonID
        {
            get;
            set;
        }
        public Guid? MenuID
        {
            get;
            set;
        }
    }
    public class tbl_CompanyUser
    {
        public int UserRelationshipId
        {
            get;
            set;
        }
        public int UserId
        {
            get;
            set;
        }
        public int RoleId
        {
            get;
            set;
        }
        public int CompanyId
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public bool? IsDelete
        {
            get;
            set;
        }
        public string ImpexAPIToken
        {
            get;
            set;
        }
        public bool? IsDefault
        {
            get;
            set;
        }
        public bool NotificationSetting
        {
            get;
            set;
        }
        public bool? IsUnsubsribedFromErrorEmail
        {
            get;
            set;
        }
        public int? DepartmentId
        {
            get;
            set;
        }
    }
    public class tbl_ListDateRangeSettings
    {
        public int ListId
        {
            get;
            set;
        }
        public string ListName
        {
            get;
            set;
        }
        public int? CompanyId
        {
            get;
            set;
        }
        public string ReferenceColumn
        {
            get;
            set;
        }
        public int? DateRangeReference
        {
            get;
            set;
        }
        public DateTime? CreatedDate
        {
            get;
            set;
        }
        public string CreatedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedDate
        {
            get;
            set;
        }
        public string ModifiedBy
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
    }
    public class tbl_Authentication_Bearer_Tokens
    {
        public Guid BearerTokenID
        {
            get;
            set;
        }
        public string Token
        {
            get;
            set;
        }
        public DateTime? TokenValidiatyStDate
        {
            get;
            set;
        }
        public DateTime? TokenValidiatyEndDate
        {
            get;
            set;
        }
        public Guid? Token_AuthenticationID
        {
            get;
            set;
        }
        public bool? IsExpired
        {
            get;
            set;
        }
        public string RefreshToken
        {
            get;
            set;
        }
        public DateTime? RefreshTokenExpiryDateTime
        {
            get;
            set;
        }
    }
    public class tbl_RFPPack_Type
    {
        public int RFPPack_typeID
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public string pack_type_code
        {
            get;
            set;
        }
        public string pack_type_desc
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
    }
    public class tbl_Docs_UserSettingTemplate
    {
        public int settingId
        {
            get;
            set;
        }
        public string FieldNameDb
        {
            get;
            set;
        }
        public string FieldNameGrd
        {
            get;
            set;
        }
        public int? FieldLength
        {
            get;
            set;
        }
        public int? FieldSequence
        {
            get;
            set;
        }
        public bool? FieldVisible
        {
            get;
            set;
        }
        public string documentName
        {
            get;
            set;
        }
        public string documentTab
        {
            get;
            set;
        }
        public int? rowHeight
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
    }
    public class tbl_RecordActivity
    {
        public int RecordActivityID
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
        public string ModuleName
        {
            get;
            set;
        }
        public string AppName
        {
            get;
            set;
        }
    }
    public class tbl_Docs_NextId
    {
        public int AutoId
        {
            get;
            set;
        }
        public string TableString
        {
            get;
            set;
        }
        public string Id
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public Guid? OrderCategoryID
        {
            get;
            set;
        }
    }
    public class tbl_COO_ChamberAndTransactionType
    {
        public int ChamberAndTransactionTypeID
        {
            get;
            set;
        }
        public string ChamberAndTransactionType
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsDeleted
        {
            get;
            set;
        }
    }
    public class tbl_LoginLog
    {
        public Guid LoginLogID
        {
            get;
            set;
        }
        public DateTime? LoginDate
        {
            get;
            set;
        }
        public DateTime? LogoutDate
        {
            get;
            set;
        }
        public string IPAddress
        {
            get;
            set;
        }
        public int? StaffID
        {
            get;
            set;
        }
        public string SessionID
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public bool? IsForceLogout
        {
            get;
            set;
        }
    }
    public class tbl_AutoLoginLog
    {
        public int ID
        {
            get;
            set;
        }
        public string SessionID
        {
            get;
            set;
        }
        public bool? IsAutoLogin
        {
            get;
            set;
        }
        public DateTime? LoginDate
        {
            get;
            set;
        }
        public string UserEmail
        {
            get;
            set;
        }
        public int? UserID
        {
            get;
            set;
        }
    }
    public class tbl_RFPpackage_type
    {
        public int RFPpackage_typeID
        {
            get;
            set;
        }
        public string package_type_code
        {
            get;
            set;
        }
        public string package_type_desc
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
    }
    public class tbl_DocumentCategory
    {
        public int DocCategoryId
        {
            get;
            set;
        }
        public string DocCategoryName
        {
            get;
            set;
        }
        public string DocCategoryDesc
        {
            get;
            set;
        }
        public long? CompanyId
        {
            get;
            set;
        }
        public string CreatedBy
        {
            get;
            set;
        }
        public DateTime CreatedOn
        {
            get;
            set;
        }
        public string ModifedBy
        {
            get;
            set;
        }
        public DateTime? ModifedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public bool? IsDeleted
        {
            get;
            set;
        }
    }
    public class tbl_RecordActivityLog
    {
        public Guid RecordActivityLogID
        {
            get;
            set;
        }
        public string ActivityDescription
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? RecordActivityID
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
    }
    public class tbl_COO_ChamberOfCommerce
    {
        public int ChamberOfCommerceID
        {
            get;
            set;
        }
        public string COC_ListingID
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsDeleted
        {
            get;
            set;
        }
        public string Country
        {
            get;
            set;
        }
        public string CountryCode
        {
            get;
            set;
        }
        public string DomainName
        {
            get;
            set;
        }
    }
    public class tbl_MasterDbConnections
    {
        public int ConnectionId
        {
            get;
            set;
        }
        public string ConnectionType
        {
            get;
            set;
        }
        public string DbApplicationConnectionString
        {
            get;
            set;
        }
        public string DbReportConnectionString
        {
            get;
            set;
        }
        public string DbDevesaConnectionString
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public string CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreationDate
        {
            get;
            set;
        }
        public DateTime? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedDate
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public string ExternalDomain
        {
            get;
            set;
        }
        public string DbCommonConnectionString
        {
            get;
            set;
        }
    }
    public class tbl_billing_Scheduler
    {
        public Guid BillingBatchID
        {
            get;
            set;
        }
        public string BatchName
        {
            get;
            set;
        }
        public DateTime? BatchStartDate
        {
            get;
            set;
        }
        public DateTime? BatchEndDate
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public DateTime? BatchCreationDate
        {
            get;
            set;
        }
        public int? BatchStatus
        {
            get;
            set;
        }
        public string BatchZipFilePath
        {
            get;
            set;
        }
        public bool? BatchExcludeInActiveCompanies
        {
            get;
            set;
        }
        public bool? BatchExcludeDeletedCancelledRFPs
        {
            get;
            set;
        }
        public bool? BatchExcludeTextRFPs
        {
            get;
            set;
        }
        public bool? IsBillingGeneratedStatus
        {
            get;
            set;
        }
        public bool? IsInvoicesSendToXeroStatus
        {
            get;
            set;
        }
        public string AgencyType
        {
            get;
            set;
        }
        public bool? IsDeleted
        {
            get;
            set;
        }
        public DateTime? BatchRunStartTime
        {
            get;
            set;
        }
        public DateTime? BatchRunEndTime
        {
            get;
            set;
        }
        public string BatchRunLogStatus
        {
            get;
            set;
        }
        public string BatchException
        {
            get;
            set;
        }
    }
    public class tbl_RFPpermit_type
    {
        public string permit_type_code
        {
            get;
            set;
        }
        public string permit_type_desc
        {
            get;
            set;
        }
        public int RFPpermit_typeID
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
    }
    public class tbl_EDN_Airline
    {
        public int EDNAirlineID
        {
            get;
            set;
        }
        public string airline_code
        {
            get;
            set;
        }
        public string airline_name
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? Modifiedby
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
    }
    public class tbl_CRN_Items
    {
        public Guid CRNItemID
        {
            get;
            set;
        }
        public Guid? CRNHeaderID
        {
            get;
            set;
        }
        public int? Line_No
        {
            get;
            set;
        }
        public string CustomsAuthNo
        {
            get;
            set;
        }
        public string ExemptCode
        {
            get;
            set;
        }
        public string ContingencyCustomsAuthNo
        {
            get;
            set;
        }
        public int? NoOfPackages
        {
            get;
            set;
        }
        public string HouseBillNo
        {
            get;
            set;
        }
        public string OwnerID
        {
            get;
            set;
        }
        public string OwnerName
        {
            get;
            set;
        }
        public string GoodsDesc
        {
            get;
            set;
        }
        public string CountryOfDestinationCode
        {
            get;
            set;
        }
        public string CountryOfDestinationDesc
        {
            get;
            set;
        }
        public string ActionCode
        {
            get;
            set;
        }
        public int? NoOfContainers
        {
            get;
            set;
        }
    }
    public class tbl_RFP_AHECCCutProdTypeCombinations
    {
        public int CombinationID
        {
            get;
            set;
        }
        public string AheccCode
        {
            get;
            set;
        }
        public string CutCode
        {
            get;
            set;
        }
        public string ProductTypeCode
        {
            get;
            set;
        }
        public string ProductTypeDesc
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public string ScientificName
        {
            get;
            set;
        }
        public string Commodity
        {
            get;
            set;
        }
        public string CutCodeDesc
        {
            get;
            set;
        }
    }
    public class tbl_Docs_PartnerProductDetails
    {
        public int PartnerProductID
        {
            get;
            set;
        }
        public string PartnerProductCode
        {
            get;
            set;
        }
        public string PartnerProductDesc
        {
            get;
            set;
        }
        public string PartnerAheccCode
        {
            get;
            set;
        }
        public string PartnerAheccDesc
        {
            get;
            set;
        }
        public string PartnerHSCode
        {
            get;
            set;
        }
        public int ProductID
        {
            get;
            set;
        }
        public int PartnerProductMasterID
        {
            get;
            set;
        }
        public int? ColesPartnerProductID
        {
            get;
            set;
        }
        public bool? IsActiveForFacility
        {
            get;
            set;
        }
        public decimal? BookValue
        {
            get;
            set;
        }
        public string PrimalGrouping
        {
            get;
            set;
        }
        public string PrimalGroupingCode
        {
            get;
            set;
        }
        public string TempStateCode
        {
            get;
            set;
        }
        public string TempStateDesc
        {
            get;
            set;
        }
        public string CutType
        {
            get;
            set;
        }
        public string ExportLabel
        {
            get;
            set;
        }
        public string DestCountryCode
        {
            get;
            set;
        }
        public string DestCountryName
        {
            get;
            set;
        }
        public string HamIdentifier
        {
            get;
            set;
        }
        public string PartnerProductBrand
        {
            get;
            set;
        }
        public string FullSet
        {
            get;
            set;
        }
        public decimal? StorageTemp
        {
            get;
            set;
        }
        public int? Cartons
        {
            get;
            set;
        }
        public decimal? Weight
        {
            get;
            set;
        }
        public decimal? Age0To14
        {
            get;
            set;
        }
        public decimal? Age15To30
        {
            get;
            set;
        }
        public decimal? Age31To90
        {
            get;
            set;
        }
        public decimal? Age91Plus
        {
            get;
            set;
        }
        public decimal? ProductionValue
        {
            get;
            set;
        }
        public decimal? ProvisionWeight
        {
            get;
            set;
        }
        public bool? IsExcessStock
        {
            get;
            set;
        }
        public int? ExcessCarton
        {
            get;
            set;
        }
        public decimal? ExcessWt
        {
            get;
            set;
        }
        public string Comments
        {
            get;
            set;
        }
        public DateTime? StartProductionDate
        {
            get;
            set;
        }
        public DateTime? EndProductionDate
        {
            get;
            set;
        }
        public DateTime? SOH_Date
        {
            get;
            set;
        }
        public DateTime? SOH_LoadedDate
        {
            get;
            set;
        }
        public int? ProvisionSalesSourceID
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public int? ProductGroupLevelID
        {
            get;
            set;
        }
        public string PackSize
        {
            get;
            set;
        }
        public string UnitSize
        {
            get;
            set;
        }
        public string ChilledOrFrozen
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public int? CommittedCartons
        {
            get;
            set;
        }
        public decimal? CommittedWeight
        {
            get;
            set;
        }
        public bool? IsDeleted
        {
            get;
            set;
        }
    }
    public class tbl_COO_ChamberOfCommerceDetails
    {
        public int ChamberOfCommerceDetailID
        {
            get;
            set;
        }
        public int? TransactionTypeID
        {
            get;
            set;
        }
        public int? DocumentTypeID
        {
            get;
            set;
        }
        public string TemplateName
        {
            get;
            set;
        }
        public int? ChamberOfCommerceID
        {
            get;
            set;
        }
        public bool IsDevExpress
        {
            get;
            set;
        }
    }
    public class tbl_Menu
    {
        public string MenuName
        {
            get;
            set;
        }
        public string DisplayMenuName
        {
            get;
            set;
        }
        public string MenuType
        {
            get;
            set;
        }
        public int? MenuOrder
        {
            get;
            set;
        }
        public string MenuURL
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public short? AppID
        {
            get;
            set;
        }
        public string ActionName
        {
            get;
            set;
        }
        public string ControllerName
        {
            get;
            set;
        }
        public Guid MenuID
        {
            get;
            set;
        }
        public Guid? ParentMenuID
        {
            get;
            set;
        }
        public int? AppID_Old
        {
            get;
            set;
        }
        public string MenuKey
        {
            get;
            set;
        }
        public string MenuCSS
        {
            get;
            set;
        }
    }
    public class tbl_BillingAPIUser
    {
        public int ApiUserID
        {
            get;
            set;
        }
        public string ApiUserName
        {
            get;
            set;
        }
        public string ApiKey
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
    }
    public class tbl_RFPpreservation_type
    {
        public int RFPpreservation_typeID
        {
            get;
            set;
        }
        public string preservation_type_code
        {
            get;
            set;
        }
        public string preservation_type_desc
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
    }
    public class tbl_EDN_AssayElement
    {
        public int EDNAssayElementID
        {
            get;
            set;
        }
        public string assay_symbol
        {
            get;
            set;
        }
        public string assay_desc
        {
            get;
            set;
        }
        public string assay_con_unit
        {
            get;
            set;
        }
        public string aqis_con_unit_desc
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? Modifiedby
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
    }
    public class tbl_RFP_ProductCodeCombinations
    {
        public int ProductCodeCombinationID
        {
            get;
            set;
        }
        public string CommodityCode
        {
            get;
            set;
        }
        public string PreservationTypeCode
        {
            get;
            set;
        }
        public string PackTypeCode
        {
            get;
            set;
        }
        public string SupplementaryCode
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public string ProductTypeCode
        {
            get;
            set;
        }
        public string ScientificName
        {
            get;
            set;
        }
        public string PreservationTypeDesc
        {
            get;
            set;
        }
        public string PackTypeDesc
        {
            get;
            set;
        }
        public string ProductTypeDesc
        {
            get;
            set;
        }
        public string SupplementaryDesc
        {
            get;
            set;
        }
        public string CommodityDesc
        {
            get;
            set;
        }
    }
    public class tbl_Docs_ProductType
    {
        public int ProductTypeID
        {
            get;
            set;
        }
        public string ProductType
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
    }
    public class tbl_COO_DocumentType
    {
        public int DocumentTypeID
        {
            get;
            set;
        }
        public string DocumentID
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsDeleted
        {
            get;
            set;
        }
    }
    public class tbl_MenuButtons
    {
        public int MenuButtonID
        {
            get;
            set;
        }
        public int? ButtonID
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public Guid? MenuID
        {
            get;
            set;
        }
    }
    public class tbl_BillingItems
    {
        public int BillingItemID
        {
            get;
            set;
        }
        public string BillingItemTitle
        {
            get;
            set;
        }
        public string BillingItemDesc
        {
            get;
            set;
        }
        public int? BillingServiceType
        {
            get;
            set;
        }
        public string BillingAccount
        {
            get;
            set;
        }
        public int? BillingRateBasis
        {
            get;
            set;
        }
        public decimal? UnitPrice
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public bool? IsDeleted
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public int? ApplicationId
        {
            get;
            set;
        }
    }
    public class tbl_RFPprocess_type
    {
        public string process_type_code
        {
            get;
            set;
        }
        public string process_type_desc
        {
            get;
            set;
        }
        public int RFPprocess_typeID
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public int? DisplayOrder
        {
            get;
            set;
        }
    }
    public class tbl_EDN_Containers
    {
        public int EDNContainerID
        {
            get;
            set;
        }
        public string container_code
        {
            get;
            set;
        }
        public string container_type
        {
            get;
            set;
        }
        public string container_desc
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? Modifiedby
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
    }
    public class tbl_RFP_Validations
    {
        public int RFPValidationID
        {
            get;
            set;
        }
        public string ValidationKey
        {
            get;
            set;
        }
        public string ValidationTitle
        {
            get;
            set;
        }
        public string ValidationMessage
        {
            get;
            set;
        }
        public string Commodity
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public string TransportMode
        {
            get;
            set;
        }
        public string MessageTypeKey
        {
            get;
            set;
        }
        public bool? MessageTypeValue
        {
            get;
            set;
        }
    }
    public class tbl_Docs_ReceiptLocation
    {
        public int ReceiptLocationID
        {
            get;
            set;
        }
        public string Code
        {
            get;
            set;
        }
        public string Name
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
    }
    public class tbl_COO_OriginConferringCriterion
    {
        public int OriginConferringCriterionID
        {
            get;
            set;
        }
        public string OriginConferringCriterion
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsDeleted
        {
            get;
            set;
        }
        public int? TransactionTypeID
        {
            get;
            set;
        }
    }
    public class tbl_MessageType
    {
        public int Mess_TypeID
        {
            get;
            set;
        }
        public string Mess_Type
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public int? AppID
        {
            get;
            set;
        }
        public bool? IsNexDocs
        {
            get;
            set;
        }
    }
    public class tbl_BillingLedger
    {
        public int LedgerID
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? NoPurchased
        {
            get;
            set;
        }
        public int? UsedQty
        {
            get;
            set;
        }
        public int? BalanceQty
        {
            get;
            set;
        }
        public DateTime? PurchaseDate
        {
            get;
            set;
        }
        public DateTime? StartDate
        {
            get;
            set;
        }
        public DateTime? EndDate
        {
            get;
            set;
        }
        public string Plan
        {
            get;
            set;
        }
        public string PlanType
        {
            get;
            set;
        }
        public string Product
        {
            get;
            set;
        }
    }
    public class tbl_RFPproduct_type
    {
        public int RFPproduct_typeID
        {
            get;
            set;
        }
        public string product_type_code
        {
            get;
            set;
        }
        public string product_type_desc
        {
            get;
            set;
        }
        public string product_type_comodity
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public string scientific_name
        {
            get;
            set;
        }
        public string product_type_comodity_desc
        {
            get;
            set;
        }
    }
    public class tbl_EDN_ExpDecExemption
    {
        public int EDNExpDecExemptionID
        {
            get;
            set;
        }
        public string exp_dec_exem_code
        {
            get;
            set;
        }
        public string exp_dec_exem_desc
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? Modifiedby
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
    }
    public class tbl_RFPApprovedCertifier
    {
        public int RFPApprovedCertifierID
        {
            get;
            set;
        }
        public string rfp_AppCertCode
        {
            get;
            set;
        }
        public string rfp_AppCertDesc
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public string rfp_AppCertName
        {
            get;
            set;
        }
    }
    public class tbl_COO_TransactionType
    {
        public int TransactionTypeID
        {
            get;
            set;
        }
        public string TransactionID
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsDeleted
        {
            get;
            set;
        }
        public string SubmissionType
        {
            get;
            set;
        }
    }
    public class tbl_newcompany_error_log
    {
        public long ErrorLogID
        {
            get;
            set;
        }
        public string ErrorMessage
        {
            get;
            set;
        }
        public int CompanyID
        {
            get;
            set;
        }
        public DateTime LogDate
        {
            get;
            set;
        }
    }
    public class tbl_BillingReportDetails
    {
        public Guid BillingReportID
        {
            get;
            set;
        }
        public Guid BillingBatchID
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? BatchStatus
        {
            get;
            set;
        }
        public string BatchZipFilePath
        {
            get;
            set;
        }
        public bool? CompanyIsActive
        {
            get;
            set;
        }
        public bool? BatchExcludeDeletedCancelledRFPs
        {
            get;
            set;
        }
        public bool? BatchExcludeTextRFPs
        {
            get;
            set;
        }
        public bool? IsBillingGeneratedStatus
        {
            get;
            set;
        }
        public bool? IsInvoicesSendToXeroStatus
        {
            get;
            set;
        }
        public string AgencyType
        {
            get;
            set;
        }
        public bool? IsDeleted
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public string Excetion
        {
            get;
            set;
        }
        public DateTime? BatchRunStartTime
        {
            get;
            set;
        }
        public DateTime? BatchRunEndTime
        {
            get;
            set;
        }
        public string BatchRunLogStatus
        {
            get;
            set;
        }
    }
    public class tbl_RFPstate
    {
        public string CountryID
        {
            get;
            set;
        }
        public string state_code
        {
            get;
            set;
        }
        public string state_name
        {
            get;
            set;
        }
        public int RFPstateID
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public string EDNCode
        {
            get;
            set;
        }
    }
    public class tbl_EDN_ExportGoodsType
    {
        public int EDNExportGoodTypeID
        {
            get;
            set;
        }
        public string exp_goods_type_code
        {
            get;
            set;
        }
        public string exp_goods_type_desc
        {
            get;
            set;
        }
        public bool exp_goods_type_selfexp
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? Modifiedby
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
    }
    public class tbl_RFPaqis_currency
    {
        public int RFPaqis_currencyID
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public string currency_code
        {
            get;
            set;
        }
        public string currency_name
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
    }
    public class tbl_Docs_ShipmentDocs
    {
        public string ShipmentID
        {
            get;
            set;
        }
        public string DocumentID
        {
            get;
            set;
        }
        public int? StatusID
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public DateTime? StatusChangeDate
        {
            get;
            set;
        }
        public int? StatusChangedBy
        {
            get;
            set;
        }
        public bool? IsDeleted
        {
            get;
            set;
        }
        public string ActualDocumentID
        {
            get;
            set;
        }
        public string doc_title_tree
        {
            get;
            set;
        }
        public string Layout
        {
            get;
            set;
        }
        public int? Sequence
        {
            get;
            set;
        }
        public int? ShipmentDocsID_Old
        {
            get;
            set;
        }
        public int? ShipmentFolderDetailID_Old
        {
            get;
            set;
        }
        public Guid ShipmentDocsID
        {
            get;
            set;
        }
        public Guid? ShipmentFolderDetailID
        {
            get;
            set;
        }
        public bool? IsCopied
        {
            get;
            set;
        }
        public DateTime? Createdon
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? StatusUpdateOn
        {
            get;
            set;
        }
        public bool? IsStatusAutoUpdate
        {
            get;
            set;
        }
        public int? StatusUpdateBy
        {
            get;
            set;
        }
        public int? AppID
        {
            get;
            set;
        }
        public bool? IsMigrate
        {
            get;
            set;
        }
        public int? CounterForUpdate
        {
            get;
            set;
        }
        public string DocStatus
        {
            get;
            set;
        }
        public bool IsUpdatedOnce
        {
            get;
            set;
        }
        public int? DeletedBy
        {
            get;
            set;
        }
        public DateTime? DeletedOn
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public string TreeExpRef
        {
            get;
            set;
        }
        public int? DocCount
        {
            get;
            set;
        }
        public string DevesaStatus
        {
            get;
            set;
        }
        public DateTime? SyncDevesaStatusTime
        {
            get;
            set;
        }
    }
    public class tbl_Country_Currency
    {
        public int country_currencyID
        {
            get;
            set;
        }
        public string country_code
        {
            get;
            set;
        }
        public string country_name
        {
            get;
            set;
        }
        public string country_indicator
        {
            get;
            set;
        }
        public bool? country_req_freez_estab
        {
            get;
            set;
        }
        public string currency_code
        {
            get;
            set;
        }
        public string currency_name
        {
            get;
            set;
        }
        public bool? currency_fob
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public string CurrencySymbol
        {
            get;
            set;
        }
    }
    public class tbl_NexDocsMessageType
    {
        public int Mess_TypeID
        {
            get;
            set;
        }
        public string Mess_Type
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public int? AppID
        {
            get;
            set;
        }
        public string CommodityType
        {
            get;
            set;
        }
        public bool? IsNexDocs
        {
            get;
            set;
        }
        public int? DislayOrder
        {
            get;
            set;
        }
    }
    public class tbl_BillingSetting
    {
        public int BillingSettingID
        {
            get;
            set;
        }
        public int BillingCategoryID
        {
            get;
            set;
        }
        public string InvoiceCurrency
        {
            get;
            set;
        }
        public string ContractDuration
        {
            get;
            set;
        }
        public string CPIIncrease
        {
            get;
            set;
        }
        public string Comments
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public int? BillingCycleID
        {
            get;
            set;
        }
        public bool? BillingStatus
        {
            get;
            set;
        }
        public int? BillingTypeID
        {
            get;
            set;
        }
        public int? PaymentMethod
        {
            get;
            set;
        }
        public int? ResponsiblePerson
        {
            get;
            set;
        }
        public bool? IsShowAlertToAgencyUser
        {
            get;
            set;
        }
        public string CreditLimit
        {
            get;
            set;
        }
        public bool? IsShowAlertToCompanyUser
        {
            get;
            set;
        }
        public bool? IsSplitReport
        {
            get;
            set;
        }
        public DateTime? CPIIncreaseDueDate
        {
            get;
            set;
        }
    }
    public class tbl_RFPsupplementary
    {
        public int RFPsupplementaryID
        {
            get;
            set;
        }
        public string supplementary_code
        {
            get;
            set;
        }
        public string supplementary_desc
        {
            get;
            set;
        }
        public string supplementary_comodities
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public string supplementary_comodities_desc
        {
            get;
            set;
        }
    }
    public class tbl_EDN_Goods_OwnerParty
    {
        public int Good_OwnerPartyID
        {
            get;
            set;
        }
        public string goods_Owner_abn
        {
            get;
            set;
        }
        public string goods_Owner_name
        {
            get;
            set;
        }
    }
    public class tbl_RFPaqis_office
    {
        public int RFPaqis_officeID
        {
            get;
            set;
        }
        public string aqis_office_code
        {
            get;
            set;
        }
        public string aqis_office_name
        {
            get;
            set;
        }
        public string aqis_office_state
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? Modifiedby
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public string aqis_office_state_desc
        {
            get;
            set;
        }
    }
    public class tbl_VesselScheduleBatch_Log
    {
        public int VesselScheduleBatchLogID
        {
            get;
            set;
        }
        public DateTime? BatchCreationDate
        {
            get;
            set;
        }
        public int? TotalBookingForUpdate
        {
            get;
            set;
        }
        public int? TotalBookingUpdated
        {
            get;
            set;
        }
        public int? TotalNotificationSend
        {
            get;
            set;
        }
        public int? TotalVesselUpdateFound
        {
            get;
            set;
        }
        public DateTime? BatchEndDate
        {
            get;
            set;
        }
        public int? TotalEmailSend
        {
            get;
            set;
        }
    }
    public class tbl_Docs_ShipmentStatus
    {
        public int ShipmentStatusId
        {
            get;
            set;
        }
        public string Status
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsDefault
        {
            get;
            set;
        }
        public string Sequence
        {
            get;
            set;
        }
        public string Color
        {
            get;
            set;
        }
        public bool? IsForSO
        {
            get;
            set;
        }
        public bool? IsForPO
        {
            get;
            set;
        }
        public bool? IsForShipment
        {
            get;
            set;
        }
        public bool? IsForBooking
        {
            get;
            set;
        }
        public bool? IsShowForSO
        {
            get;
            set;
        }
        public bool? IsShowForPO
        {
            get;
            set;
        }
        public bool? IsShowForShipment
        {
            get;
            set;
        }
        public bool? IsShowForBooking
        {
            get;
            set;
        }
        public string StatusType
        {
            get;
            set;
        }
        public bool? IsForRateRequest
        {
            get;
            set;
        }
        public bool? IsShowForRateRequest
        {
            get;
            set;
        }
        public bool IsMarkArchived
        {
            get;
            set;
        }
        public bool TriggerNotification
        {
            get;
            set;
        }
        public string SendTo
        {
            get;
            set;
        }
        public string Subject
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
        public bool IsShowForShipmentStage
        {
            get;
            set;
        }
        public bool IsForShipmentStage
        {
            get;
            set;
        }
        public int? ShipmentStatusId_old
        {
            get;
            set;
        }
        public int? IsShowForShipmentStage_old
        {
            get;
            set;
        }
        public int? IsForShipmentStage_old
        {
            get;
            set;
        }
        public int? IsForSO_old
        {
            get;
            set;
        }
        public int? IsShowForSO_old
        {
            get;
            set;
        }
        public int? IsForPO_old
        {
            get;
            set;
        }
        public int? IsShowForPO_old
        {
            get;
            set;
        }
        public bool? IsPartialAllocation
        {
            get;
            set;
        }
        public bool? IsFullAllocation
        {
            get;
            set;
        }
        public bool? IsMarkAsCompleted
        {
            get;
            set;
        }
        public bool? AllowOnlySequentialFlow
        {
            get;
            set;
        }
        public string DocumentType
        {
            get;
            set;
        }
        public string DocumentName
        {
            get;
            set;
        }
        public bool? IsInCreaseCreditLimit
        {
            get;
            set;
        }
    }
    public class tbl_DatabaseErrorLog
    {
        public long DBErrorId
        {
            get;
            set;
        }
        public string SPName
        {
            get;
            set;
        }
        public string ServerAddress
        {
            get;
            set;
        }
        public string DBName
        {
            get;
            set;
        }
        public int? CompanyId
        {
            get;
            set;
        }
        public int? UserId
        {
            get;
            set;
        }
        public string ErrorMsg
        {
            get;
            set;
        }
        public string ErrorLine
        {
            get;
            set;
        }
        public string ErrorNumber
        {
            get;
            set;
        }
        public string ErrorSeverity
        {
            get;
            set;
        }
        public string ErroState
        {
            get;
            set;
        }
        public DateTime? CreationDate
        {
            get;
            set;
        }
    }
    public class tbl_PartnerPartnerType
    {
        public long Partner_PartnerTypeID
        {
            get;
            set;
        }
        public long? PartnerAutoID
        {
            get;
            set;
        }
        public int? PartnerTypeID
        {
            get;
            set;
        }
    }
    public class tbl_BillingSettingItems
    {
        public int BillingSettingItemDetailID
        {
            get;
            set;
        }
        public int? BillingItemID
        {
            get;
            set;
        }
        public string BillingItemDesc
        {
            get;
            set;
        }
        public string ServiceType
        {
            get;
            set;
        }
        public string Account
        {
            get;
            set;
        }
        public int? RateBasis
        {
            get;
            set;
        }
        public decimal? UnitPrice
        {
            get;
            set;
        }
        public string InvoiceBase
        {
            get;
            set;
        }
        public string Comments
        {
            get;
            set;
        }
        public int? BillingSettingID
        {
            get;
            set;
        }
    }
    public class tbl_RFPTreatment
    {
        public int RFPtreatmentID
        {
            get;
            set;
        }
        public string treatment_code
        {
            get;
            set;
        }
        public string treatment_desc
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
    }
    public class tbl_EDN_GoodsOrigin
    {
        public int EDNGoodsOriginID
        {
            get;
            set;
        }
        public string goods_origin_code
        {
            get;
            set;
        }
        public string goods_origin_desc
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? Modifiedby
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
    }
    public class tbl_RFPaqis_region
    {
        public int RFPaqis_regionID
        {
            get;
            set;
        }
        public string aqis_region_code
        {
            get;
            set;
        }
        public string aqis_region_name
        {
            get;
            set;
        }
        public string aqis_region_comodities
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public string aqis_region_comodities_desc
        {
            get;
            set;
        }
    }
    public class tbl_VesselUpdateNotificationLog
    {
        public int VesselUpdateNotificationLogID
        {
            get;
            set;
        }
        public int? TotalBookingForUpdate
        {
            get;
            set;
        }
        public int? TotalBookingUpdated
        {
            get;
            set;
        }
        public int? TotalNotificationSend
        {
            get;
            set;
        }
        public DateTime? NotificationSendDate
        {
            get;
            set;
        }
        public int? TotalVesselUpdateFound
        {
            get;
            set;
        }
    }
    public class tbl_Docs_SO_PO_AmendmentReasons
    {
        public int AmendmentReasonID
        {
            get;
            set;
        }
        public string AmendmentReason
        {
            get;
            set;
        }
        public int? ReasonAddedBy
        {
            get;
            set;
        }
        public DateTime? ReasonAddedDate
        {
            get;
            set;
        }
        public Guid? RecordID
        {
            get;
            set;
        }
        public bool? IsForSaleOrder
        {
            get;
            set;
        }
        public bool? IsForPurchaseOrder
        {
            get;
            set;
        }
    }
    public class tbl_DropDown
    {
        public int DropDownID
        {
            get;
            set;
        }
        public string DDName
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
    }
    public class tbl_Port
    {
        public int Port_ID
        {
            get;
            set;
        }
        public string port_code
        {
            get;
            set;
        }
        public string port_name
        {
            get;
            set;
        }
        public string port_country
        {
            get;
            set;
        }
        public string port_type
        {
            get;
            set;
        }
        public string port_indicator
        {
            get;
            set;
        }
        public string port_countrycode
        {
            get;
            set;
        }
        public string port_unlocode
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public string alvarezcode
        {
            get;
            set;
        }
    }
    public class tbl_BillingSubscriptions
    {
        public int? CompanyID
        {
            get;
            set;
        }
        public int SubscriptionID
        {
            get;
            set;
        }
        public string GroupName
        {
            get;
            set;
        }
        public DateTime? StartDate
        {
            get;
            set;
        }
        public DateTime? EndDate
        {
            get;
            set;
        }
        public int? NoAllowed
        {
            get;
            set;
        }
        public string PaymentType
        {
            get;
            set;
        }
        public string PaymentMethod
        {
            get;
            set;
        }
        public string Status
        {
            get;
            set;
        }
        public string PlanType
        {
            get;
            set;
        }
        public DateTime? StatusDate
        {
            get;
            set;
        }
        public int? ProductID
        {
            get;
            set;
        }
        public string ProductName
        {
            get;
            set;
        }
        public string ProductDesc
        {
            get;
            set;
        }
        public int? WHMCSOrderID
        {
            get;
            set;
        }
        public int? WHMCSSubcriptionID
        {
            get;
            set;
        }
    }
    public class tbl_RFPTreatmentType
    {
        public int RFPTreatmentTypeID
        {
            get;
            set;
        }
        public string rfp_TreatTypeCode
        {
            get;
            set;
        }
        public string rfp_TreatDesc
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
    }
    public class tbl_EDN_NetQtyUnit
    {
        public int EXDNetQtyUnitID
        {
            get;
            set;
        }
        public string net_qty_code
        {
            get;
            set;
        }
        public string net_qty_unit
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? Modifiedby
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
    }
    public class tbl_RFPcomodity
    {
        public int RFPcomodityID
        {
            get;
            set;
        }
        public string comodity_code
        {
            get;
            set;
        }
        public string comodity_desc
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? Createdby
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public string CommodityForIDs
        {
            get;
            set;
        }
        public string SubmissionType
        {
            get;
            set;
        }
        public string DocumentXMLName
        {
            get;
            set;
        }
        public bool? IsNexDocs
        {
            get;
            set;
        }
    }
    public class tbl_Docs_StockAllocation
    {
        public Guid AllocationID
        {
            get;
            set;
        }
        public Guid? SalesOrderID
        {
            get;
            set;
        }
        public Guid? PurchaseOrderID
        {
            get;
            set;
        }
        public string SaleProductID
        {
            get;
            set;
        }
        public string PurchaseProductID
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public string Status
        {
            get;
            set;
        }
        public decimal? POAllocatedQty
        {
            get;
            set;
        }
        public decimal? SOAllocatedQty
        {
            get;
            set;
        }
        public bool? IsDeleted
        {
            get;
            set;
        }
        public Guid? ShipmentDocsID
        {
            get;
            set;
        }
        public string ShipmentId
        {
            get;
            set;
        }
    }
    public class tbl_DDValues
    {
        public int DDValueID
        {
            get;
            set;
        }
        public int? DropDownID
        {
            get;
            set;
        }
        public string DDKeyValue
        {
            get;
            set;
        }
        public string DDValue
        {
            get;
            set;
        }
        public int? OrderNo
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public bool? IsForDisplay
        {
            get;
            set;
        }
    }
    public class tbl_PRA_ACOSCargo
    {
        public int ACOSCargoID
        {
            get;
            set;
        }
        public string ACOSCargoCode
        {
            get;
            set;
        }
        public string ACOSCargo_Description
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsDeleted
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public string CommodityType
        {
            get;
            set;
        }
        public string ContainerHandling
        {
            get;
            set;
        }
        public string MinTemp
        {
            get;
            set;
        }
        public string MaxTemp
        {
            get;
            set;
        }
        public string VentSetting
        {
            get;
            set;
        }
    }
    public class tbl_BillingSubscriptions_History
    {
        public int? CompanyID
        {
            get;
            set;
        }
        public int HSubscriptionID
        {
            get;
            set;
        }
        public string GroupName
        {
            get;
            set;
        }
        public DateTime? StartDate
        {
            get;
            set;
        }
        public DateTime? EndDate
        {
            get;
            set;
        }
        public int? NoAllowed
        {
            get;
            set;
        }
        public string PaymentType
        {
            get;
            set;
        }
        public string PaymentMethod
        {
            get;
            set;
        }
        public string Status
        {
            get;
            set;
        }
        public string PlanType
        {
            get;
            set;
        }
        public DateTime? StatusDate
        {
            get;
            set;
        }
        public int? ProductID
        {
            get;
            set;
        }
        public string ProductName
        {
            get;
            set;
        }
        public string ProductDesc
        {
            get;
            set;
        }
        public int? RelatedSubscriptionID
        {
            get;
            set;
        }
        public DateTime? UpgradeDate
        {
            get;
            set;
        }
    }
    public class tbl_Role
    {
        public int RoleID
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public string RoleName
        {
            get;
            set;
        }
        public string RoleDescription
        {
            get;
            set;
        }
        public bool? IsMasterAdmin
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public bool? IsAdminUser
        {
            get;
            set;
        }
        public string DisplayRoleName
        {
            get;
            set;
        }
        public int? CreatedFrom
        {
            get;
            set;
        }
        public bool? IsDeleted
        {
            get;
            set;
        }
    }
    public class tbl_EDN_Port
    {
        public int EDNPort_ID
        {
            get;
            set;
        }
        public string port_unlocode
        {
            get;
            set;
        }
        public string Location
        {
            get;
            set;
        }
        public string Custom_code
        {
            get;
            set;
        }
        public string State
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
    }
    public class tbl_RFPcommodity_Companywise
    {
        public int RFPcommodity_CompanywideID
        {
            get;
            set;
        }
        public int? RFPcomodityID
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? Createdby
        {
            get;
            set;
        }
        public string SubmissionType
        {
            get;
            set;
        }
        public Guid? DocumentXMLName
        {
            get;
            set;
        }
        public bool? IsNexDocs
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsMode
        {
            get;
            set;
        }
    }
    public class tbl_Docs_ContainerDepot
    {
        public int ContainerDepotId
        {
            get;
            set;
        }
        public string ContainerDepotName
        {
            get;
            set;
        }
        public bool? Status
        {
            get;
            set;
        }
        public string CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public string ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
    }
    public class tbl_PRA_CombinedVesselRouting
    {
        public int CombinedVesselRoutingID
        {
            get;
            set;
        }
        public string TerminalCode
        {
            get;
            set;
        }
        public string TerminalName
        {
            get;
            set;
        }
        public string Vessel
        {
            get;
            set;
        }
        public string LloydsNumber
        {
            get;
            set;
        }
        public string VoyageNumber
        {
            get;
            set;
        }
        public string DischargeCountry
        {
            get;
            set;
        }
        public string DischargePortName
        {
            get;
            set;
        }
        public string DischargePortCode
        {
            get;
            set;
        }
        public string DischargeState
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsDeleted
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public bool? IsToBeDeleted
        {
            get;
            set;
        }
    }
    public class tbl_BookingContainerType
    {
        public int ID
        {
            get;
            set;
        }
        public string Code
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public bool IsActive
        {
            get;
            set;
        }
        public bool IsDeleted
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime CreatedOn
        {
            get;
            set;
        }
        public DateTime ModifiedOn
        {
            get;
            set;
        }
    }
    public class ELMAH_Error
    {
        public Guid ErrorId
        {
            get;
            set;
        }
        public string Application
        {
            get;
            set;
        }
        public string Host
        {
            get;
            set;
        }
        public string Type
        {
            get;
            set;
        }
        public string Source
        {
            get;
            set;
        }
        public string Message
        {
            get;
            set;
        }
        public string User
        {
            get;
            set;
        }
        public int StatusCode
        {
            get;
            set;
        }
        public DateTime TimeUtc
        {
            get;
            set;
        }
        public int Sequence
        {
            get;
            set;
        }
        public string AllXml
        {
            get;
            set;
        }
    }
    public class tbl_State
    {
        public string StateID
        {
            get;
            set;
        }
        public string CountryID
        {
            get;
            set;
        }
        public string StateName
        {
            get;
            set;
        }
        public string StateCode
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
    }
    public class tbl_EDNaqis_currency
    {
        public int EDNaqis_currencyID
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public string currency_code
        {
            get;
            set;
        }
        public string currency_name
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
    }
    public class tbl_RFPCommodityNature
    {
        public int RFPCommodityNatureID
        {
            get;
            set;
        }
        public string rfp_CommNatureCode
        {
            get;
            set;
        }
        public string rfp_CommDesc
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
    }
    public class tbl_Docs_VesselBooking
    {
        public Guid BookingID
        {
            get;
            set;
        }
        public string BookingNo
        {
            get;
            set;
        }
        public string BookingStatus
        {
            get;
            set;
        }
        public string FreightProvider
        {
            get;
            set;
        }
        public string FreightProviderDesc
        {
            get;
            set;
        }
        public Guid? RateListItemID
        {
            get;
            set;
        }
        public string ExpectedFreightRate
        {
            get;
            set;
        }
        public string PortOfLoadingCode
        {
            get;
            set;
        }
        public string PortOfLoading
        {
            get;
            set;
        }
        public string PortOfDestinationCode
        {
            get;
            set;
        }
        public string PortOfDestination
        {
            get;
            set;
        }
        public DateTime? ETD
        {
            get;
            set;
        }
        public string BookingRef
        {
            get;
            set;
        }
        public string ShippingLine
        {
            get;
            set;
        }
        public string ShippingLineDesc
        {
            get;
            set;
        }
        public string VesselName
        {
            get;
            set;
        }
        public string VoyageNo
        {
            get;
            set;
        }
        public string QuestionRef
        {
            get;
            set;
        }
        public string AdditionalInfo
        {
            get;
            set;
        }
        public string BookingConfirmation
        {
            get;
            set;
        }
        public string BookingConfirmationFileName
        {
            get;
            set;
        }
        public int? Container
        {
            get;
            set;
        }
        public string ContainerOption
        {
            get;
            set;
        }
        public string HSCode
        {
            get;
            set;
        }
        public int? GrossWeight
        {
            get;
            set;
        }
        public string ContainerType
        {
            get;
            set;
        }
        public string HazardousClass
        {
            get;
            set;
        }
        public string MaterialSafetyDataSheet
        {
            get;
            set;
        }
        public string MaterialSafetyDataSheetFileName
        {
            get;
            set;
        }
        public string CargoDescription
        {
            get;
            set;
        }
        public string ShipperCode
        {
            get;
            set;
        }
        public string ShipperName
        {
            get;
            set;
        }
        public string ShipperAgentName
        {
            get;
            set;
        }
        public string ShipperPhoneNumber
        {
            get;
            set;
        }
        public string ShipperEmail
        {
            get;
            set;
        }
        public string ShipperAddress
        {
            get;
            set;
        }
        public string YourEmail
        {
            get;
            set;
        }
        public string YourName
        {
            get;
            set;
        }
        public string PhoneNumber
        {
            get;
            set;
        }
        public string OurReference
        {
            get;
            set;
        }
        public string BookingPartyName
        {
            get;
            set;
        }
        public string BookingPartyAddress
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public bool IsDeleted
        {
            get;
            set;
        }
        public bool? IsArchive
        {
            get;
            set;
        }
        public string GrossWeightUOM
        {
            get;
            set;
        }
        public string YourCompany
        {
            get;
            set;
        }
        public string FreightProviderEmail
        {
            get;
            set;
        }
        public long? PartnerID
        {
            get;
            set;
        }
        public string MessageType
        {
            get;
            set;
        }
        public string BookingPartyType
        {
            get;
            set;
        }
        public string PaymentDetails
        {
            get;
            set;
        }
        public string ContainerDetails
        {
            get;
            set;
        }
        public string CargoDetails
        {
            get;
            set;
        }
        public string MainCarriage
        {
            get;
            set;
        }
        public string RemovePreCarriage
        {
            get;
            set;
        }
        public string PreCarriage
        {
            get;
            set;
        }
        public string CarrierDoesNOTFile
        {
            get;
            set;
        }
        public string ConsigneeDetails
        {
            get;
            set;
        }
        public string ForwarderDetails
        {
            get;
            set;
        }
        public string ShipperReferenceNumber
        {
            get;
            set;
        }
        public string ForwarderReferenceNumber
        {
            get;
            set;
        }
        public string PurchaseOrderNumber
        {
            get;
            set;
        }
        public string TariffNumber
        {
            get;
            set;
        }
        public string ContractPartyReferenceNumber
        {
            get;
            set;
        }
        public string ConsigneesReferenceNumber
        {
            get;
            set;
        }
        public string BLReferenceNumber
        {
            get;
            set;
        }
        public string MoveType
        {
            get;
            set;
        }
        public string PlaceofCarrierReceipt
        {
            get;
            set;
        }
        public DateTime? EarliestDepartureDate
        {
            get;
            set;
        }
        public string PlaceofCarrierDelivery
        {
            get;
            set;
        }
        public DateTime? LatestDeliveryDate
        {
            get;
            set;
        }
        public string AdditionalNotifyParty2Description
        {
            get;
            set;
        }
        public string AdditionalNotifyParty2
        {
            get;
            set;
        }
        public string AdditionalNotifyParty1Description
        {
            get;
            set;
        }
        public string AdditionalNotifyParty1
        {
            get;
            set;
        }
        public string NOTIFYPARTY1
        {
            get;
            set;
        }
        public string NOTIFYDescription
        {
            get;
            set;
        }
        public string ShipperID
        {
            get;
            set;
        }
        public string ConsigneeID
        {
            get;
            set;
        }
        public string ConsigneeDescription
        {
            get;
            set;
        }
        public string ShipperDescription
        {
            get;
            set;
        }
        public string ContractPartyID
        {
            get;
            set;
        }
        public string ContractPartyDescription
        {
            get;
            set;
        }
        public string ForwarderDescription
        {
            get;
            set;
        }
        public string ForwarderID
        {
            get;
            set;
        }
        public string HaulageDetailsId
        {
            get;
            set;
        }
        public string HaulageDetailsDetails
        {
            get;
            set;
        }
        public string BookingOffice
        {
            get;
            set;
        }
        public string CustomerComments
        {
            get;
            set;
        }
        public string PartnerEmailNotifications
        {
            get;
            set;
        }
        public string PlaceofCarrierReceiptDesc
        {
            get;
            set;
        }
        public string PlaceofCarrierDeliveryDesc
        {
            get;
            set;
        }
        public string Address1_ExporterShipper
        {
            get;
            set;
        }
        public string Address2_ExporterShipper
        {
            get;
            set;
        }
        public string Address3_ExporterShipper
        {
            get;
            set;
        }
        public string Address4_ExporterShipper
        {
            get;
            set;
        }
        public string Address5_ExporterShipper
        {
            get;
            set;
        }
        public string ProductSourceCountry
        {
            get;
            set;
        }
        public string ProductSourceCountryDesc
        {
            get;
            set;
        }
        public string Address1_Forwarder
        {
            get;
            set;
        }
        public string Address2_Forwarder
        {
            get;
            set;
        }
        public string Address3_Forwarder
        {
            get;
            set;
        }
        public string Address4_Forwarder
        {
            get;
            set;
        }
        public string Address5_Forwarder
        {
            get;
            set;
        }
        public string ForwarderCountry
        {
            get;
            set;
        }
        public string ForwarderCountryDesc
        {
            get;
            set;
        }
        public string Address1_Consignee
        {
            get;
            set;
        }
        public string Address2_Consignee
        {
            get;
            set;
        }
        public string Address3_Consignee
        {
            get;
            set;
        }
        public string Address4_Consignee
        {
            get;
            set;
        }
        public string Address5_Consignee
        {
            get;
            set;
        }
        public string ConsigneeCountry
        {
            get;
            set;
        }
        public string ConsigneeCountryDesc
        {
            get;
            set;
        }
        public string ContactName
        {
            get;
            set;
        }
        public string ContactPhone
        {
            get;
            set;
        }
        public string ContactEmail
        {
            get;
            set;
        }
        public string Phone_ExporterShipper
        {
            get;
            set;
        }
        public string Email_ExporterShipper
        {
            get;
            set;
        }
        public string Phone_Forwarder
        {
            get;
            set;
        }
        public string Email_Forwarder
        {
            get;
            set;
        }
        public string Phone_Consignee
        {
            get;
            set;
        }
        public string Email_Consignee
        {
            get;
            set;
        }
        public string Name_ExporterShipper
        {
            get;
            set;
        }
        public string Name_Forwarder
        {
            get;
            set;
        }
        public string Name_Consignee
        {
            get;
            set;
        }
        public string NatureofCargo
        {
            get;
            set;
        }
        public int ShipmentID
        {
            get;
            set;
        }
        public string QuotedFreightRate
        {
            get;
            set;
        }
        public string QuotedFreightRateCurrency
        {
            get;
            set;
        }
        public string BookingOfficeLocCode
        {
            get;
            set;
        }
        public string BookingOfficeLocDesc
        {
            get;
            set;
        }
        public string BookingOfficeName
        {
            get;
            set;
        }
        public string BookingOfficeCity
        {
            get;
            set;
        }
        public string BookingOfficeCountry
        {
            get;
            set;
        }
        public string BookingOfficeCountryDesc
        {
            get;
            set;
        }
        public string INTTRAReferenceNumber
        {
            get;
            set;
        }
        public DateTime? BookingDateTime
        {
            get;
            set;
        }
        public string VGMCutoffDatetime
        {
            get;
            set;
        }
        public string CarrierComments
        {
            get;
            set;
        }
        public string ConfirmedWithName
        {
            get;
            set;
        }
        public string ConfirmedWithEmail
        {
            get;
            set;
        }
        public string BillOfLadingNumber
        {
            get;
            set;
        }
        public string ContractNumber
        {
            get;
            set;
        }
        public string GoodDescription
        {
            get;
            set;
        }
        public string LastNonUSPort
        {
            get;
            set;
        }
        public string PlaceOfAcceptance
        {
            get;
            set;
        }
        public string PlaceOfAcceptanceName
        {
            get;
        }
    }
    public class tbl_Docs_ContainerType
    {
        public int ContainerTypeID
        {
            get;
            set;
        }
        public string ContainerTypeCode
        {
            get;
            set;
        }
        public string ContainerTypeDesc
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public bool? IsDeleted
        {
            get;
            set;
        }
    }
    public class tbl_PRA_Commodity
    {
        public int CommodityID
        {
            get;
            set;
        }
        public string Commodity_Code
        {
            get;
            set;
        }
        public string Commodity_Description
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsDeleted
        {
            get;
            set;
        }
    }
    public class tbl_bpanel_DocumentTemplate
    {
        public decimal Id
        {
            get;
            set;
        }
        public decimal? CompanyId
        {
            get;
            set;
        }
        public decimal? UserId
        {
            get;
            set;
        }
        public string TemplateTitle
        {
            get;
            set;
        }
        public string Template
        {
            get;
            set;
        }
        public DateTime? CreatedDate
        {
            get;
            set;
        }
        public DateTime? UpdatedDate
        {
            get;
            set;
        }
        public bool? IsDelete
        {
            get;
            set;
        }
        public string OutputType
        {
            get;
            set;
        }
        public string OutputTypeDisplay
        {
            get;
            set;
        }
        public string DocumentType
        {
            get;
            set;
        }
    }
    public class tbl_SystemNotification
    {
        public int SystemNotificationID
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public bool? ShowOnLoginPage
        {
            get;
            set;
        }
        public bool? ShowToUser
        {
            get;
            set;
        }
        public string Description
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public string LoginText
        {
            get;
            set;
        }
        public int? LoginImportance
        {
            get;
            set;
        }
        public int? DescriptionImportance
        {
            get;
            set;
        }
        public string LandingPageTitle
        {
            get;
            set;
        }
        public bool? IsForDevesa
        {
            get;
            set;
        }
        public bool? IsForKilcoy
        {
            get;
            set;
        }
        public bool? IsForGreenham
        {
            get;
            set;
        }
        public bool? IsForMainApplication
        {
            get;
            set;
        }
        public DateTime? ExpiryDate
        {
            get;
            set;
        }
        public DateTime? PublishingDate
        {
            get;
            set;
        }
        public string DisplayLocation
        {
            get;
            set;
        }
        public string NotificationType
        {
            get;
            set;
        }
        public string DisplayServer
        {
            get;
            set;
        }
        public string URL
        {
            get;
            set;
        }
        public string Status
        {
            get;
            set;
        }
    }
    public class tbl_EDNFOB_currency
    {
        public int EDNFOB_currencyID
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public string currency_code
        {
            get;
            set;
        }
        public string currency_name
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
    }
    public class tbl_Docs_eBookingDefaults
    {
        public int BookingDefaultID
        {
            get;
            set;
        }
        public string ShippingLineCode
        {
            get;
            set;
        }
        public string ShippingLineDesc
        {
            get;
            set;
        }
        public string NatureOfCargo
        {
            get;
            set;
        }
        public string ContactName
        {
            get;
            set;
        }
        public string ContactPhone
        {
            get;
            set;
        }
        public string ContactEmail
        {
            get;
            set;
        }
        public string BookingPartyType
        {
            get;
            set;
        }
        public string ShipperCode
        {
            get;
            set;
        }
        public string ShipperDesc
        {
            get;
            set;
        }
        public string ShipperAddress1
        {
            get;
            set;
        }
        public string ShipperAddress2
        {
            get;
            set;
        }
        public string ShipperCity
        {
            get;
            set;
        }
        public string ShipperPostalCode
        {
            get;
            set;
        }
        public string ShipperCountryCode
        {
            get;
            set;
        }
        public string ShipperCountryDesc
        {
            get;
            set;
        }
        public string ForwarderCode
        {
            get;
            set;
        }
        public string ForwarderDesc
        {
            get;
            set;
        }
        public string ForwarderAddress1
        {
            get;
            set;
        }
        public string ForwarderAddress2
        {
            get;
            set;
        }
        public string ForwarderCity
        {
            get;
            set;
        }
        public string ForwarderPostalCode
        {
            get;
            set;
        }
        public string ForwarderCountryCode
        {
            get;
            set;
        }
        public string ForwarderCountryDesc
        {
            get;
            set;
        }
        public string ConsigneeCode
        {
            get;
            set;
        }
        public string ConsigneeDesc
        {
            get;
            set;
        }
        public string ConsigneeAddress1
        {
            get;
            set;
        }
        public string ConsigneeAddress2
        {
            get;
            set;
        }
        public string ConsigneeCity
        {
            get;
            set;
        }
        public string ConsigneePostalCode
        {
            get;
            set;
        }
        public string ConsigneeCountryCode
        {
            get;
            set;
        }
        public string ConsigneeCountryDesc
        {
            get;
            set;
        }
        public string ConsigneeContactName
        {
            get;
            set;
        }
        public string ConsigneeContactPhone
        {
            get;
            set;
        }
        public string ConsigneeContactEmail
        {
            get;
            set;
        }
        public string MoveType
        {
            get;
            set;
        }
        public string PlaceofCarrierReceiptCode
        {
            get;
            set;
        }
        public string PlaceofCarrierReceiptDesc
        {
            get;
            set;
        }
        public string PlaceofCarrierDeliveryCode
        {
            get;
            set;
        }
        public string PlaceofCarrierDeliveryDesc
        {
            get;
            set;
        }
        public string LoadPort
        {
            get;
            set;
        }
        public string LoadPortDesc
        {
            get;
            set;
        }
        public string DischargePort
        {
            get;
            set;
        }
        public string DischargePortDesc
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public int? UserID
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public DateTime? ModifiedBy
        {
            get;
            set;
        }
        public string CargoDesc
        {
            get;
            set;
        }
        public string HSCode
        {
            get;
            set;
        }
        public string CargoWeight
        {
            get;
            set;
        }
        public string CargoWeightUOM
        {
            get;
            set;
        }
        public int? ContainerQty
        {
            get;
            set;
        }
        public string ContainerType
        {
            get;
            set;
        }
        public bool? IsShipperOwned
        {
            get;
            set;
        }
        public bool? IsNonActiveReefer
        {
            get;
            set;
        }
        public string Temp
        {
            get;
            set;
        }
        public string TempUOM
        {
            get;
            set;
        }
        public string Comments
        {
            get;
            set;
        }
        public string BookingOfficeCode
        {
            get;
            set;
        }
        public string BookingOfficeDesc
        {
            get;
            set;
        }
        public string GrossVolumeUOM
        {
            get;
            set;
        }
        public string PackageTypeUOM
        {
            get;
            set;
        }
        public string ChargeType
        {
            get;
            set;
        }
        public string FreightTerm
        {
            get;
            set;
        }
        public string Payer
        {
            get;
            set;
        }
        public string PaymentLocation
        {
            get;
            set;
        }
        public string PaymentLocationDes
        {
            get;
            set;
        }
        public string AnyOtherInfo
        {
            get;
            set;
        }
        public string PrimaryImoClass
        {
            get;
            set;
        }
        public string UNDGNumber
        {
            get;
            set;
        }
        public string RegPageNumber
        {
            get;
            set;
        }
        public string RegVersionNumber
        {
            get;
            set;
        }
        public string ProperShippingName
        {
            get;
            set;
        }
        public string TechnicalName
        {
            get;
            set;
        }
        public string NetWeight
        {
            get;
            set;
        }
        public string NetWeightUOM
        {
            get;
            set;
        }
        public string NetVolume
        {
            get;
            set;
        }
        public string NetVolumeUOM
        {
            get;
            set;
        }
        public string PackingGroup
        {
            get;
            set;
        }
        public string FlashPoint
        {
            get;
            set;
        }
        public string FlashPointUOM
        {
            get;
            set;
        }
        public string MarinePollutantStatus
        {
            get;
            set;
        }
        public string EMSNumber
        {
            get;
            set;
        }
        public string IBCPackageCode
        {
            get;
            set;
        }
        public string EmergencyContactName
        {
            get;
            set;
        }
        public string EmergencyContactNumber
        {
            get;
            set;
        }
        public string OtherHazardousGoodsComments
        {
            get;
            set;
        }
        public string AirFlow
        {
            get;
            set;
        }
        public string AirFlowUOM
        {
            get;
            set;
        }
        public string RelativeHumidity
        {
            get;
            set;
        }
        public string VentSetting
        {
            get;
            set;
        }
        public bool? IsDehumidification
        {
            get;
            set;
        }
        public bool? IsGenSet
        {
            get;
            set;
        }
        public bool? IsAtmosphere
        {
            get;
            set;
        }
        public string SpecialServiceRequest
        {
            get;
            set;
        }
        public string GenEquipmentComm
        {
            get;
            set;
        }
        public string Lloyds
        {
            get;
            set;
        }
        public string Total
        {
            get;
            set;
        }
        public string FreightLocal
        {
            get;
            set;
        }
        public string TotalFreightUSD
        {
            get;
            set;
        }
        public string DemurrageFreeTime
        {
            get;
            set;
        }
        public string DetentionFreeTime
        {
            get;
            set;
        }
        public string BookingPartyComments
        {
            get;
            set;
        }
        public string FreightProviderIntraCode
        {
            get;
            set;
        }
        public string BookingType
        {
            get;
            set;
        }
        public string TransportMode
        {
            get;
            set;
        }
        public string ShipmentType
        {
            get;
            set;
        }
        public bool? IsCopyInSO
        {
            get;
            set;
        }
        public bool? IsCopyInPO
        {
            get;
            set;
        }
        public bool? IsCopyInShipment
        {
            get;
            set;
        }
        public string PaymentSerializeData
        {
            get;
            set;
        }
    }
    public class tbl_RFPCountry
    {
        public string OrderNumber
        {
            get;
            set;
        }
        public string CountryName
        {
            get;
            set;
        }
        public string FormalName
        {
            get;
            set;
        }
        public string Type
        {
            get;
            set;
        }
        public string SubType
        {
            get;
            set;
        }
        public string Sovereignty
        {
            get;
            set;
        }
        public string Capital
        {
            get;
            set;
        }
        public string CurrencyCode
        {
            get;
            set;
        }
        public string CurrencyName
        {
            get;
            set;
        }
        public string TelephoneCode
        {
            get;
            set;
        }
        public string CountryID
        {
            get;
            set;
        }
        public string ISOLetterCode
        {
            get;
            set;
        }
        public string Number
        {
            get;
            set;
        }
        public string CountryCode
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
    }
    public class tbl_Docs_DangerousGoods
    {
        public int DangerousGoodsID
        {
            get;
            set;
        }
        public int ShipmentDocsID
        {
            get;
            set;
        }
        public string ShipmentID
        {
            get;
            set;
        }
        public int OtherProductID
        {
            get;
            set;
        }
        public string IMOClass
        {
            get;
            set;
        }
        public string IMDGCodePage
        {
            get;
            set;
        }
        public int? UNDGNo
        {
            get;
            set;
        }
        public string EMSNo
        {
            get;
            set;
        }
        public string ShippingName
        {
            get;
            set;
        }
        public string PackingGroup
        {
            get;
            set;
        }
        public string FlashPointTemperature
        {
            get;
            set;
        }
        public string TemperatureUOM
        {
            get;
            set;
        }
        public string PackingDetails
        {
            get;
            set;
        }
        public string GeneralComments
        {
            get;
            set;
        }
        public string EmergencyContactName
        {
            get;
            set;
        }
        public string EmergencyTelNo
        {
            get;
            set;
        }
        public bool IsDeleted
        {
            get;
            set;
        }
    }
    public class tbl_ProductGroupLevels
    {
        public Guid ProductGroupLevelId
        {
            get;
            set;
        }
        public string LevelKey
        {
            get;
            set;
        }
        public string LevelCustomValue
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public string TaxIds
        {
            get;
            set;
        }
    }
    public class tbl_PRA_ContainerISO
    {
        public int ContainerISOID
        {
            get;
            set;
        }
        public string ContainerISOCode
        {
            get;
            set;
        }
        public string ContainerISO_Description
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsDeleted
        {
            get;
            set;
        }
        public string ISOLength
        {
            get;
            set;
        }
        public string ISOHeight
        {
            get;
            set;
        }
        public string ISOTareWt
        {
            get;
            set;
        }
        public string ISOSafeWt
        {
            get;
            set;
        }
        public string ISOLengthMM
        {
            get;
            set;
        }
        public string ISOHeightMM
        {
            get;
            set;
        }
        public string ISOWidthMM
        {
            get;
            set;
        }
    }
    public class tbl_Buttons
    {
        public int ButtonID
        {
            get;
            set;
        }
        public int? CompanyID
        {
            get;
            set;
        }
        public string ButtonName
        {
            get;
            set;
        }
        public string DisplayButtonName
        {
            get;
            set;
        }
        public int? CreatedBy
        {
            get;
            set;
        }
        public DateTime? CreatedOn
        {
            get;
            set;
        }
        public int? ModifiedBy
        {
            get;
            set;
        }
        public DateTime? ModifiedOn
        {
            get;
            set;
        }
        public bool? IsActive
        {
            get;
            set;
        }
        public int? AppID
        {
            get;
            set;
        }
        public string ButtonType
        {
            get;
            set;
        }
    }
    public class tbl_TimeZone
    {
        public string DisplayName
        {
            get;
            set;
        }
        public string Standardname
        {
            get;
            set;
        }
        public int timezoneid
        {
            get;
            set;
        }
        public string OffSet
        {
            get;
            set;
        }
    }
}