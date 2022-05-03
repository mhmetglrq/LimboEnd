using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML.Data;

namespace Limbo.SentimentAnalysis
{
    public class SentimentData
    {
        [LoadColumn(0)]
        public float Sentiment { get; set; }
        [LoadColumn(1)]
        public string Text { get; set; }
    }
}
