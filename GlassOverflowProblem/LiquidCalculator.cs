namespace GlassOverflowProblem
{
    public class LiquidCalculator
    {
        /// <summary>
        /// GetParentPositions(Position position)
        /// Returnera positioner för angiven positions föräldrar.
        /// Samtliga positioner har två föräldrar utom ändpositioner
        /// som har en förälder vardera
        /// </summary>
        /// <param name="position"></param>
        /// <returns>Lista av positioner</returns>
        private static List<Position> GetParentPositions(Position position)
        {
            var parentRow = position.Row - 1;
            var parentColumnLeft = position.Column - 1;
            var parentColumnRight = position.Column;

            if (parentColumnRight > parentRow)
                return new List<Position> { new() { Column = parentColumnLeft, Row = parentRow } };
            if (parentColumnLeft < 1)
                return new List<Position> { new() { Column = parentColumnRight, Row = parentRow } };

            return new List<Position> { new() { Column = parentColumnLeft, Row = parentRow }, new() { Column = parentColumnRight, Row = parentRow } };
        }


        /// <summary>
        /// Returnerar total volym (i antal glas) som flödat genom angiven position
        /// </summary>
        /// <param name="totalAmountDelivered"></param>
        /// <param name="position"></param>
        /// <returns>Genomfluten volym</returns>
        private static double GetAmountDeliverAt(double totalAmountDelivered, Position position)
        {
            if (position.Row == 1)
                return totalAmountDelivered;
            if (position.Column < 1 || position.Column > position.Row)
                return 0;

            var amount = 0D;
            var parentPositions = GetParentPositions(position);
            parentPositions.ForEach(p =>
            {
                // Hämta överflöde från förälder på position p
                amount += Math.Max((GetAmountDeliverAt(totalAmountDelivered, p) - 1) / 2, 0);
            });

            return amount;
        }

        /// <summary>
        /// Returnerar total volym (i antal glas) som totalt tillsatts då överflöde 
        /// sker vid angiven position
        /// </summary>
        /// <param name="position"></param>
        /// <returns>Totalt tillsatt volym</returns>
        private static double GetTotalAmountDeliveredAtBreakpoint(Position position)
        {
            var totalAmountDelivered = 0D;

            // Snabb-iterera med heltal fram tills brytpunkt passerats
            while (GetAmountDeliverAt(totalAmountDelivered, position) < 1) { totalAmountDelivered += 1; }

            // Iterera fram till brytpunkten (mängd vätska som levererats > 1)
            while (GetAmountDeliverAt(totalAmountDelivered, position) > 1) { totalAmountDelivered -= 0.0001; }

            return totalAmountDelivered + 0.0001;
        }

        /// <summary>
        /// Returnerar tid att uppnå överflöde vid angiven position.
        /// Överflöde uppnås efter en volymenhet har genomflödat. 
        /// Varje tillsatt volymenhet tar 10 sekunder.
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
        /// <exception cref="InvalidParametersException"></exception>
        public static double GetTimeToReachBreakpoint(Position position)
        {
            if (position.Row is < 2 or > 50 || position.Column < 1 || position.Column > position.Row)
                throw new InvalidParametersException();

            return GetTotalAmountDeliveredAtBreakpoint(position) * 10;
        }
    }

    /// <summary>
    /// Representerar positionen för ett glas
    /// </summary>
    public struct Position
    {
        public int Column;
        public int Row;
    }

    public class  InvalidParametersException : Exception { }
}
