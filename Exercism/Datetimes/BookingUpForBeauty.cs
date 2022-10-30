using System;

namespace Datetimes
{
  static class Appointment
  {
    public static DateTime Schedule(string appointmentDateDescription)
    {
      DateTime dt;
      if (DateTime.TryParse(appointmentDateDescription, out dt))
      {
        return dt;
      }
      else
      {
        return DateTime.Now;
      }
    }

    public static bool HasPassed(DateTime appointmentDate)
    {
      return appointmentDate < DateTime.Now;
    }

    public static bool IsAfternoonAppointment(DateTime appointmentDate)
    {
      var sameDay = appointmentDate.Date;
      var begin = new DateTime(sameDay.Year, sameDay.Month, sameDay.Day, 12, 0, 0);
      var end = new DateTime(sameDay.Year, sameDay.Month, sameDay.Day, 18, 0, 0);
      return (begin <= appointmentDate && appointmentDate < end);
    }

    public static string Description(DateTime appointmentDate)
    {
      string time = appointmentDate.ToString("M/d/yyyy h:mm:ss tt");
      return $"You have an appointment on {time}.";
    }

    public static DateTime AnniversaryDate()
    {
      var thisYear = DateTime.Now.Year;
      return new DateTime(thisYear, 9, 15);
    }
  }
}

