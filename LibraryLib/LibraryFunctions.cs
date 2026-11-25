using System;
using System.Collections.Generic;

namespace LibraryLib
{
    public class LibraryFunctions
    {
        // Храним основные данные о библиотеке и начальный список сотрудников
        private static string libraryName = "Городская библиотека г.Чита";
        private static string chiefLibrarian = "Иванова Мария Петровна";
        private static List<string> staffList = new List<string>
        {
            "Петров П.С.",
            "Сидорова А.В.",
            "Козлов И.Д.",
            "Иванова М.П."
        };

        // Возвращает ФИО главного библиотекаря
        public static string GetChiefLibrarian()
        {
            return chiefLibrarian;
        }

        // Возвращает название библиотеки
        public static string GetLibraryName()
        {
            return libraryName;
        }

        // Назначает нового главного библиотекаря, если он числится в списке сотрудников
        public static bool SetChiefLibrarian(string fullname)
        {
            if (string.IsNullOrWhiteSpace(fullname))
            {
                return false;
            }

            if (staffList.Contains(fullname))
            {
                chiefLibrarian = fullname;
                return true;
            }

            return false;
        }

        // Формирует код книги в формате КАТЕГОРИЯ_НОМЕР
        public static string GenerateBookCode(string category, int number)
        {
            string formattedCategory = string.IsNullOrWhiteSpace(category) ? "GEN" : category.Trim().ToUpper();
            return $"{formattedCategory}_{number}";
        }

        // Возвращает копию списка сотрудников, чтобы его нельзя было случайно изменить извне
        public static List<string> GetStaff()
        {
            return new List<string>(staffList);
        }

        // Добавляет сотрудника с переданным ФИО (основной рабочий вариант)
        public static bool AddStaff(string fullname)
        {
            if (string.IsNullOrWhiteSpace(fullname) || staffList.Contains(fullname))
            {
                return false;
            }

            staffList.Add(fullname);
            return true;
        }

        // Перегрузка без параметров строго по буквальной записи из ТЗ
        public static void AddStaff()
        {
            staffList.Add($"Сотрудник_{staffList.Count + 1}");
        }
    }
}
