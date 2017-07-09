using System;

class Hospital
{
    static void Main()
    {
        var period = int.Parse(Console.ReadLine());

        int treatedPatients = 0;
        int untreatedPatients = 0;
        int countOfDoctors = 7;

        for (int day = 1; day <= period; day++)
        {
            var currentPatients = int.Parse(Console.ReadLine());

            if ((day % 3 == 0) && (untreatedPatients > treatedPatients))
            {
                countOfDoctors++;
            }

            if (currentPatients > countOfDoctors)
            {
                treatedPatients += countOfDoctors;
                untreatedPatients += currentPatients - countOfDoctors;
            }
            else
            {
                treatedPatients += currentPatients;
            }
        }

        Console.WriteLine("Treated patients: {0}.", treatedPatients);
        Console.WriteLine("Untreated patients: {0}.", untreatedPatients);
    }
}

