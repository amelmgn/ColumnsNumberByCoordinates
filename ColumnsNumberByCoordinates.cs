using System;
using System.Collections.Generic;
using System.Linq;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System.Windows.Forms;

namespace ColumnsNumberByCoordinates
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class ColumnsNumberByCoordinates : IExternalCommand
    {
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            //Получение документа
            Document doc = commandData.Application.ActiveUIDocument.Document;
            
            //Создание переменных - номер колонны, текстовый префикс, список упорядоченных колонн
            int num = 1;
            string prefix;
            List<FamilyInstance> OrderedColList;

            //Коллектор, выбирающий из проекта экземпляры семейств категории "Несущие колонны" и вывод
            //исключения в случае, если таких элементов в проекте нет.
            List<FamilyInstance> colList = new FilteredElementCollector(doc)
                .OfCategory(BuiltInCategory.OST_StructuralColumns)
                .OfClass(typeof(FamilyInstance))
                .Cast<FamilyInstance>()
                .ToList();

            if (colList.Count() == 0) throw new Exception("Несущие колонны в проекте отсутствуют!");

            //Инициализация и показ формы
            OptionsForm optForm = new OptionsForm();
            optForm.ShowDialog();

            //Проверка того, нажал ли пользователь кнопку ОК. Если нет - остановка работы плагина
            if (optForm.DialogResult != DialogResult.OK)
            {
                return Result.Cancelled;
            }

            //Упорядочивание нумерации колонн в зависимости от переключателя в форме (X->Y или Y->X)
            if (optForm.XthenY)
            {
                OrderedColList = colList.OrderBy(f => (int)((LocationPoint)f.Location).Point.X)
                                 .ThenBy(f => (int)((LocationPoint)f.Location).Point.Y)
                                 .ToList();
            }
            else
            {
                OrderedColList = colList.OrderBy(f => (int)((LocationPoint)f.Location).Point.Y)
                                 .ThenBy(f => (int)((LocationPoint)f.Location).Point.X)
                                 .ToList();
            }

            //Передача значения поля префикса из формы в переменную
            prefix = optForm.markPref;

            //Процесс нумерации колонн. Выбираем из упорядоченного списка колонну, находим параметр "Марка",
            //присваиваем этому параметру значение "префикс + номер", увеличиваем номер на 1.
            using (Transaction t = new Transaction(doc))
            {
                t.Start("Нумерация колонн");

                for (int i = 0; i < OrderedColList.Count(); i++)
                {
                    FamilyInstance col = OrderedColList.ElementAt(i);
                    Parameter mark = col.LookupParameter("Марка");
                    mark.Set(prefix + num.ToString());
                    num++;
                }

                t.Commit();
            }

            //Вывод сообщения в случае, если плагин не сработал и возврат успеха, если плагин сработал
            message = "Возникли ошибки! Колонны не пронумерованы!";
            return Result.Succeeded;
        }
    }
}