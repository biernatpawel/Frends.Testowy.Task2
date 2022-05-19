using System.ComponentModel;
using System.Threading;
using Microsoft.CSharp; // You can remove this if you don't need dynamic type in .NET Standard frends Tasks

#pragma warning disable 1591

namespace Frends.Testowy.Task2
{
    public static class UpperClass
    {
        /// <summary>
        /// This is task
        /// Documentation: https://github.com/CommunityHiQ/Frends.Testowy.Task2
        /// </summary>
        /// <param name="input">What to repeat.</param>


        public static Result UpperText(Parameters input)
        {
            var inputText = new Parameters
            {
                InputText = input.InputText
            };

            var output = new Result
            {
                TextInUppercase = inputText.InputText.ToUpper()
            };

            return output;
            
        }
    }

}