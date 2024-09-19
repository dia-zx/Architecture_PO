using Lesson8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8.Presenters;

internal interface IRestaurant
{
    public IEnumerable<Table> GetAllTables();
    public IEnumerable<Reservation> GetAllReservations();

    /// <summary>
    /// выдать все заказы на указанную дату
    /// </summary>
    public IEnumerable<Reservation> GetReservationsOnDate(DateOnly date);

    /// <summary>
    /// Выдать все заказы на заданный интевал времени
    /// </summary>
    /// <param name="date"> начало интервала</param>
    /// <param name="duration"> длительность интервала в часах</param>
    public IEnumerable<Reservation> GetReservationsOnDateTime(DateTime date, int duration);

    /// <summary>
    /// Добавление заказа на столик если он свободен
    /// </summary>
    /// <param name="reservation"></param>
    /// <exception cref="Exception">занято</exception>
    public void AddReservation(Reservation reservation);
}

