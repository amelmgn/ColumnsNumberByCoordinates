using System.Collections.Generic;
using System.Linq;
using Autodesk.Revit.UI;
using System.Windows.Media.Imaging;

namespace ColumnsNumberByCoordinates
{
    [Autodesk.Revit.Attributes.Transaction(Autodesk.Revit.Attributes.TransactionMode.Manual)]
    public class App : IExternalApplication
    {
        public static string assemblyPath = "";
        private readonly string tabName = "Amel";

        public Result OnShutdown(UIControlledApplication application)
        {
            return Result.Succeeded;
        }

        public Result OnStartup(UIControlledApplication application)
        {
            assemblyPath = System.Reflection.Assembly.GetExecutingAssembly().Location;

            try { application.CreateRibbonTab(tabName); } catch { }

            //создание вкладки
            string panelName = "Обучение";
            RibbonPanel panel = null;
            List<RibbonPanel> tryPanels = application.GetRibbonPanels(tabName).Where(i => i.Name == panelName).ToList();
            if (tryPanels.Count == 0)
            {
                panel = application.CreateRibbonPanel(tabName, panelName);
            }
            else
            {
                panel = tryPanels.First();
            }
            //конец блока создания вкладки

            //создание кнопки
            PushButton btnConstr = panel.AddItem(new PushButtonData(
                "ColumnsNumberByCoordinates",
                "Нумерация\nколонн\nпо координатам",
                assemblyPath,
                "ColumnsNumberByCoordinates.ColumnsNumberByCoordinates")
                ) as PushButton;
            //конец блока создания кнопки

            //назначения изображений кнопке
            btnConstr.LargeImage = PngImageSource("ColumnsNumberByCoordinates.Resources.ColNumCoord_32.png");
            btnConstr.Image = PngImageSource("ColumnsNumberByCoordinates.Resources.ColNumCoord_16.png");
            //конец блок назначения изображений кнопке

            return Result.Succeeded;
        }

        private System.Windows.Media.ImageSource PngImageSource(string embeddedPathname)
        {
            System.IO.Stream st = this.GetType().Assembly.GetManifestResourceStream(embeddedPathname);

            PngBitmapDecoder decoder = new PngBitmapDecoder(st, BitmapCreateOptions.PreservePixelFormat, BitmapCacheOption.Default);

            return decoder.Frames[0];
        }
    }
}