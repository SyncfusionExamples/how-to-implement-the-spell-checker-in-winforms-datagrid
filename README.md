# How to implement the spell checker in WinForms DataGrid (SfDataGrid)?

## About the sample
This example illustrates how to implement the spell checker in WinForms DataGrid (SfDataGrid)

By default, [SfDataGrid](https://help.syncfusion.com/cr/cref_files/windowsforms/Syncfusion.SfDataGrid.WinForms~Syncfusion.WinForms.DataGrid.SfDataGrid.html) does not provide the support for spell checker in GridCell. You can underline or highlight misspelled words within a cell from a [SfDataGrid](https://help.syncfusion.com/cr/cref_files/windowsforms/Syncfusion.SfDataGrid.WinForms~Syncfusion.WinForms.DataGrid.SfDataGrid.html) by creating the custom column like **GridSpellCheckColumn** and **SpellCheckCellRenderer** for checking the GridCell text in [SfDataGrid](https://help.syncfusion.com/cr/cref_files/windowsforms/Syncfusion.SfDataGrid.WinForms~Syncfusion.WinForms.DataGrid.SfDataGrid.html).

```C#

this.sfDataGrid1.CellRenderers.Add("SpellCheck", new SpellCheckCellRenderer(this.sfDataGrid1));

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

```
## Requirements to run the demo
Visual Studio 2015 and above versions

