/*
 * Создано в SharpDevelop.
 * Пользователь: Student
 * Дата: 01.10.2019
 * Время: 18:53
 * 
 * Для изменения этого шаблона используйте меню "Инструменты | Параметры | Кодирование | Стандартные заголовки".
 */
using System;

namespace Dor_Proj
{
	class Program
{
    static void Main(string[] args)
    {
        Cap hat = new Cap(8, "Vip", new DemoSeasonCold());
        hat.Season();
        hat.Weather = new DemoSeasonWarm();
        hat.Season();
 
        Console.ReadLine();
    }
}
interface ISeasonsWeather
{
    void Season();
}
 
class DemoSeasonCold : ISeasonsWeather
{
    public void Season()
    {
        Console.WriteLine("Пригодна для носки зимой");
    }
}
 
class DemoSeasonWarm : ISeasonsWeather
{
    public void Season()
    {
        Console.WriteLine("Пригодна для носки весной");
    }
}
class Cap
{
    protected int wedge; // кол-во клиньев
    protected string model; // модель кепки
 
    public Cap(int num, string model, ISeasonsWeather mov)
    {
        this.wedge = num;
        this.model = model;
        Weather = Season;
    }
    public ISeasonsWeather Weather { private get; set; }
    public void Season()
    {
        Weather.Season();
    }
}
	}