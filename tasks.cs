using HTTPUtils;
using System.Text.Json;
using AnsiTools;
using Colors = AnsiTools.ANSICodes.Colors;

namespace tasks{
    public class Tasks {
        const string myPersonalID = "ec9876325b5904354be72a2d6413bde81d858754bff32560beab1aedc16ff71d";
        const string baseURL = "https://mm-203-module-2-server.onrender.com/";
        const string startEndpoint = "start/"; // baseURl + startEndpoint + myPersonalID
        const string taskEndpoint = "task/";   // baseURl + taskEndpoint + myPersonalID + "/" + taskID

        public static double Task1(string parameters) {
            double tempToConvert = Convert.ToDouble(parameters);
            double convertedValue = Math.Truncate(100 * (tempToConvert - 32) * 5/9) / 100; 
            Console.WriteLine(parameters + "  farenheit is " + convertedValue + " celsius.");
            return convertedValue;

        }

        public static string Task2(string parameters) {
            
            string[] parameterstask2Divided = parameters.Split(',');
            int[] parameterstask2 = new int[parameterstask2Divided.Length];

            for(int i = 0; i < parameterstask2Divided.Length; i++) {
            bool successfullyParsed = int.TryParse(parameterstask2Divided[i], out int result);
            if(successfullyParsed) {
                parameterstask2[i] = int.Parse(parameterstask2Divided[i]);
            }
            }

            int[] extendedParameterArraytask2 = new int[parameterstask2.Length + 1];
            parameterstask2.CopyTo(extendedParameterArraytask2, 1);

            int difference = parameterstask2[1] - parameterstask2[0];

            int answer = (parameterstask2[parameterstask2.Length-1] + difference);

            Console.WriteLine("The next number in the series is " + answer);

            return  answer.ToString();
             
        }

        public static string Task3(string parameters) {

            int[] task3Parameters = ConvertParameterToIntArray(parameters);

            int[] ConvertParameterToIntArray(string parameters) {

                string[] divideParameters = parameters.Split(',');
                int[] resultArray = new int[divideParameters.Length];

                for(int i = 0; i < divideParameters.Length; i++) {
                    bool successfullyParsed = int.TryParse(divideParameters[i], out int result);
                    if(successfullyParsed) {
                        resultArray[i] = int.Parse(divideParameters[i]);
                    }
                }
                return resultArray;
            }

            if(task3Parameters[0] % 2 == 0) {
                return "even";
            } else {
                return "odd";
            }
        }

        public static string Task4(string valueToConvert) {
            Dictionary<char, int> RomanNumeralValue = new Dictionary<char, int>();

            RomanNumeralValue.Add('C', 100);
            RomanNumeralValue.Add('L', 50);
            RomanNumeralValue.Add('X', 10);
            RomanNumeralValue.Add('V', 5);
            RomanNumeralValue.Add('I', 1);

            int answer4 = 0;

            valueToConvert = valueToConvert.Replace("IV","IIII")
                        .Replace("IX", "VIIII")
                        .Replace("XL", "XXXX")
                        .Replace("XC", "LXXXX");
                    
            foreach(char c in valueToConvert){
                answer4 += RomanNumeralValue[c];
            }

            return answer4.ToString();
            }
                    
    }
}