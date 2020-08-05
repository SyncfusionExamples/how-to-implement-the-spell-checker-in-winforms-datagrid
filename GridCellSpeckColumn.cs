
using Syncfusion.Windows.Forms.Tools;
using Syncfusion.WinForms.DataGrid;
using Syncfusion.WinForms.DataGrid.Renderers;
using Syncfusion.WinForms.DataGrid.Styles;
using Syncfusion.WinForms.GridCommon.ScrollAxis;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SfDataGridDemo
{
    public class SpellCheckCellRenderer : GridTextBoxCellRenderer
    {
        //Using SpellChecker tool.
        private SpellCheckerAdv spellchecker;
        public SpellCheckCellRenderer(SfDataGrid sfdataGrid)
        {
            spellchecker = new SpellCheckerAdv();
        }
        protected override void OnRender(Graphics paint, Rectangle cellRect, string cellValue, CellStyleInfo style, DataColumnBase column, RowColumnIndex rowColumnIndex)
        {
            string check = this.spellchecker.SpellCheck(cellValue.ToString());
            //Checking whether the result has suggestions.
            if (check != "")
            {
                style.Font.Underline = true;
            }
            base.OnRender(paint, cellRect, cellValue, style, column, rowColumnIndex);
        }
    }
    public class GridSpellCheckColumn : GridTextColumn
    {
        public GridSpellCheckColumn()
        {
            SetCellType("SpellCheck");
        }
    }
}
