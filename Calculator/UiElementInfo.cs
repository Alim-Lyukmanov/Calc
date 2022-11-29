using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Navigation;

internal class UiElementInfo : IUiElement
{
    public string Name { get { return name; }  set => name = value; }
    public string Content { get { return content; } set => content = value; }
    public int RowIndex { get { return rowIndex; } set => rowIndex = value; }
    public int ColumnIndex { get { return columnIndex; } set => columnIndex = value; }
    public int RowSpam { get { return rowSpan; } set => rowSpan = value; }
    public int ColumnSpan { get { return columnSpan; } set => columnSpan = value; }
    private string name;
    private string content;
    private int rowIndex;
    private int columnIndex;
    private int rowSpan;
    private int columnSpan;
}

