//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Runtime.Serialization;

namespace Woozle.Model
{
    [Serializable]
    public partial class TextFieldPlaceHolder : WoozleObject
    {
        private string name;
        private int descriptiontranslationid;
        private int fieldvaluetranslationid;
        private string placeholdertype;
    
        public string Name 
    	{ 
    		get { return this.name;} 
    		set { 
    			if(this.name != value)
    			{
    				this.name = value;
    			}
    		}
    	}
        public int DescriptionTranslationId 
    	{ 
    		get { return this.descriptiontranslationid;} 
    		set { 
    			if(this.descriptiontranslationid != value)
    			{
    				this.descriptiontranslationid = value;
    			}
    		}
    	}
        public int FieldValueTranslationId 
    	{ 
    		get { return this.fieldvaluetranslationid;} 
    		set { 
    			if(this.fieldvaluetranslationid != value)
    			{
    				this.fieldvaluetranslationid = value;
    			}
    		}
    	}
        public string PlaceHolderType 
    	{ 
    		get { return this.placeholdertype;} 
    		set { 
    			if(this.placeholdertype != value)
    			{
    				this.placeholdertype = value;
    			}
    		}
    	}
    
    
    public virtual Translation Translation { get; set; }
    
    
    public virtual Translation Translation1 { get; set; }
    
    
    
    public override bool Equals(object obj)
    {
        if (this == obj)
            return true;
        if (obj == null)
            return false;
        if (GetType() != obj.GetType())
            return false;
    	//objects are equal when they are not new (Id != 0) and the Ids are equal
        WoozleObject other = (WoozleObject)obj;
        if (Id == 0 || Id != other.Id)
            return false;
        return true;
    }
    
    public override int GetHashCode()
    {
        int prime = 31;
    	int result = 1;
    	result = prime * result + Id;
    	return result;
    }
    }
    
}