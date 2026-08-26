public static class TimeFormat
{
    // defined to avoid magic numbers
    const int Hour = 3600;
    const int Minute = 60;
  
    public static string GetReadableTime(int seconds)
    {
        // totals in more readable format, manually done instead of using library
        int t_hours = seconds / Hour;
        int t_minutes = (seconds - (t_hours * Hour)) / Minute;
        int t_seconds =  (seconds - (t_hours * Hour) - (t_minutes * Minute)) % Minute;
      
        // final string representation
        return $"{t_hours:D2}:{t_minutes:D2}:{t_seconds:D2}";
    }
}
