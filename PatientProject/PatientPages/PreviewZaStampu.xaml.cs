using System;
using System.Collections.Generic;
using System.IO;
using System.Windows;
using System.Windows.Documents;
using System.Windows.Documents.Serialization;
using System.Windows.Media;
using System.Windows.Xps;
using System.Windows.Xps.Packaging;

namespace PatientProject.PatientPages
{
    /// <summary>
    /// Interaction logic for PreviewZaStampu.xaml
    /// </summary>
    public partial class PreviewZaStampu : Window
    {
        public static int prev = DateTime.Today.Month;
        public static int previousMonth =  prev - 1; // prethodni mesec
        public static int currentMonth = DateTime.Today.Month; // trenutni mesec
        public static int currentYear = DateTime.Today.Year; // trenutna godina
        public static DateTime selectedDay = DateTime.Today;

        private static List<CalendarDataTherapy> calendarDataList = new List<CalendarDataTherapy>();

        public class Days
        {
            public Visibility visible { get; set; }  // vidljivost
            public DateTime date { get; set; } // dan na koji se odnosi
            public string name { get; set; } // broj
            public string text { get; set; } // tekst koji ce stojati
            public FontWeight weight { get; set; } // velicina slova
            public SolidColorBrush dayColor { get; set; } // posebne boje za odmore, radno vreme i slicno 
        }

        public PreviewZaStampu()
        {
            InitializeComponent();


            calendarDataList = new List<CalendarDataTherapy>();

            calendarDataList.Add(new CalendarDataTherapy { Date = new DateTime(2020, 6, 1), Lek = "Lek1" });
            calendarDataList.Add(new CalendarDataTherapy { Date = new DateTime(2020, 6, 2), Lek = "Lek1" });
            calendarDataList.Add(new CalendarDataTherapy { Date = new DateTime(2020, 6, 3), Lek = "Lek1" });
            calendarDataList.Add(new CalendarDataTherapy { Date = new DateTime(2020, 6, 4), Lek = "Lek1" });

            calendarDataList.Add(new CalendarDataTherapy { Date = new DateTime(2020, 6, 5), Lek = "Lek2" });
            calendarDataList.Add(new CalendarDataTherapy { Date = new DateTime(2020, 6, 6), Lek = "Lek2" });
            calendarDataList.Add(new CalendarDataTherapy { Date = new DateTime(2020, 6, 7), Lek = "Lek2" });
            calendarDataList.Add(new CalendarDataTherapy { Date = new DateTime(2020, 6, 8), Lek = "Lek2" });

            calendarDataList.Add(new CalendarDataTherapy { Date = new DateTime(2020, 6, 9), Lek = "Lek3" });
            calendarDataList.Add(new CalendarDataTherapy { Date = new DateTime(2020, 6, 10), Lek = "Lek3" });
            calendarDataList.Add(new CalendarDataTherapy { Date = new DateTime(2020, 6, 11), Lek = "Lek3" });
            calendarDataList.Add(new CalendarDataTherapy { Date = new DateTime(2020, 6, 12), Lek = "Lek3" });
            calendarDataList.Add(new CalendarDataTherapy { Date = new DateTime(2020, 6, 13), Lek = "Lek3" });

            calendarDataList.Add(new CalendarDataTherapy { Date = new DateTime(2020, 6, 14), Lek = "Lek4" });
            calendarDataList.Add(new CalendarDataTherapy { Date = new DateTime(2020, 6, 15), Lek = "Lek4" });
            calendarDataList.Add(new CalendarDataTherapy { Date = new DateTime(2020, 6, 16), Lek = "Lek4" });
            calendarDataList.Add(new CalendarDataTherapy { Date = new DateTime(2020, 6, 17), Lek = "Lek4" });
            calendarDataList.Add(new CalendarDataTherapy { Date = new DateTime(2020, 6, 18), Lek = "Lek4" });
            calendarDataList.Add(new CalendarDataTherapy { Date = new DateTime(2020, 6, 19), Lek = "Lek4" });
            calendarDataList.Add(new CalendarDataTherapy { Date = new DateTime(2020, 6, 20), Lek = "Lek4" });
            calendarDataList.Add(new CalendarDataTherapy { Date = new DateTime(2020, 6, 21), Lek = "Lek4" });
            calendarDataList.Add(new CalendarDataTherapy { Date = new DateTime(2020, 6, 22), Lek = "Lek4" });
            calendarDataList.Add(new CalendarDataTherapy { Date = new DateTime(2020, 6, 23), Lek = "Lek4" });
            calendarDataList.Add(new CalendarDataTherapy { Date = new DateTime(2020, 6, 24), Lek = "Lek4" });
            calendarDataList.Add(new CalendarDataTherapy { Date = new DateTime(2020, 6, 25), Lek = "Lek4" });
            calendarDataList.Add(new CalendarDataTherapy { Date = new DateTime(2020, 6, 26), Lek = "Lek4" });
            calendarDataList.Add(new CalendarDataTherapy { Date = new DateTime(2020, 6, 27), Lek = "Lek4" });

            calendarDataList.Add(new CalendarDataTherapy { Date = new DateTime(2020, 7, 5), Lek = "Lek5" });
            calendarDataList.Add(new CalendarDataTherapy { Date = new DateTime(2020, 7, 6), Lek = "Lek5" });
            calendarDataList.Add(new CalendarDataTherapy { Date = new DateTime(2020, 7, 7), Lek = "Lek5" });
            calendarDataList.Add(new CalendarDataTherapy { Date = new DateTime(2020, 7, 8), Lek = "Lek5" });
            calendarDataList.Add(new CalendarDataTherapy { Date = new DateTime(2020, 7, 9), Lek = "Lek5" });
            calendarDataList.Add(new CalendarDataTherapy { Date = new DateTime(2020, 7, 10), Lek = "Lek5" });
            calendarDataList.Add(new CalendarDataTherapy { Date = new DateTime(2020, 7, 11), Lek = "Lek5" });
            calendarDataList.Add(new CalendarDataTherapy { Date = new DateTime(2020, 7, 12), Lek = "Lek5" });


            SetDays();
        }

