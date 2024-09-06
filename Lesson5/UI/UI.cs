﻿using Lesson5.ProjectSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson5.UI
{
    internal class UI : IUI
    {
        private IProjectSettings _projectSettings;
        public void Init()
        {
            _projectSettings = new ProjectSettings.ProjectSettings();
        }

        public void Start()
        {
            do
            {
                string userInput = Menu();
                switch (userInput)
                {
                    case "0": return;
                    case "1": MenuLoad(); break;
                    case "2": MenuSave(); break;
                    case "3": MenuShowSettings(); break;
                    case "4": MenuShowObjects(); break;

                    default: break;
                }

            } while (true);
        }

        private string Menu()
        {
            Console.Clear();
            Console.WriteLine("****** 3D Редактор. Меню команд. *****");
            Console.WriteLine("     1 - Загрузка проекта");
            Console.WriteLine("     2 - Сохранение проекта");
            Console.WriteLine("     3 - Отображение настроек проекта");
            Console.WriteLine("     4 - Список объектов проекта");

            Console.WriteLine("     0 - Выход");
            Console.Write("Введите команду: ");
            return Console.ReadLine();
        }
        private void MenuSave()
        {
            Console.WriteLine("Введите название файла: ");
            string userInput = Console.ReadLine();
            _projectSettings.Path = userInput;
            try
            {
                _projectSettings.Save();
                Console.WriteLine("Настройки успешно сохранены!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            Console.WriteLine("Нажмите клавишу <Enter>.");
            Console.ReadLine();
        }

        private void MenuLoad()
        {
            Console.WriteLine("Введите название файла: ");
            string userInput = Console.ReadLine();
            _projectSettings.Path = userInput;
            try
            {
                _projectSettings.Load();
                Console.WriteLine("Настройки успешно загружены!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ошибка: " + ex.Message);
            }
            Console.WriteLine("Нажмите клавишу <Enter>.");
            Console.ReadLine();
        }

        private void MenuShowSettings()
        {
            Console.WriteLine("\n******** Настройки проекта *********");
            Console.WriteLine(_projectSettings);
            Console.WriteLine("Нажмите клавишу <Enter>.");
            Console.ReadLine();
        }

        private void MenuShowObjects()
        {

        }
    }
}
