using System;

class PriceChangeAlert
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());



        double granica = double. Parse(Console.ReadLine());


        double last = double.Parse(Console.ReadLine());

        for (int i = 0; i < n - 1; i++) {
            double c = double.Parse(Console.ReadLine());
            double div = Proc(last, c); bool isSignificantDifference = imaliDif(div, granica);



            string message = Get(c, last, div, isSignificantDifference);
            Console.WriteLine(message);

            last = c; }             }

    private static string Get(double c, double last, double razlika, bool etherTrueOrFalse)






    {   string to = "";
        if (razlika == 0)
                                                            {
                                                                to = string.Format("NO CHANGE: {0}", c);
                                                            }
        else if (!etherTrueOrFalse){
            to = string.Format("MINOR CHANGE: {0} to {1} ({2:F2}%)", last, c, razlika);}
        else if (etherTrueOrFalse && (razlika > 0))
{
to = string.Format("PRICE UP: {0} to {1} ({2:F2}%)", last, c, razlika);
}
        else if (etherTrueOrFalse && (razlika < 0))
to = string.Format("PRICE DOWN: {0} to {1} ({2:F2}%)", last, c, razlika);
        return to;}
        private static bool imaliDif(double granica, double isDiff)
        {
        if (Math.Abs(granica) >= isDiff)
        {
        return true;
        }
        return false;
        }

private static double Proc(double l, double c)
{
double r = (c - l) / l;
return r;
}
}