        public void SetDays()
        {
            DateTime firstDate = new DateTime(currentYear, currentMonth, 1);
            SetText();

            if ((int)firstDate.DayOfWeek == 1)
            {
                SetDaysFromMonday();
            }
            else if ((int)firstDate.DayOfWeek == 2)
            {
                SetDaysFromTuesday();
            }

            else if ((int)firstDate.DayOfWeek == 3)
            {
                SetDaysFromWednesday();
            }
            else if ((int)firstDate.DayOfWeek == 4)
            {
                SetDaysFromThrusday();
            }
            else if ((int)firstDate.DayOfWeek == 5)
            {
                SetDaysFromFriday();
            }
            else if ((int)firstDate.DayOfWeek == 6)
            {
                SetDaysFromSaturday();
            }
            else if ((int)firstDate.DayOfWeek == 0)
            {
                SetDaysFromSunday();
            }
        }
        private void SetDaysFromMonday()
        {
            int daysInMonth = DateTime.DaysInMonth(currentYear, currentMonth);
            int daysInPreviousMonth = DateTime.DaysInMonth(currentYear, previousMonth);
            List<Days> dayList = new List<Days>();
            DateTime firstDate = new DateTime(currentYear, previousMonth, daysInPreviousMonth);

            int i = 0;
            dayList.Add(new Days() { name = daysInPreviousMonth.ToString(), visible = Visibility.Visible, date = firstDate.AddDays(-1), weight = FontWeights.Light });
            while (i < daysInMonth)
            {
                Days day = null;
                firstDate = firstDate.AddDays(1);

                foreach (CalendarDataTherapy data in calendarDataList)
                {
                    if (DateTime.Compare(data.Date, firstDate) == 0)
                    {
                        day = new Days() { dayColor = data.color, text = data.Lek, date = firstDate, name = (++i).ToString(), visible = Visibility.Visible, weight = FontWeights.ExtraBold };
                    }
                }

                if (day == null)
                {
                    day = new Days() { date = firstDate, name = (++i).ToString(), visible = Visibility.Visible, weight = FontWeights.ExtraBold };

                }



                dayList.Add(day);
            }
            int j = 0;
            for (i = 0; i < (41 - daysInMonth); i++)
            {
                firstDate = firstDate.AddDays(1);
                dayList.Add(new Days() { date = firstDate.AddDays(1), name = (++j).ToString(), visible = Visibility.Visible, weight = FontWeights.Light });
            }



            Week1.ItemsSource = new List<Days>();
            Week1.ItemsSource = dayList.GetRange(0, 7);
            Week2.ItemsSource = new List<Days>();
            Week2.ItemsSource = dayList.GetRange(7, 7);
            Week3.ItemsSource = new List<Days>();
            Week3.ItemsSource = dayList.GetRange(14, 7);
            Week4.ItemsSource = new List<Days>();
            Week4.ItemsSource = dayList.GetRange(21, 7);
            Week5.ItemsSource = new List<Days>();
            Week5.ItemsSource = dayList.GetRange(28, 7);
            Week6.ItemsSource = new List<Days>();
            Week6.ItemsSource = dayList.GetRange(35, 7);
        }

