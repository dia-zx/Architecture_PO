using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson8.Models;

/// <summary>
/// Содержит информацию о бронировании столика
/// </summary>
internal class Reservation
{
    private static int _id_nex = 0;
    private int _id;
    public Reservation()
    {
        _id = _id_nex++;
    }
    public int Id {  get => _id; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Table Table { get; set; }
    public DateTime Date { get; set; }
    /// <summary> длительность бронирования в часах </summary>
    public int DurationInHours {  get; set; }
    public override string ToString()=> $"заказ ID: {_id} на Имя: {Name}, Дата: {Date.ToString("u")}, длительность :{DurationInHours} час., столик: {Table.Number}, ({Description})";
}
