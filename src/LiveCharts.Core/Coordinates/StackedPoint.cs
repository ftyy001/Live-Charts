using LiveCharts.Core.Abstractions;
using LiveCharts.Core.Data;

namespace LiveCharts.Core.Coordinates
{
    /// <summary>
    /// A stacked coordinate.
    /// </summary>
    public struct StackedPoint : ICoordinate
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="StackedPoint"/> struct.
        /// </summary>
        public StackedPoint(double participation, double value, int index)
        {
            Participation = participation;
            Value = value;
            Index = index;
        }

        /// <summary>
        /// Gets or sets the index.
        /// </summary>
        /// <value>
        /// The index.
        /// </value>
        public int Index { get; }

        /// <summary>
        /// Gets or sets the participation.
        /// </summary>
        /// <value>
        /// The participation.
        /// </value>
        public double Participation { get; }

        /// <summary>
        /// Gets or sets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public double Value { get; }

        /// <summary>
        /// Gets or sets the total.
        /// </summary>
        /// <value>
        /// The total.
        /// </value>
        public double TotalStacked => Value / Participation;

        public bool CompareDimensions(DimensionRange[] dimensionRanges, SeriesSkipCriteria skipCriteria)
        {
            throw new System.NotImplementedException();
        }
    }
}