        private void SetDaysFromTuesday()
        {
            int daysInMonth = DateTime.DaysInMonth(currentYear, currentMonth);
            int daysInPreviousMonth = DateTime.DaysInMonth(currentYear, previousMonth);
            List<Days> dayList = new List<Days>();
            DateTime firstDate = new DateTime(currentYear, previousMonth, daysInPreviousMonth);
            int i = 0;
            dayList.Add(new Days() { date = new DateTime(currentYear, previousMonth, daysInPreviousMonth - 1), name = (daysInPreviousMonth - 1).ToString(), visible = Visibility.Visible, weight = FontWeights.Light });
            dayList.Add(new Days() { date = new DateTime(currentYear, previousMonth, daysInPreviousMonth), name = daysInPreviousMonth.ToString(), visible = Visibility.Visible, weight = FontWeights.Light });

            while (i < daysInMonth)
            {
                Days day = null;

                firstDate = firstDate.AddDays(1);

                foreach (CalendarDataTherapy data in calendarDataList)
                {
                    if (DateTime.Compare(data.Date, firstDate) == 0)
                    {
                        day = new Days() { dayColor = data.color, text = data.Lek, date = firstDate, name = (++i).ToString(), visible = Visibility.Visible, weight = FontWeights.ExtraBold };
                    }
                }

                if (day == null)
                {
                    day = new Days() { date = firstDate, name = (++i).ToString(), visible = Visibility.Visible, weight = FontWeights.ExtraBold };

                }



                dayList.Add(day);


            }
            int j = 0;
            for (i = 0; i < (40 - daysInMonth); i++)
            {
                firstDate = firstDate.AddDays(1);
                dayList.Add(new Days() { date = firstDate.AddDays(1), name = (++j).ToString(), visible = Visibility.Visible, weight = FontWeights.Light });
            }


            Week1.ItemsSource = new List<Days>();
            Week1.ItemsSource = dayList.GetRange(0, 7);
            Week2.ItemsSource = new List<Days>();
            Week2.ItemsSource = dayList.GetRange(7, 7);
            Week3.ItemsSource = new List<Days>();
            Week3.ItemsSource = dayList.GetRange(14, 7);
            Week4.ItemsSource = new List<Days>();
            Week4.ItemsSource = dayList.GetRange(21, 7);
            Week5.ItemsSource = new List<Days>();
            Week5.ItemsSource = dayList.GetRange(28, 7);
            Week6.ItemsSource = new List<Days>();
            Week6.ItemsSource = dayList.GetRange(35, 7);
        }

