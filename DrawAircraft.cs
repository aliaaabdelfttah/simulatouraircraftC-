private void DrawAircraft(Graphics g, Point location)
{
    Brush b = Brushes.Blue;
    g.FillEllipse(b, location.X, location.Y, 10, 10);
