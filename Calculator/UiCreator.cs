using System.Windows.Controls;

internal class UiCreator
{
    public Grid NewGrid;

    public UiCreator()
    {
        NewGrid = new Grid();
        NewGrid.ShowGridLines = true;
    }

    public Grid CreateGrid()
    {
        RowDefinitionCollection rd = NewGrid.RowDefinitions;
        ColumnDefinitionCollection cd = NewGrid.ColumnDefinitions;

        rd = AddRows(rd, 4);
        cd = AddColums(cd, 5);

        return NewGrid;
    }

    private RowDefinitionCollection AddRows(RowDefinitionCollection rd, int rowsAmount)
    {
        for (int i = 0; i < rowsAmount; i++)
        {
            rd.Add(new RowDefinition());
        }
        return rd;
    }

    private ColumnDefinitionCollection AddColums(ColumnDefinitionCollection cd, int columnsAmount)
    {
        for (int i = 0; i < columnsAmount; i++)
        {
            cd.Add(new ColumnDefinition());
        }

        return cd;
    }
}