using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.ML.Data;

namespace Limbo.SentimentAnalysis
{
    public class SentimentPrediction
    {
        [ColumnName("PredictedLabel")] public bool Prediction { get; set; }
        public float Probability { get; set; }
        public float Score { get; set; }
    }
}