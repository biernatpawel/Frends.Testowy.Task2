using System.ComponentModel;
using System.Threading;
using Microsoft.CSharp; // You can remove this if you don't need dynamic type in .NET Standard frends Tasks

#pragma warning disable 1591

namespace Frends.Testowy.Task2
{
    public static class TextConvert
    {
        /// <summary>
        /// This is task
        /// Documentation: https://github.com/CommunityHiQ/Frends.Testowy.Task2
        /// </summary>
        /// <param name="input">Text to convert.</param>
        /// <param name="action">Kind of conversion.</param>

        public static Result ConvertText(Parameters input, [PropertyTab]Options action)
        {
            var inputText = new Parameters
            {
                InputText = input.InputText
            };

            var output = new Result
            {
                OutputText = ""
            };


            switch (action.TextAction)
            {
                case TextActionEnum.Uppercase:
                    output.OutputText = inputText.InputText.ToUpper();
                    break;

                case TextActionEnum.Lowercase:
                    output.OutputText = inputText.InputText.ToLower();  
                    break;
            }



            return output;
            
        }

    }

}