        private void SetDaysFromWednesday()
        {

            int daysInMonth = DateTime.DaysInMonth(currentYear, currentMonth);
            int daysInPreviousMonth = DateTime.DaysInMonth(currentYear, previousMonth);
            List<Days> dayList = new List<Days>();
            DateTime firstDate = new DateTime(currentYear, previousMonth, daysInPreviousMonth);
            int i = 0;
            dayList.Add(new Days() { date = new DateTime(currentYear, previousMonth, daysInPreviousMonth - 2), name = (daysInPreviousMonth - 2).ToString(), visible = Visibility.Visible, weight = FontWeights.Light });
            dayList.Add(new Days() { date = new DateTime(currentYear, previousMonth, daysInPreviousMonth - 1), name = (daysInPreviousMonth - 1).ToString(), visible = Visibility.Visible, weight = FontWeights.Light });
            dayList.Add(new Days() { date = new DateTime(currentYear, previousMonth, daysInPreviousMonth), name = daysInPreviousMonth.ToString(), visible = Visibility.Visible, weight = FontWeights.Light });

            while (i < daysInMonth)
            {
                Days day = null;

                firstDate = firstDate.AddDays(1);

                foreach (CalendarDataTherapy data in calendarDataList)
                {
                    if (DateTime.Compare(data.Date, firstDate) == 0)
                    {
                        day = new Days() { dayColor = data.color, text = data.Lek, date = firstDate, name = (++i).ToString(), visible = Visibility.Visible, weight = FontWeights.ExtraBold };
                    }
                }

                if (day == null)
                {
                    day = new Days() { date = firstDate, name = (++i).ToString(), visible = Visibility.Visible, weight = FontWeights.ExtraBold };

                }



                dayList.Add(day);
            }
            int j = 0;
            for (i = 0; i < (39 - daysInMonth); i++)
            {
                firstDate = firstDate.AddDays(1);
                dayList.Add(new Days() { date = firstDate.AddDays(1), name = (++j).ToString(), visible = Visibility.Visible, weight = FontWeights.Light });
            }
            Week1.ItemsSource = new List<Days>();
            Week1.ItemsSource = dayList.GetRange(0, 7);
            Week2.ItemsSource = new List<Days>();
            Week2.ItemsSource = dayList.GetRange(7, 7);
            Week3.ItemsSource = new List<Days>();
            Week3.ItemsSource = dayList.GetRange(14, 7);
            Week4.ItemsSource = new List<Days>();
            Week4.ItemsSource = dayList.GetRange(21, 7);
            Week5.ItemsSource = new List<Days>();
            Week5.ItemsSource = dayList.GetRange(28, 7);
            Week6.ItemsSource = new List<Days>();
            Week6.ItemsSource = dayList.GetRange(35, 7);
        }

        private void SetDaysFromThrusday()
        {
            int daysInMonth = DateTime.DaysInMonth(currentYear, currentMonth);
            int daysInPreviousMonth = DateTime.DaysInMonth(currentYear, previousMonth);
            List<Days> dayList = new List<Days>();
            DateTime firstDate = new DateTime(currentYear, previousMonth, daysInPreviousMonth);
            int i = 0;
            dayList.Add(new Days() { date = new DateTime(currentYear, previousMonth, daysInPreviousMonth - 3), name = (daysInPreviousMonth - 3).ToString(), visible = Visibility.Visible, weight = FontWeights.Light });
            dayList.Add(new Days() { date = new DateTime(currentYear, previousMonth, daysInPreviousMonth - 2), name = (daysInPreviousMonth - 2).ToString(), visible = Visibility.Visible, weight = FontWeights.Light });
            dayList.Add(new Days() { date = new DateTime(currentYear, previousMonth, daysInPreviousMonth - 1), name = (daysInPreviousMonth - 1).ToString(), visible = Visibility.Visible, weight = FontWeights.Light });
            dayList.Add(new Days() { date = new DateTime(currentYear, previousMonth, daysInPreviousMonth), name = daysInPreviousMonth.ToString(), visible = Visibility.Visible, weight = FontWeights.Light });

            while (i < daysInMonth)
            {
                Days day = null;

                firstDate = firstDate.AddDays(1);

                foreach (CalendarDataTherapy data in calendarDataList)
                {
                    if (DateTime.Compare(data.Date, firstDate) == 0)
                    {
                        day = new Days() { dayColor = data.color, text = data.Lek, date = firstDate, name = (++i).ToString(), visible = Visibility.Visible, weight = FontWeights.ExtraBold };
                    }
                }

                if (day == null)
                {
                    day = new Days() { date = firstDate, name = (++i).ToString(), visible = Visibility.Visible, weight = FontWeights.ExtraBold };

                }



                dayList.Add(day);
            }
            int j = 0;
            for (i = 0; i < (38 - daysInMonth); i++)
            {
                firstDate = firstDate.AddDays(1);
                dayList.Add(new Days() { date = firstDate.AddDays(1), name = (++j).ToString(), visible = Visibility.Visible, weight = FontWeights.Light });
            }
            Week1.ItemsSource = new List<Days>();
            Week1.ItemsSource = dayList.GetRange(0, 7);
            Week2.ItemsSource = new List<Days>();
            Week2.ItemsSource = dayList.GetRange(7, 7);
            Week3.ItemsSource = new List<Days>();
            Week3.ItemsSource = dayList.GetRange(14, 7);
            Week4.ItemsSource = new List<Days>();
            Week4.ItemsSource = dayList.GetRange(21, 7);
            Week5.ItemsSource = new List<Days>();
            Week5.ItemsSource = dayList.GetRange(28, 7);
            Week6.ItemsSource = new List<Days>();
            Week6.ItemsSource = dayList.GetRange(35, 7);
        }

