#pragma warning disable 1591

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Frends.Testowy.Task2
{

    public enum TextActionEnum { Uppercase, Lowercase };
    /// <summary>
    /// Parameters class usually contains parameters that are required.
    /// </summary>
    public class Parameters
    {
        /// <summary>
        /// Text to convert.
        /// </summary>
        [DisplayFormat(DataFormatString = "Text")]
        [DefaultValue("Text to convert")]
        public string InputText { get; set; }
    }

    public class Options
    {

        /// <summary>
        /// What to do with input text.
        /// </summary>
        [DisplayFormat(DataFormatString = "Text")]
        [DefaultValue(TextActionEnum.Uppercase)]
        public TextActionEnum TextAction { get; set; }


    }
 

    public class Result
    {
        /// <summary>
        /// Contains the input text in uppercase or lowercase.
        /// </summary>
        [DisplayFormat(DataFormatString = "Text")]
        public string OutputText;
    }
}
