public class Evaporator { 
  
  public static int evaporator(double content, double evap_per_day, double threshold) 
       {
        int days = 0;
        double thresholdPercentage = threshold / 100.0;
        double remainingPercentage = 1.0;

        while (remainingPercentage > thresholdPercentage)
        {
            remainingPercentage -= (remainingPercentage * (evap_per_day / 100.0));
            days++;
        }

        return days;
    }
}