        private void SetDaysFromFriday()
        {
            int daysInMonth = DateTime.DaysInMonth(currentYear, currentMonth);
            int daysInPreviousMonth = DateTime.DaysInMonth(currentYear, previousMonth);
            List<Days> dayList = new List<Days>();
            DateTime firstDate = new DateTime(currentYear, previousMonth, daysInPreviousMonth);
            dayList.Add(new Days() { date = new DateTime(currentYear, previousMonth, daysInPreviousMonth - 4), name = (daysInPreviousMonth - 4).ToString(), visible = Visibility.Visible, weight = FontWeights.Light });
            dayList.Add(new Days() { date = new DateTime(currentYear, previousMonth, daysInPreviousMonth - 3), name = (daysInPreviousMonth - 3).ToString(), visible = Visibility.Visible, weight = FontWeights.Light });
            dayList.Add(new Days() { date = new DateTime(currentYear, previousMonth, daysInPreviousMonth - 2), name = (daysInPreviousMonth - 2).ToString(), visible = Visibility.Visible, weight = FontWeights.Light });
            dayList.Add(new Days() { date = new DateTime(currentYear, previousMonth, daysInPreviousMonth - 1), name = (daysInPreviousMonth - 1).ToString(), visible = Visibility.Visible, weight = FontWeights.Light });
            dayList.Add(new Days() { date = new DateTime(currentYear, previousMonth, daysInPreviousMonth), name = daysInPreviousMonth.ToString(), visible = Visibility.Visible, weight = FontWeights.Light });

            int i = 0;
            while (i < daysInMonth)
            {
                Days day = null;

                firstDate = firstDate.AddDays(1);

                foreach (CalendarDataTherapy data in calendarDataList)
                {
                    if (DateTime.Compare(data.Date, firstDate) == 0)
                    {
                        day = new Days() { dayColor = data.color, text = data.Lek, date = firstDate, name = (++i).ToString(), visible = Visibility.Visible, weight = FontWeights.ExtraBold };
                    }
                }

                if (day == null)
                {
                    day = new Days() { date = firstDate, name = (++i).ToString(), visible = Visibility.Visible, weight = FontWeights.ExtraBold };

                }



                dayList.Add(day);
            }
            int j = 0;
            for (i = 0; i < (37 - daysInMonth); i++)
            {
                firstDate = firstDate.AddDays(1);
                dayList.Add(new Days() { date = firstDate.AddDays(1), name = (++j).ToString(), visible = Visibility.Visible, weight = FontWeights.Light });
            }
            Week1.ItemsSource = new List<Days>();
            Week1.ItemsSource = dayList.GetRange(0, 7);
            Week2.ItemsSource = new List<Days>();
            Week2.ItemsSource = dayList.GetRange(7, 7);
            Week3.ItemsSource = new List<Days>();
            Week3.ItemsSource = dayList.GetRange(14, 7);
            Week4.ItemsSource = new List<Days>();
            Week4.ItemsSource = dayList.GetRange(21, 7);
            Week5.ItemsSource = new List<Days>();
            Week5.ItemsSource = dayList.GetRange(28, 7);
            Week6.ItemsSource = new List<Days>();
            Week6.ItemsSource = dayList.GetRange(35, 7);
        }
        private void SetDaysFromSaturday()
        {
            int daysInMonth = DateTime.DaysInMonth(currentYear, currentMonth);
            int daysInPreviousMonth = DateTime.DaysInMonth(currentYear, previousMonth);
            List<Days> dayList = new List<Days>();
            DateTime firstDate = new DateTime(currentYear, previousMonth, daysInPreviousMonth);
            int i = 0;
            dayList.Add(new Days() { date = new DateTime(currentYear, previousMonth, daysInPreviousMonth - 5), name = (daysInPreviousMonth - 5).ToString(), visible = Visibility.Visible, weight = FontWeights.Light });
            dayList.Add(new Days() { date = new DateTime(currentYear, previousMonth, daysInPreviousMonth - 4), name = (daysInPreviousMonth - 4).ToString(), visible = Visibility.Visible, weight = FontWeights.Light });
            dayList.Add(new Days() { date = new DateTime(currentYear, previousMonth, daysInPreviousMonth - 3), name = (daysInPreviousMonth - 3).ToString(), visible = Visibility.Visible, weight = FontWeights.Light });
            dayList.Add(new Days() { date = new DateTime(currentYear, previousMonth, daysInPreviousMonth - 2), name = (daysInPreviousMonth - 2).ToString(), visible = Visibility.Visible, weight = FontWeights.Light });
            dayList.Add(new Days() { date = new DateTime(currentYear, previousMonth, daysInPreviousMonth - 1), name = (daysInPreviousMonth - 1).ToString(), visible = Visibility.Visible, weight = FontWeights.Light });
            dayList.Add(new Days() { date = new DateTime(currentYear, previousMonth, daysInPreviousMonth), name = daysInPreviousMonth.ToString(), visible = Visibility.Visible, weight = FontWeights.Light });

            while (i < daysInMonth)
            {
                Days day = null;

                firstDate = firstDate.AddDays(1);

                foreach (CalendarDataTherapy data in calendarDataList)
                {
                    if (DateTime.Compare(data.Date, firstDate) == 0)
                    {
                        day = new Days() { dayColor = data.color, text = data.Lek, date = firstDate, name = (++i).ToString(), visible = Visibility.Visible, weight = FontWeights.ExtraBold };
                    }
                }

                if (day == null)
                {
                    day = new Days() { date = firstDate, name = (++i).ToString(), visible = Visibility.Visible, weight = FontWeights.ExtraBold };

                }


                dayList.Add(day);
            }
            int j = 0;
            for (i = 0; i < (36 - daysInMonth); i++)
            {
                firstDate = firstDate.AddDays(1);
                dayList.Add(new Days() { date = firstDate.AddDays(1), name = (++j).ToString(), visible = Visibility.Visible, weight = FontWeights.Light });
            }
            Week1.ItemsSource = new List<Days>();
            Week1.ItemsSource = dayList.GetRange(0, 7);
            Week2.ItemsSource = new List<Days>();
            Week2.ItemsSource = dayList.GetRange(7, 7);
            Week3.ItemsSource = new List<Days>();
            Week3.ItemsSource = dayList.GetRange(14, 7);
            Week4.ItemsSource = new List<Days>();
            Week4.ItemsSource = dayList.GetRange(21, 7);
            Week5.ItemsSource = new List<Days>();
            Week5.ItemsSource = dayList.GetRange(28, 7);
            Week6.ItemsSource = new List<Days>();
            Week6.ItemsSource = dayList.GetRange(35, 7);

        }
        private void SetDaysFromSunday()
        {
            int daysInMonth = DateTime.DaysInMonth(currentYear, currentMonth);
            int daysInPreviousMonth = DateTime.DaysInMonth(currentYear, previousMonth);
            List<Days> dayList = new List<Days>();
            DateTime firstDate = new DateTime(currentYear, previousMonth, daysInPreviousMonth);
            int i = 0;

            while (i < daysInMonth)
            {
                Days day = null;

                firstDate = firstDate.AddDays(1);

                foreach (CalendarDataTherapy data in calendarDataList)
                {
                    if (DateTime.Compare(data.Date, firstDate) == 0)
                    {
                        day = new Days() { dayColor = data.color, text = data.Lek, date = firstDate, name = (++i).ToString(), visible = Visibility.Visible, weight = FontWeights.ExtraBold };
                    }
                }

                if (day == null)
                {
                    day = new Days() { date = firstDate, name = (++i).ToString(), visible = Visibility.Visible, weight = FontWeights.ExtraBold };

                }



                dayList.Add(day);
            }
            int j = 0;
            for (i = 0; i < (42 - daysInMonth); i++)
            {
                firstDate = firstDate.AddDays(1);
                dayList.Add(new Days() { date = firstDate.AddDays(1), name = (++j).ToString(), visible = Visibility.Visible, weight = FontWeights.Light });
            }
            Week1.ItemsSource = new List<Days>();
            Week1.ItemsSource = dayList.GetRange(0, 7);
            Week2.ItemsSource = new List<Days>();
            Week2.ItemsSource = dayList.GetRange(7, 7);
            Week3.ItemsSource = new List<Days>();
            Week3.ItemsSource = dayList.GetRange(14, 7);
            Week4.ItemsSource = new List<Days>();
            Week4.ItemsSource = dayList.GetRange(21, 7);
            Week5.ItemsSource = new List<Days>();
            Week5.ItemsSource = dayList.GetRange(28, 7);
            Week6.ItemsSource = new List<Days>();
            Week6.ItemsSource = dayList.GetRange(35, 7);
        }



