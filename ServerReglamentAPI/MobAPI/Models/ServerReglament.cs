using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MobAPI.Models
{
    public class ServerReglament
    {
        
        public static string Status { set; get; }

        /// <summary>
        /// Дать статус сервера.
        /// </summary>
        /// <returns></returns>
        public static string CountServerReglament()
        {
            DatabaseReglamentCon context = new DatabaseReglamentCon();

            DateTime dateNow = DateTime.Now;
            string customFmt = "dd.MM.yyyy";
            string formatData = dateNow.ToString(customFmt);

            var ListReg = (from a in context.ReglamentTable select a).ToList();


            foreach (var item in ListReg)
            {
                System.Diagnostics.Debug.WriteLine("#=== " + item.data);
                if (formatData == item.data.ToString())
                {
                    Status = "Идут регламентные работы. Причина = " + item.info;
                    return dateNow.ToString(customFmt);

                }

            }

            foreach (var item in ListReg)
            {
                TimeSpan difference = dateNow - Convert.ToDateTime(item.data);

                // Предупреждение за день.
                if (difference.Days == 0)
                {
                    Status = "Скоро регламентные работы. Причина = " + item.info;
                    return "Запланированы работы: " + dateNow.ToString(item.data);

                }
                // Предупреждение за 2 дня.
                if (difference.Days == -1)
                {
                    Status = "Запланированы регламентные работы. Причина = " + item.info;
                    return "Запланированы работы: " + dateNow.ToString(item.data);

                }
            }

            Status = "Нормальный режим";
            return "Время сервера " + formatData;

        }
    }
}