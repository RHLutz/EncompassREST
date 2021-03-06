﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncompassREST.Data
{
    public class RegulationZ
    {
        public bool? pmiIndicator { get; set; }
        public string borrowerMiTerminationDate { get; set; }
        public string miScheduledTerminationDate { get; set; }
        public decimal? extraPaymentForEarlyPayOff { get; set; }
        public string disclosureType { get; set; }
        public bool? demandFeatureIndicator { get; set; }
        public bool? requiredDepositIndicator { get; set; }
        public bool? variableRateFeatureIndicator { get; set; }
        public string additionalArmInformation { get; set; }
        public bool? refundPaymentIndicator { get; set; }
        public string securityType { get; set; }
        public int? lateChargeDays { get; set; }
        public decimal? lateChargePercent { get; set; }
        public bool? floodInsuranceIndicator { get; set; }
        public string assumptionOnYourProperty { get; set; }
        public bool? allDateAndNumericalDisclosureIndicator { get; set; }
        public bool? meansAnEstimateIndicator { get; set; }
        public bool? mmiIndicator { get; set; }
        public decimal? aprPercent { get; set; }
        public decimal? amountFinanced { get; set; }
        public decimal? prepaidFinanceCharge { get; set; }
        public int? constructionPeriodMonths { get; set; }
        public int? interestOnlyMonths { get; set; }
        public int? miMonthsOfAdjustmentLevel1 { get; set; }
        public int? miMonthsOfAdjustmentLevel2 { get; set; }
        public decimal? miAdjustmentFactorLevel2 { get; set; }
        public decimal? mortgageInsuranceCancelPercent { get; set; }
        public decimal? financeCharge { get; set; }
        public decimal? totalOfPayments { get; set; }
        public int? monthsOfMiPrepaid { get; set; }
        public bool? propertyInsuranceIndicator { get; set; }
        public decimal? interestReserveAmount { get; set; }
        public int? years { get; set; }
        public decimal? ratePercent { get; set; }
        public string constructionLoanDescription { get; set; }
        public string interstInNameOf { get; set; }
        public decimal? constructionRatePercent { get; set; }
        public bool? customizePaymentScheduleIndicator { get; set; }
        public List<RegulationZPayment> regulationZPayments { get; set; }
        public bool? creditLifeInsuranceIndicator { get; set; }
        public bool? creditDisabilityIndicator { get; set; }
        public int? numberOfPayments { get; set; }
        public string insuranceRequiredDescription { get; set; }
        public decimal? creditLife { get; set; }
        public decimal? creditDisability { get; set; }
        public decimal? creditLifeAndCreditDisability { get; set; }
        public decimal? filingFees { get; set; }
        public bool? ifYouPurchaseIndicator { get; set; }
        public string ifYouPurchaseType { get; set; }
        public decimal? yearlyTerm { get; set; }
        public decimal? monthlyTerm { get; set; }
        public int? recentPaidMonths { get; set; }
        public int? recentStopMonths { get; set; }
        public string lateChargeType { get; set; }
        public string midpointCancellation { get; set; }
        public decimal? miMonthlyPaymentLevel1 { get; set; }
        public decimal? miMonthlyPaymentLevel2 { get; set; }
        public string calculateBasedOnRemainingBalance { get; set; }
        public decimal? MarginPlusIndexPercent { get; set; }
        public bool? usePitiForRatioIndicator { get; set; }
        public string lateChargeComments { get; set; }
        public decimal? minimumPayment { get; set; }
        public decimal? maximumPayment { get; set; }
        public string yearOfMaximumPayment { get; set; }
        public decimal? samplePayments { get; set; }
        public string armDisclosureDescription { get; set; }
        public DateTime? finalPaymentDate { get; set; }
        public DateTime? firstAmortizationPaymentDate { get; set; }
        public bool? acquisition { get; set; }
        public string namePreparedBy { get; set; }
        public string phonePreparedBy { get; set; }
        public string acknowledgedDay { get; set; }
        public string acknowledgedMonth { get; set; }
        public string acknowledgedYear { get; set; }
        public string regzTableType { get; set; }
        public string useDaysInYears { get; set; }
        public string constructionLoanMethod { get; set; }
        public decimal? discountRatePercent { get; set; }
        public int? discountPeriod { get; set; }
        public string discountType { get; set; }
        public string newConstructionIndicator { get; set; }
        public DateTime? originalContractDate { get; set; }
        public string interestRateType { get; set; }
        public decimal? lendersInspectionFee { get; set; }
        public decimal? minimumLateCharge { get; set; }
        public decimal? maximumLateCharge { get; set; }
        public bool? miPrepaidIndicator { get; set; }
        public bool? interestOnlyIndicator { get; set; }
        public decimal? disclosedAprPercent { get; set; }
        public DateTime? tilDate { get; set; }
        public bool? disclosedByBrokerIndicator { get; set; }
        public DateTime? lastDisclosedDate { get; set; }
        public string disclosureMethod { get; set; }
        public string lastDisclosedBy { get; set; }
        public DateTime? gfeExpirationDate { get; set; }
        public string disclosedComments { get; set; }
        public DateTime? gfeApplicationDate { get; set; }
        public DateTime? initialDisclosureDueDate { get; set; }
        public DateTime? initialDisclosureProvidedDate { get; set; }
        public DateTime? earliestFeeCollectionDate { get; set; }
        public DateTime? feeCollectedDate { get; set; }
        public DateTime? earliestClosingDate { get; set; }
        public DateTime? initialGfeDisclosureProvidedDate { get; set; }
        public DateTime? initialGfeDisclosureReceivedDate { get; set; }
        public DateTime? gfeRedisclosureProvidedDate { get; set; }
        public DateTime? gfeRedisclosureReceivedDate { get; set; }
        public DateTime? initialTilDisclosureProvidedDate { get; set; }
        public DateTime? initialTilDisclosureReceivedDate { get; set; }
        public DateTime? tilRedisclosureProvidedDate { get; set; }
        public DateTime? tilRedisclosureReceivedDate { get; set; }
        public DateTime? tilLastDisclosedDate { get; set; }
        public DateTime? tilLastDisclosedBorrowerReceivedDate { get; set; }
        public string tilDisclosureMethod { get; set; }
        public string tilLastDisclosedBy { get; set; }
        public string tilDisclosedComments { get; set; }
        public bool? hud1ToleranceViolatedIndicator { get; set; }
        public DateTime? rateLockGfeDueDate { get; set; }
        public string gfeExpirationPeriod { get; set; }
        public DateTime? lastDisclosedGfeReceivedDate { get; set; }
        public bool? borrowerIntendToContinueIndicator { get; set; }
        public DateTime? circumstanceChangeReceivedDate { get; set; }
        public string circumstanceChangeReason { get; set; }
        public DateTime? revisedGfeDueDate { get; set; }
        public bool? gfeChangedCircumstanceIndicator { get; set; }
        public string gfeChangedCircumstanceItem { get; set; }
        public string gFEChangedCirsumstanceItemCode { get; set; }
        public DateTime? gfeDate { get; set; }
        public DateTime? hudToleranceResolutionDate { get; set; }
        public string hudToleranceResolutionComments { get; set; }
        public string hudToleranceResolvedBy { get; set; }
        public DateTime? borrowerIntendToContinueDate { get; set; }
        public bool? gfeRateLockRedisclosureRequiredIndicator { get; set; }
        public bool? miDecliningRenewalsIndicator { get; set; }
        public bool? refundUnearnedMipIndicator { get; set; }
        public bool? chargesAddedToPaymentsIndicator { get; set; }
        public bool? chargesAtLoanClosingIndicator { get; set; }
        public bool? lenderPaidMortgageInsuranceIndicator { get; set; }
        public bool? mIPFactorLocked { get; set; }
        public decimal? mIPrepaidAmount { get; set; }
        public DateTime? lESentOnDate { get; set; }
        public string lEReceivedBy { get; set; }
        public string lEReceivedMethod { get; set; }
        public string lEReceivedMethodOther { get; set; }
        public string lEIntentToProceedComment { get; set; }
        public DateTime? closingDisclosureSentDate { get; set; }
        public DateTime? closingDisclosureReceivedDate { get; set; }
        public DateTime? revisedClosingDisclosureSentDate { get; set; }
        public DateTime? revisedClosingDisclosureReceivedDate { get; set; }
        public DateTime? postConsummationDisclosureSentDate { get; set; }
        public DateTime? postConsummationDisclosureReceivedDate { get; set; }
        public DateTime? eSignConsentDate { get; set; }
        public string eSignConsentBorrowerStatus1 { get; set; }
        public DateTime? eSignConsentBorrowerDateAccepted1 { get; set; }
        public string eSignConsentBorrowerIPAddress1 { get; set; }
        public string eSignConsentBorrowerSource1 { get; set; }
        public string eSignConsentCoBorrowerStatus1 { get; set; }
        public DateTime? eSignConsentCoBorrowerDateAccepted1 { get; set; }
        public string eSignConsentCoBorrowerIPAddress1 { get; set; }
        public string eSignConsentCoBorrowerSource1 { get; set; }
        public string eSignConsentBorrowerStatus2 { get; set; }
        public DateTime? eSignConsentBorrowerDateAccepted2 { get; set; }
        public string eSignConsentBorrowerIPAddress2 { get; set; }
        public string eSignConsentBorrowerSource2 { get; set; }
        public string eSignConsentCoBorrowerStatus2 { get; set; }
        public DateTime? eSignConsentCoBorrowerDateAccepted2 { get; set; }
        public string eSignConsentCoBorrowerIPAddress2 { get; set; }
        public string eSignConsentCoBorrowerSource2 { get; set; }
        public string eSignConsentBorrowerStatus3 { get; set; }
        public DateTime? eSignConsentBorrowerDateAccepted3 { get; set; }
        public string eSignConsentBorrowerIPAddress3 { get; set; }
        public string eSignConsentBorrowerSource3 { get; set; }
        public string eSignConsentCoBorrowerStatus3 { get; set; }
        public DateTime? eSignConsentCoBorrowerDateAccepted3 { get; set; }
        public string eSignConsentCoBorrowerIPAddress3 { get; set; }
        public string eSignConsentCoBorrowerSource3 { get; set; }
        public string eSignConsentBorrowerStatus4 { get; set; }
        public DateTime? eSignConsentBorrowerDateAccepted4 { get; set; }
        public string eSignConsentBorrowerIPAddress4 { get; set; }
        public string eSignConsentBorrowerSource4 { get; set; }
        public string eSignConsentCoBorrowerStatus4 { get; set; }
        public DateTime? eSignConsentCoBorrowerDateAccepted4 { get; set; }
        public string eSignConsentCoBorrowerIPAddress4 { get; set; }
        public string eSignConsentCoBorrowerSource4 { get; set; }
        public string eSignConsentBorrowerStatus5 { get; set; }
        public DateTime? eSignConsentBorrowerDateAccepted5 { get; set; }
        public string eSignConsentBorrowerIPAddress5 { get; set; }
        public string eSignConsentBorrowerSource5 { get; set; }
        public string eSignConsentCoBorrowerStatus5 { get; set; }
        public DateTime? eSignConsentCoBorrowerDateAccepted5 { get; set; }
        public string eSignConsentCoBorrowerIPAddress5 { get; set; }
        public string eSignConsentCoBorrowerSource5 { get; set; }
        public string eSignConsentBorrowerStatus6 { get; set; }
        public DateTime? eSignConsentBorrowerDateAccepted6 { get; set; }
        public string eSignConsentBorrowerIPAddress6 { get; set; }
        public string eSignConsentBorrowerSource6 { get; set; }
        public string eSignConsentCoBorrowerStatus6 { get; set; }
        public DateTime? eSignConsentCoBorrowerDateAccepted6 { get; set; }
        public string eSignConsentCoBorrowerIPAddress6 { get; set; }
        public string eSignConsentCoBorrowerSource6 { get; set; }
        public decimal? totalOfPrincipalAndInterest { get; set; }
        public DateTime? sSPLSentDate { get; set; }
        public DateTime? safeHarborSentDate { get; set; }
        public DateTime? occupancyCertDate { get; set; }
        public bool? includeTaxesInsuranceIndicator { get; set; }
        public bool? includePmiIndicator { get; set; }
        public bool? includeMiIndicator { get; set; }
        public List<RegulationZInterestRatePeriod> regulationZInterestRatePeriods { get; set; }
        public DateTime? dueDate { get; set; }
        public decimal? outstandingBalance { get; set; }
        public string paymentFrequencyType { get; set; }
        public decimal? roundedMarginPlusIndexPercent { get; set; }
        public decimal? totalBrokerFees { get; set; }
        public decimal? totalLenderFees { get; set; }
        public decimal? disclosedFinanceCharge { get; set; }
        public string disclosedProduct { get; set; }
        public bool? disclosedPrepayment { get; set; }
        public decimal? disclosedDailyInterestCharge { get; set; }
        public DateTime? highCostDisclosure { get; set; }
        public DateTime? initialGfeAffiliatedBusinessProvidedDate { get; set; }
        public DateTime? initialGfeCharmBookletProvidedDate { get; set; }
        public DateTime? initialGfeHudSpecialBookletProvidedDate { get; set; }
        public DateTime? initialGfeHelocBrochureProvidedDate { get; set; }
        public DateTime? pmiMidpointCancelationDate { get; set; }
        public decimal? financedAllGuaranteeFeePercent { get; set; }
        public decimal? financedAllGuaranteeFeeAmount { get; set; }
        public decimal? financedAllTotalLoanAmount { get; set; }
        public decimal? financedPortionGuaranteeFeePercent { get; set; }
        public decimal? financedPortionGuaranteeFeeAmount { get; set; }
        public decimal? financedPortionTotalLoanAmount { get; set; }
        public string financingType { get; set; }
        public DateTime? initialGFEAppraisalProvidedDate { get; set; }
        public bool? useCustomLenderProfile { get; set; }
        public DateTime? initialSubsequentAppraisalProvidedDate { get; set; }
        public DateTime? initialAVMProvidedDate { get; set; }
        public DateTime? homeCounselingProvidedDate { get; set; }
        public decimal? lateFee { get; set; }
        public decimal? totalLatePayment { get; set; }
        public bool? interestOnly { get; set; }
        public decimal? paymentIncreasePercent { get; set; }
        public bool? constructionRefinanceIndicator { get; set; }
        public string constructionFirstIntChangeAdjType { get; set; }
        public string id { get; set; }



        
    }
}