        private void SetText()
        {
            string text = "";
            if (currentMonth == 1)
            {
                text = "Januar " + currentYear.ToString();
            }
            if (currentMonth == 2)
            {
                text = "Februar " + currentYear.ToString();
            }
            if (currentMonth == 3)
            {
                text = "Mart " + currentYear.ToString();
            }
            if (currentMonth == 4)
            {
                text = "April " + currentYear.ToString();
            }
            if (currentMonth == 5)
            {
                text = "Maj " + currentYear.ToString();
            }
            if (currentMonth == 6)
            {
                text = "Jun " + currentYear.ToString();
            }
            if (currentMonth == 7)
            {
                text = "Jul " + currentYear.ToString();
            }
            if (currentMonth == 8)
            {
                text = "Avgust " + currentYear.ToString();
            }
            if (currentMonth == 9)
            {
                text = "Septembar " + currentYear.ToString();
            }
            if (currentMonth == 10)
            {
                text = "Oktobar " + currentYear.ToString();
            }
            if (currentMonth == 11)
            {
                text = "Novembar " + currentYear.ToString();
            }
            if (currentMonth == 12)
            {
                text = "Decembar " + currentYear.ToString();
            }
            CurrentMonth.Text = text;
        }


        private void btnLeftCalendar_Click(object sender, RoutedEventArgs e)
        {
            currentMonth--;
            previousMonth--;
            if (currentMonth == 13)
            {
                currentMonth = 1;
                previousMonth = 12;
                currentYear++;
            }
            else if (currentMonth == 0)
            {
                currentMonth = 12;
                previousMonth = 11;
                currentYear--;
            }
            else if (previousMonth == 0)
            {
                currentMonth = 1;
                previousMonth = 12;
            }

            Console.WriteLine(currentMonth);
            Console.WriteLine(previousMonth);


            Week1.ItemsSource = new List<Days>();
            Week2.ItemsSource = new List<Days>();
            Week3.ItemsSource = new List<Days>();
            Week4.ItemsSource = new List<Days>();
            Week5.ItemsSource = new List<Days>();
            Week6.ItemsSource = new List<Days>();
            SetDays();
        }

