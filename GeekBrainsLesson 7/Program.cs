var m = Convert.ToInt32(Console.ReadLine()); //объявляем переменную
var n = Convert.ToInt32(Console.ReadLine());
var m_n = new double[m, n]; //вводим двумерный массив=матрица
var random = new Random(); //генератор рандомных чисел
for (int i = 0; i < m; i++) //for условие, i индекс по вертикали, j по горизонтали и мы перебираем построчно (++)
{
    for (int j = 0; j < n; j++)
    {
        m_n[i, j] = Math.Round(random.NextDouble() + random.Next(-10, 10), 1); //объявляем значение для каждого элемента и округляем его до 1 числа после запятой
        Console.Write(m_n[i, j] + "\t"); //выводим каждое значение по строчкам
    }
    Console.WriteLine();//переход на новую строку
}
