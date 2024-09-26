using Lesson8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8.Presenters;

internal class RestaurantPresenter
{
    public RestaurantPresenter(IRestaurant restaurant, IRestaurantView view)
    {
        _Restaurant = restaurant;
        _View = view;
    }

    public void Run()
    {
        List<string> menu =
            [
                "1 - Список столов",
                "2 - Список заказов (зарезервированных столов)",
                "3 - Добавить заказ",
                "0 - Выход"
            ];

        do
        {
            string userInputStr = _View.ShowMenu(menu);
            int userInput;
            if (!Int32.TryParse(userInputStr, out userInput)) continue;
            if (userInput < 0) continue;
            if (userInput == 0) break;

            switch (userInput)
            {
                case 1: GetAllTables(); break;
                case 2: GetAllReservations(); break;
                case 3: AddReservation(); break;
                default:
                    break;
            }

        } while (true);
    }

    private void GetAllTables()
    {
        _View.PrintLines(_Restaurant.GetAllTables().Select(it=>it.ToString()).ToList());
        _View.PrintLines(["\n Нажмите клавишу <Enter>"]);
        _View.GetUserInput();
    }

    private void GetAllReservations()
    {
        _View.PrintLines(_Restaurant.GetAllReservations().Select(it => it.ToString()).ToList());
        _View.PrintLines(["\n Нажмите клавишу <Enter>"]);
        _View.GetUserInput();
    }

    /// <summary>
    /// Резервирование столика
    /// </summary>
    private void AddReservation()
    {        
        _View.PrintLines(["Введите ваше имя:"]);
        string name = _View.GetUserInput();

        _View.PrintLines(["Введите номер столика:"]);
        if(!Int32.TryParse(_View.GetUserInput(), out int tableNumber))
        {
            _View.PrintLines(["Неверный номер столика!"]);
            _View.GetUserInput();
            return;
        }
        Table table = null;
        foreach (var item in _Restaurant.GetAllTables())
        {
            if (item.Number == tableNumber)
            {
                table = item;
                break;
            }
        }
        if (table == null) {
            _View.PrintLines(["Неверный номер столика!"]);
            _View.GetUserInput();
            return;
        }

        _View.PrintLines(["Введите дату и время бронирования:"]);
        if (!DateTime.TryParse(_View.GetUserInput(), out DateTime dateTime))
        {
            _View.PrintLines(["Неверный формат даты и времени!"]);
            _View.GetUserInput();
            return;
        }
        Reservation reservation = new() {
            Name = name,
            DurationInHours = 2,
            Table = table,
            Date = dateTime
        };
        try
        {
            _Restaurant.AddReservation(reservation);
        }
        catch (Exception ex) {
            _View.PrintLines(["Невозможно созSдать заказ с данными параметрами!"]);
            _View.GetUserInput();
            return;
        }
        _View.PrintLines(["Резервирование столика прошло успешно!"]);
        _View.GetUserInput();
    }

    private IRestaurant _Restaurant;
    private IRestaurantView _View;
}