        private void btnRightCalendar_Click(object sender, RoutedEventArgs e)
        {
            currentMonth++;
            previousMonth++;
            if (currentMonth == 13)
            {
                currentMonth = 1;
                previousMonth = 12;
                currentYear++;
            }
            else if (currentMonth == 0)
            {
                currentMonth = 12;
                currentYear--;
            }
            else if (previousMonth == 13)
            {
                previousMonth = 1;
                currentMonth = 2;
            }



            Week1.ItemsSource = new List<Days>();
            Week2.ItemsSource = new List<Days>();
            Week3.ItemsSource = new List<Days>();
            Week4.ItemsSource = new List<Days>();
            Week5.ItemsSource = new List<Days>();
            Week6.ItemsSource = new List<Days>();
            SetDays();
        }

        private void print_Click(object sender, RoutedEventArgs e)
        {

            Print_WPF_Preview(gridStampa);
        }

        public void Print_WPF_Preview(FrameworkElement wpf_Element) {

            string sPrintFilename = "report.xps";
            if (File.Exists(sPrintFilename) == true) File.Delete(sPrintFilename);

            XpsDocument doc = new XpsDocument(sPrintFilename, FileAccess.ReadWrite);

            XpsDocumentWriter writer = XpsDocument.CreateXpsDocumentWriter(doc);

            SerializerWriterCollator outputDocument = writer.CreateVisualsCollator();
            outputDocument.BeginBatchWrite();
            outputDocument.Write(wpf_Element);
            outputDocument.EndBatchWrite();

            FixedDocumentSequence preview = doc.GetFixedDocumentSequence();

            //prozor koji trea da otvorimo
            //trea ga prikazati

            PrintWindow printWindow = new PrintWindow(preview);
            printWindow.Show();

            doc.Close();
            writer = null;
            outputDocument = null;
            doc = null; 

        }
    }
}
