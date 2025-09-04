//Load sample data
using Test_DL;

var sampleData = new MLModel1.ModelInput()
{
    //Col0 = @"Crust is not good.",
    Col0 = "This restaurant was wonderful."
};

//Load model and predict output
var result = MLModel1.Predict(sampleData);

var sentiment = result.PredictedLabel == 1 ? "Positive" : "Negative";
Console.WriteLine($"Text: {sampleData.Col0}\nSentiment: {sentiment}");