﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.17929
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

using System.Xml.Serialization;

// 
// 此源代码由 xsd 自动生成, Version=4.0.30319.1。
// 


/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.PanPort.com/pag/cab-profile/2.0/")]
[System.Xml.Serialization.XmlRootAttribute(Namespace="http://schemas.PanPort.com/pag/cab-profile/2.0/", IsNullable=false)]
public partial class sampleGroup {
    
    private object[] itemsField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlElementAttribute("complex", typeof(sampleGroupComplex))]
    [System.Xml.Serialization.XmlElementAttribute("simple", typeof(sampleGroupSimple))]
    public object[] Items {
        get {
            return this.itemsField;
        }
        set {
            this.itemsField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.PanPort.com/pag/cab-profile/2.0/")]
public partial class sampleGroupComplex {
    
    private sampleGroupComplexChildrenChild[] childrenField;
    
    private string heightField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("child", typeof(sampleGroupComplexChildrenChild), IsNullable=false)]
    public sampleGroupComplexChildrenChild[] children {
        get {
            return this.childrenField;
        }
        set {
            this.childrenField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string height {
        get {
            return this.heightField;
        }
        set {
            this.heightField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.PanPort.com/pag/cab-profile/2.0/")]
public partial class sampleGroupComplexChildrenChild {
    
    private string firstNameField;
    
    private string lastNameField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string firstName {
        get {
            return this.firstNameField;
        }
        set {
            this.firstNameField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string lastName {
        get {
            return this.lastNameField;
        }
        set {
            this.lastNameField = value;
        }
    }
}

/// <remarks/>
[System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.0.30319.1")]
[System.SerializableAttribute()]
[System.Diagnostics.DebuggerStepThroughAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://schemas.PanPort.com/pag/cab-profile/2.0/")]
public partial class sampleGroupSimple {
    
    private string maxValueField;
    
    private string minValueField;
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string maxValue {
        get {
            return this.maxValueField;
        }
        set {
            this.maxValueField = value;
        }
    }
    
    /// <remarks/>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public string minValue {
        get {
            return this.minValueField;
        }
        set {
            this.minValueField = value;
        }
    }
}
