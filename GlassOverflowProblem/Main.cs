namespace GlassOverflowProblem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void btCalc_Click(object sender, EventArgs e)
        {
            var calculator = new LiquidCalculator();
            var timeInSeconds = LiquidCalculator.GetTimeToReachBreakpoint(new Position { Column = Convert.ToInt32(numCol.Value), Row = Convert.ToInt32(numRow.Value) });

            txtTime.Text = timeInSeconds.ToString();
        }

        private void numCol_ValueChanged(object sender, EventArgs e)
        {
            numCol.Value = Math.Min(numCol.Value, numRow.Value);
        }
    }
}
