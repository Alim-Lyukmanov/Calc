interface IUiElement
{
    string Name { get; set; }
    string Content { get; set; }
    int RowIndex { get; set; }
    int ColumnIndex { get; set; }
    int RowSpam { get; set; }
    int ColumnSpan { get; set; }
}
