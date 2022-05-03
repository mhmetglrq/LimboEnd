using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML;

namespace Limbo.SentimentAnalysis
{
    public class SentimentReturn
    {
        public float Predict(string text)
        {
            var context = new MLContext();

            DataViewSchema modelSchema;

            ITransformer model = context.Model.Load("model.zip", out modelSchema);

            var predictionEngine = context.Model.CreatePredictionEngine<SentimentData, SentimentPrediction>(model);
            float total = 0;
            if (text.Contains('.'))
            {
                var texts = text.Split('.');
                for (int i = 0; i < texts.Length - 1; i++)
                {
                    total += predictionEngine.Predict(new SentimentData { Text = texts[i] }).Probability * 100;
                }

                total = total / texts.Length - 1;
            }
            else
            {
                total += predictionEngine.Predict(new SentimentData { Text = text }).Probability * 100;
            }

            return total;
        }
    }
}
