namespace Hospital
{
    using System;
    class StartUp
    {
        static void Main(string[] args)
        {
            int dayCount = int.Parse(Console.ReadLine());
            int doctorCount = 7;
            int patientsTreated = 0;
            int patientsUntreated = 0;
            for (int i = 1; i <= dayCount; i++)
            {
                if (i % 3 == 0 && patientsUntreated > patientsTreated)
                {
                    doctorCount++;
                }
                int patientsAdmitted = int.Parse(Console.ReadLine());
                if (patientsAdmitted <= doctorCount)
                {
                    patientsTreated += patientsAdmitted;
                }
                else
                {
                    patientsTreated += doctorCount;
                    patientsUntreated += patientsAdmitted - doctorCount;
                }
            }
            Console.WriteLine($"Treated patients: {patientsTreated}.");
            Console.WriteLine($"Untreated patients: {patientsUntreated}.");
        }
    }
}