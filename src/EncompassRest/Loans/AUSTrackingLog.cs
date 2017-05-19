using System;
using System.Collections.Generic;

namespace EncompassRest.Loans
{
    public sealed class AUSTrackingLog
    {
        public string Log_UnderwritingRiskAssessType { get; set; }
        public string Log_UnderwritingRiskAssessOther { get; set; }
        public DateTime? Log_SubmissionDate { get; set; }
        public DateTime? Log_FirstSubmissionDate { get; set; }
        public string Log_SubmissionNumber { get; set; }
        public string Log_AUSRecommendation { get; set; }
        public string Log_DUCaseIDorLPAUSKey { get; set; }
        public string Log_SubmittedBy { get; set; }
        public string Log_AUSVersion { get; set; }
        public string Log_FreddieDocClass { get; set; }
        public decimal? Log_LTV { get; set; }
        public decimal? Log_CuredLTV { get; set; }
        public decimal? Log_CLTV { get; set; }
        public decimal? Log_CuredCLTV { get; set; }
        public decimal? Log_HLCTV { get; set; }
        public decimal? Log_HousingExpenseRatio { get; set; }
        public decimal? Log_CuredHousingExpenseRatio { get; set; }
        public decimal? Log_TotalExpenseRatio { get; set; }
        public decimal? Log_CuredTotalExpenseRatio { get; set; }
        public decimal? Log_TotalLoanAmount { get; set; }
        public decimal? Log_CuredTotalLoanAmount { get; set; }
        public decimal? Log_SalesPrice { get; set; }
        public int? Log_AppraisedValue { get; set; }
        public int? Log_CuredAppraisedValue { get; set; }
        public decimal? Log_NoteRate { get; set; }
        public decimal? Log_CuredNoteRate { get; set; }
        public string Log_LoanType { get; set; }
        public string Log_CuredLoanType { get; set; }
        public int? Log_LoanTerm { get; set; }
        public int? Log_CuredLoanTerm { get; set; }
        public string Log_AmortizationType { get; set; }
        public string Log_CuredAmortizationType { get; set; }
        public string Log_LoanPurpose { get; set; }
        public string Log_CuredLoanPurpose { get; set; }
        public string Log_RefinancePurpose { get; set; }
        public string Log_CuredRefinancePurpose { get; set; }
        public decimal? Log_FirstPandI { get; set; }
        public decimal? Log_SecondPandI { get; set; }
        public decimal? Log_ProposedHazardInsurance { get; set; }
        public decimal? Log_ProposedTaxes { get; set; }
        public decimal? Log_ProposedMortgageInsurance { get; set; }
        public decimal? Log_ProposedHOAFees { get; set; }
        public decimal? Log_ProposedOtherPayment { get; set; }
        public decimal? Log_ProposedTotalHousingPayment { get; set; }
        public decimal? Log_CuredProposedTotalHousingPayment { get; set; }
        public decimal? Log_ProposedTotalMonthlyDebt { get; set; }
        public decimal? Log_IncomeAssetBase { get; set; }
        public decimal? Log_IncomeAssetCommission { get; set; }
        public decimal? Log_IncomeAssetBonus { get; set; }
        public decimal? Log_IncomeAssetOvertime { get; set; }
        public decimal? Log_IncomeAssetOther { get; set; }
        public decimal? Log_IncomeAssetPositiveNetRental { get; set; }
        public decimal? Log_IncomeAssetPosCashFlow { get; set; }
        public decimal? Log_TotalMonthlyIncome { get; set; }
        public decimal? Log_CuredTotalMonthlyIncome { get; set; }
        public decimal? Log_TotalAsset { get; set; }
        public string Log_eFolderGUID { get; set; }
        public string Log_BorrowerName { get; set; }
        public string Log_LenderLoan { get; set; }
        public string Log_CoborrowerName { get; set; }
        public string Log_PropertyAddress { get; set; }
        public string Log_PropertyCity { get; set; }
        public string Log_PropertyState { get; set; }
        public string Log_PropertyZipcode { get; set; }
        public string Log_DUPropertyType { get; set; }
        public int? Log_NoUnits { get; set; }
        public string Log_OccupancyStatus { get; set; }
        public string Log_Balloon { get; set; }
        public string Log_CommunityLending { get; set; }
        public int? Log_PaymentFrequency { get; set; }
        public string Log_LienType { get; set; }
        public decimal? Log_AmtSubordinateFin { get; set; }
        public decimal? Log_OwnerExistingMtg { get; set; }
        public string Log_Buydown { get; set; }
        public decimal? Log_LoanAmount { get; set; }
        public decimal? Log_FinancedMIAmount { get; set; }
        public decimal? Log_PandI { get; set; }
        public decimal? Log_QualifyingRate { get; set; }
        public decimal? Log_BoughtDownRate { get; set; }
        public decimal? Log_HousingExpense { get; set; }
        public decimal? Log_TotalExpense { get; set; }
        public string Log_IncludingLess10Mos { get; set; }
        public string Log_WithUndisclosedDebt { get; set; }
        public decimal? Log_NegativeNetRental { get; set; }
        public decimal? Log_SubjNegCashFlow { get; set; }
        public decimal? Log_AllOtherPayments { get; set; }
        public decimal? Log_TotalExpensePmt { get; set; }
        public decimal? Log_PresentPrincipalHousingPayment { get; set; }
        public decimal? Log_FundsRequiredClose { get; set; }
        public decimal? Log_ReservesRequiredVerified { get; set; }
        public decimal? Log_TotalFundsVerified { get; set; }
        public decimal? Log_CashBack { get; set; }
        public decimal? Log_NetCashBack { get; set; }
        public decimal? Log_ExcessAvailableAssetsNoVerified { get; set; }
        public string Log_Code1 { get; set; }
        public string Log_CodeDescription1 { get; set; }
        public string Log_Code2 { get; set; }
        public string Log_CodeDescription2 { get; set; }
        public string Log_BorrowerType1 { get; set; }
        public string Log_CreditAgency1 { get; set; }
        public string Log_CreditReportID1 { get; set; }
        public DateTime? Log_CreditReportDate1 { get; set; }
        public string Log_BorrowerType2 { get; set; }
        public string Log_CreditAgency2 { get; set; }
        public string Log_CreditReportID2 { get; set; }
        public DateTime? Log_CreditReportDate2 { get; set; }
        public string Log_BorrowerScoreName { get; set; }
        public string Log_BorrowerCreditScore1 { get; set; }
        public string Log_BorrowerCreditScore2 { get; set; }
        public string Log_BorrowerCreditScore3 { get; set; }
        public string Log_CoBorrowerScoreName { get; set; }
        public string Log_CoBorrowerCreditScore1 { get; set; }
        public string Log_CoBorrowerCreditScore2 { get; set; }
        public string Log_CoBorrowerCreditScore3 { get; set; }
        public string Log_BorrowerIncomeName { get; set; }
        public string Log_BorrowerIncomeType { get; set; }
        public decimal? Log_BorrowerIncomeAmount { get; set; }
        public string Log_CoBorrowerIncomeName { get; set; }
        public string Log_CoBorrowerIncomeType { get; set; }
        public decimal? Log_CoBorrowerIncomeAmount { get; set; }
        public string Log_BorrowerAssetName { get; set; }
        public string Log_BorrowerAssetType { get; set; }
        public string Log_BorrowerInstitutionName { get; set; }
        public decimal? Log_BorrowerAssetAmount { get; set; }
        public string Log_CoBorrowerAssetName { get; set; }
        public string Log_CoBorrowerAssetType { get; set; }
        public string Log_CoBorrowerInstitutionName { get; set; }
        public decimal? Log_CoBorrowerAssetAmount { get; set; }
        public string Log_AUSTransactionID { get; set; }
        public string Log_LoanProspectorID { get; set; }
        public string Log_TransactionID { get; set; }
        public string Log_RiskClass { get; set; }
        public string Log_DocumentationLevel { get; set; }
        public string Log_MortgageType { get; set; }
        public string Log_PurchaseEligibility { get; set; }
        public string Log_AUSStatus { get; set; }
        public string Log_LoanProcessingStage { get; set; }
        public string Log_AssessmentType { get; set; }
        public string Log_LPVersion { get; set; }
        public string Log_AppraisalTypeMAF { get; set; }
        public string Log_MIDecision { get; set; }
        public string Log_AcceptPlusEligible { get; set; }
        public string Log_IndicatorScore { get; set; }
        public string Log_SelectedRepository { get; set; }
        public string Log_SelectedBorrower { get; set; }
        public DateTime? Log_LPAssmtExpDate { get; set; }
        public string Log_BorrowerExperianFICO { get; set; }
        public string Log_BorrowerTransUnionEmpirica { get; set; }
        public string Log_BorrowerEquifaxBEACON { get; set; }
        public string Log_CoBorrowerExperianFICO { get; set; }
        public string Log_CoBorrowerTransUnionEmpirica { get; set; }
        public string Log_CoBorrowerEquifaxBEACON { get; set; }
        public string Log_PresentAddress { get; set; }
        public string Log_PresentAddressCity { get; set; }
        public string Log_PresentAddressState { get; set; }
        public string Log_PresentAddressZipCode { get; set; }
        public string Log_LoanApplicationID { get; set; }
        public int? Log_BalloonTerm { get; set; }
        public int? Log_AmortizationMonths { get; set; }
        public decimal? Log_ARMQualifyingRate { get; set; }
        public decimal? Log_TLTV { get; set; }
        public decimal? Log_HTLTV { get; set; }
        public decimal? Log_HousingRatio { get; set; }
        public decimal? Log_DebtRatio { get; set; }
        public decimal? Log_OccupantHousingRatio { get; set; }
        public decimal? Log_OccupantDebtRatio { get; set; }
        public string Log_NegAmortizationType { get; set; }
        public string Log_TemporarySubsidyBuydown { get; set; }
        public string Log_NewConstruction { get; set; }
        public string Log_AffordableProductType { get; set; }
        public string Log_OfferingIdentifier { get; set; }
        public string Log_IntendedUseofProperty { get; set; }
        public decimal? Log_CashOutAmount { get; set; }
        public decimal? Log_Reserves { get; set; }
        public decimal? Log_ProposedHousingPITI { get; set; }
        public decimal? Log_PresentHousingExpense { get; set; }
        public decimal? Log_MaxMortgageLimit { get; set; }
        public string Log_SalesConcessions { get; set; }
        public string Log_OriginatingCompany { get; set; }
        public string Log_SubmittingCompany { get; set; }
        public string Log_SellerNumber { get; set; }
        public string Log_TPONumber { get; set; }
        public string Log_DateTimeRequested { get; set; }
        public string Log_DateTimeAssessed { get; set; }
        public string Log_NumberOfSubmissions { get; set; }
        public string Log_NOTPNumber { get; set; }
        public string Log_LPPropertyType { get; set; }
        public string Log_SubmissionTime { get; set; }
        public string Log_FirstSubmissionTime { get; set; }
        public string Log_LQADataCompareResult { get; set; }
        public string Log_LQALPKey { get; set; }
        public DateTime? Log_LQASubmissionDateTime { get; set; }
        public string Log_LQADataCompareFieldName { get; set; }
        public string Log_LQADataCompareFieldConclusion { get; set; }
        public string Log_LQARiskAssessmentKey { get; set; }
        public string Log_LQACreditRiskAssessmentConclusion { get; set; }
        public string Log_LQAPurchaseEligibilityResult { get; set; }
        public string Log_LQACollateralRepWarrantyServiceConclusion { get; set; }
        public string Log_LCLAEvaluatedServiceType1 { get; set; }
        public string Log_LCLAEvaluatedServiceConclusion1 { get; set; }
        public string Log_LCLAEvaluatedServiceType2 { get; set; }
        public string Log_LCLAEvaluatedServiceConclusion2 { get; set; }
        public string Log_LCLAEvaluatedServiceType3 { get; set; }
        public string Log_LCLAEvaluatedServiceConclusion3 { get; set; }
        public string Log_LCLAEvaluatedServiceType4 { get; set; }
        public string Log_LCLAEvaluatedServiceConclusion4 { get; set; }
        public string Log_AUSTrackingType { get; set; }
        public string Id { get; set; }
        public int? AUSTrackingLogIndex { get; set; }
        public bool? IsHistory { get; set; }
        public string Log_GUID { get; set; }
        public DateTime? Log_CreatedOn { get; set; }
        public string Log_RecordType { get; set; }
        public bool? IsEmpty { get; set; }
        public string BatchDocumentRefId { get; set; }
    }
}