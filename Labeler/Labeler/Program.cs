List<string> Labeler(int rows, int columns, string gridName)
{
    List<string> labels = new List<string>();
    int tile = 0;
    labels.Add($"<Grid x:Name=\"{gridName}\">");

    labels.Add("<Grid.ColumnDefinitions>");

    for (int p = 0; p < columns; p++)
    {
        labels.Add("<ColumnDefinition/>");
    }

    labels.Add("</Grid.ColumnDefinitions>");

    labels.Add("<Grid.RowDefinitions>");
    for (int s = 0; s < rows; s++)
    {
        labels.Add("<RowDefinition Height=\"*\"/>");
    }

    labels.Add("</Grid.RowDefinitions>");

    for (int i = 0; i < columns; i++)
    {
        for (int j = 0; j < rows; j++)

            if (i % 2 == 0)
            {
                int evenTiles = 63 - (i * 8 + j);

                labels.Add($"<Label x:Name=\"Tile{tile}\" Grid.Row=\"{i}\" Grid.Column=\"{j}\" Content=\"Tile {tile}\" />");
                tile++;
            }
            else
            {
                int oddTiles = 63 - (i * 8 + 7 - j);
                labels.Add($"<Label x:Name=\"Tile{tile}\" Grid.Row=\"{i}\" Grid.Column=\"{j}\" Content=\"Tile {tile}\" />");
                tile++;
            }
        {


        }
    }
    labels.Add("</Grid>");

    return labels;
};

List<string> generatedLabels = Labeler(8, 8, "gooseGrid");

foreach (var label in generatedLabels)
{
    Console.WriteLine(label);
}