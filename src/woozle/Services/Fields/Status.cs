//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using Woozle.Services;
using Woozle.Services.Location;

namespace Woozle.Services.Fields
{
    [Serializable]
    public partial class Status : WoozleDto
    {
        public string Value { get; set; }
        public int StatusFieldId { get; set; }
        public int TranslationId { get; set; }
    
    	/// <summary>
        /// To use the translated value directly it needs to be filled explicit
        /// </summary>
        public string TranslatedValue { get; set; }
    
        public StatusField StatusField { get; set; }
        public Translation Translation { get; set; }
    }
}
