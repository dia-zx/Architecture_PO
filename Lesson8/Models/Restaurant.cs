using Lesson8.Presenters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8.Models;

internal class Restaurant : IRestaurant
{
    public Restaurant()
    {
        _Tables = Enumerable.Range(1, 5).Select(i => new Table() { Number = i, Description = $"столик с номером {i}" }).ToList();
        _Reservations = Enumerable.Range(1, 10)
            .Select(
            i => new Reservation()
            {
                Name = $"Имя{i}",
                DurationInHours = 2,
                Date = DateTime.Now.AddDays(i).AddHours(8 + i),
                Table = _Tables[i % 5]
            }).ToList();
    }
    public IEnumerable<Table> GetAllTables() => _Tables;
    public IEnumerable<Reservation> GetAllReservations() => _Reservations;

    /// <summary>
    /// выдать все заказы на указанную дату
    /// </summary>
    public IEnumerable<Reservation> GetReservationsOnDate(DateOnly date) => _Reservations.FindAll(x => x.Date.Date == date.ToDateTime(new TimeOnly())).ToList();

    /// <summary>
    /// Выдать все заказы на заданный интевал времени
    /// </summary>
    /// <param name="date"> начало интервала</param>
    /// <param name="duration"> длительность интервала в часах</param>
    public IEnumerable<Reservation> GetReservationsOnDateTime(DateTime date, int duration)
    {
        return _Reservations.FindAll(
            x =>
            {
                return x.Date < date && x.Date.AddHours(x.DurationInHours) > date
                || x.Date < date.AddHours(duration) && x.Date.AddHours(x.DurationInHours) > date.AddHours(duration);
            }
        ).ToList();
    }

    /// <summary>
    /// Добавление заказа на столик если он свободен
    /// </summary>
    /// <param name="reservation"></param>
    /// <exception cref="Exception">занято</exception>
    public void AddReservation(Reservation reservation)
    {
        foreach (var order in GetReservationsOnDateTime(reservation.Date, reservation.DurationInHours))
        {
            if (order.Table != reservation.Table) continue; //в заказах разные столики
            throw new Exception("На указанное время данный столик уже занят!");
        }
        _Reservations.Add(reservation);
    }


    private List<Table> _Tables = [];
    private List<Reservation> _Reservations = [];

}

