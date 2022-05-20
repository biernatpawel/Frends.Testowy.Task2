#pragma warning disable 1591

using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Frends.Testowy.Task2
{
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

 

    public class Result
    {
        /// <summary>
        /// Contains the input text in uppercase or lowercase.
        /// </summary>
        [DisplayFormat(DataFormatString = "Text")]
        public string OutputText;
    }
}
