using System;
using System.Windows;
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

        rd = AddRows(rd, 5);
        cd = AddColums(cd, 4);

        AddButtons();
        AddTextBox();
        return NewGrid;
    }

    private RowDefinitionCollection AddRows(RowDefinitionCollection rd, int rowsAmount)
    {
        for (int i = 0; i < rowsAmount; i++)
        {
            var newRow = new RowDefinition();
            if (i == 0)
            {
                newRow.Name = "Menu";
                newRow.Height = new GridLength(150);
            }
            rd.Add(newRow);
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


    private void AddButtons()
    {
        int content = 1;
        for (int i = 1; i<NewGrid.RowDefinitions.Count; i++)
        {
            for (int j = 0; j<NewGrid.ColumnDefinitions.Count; j++)
            {
                Button btn = new Button();
                btn.Content = content;
                btn.Style = AddStyle();
                Grid.SetRow(btn, i);
                Grid.SetColumn(btn, j);
                Grid.SetColumnSpan(btn, 1);
                NewGrid.Children.Add(btn);
                content++;
            }
        }
    }

    private void AddTextBox()
    {
        var textBox = new TextBox();
        Grid.SetRow(textBox, 0);
        Grid.SetColumn(textBox, 0);
        Grid.SetColumnSpan(textBox, NewGrid.ColumnDefinitions.Count);
        NewGrid.Children.Add(textBox);
    }


    private Style AddStyle()
    {
        var resDict = new ResourceDictionary() { Source = new Uri(@"C:\Users\desuFok\source\repos\Calculator\Calculator\ResourceDictionary.xaml") };
        var style = new Style();
        style = (Style)resDict["btnTemplate"]; 
        return style;
    }
}