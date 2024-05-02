namespace SQSV_lab_4
{
    public class TaxCalculate
    {
        public static float MONTHLY_REDUNDANT = 11000000;
        public static float DEPENDENT_REDUNDANT = 4400000;
        public static float MILLION = 1000000;
        public static float Calculate(float income, int dependentQty)
        {
            float taxableIncome = income - MONTHLY_REDUNDANT - DEPENDENT_REDUNDANT * dependentQty;
            float taxAmount = -1.0f;

            if (taxableIncome <= 0)
                taxAmount = 0;
            else if (taxableIncome >= 0 && taxableIncome <= 5000000)
                taxAmount = 0.05f * taxableIncome;
            else if (taxableIncome <= 10000000)
                taxAmount = 0.1f * taxableIncome - 0.25f * MILLION;
            else if (taxableIncome <= 18000000)
                taxAmount = 0.15f * taxableIncome - 0.75f * MILLION;
            else if (taxableIncome <= 32000000)
                taxAmount = 0.2f * taxableIncome - 1.65f * MILLION;
            else if (taxableIncome <= 52000000)
                taxAmount = 0.25f * taxableIncome - 3.25f * MILLION;
            else if (taxableIncome <= 80000000)
                taxAmount = 0.3f * taxableIncome - 5.85f * MILLION;
            else
                taxAmount = 0.35f * taxableIncome - 9.85f * MILLION;

            return taxAmount;
        }
    }
}
