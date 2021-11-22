using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WallPlacer
{
    [TransactionAttribute(TransactionMode.Manual)]
    class Command : IExternalCommand
    {
        private UIApplication uiapp;
        private UIDocument uidoc;
        private Autodesk.Revit.ApplicationServices.Application app;
        private Document doc;
        public Result Execute(ExternalCommandData commandData, ref string message, ElementSet elements)
        {
            uiapp = commandData.Application;
            uidoc = uiapp.ActiveUIDocument;
            app = uiapp.Application;
            doc = uidoc.Document;

            WallForm wallForm = new WallForm(commandData);
            wallForm.ShowDialog();
            PlaceWall(wallForm._startValue, wallForm._endValue);

            return Result.Succeeded;
        }

        internal void PlaceWall(XYZ start, XYZ end)
        {
            using (var transaction = new Transaction(doc))
            {

                transaction.Start("Place wall");


                // Get all Level
                FilteredElementCollector colLevels =
                    new FilteredElementCollector(doc)
                    .OfCategory(BuiltInCategory.INVALID)
                    .OfClass(typeof(Level));

                // Get first Level
                Level level = colLevels.FirstElement() as Level;

                // Get all WallType
                FilteredElementCollector colWalltypes =
                    new FilteredElementCollector(doc)
                    .OfCategory(BuiltInCategory.INVALID)
                    .OfClass(typeof(WallType));

                // Get first WallType
                WallType wallType = colWalltypes.FirstElement() as WallType;

                Line geomLine = Line.CreateBound(start, end);

                double height = 10;

                double offset = 0;

                Wall wall = Wall.Create(doc, geomLine, wallType.Id, level.Id, height, offset, false, true);

                transaction.Commit();
            }
        }
    }
}
