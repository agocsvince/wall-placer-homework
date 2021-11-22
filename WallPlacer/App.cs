using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace WallPlacer
{
    public class App : IExternalApplication
    {
        public Result OnShutdown(UIControlledApplication application)
        {
            throw new NotImplementedException();
        }

        public Result OnStartup(UIControlledApplication application)
        {
            RibbonPanel panel = ribbonPanel(application);
            string thisAssembly = Assembly.GetExecutingAssembly().Location;
            PushButton pushButton = panel.AddItem(new PushButtonData("Placewall", "Place wall button", thisAssembly, "WallPlacer.Command")) as PushButton;


            return Result.Succeeded;
        }
        private RibbonPanel ribbonPanel(UIControlledApplication application)
        {
            string tab = "Place wall";
            RibbonPanel ribbonPanel = null;
            try
            {
                application.CreateRibbonTab(tab);
            }
            catch { }
            try
            {
                RibbonPanel panel = application.CreateRibbonPanel(tab, "Place wall");
            }
            catch { }

            List<RibbonPanel> panels = application.GetRibbonPanels(tab);

            foreach (RibbonPanel p in panels)
            {
                if (p.Name == "Place wall")
                {
                    ribbonPanel = p;
                }
            }

            return ribbonPanel;
        }
    }
}
