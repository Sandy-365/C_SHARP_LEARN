/*
Create the following ENTITY CLASS (must be created):
Class Name: PatientBill
•	BillId (string) — unique identifier (example: BILL1001)
•	PatientName (string)
•	HasInsurance (bool) — true if the patient is insured
•	ConsultationFee (decimal)
•	LabCharges (decimal)
•	MedicineCharges (decimal)
•	GrossAmount (decimal) — calculated (not typed by user)
•	DiscountAmount (decimal) — calculated (not typed by user)
•	FinalPayable (decimal) — calculated (not typed by user)
*/

class PatientBill
{
    public string BillId;
    public string PatientName;
    public bool HasInsurance;
    public decimal ConsultationFee;
    public decimal LabCharges;
    public decimal MedicineCharges;
    public decimal GrossAmount;
    public decimal DiscountAmount;
    public decimal FinalPayable;
    public PatientBill()
    {
        BillId = "BILL1001";
        PatientName = "Sandeep Kumar";
        HasInsurance = true;

        ConsultationFee = 500.00m;
        LabCharges = 1200.00m;
        MedicineCharges = 800.00m;
        GrossAmount = 2500.00m;
        DiscountAmount = 500.00m;
        FinalPayable = 2000.00m;
    }


    /*
    Compute the billing amounts using the following rules (keep the logic simple):
    5.	GrossAmount = ConsultationFee + LabCharges + MedicineCharges
    6.	If HasInsurance is true, apply a 10% discount on GrossAmount (DiscountAmount = GrossAmount * 0.10)
    7.	If HasInsurance is false, DiscountAmount = 0
    8.	FinalPayable = GrossAmount - DiscountAmount
    9.	Round displayed monetary values to 2 decimal places
    */
    public void calcGrossAmount()
    {
        GrossAmount = ConsultationFee + LabCharges + MedicineCharges;
    }

    public void calcDiscountAmount()
    {
        if (HasInsurance)
        {
            DiscountAmount = GrossAmount * 0.10m;
        }
        else
        {
            DiscountAmount = GrossAmount;
        }
    }

    public void calcFinalPayable()
    {
        FinalPayable = GrossAmount - DiscountAmount;
    }
}
