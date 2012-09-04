// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code. Version 3.4.0.38967
//    <NameSpace>com.jni4net.config</NameSpace><Collection>List</Collection><codeType>CSharp</codeType><EnableDataBinding>False</EnableDataBinding><EnableLazyLoading>False</EnableLazyLoading><TrackingChangesEnable>False</TrackingChangesEnable><GenTrackingClasses>False</GenTrackingClasses><HidePrivateFieldInIDE>False</HidePrivateFieldInIDE><EnableSummaryComment>False</EnableSummaryComment><VirtualProp>False</VirtualProp><IncludeSerializeMethod>False</IncludeSerializeMethod><UseBaseClass>False</UseBaseClass><GenBaseClass>False</GenBaseClass><GenerateCloneMethod>False</GenerateCloneMethod><GenerateDataContracts>False</GenerateDataContracts><CodeBaseTag>Net35</CodeBaseTag><SerializeMethodName>Serialize</SerializeMethodName><DeserializeMethodName>Deserialize</DeserializeMethodName><SaveToFileMethodName>SaveToFile</SaveToFileMethodName><LoadFromFileMethodName>LoadFromFile</LoadFromFileMethodName><GenerateXMLAttributes>True</GenerateXMLAttributes><EnableEncoding>False</EnableEncoding><AutomaticProperties>False</AutomaticProperties><GenerateShouldSerialize>False</GenerateShouldSerialize><DisableDebug>False</DisableDebug><PropNameSpecified>Default</PropNameSpecified><Encoder>UTF8</Encoder><CustomUsings></CustomUsings><ExcludeIncludedTypes>False</ExcludeIncludedTypes><EnableInitializeFields>True</EnableInitializeFields>
//  </auto-generated>
// ------------------------------------------------------------------------------
namespace com.jni4net.config {
    using System;
    using System.Diagnostics;
    using System.Xml.Serialization;
    using System.Collections;
    using System.Xml.Schema;
    using System.ComponentModel;
    using System.Collections.Generic;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.38968")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://jni4net.sf.net/0.9.0.0/proxygenConfig.xsd")]
    [System.Xml.Serialization.XmlRootAttribute("jni4net-proxygen", Namespace="http://jni4net.sf.net/0.9.0.0/proxygenConfig.xsd", IsNullable=false)]
    public partial class ProxygenConfig {
        
        private List<ProjectRegistration> projectField;
        
        public ProxygenConfig() {
            this.projectField = new List<ProjectRegistration>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("project", Order=0)]
        public List<ProjectRegistration> project {
            get {
                return this.projectField;
            }
            set {
                this.projectField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.38968")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://jni4net.sf.net/0.9.0.0/proxygenConfig.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://jni4net.sf.net/0.9.0.0/proxygenConfig.xsd", IsNullable=true)]
    public partial class ProjectRegistration {
        
        private List<ClassPath> classPathField;
        
        private List<Directory> assembliesDirectoryField;
        
        private List<Assembly> assemblyField;
        
        private List<TypeRegistration> jvmClassField;
        
        private List<TypeRegistration> clrClassField;
        
        private string projectNameField;
        
        private string projectVersionField;
        
        private string projectKeyField;
        
        private bool forceGenerateBaseClassField;
        
        private bool forceGenerateInterfacesField;
        
        private bool forceGenerateNestedClassesField;
        
        private bool forceGenerateGenericParamsField;
        
        private bool autoGenerateBaseClassField;
        
        private bool autoGenerateInterfacesField;
        
        private bool autoGenerateNestedClassesField;
        
        private bool autoGenerateGenericParamsField;
        
        private bool autoGenerateMethodParamsField;
        
        private bool autoSubstituteMethodParamsField;
        
        private bool forceAutoGenerateField;
        
        private string targetDirJvmField;
        
        private string targetDirClrField;
        
        private string baseDirectoryField;
        
        private bool disableProjectGenerationField;
        
        public ProjectRegistration() {
            this.clrClassField = new List<TypeRegistration>();
            this.jvmClassField = new List<TypeRegistration>();
            this.assemblyField = new List<Assembly>();
            this.assembliesDirectoryField = new List<Directory>();
            this.classPathField = new List<ClassPath>();
            this.forceGenerateBaseClassField = false;
            this.forceGenerateInterfacesField = false;
            this.forceGenerateNestedClassesField = false;
            this.forceGenerateGenericParamsField = false;
            this.autoGenerateBaseClassField = true;
            this.autoGenerateInterfacesField = true;
            this.autoGenerateNestedClassesField = true;
            this.autoGenerateGenericParamsField = true;
            this.autoGenerateMethodParamsField = false;
            this.autoSubstituteMethodParamsField = true;
            this.forceAutoGenerateField = false;
            this.targetDirJvmField = "j4n";
            this.targetDirClrField = "j4n";
            this.disableProjectGenerationField = false;
        }
        
        [System.Xml.Serialization.XmlElementAttribute("classPath", Order=0)]
        public List<ClassPath> classPath {
            get {
                return this.classPathField;
            }
            set {
                this.classPathField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("assembliesDirectory", Order=1)]
        public List<Directory> assembliesDirectory {
            get {
                return this.assembliesDirectoryField;
            }
            set {
                this.assembliesDirectoryField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("assembly", Order=2)]
        public List<Assembly> assembly {
            get {
                return this.assemblyField;
            }
            set {
                this.assemblyField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("jvmClass", Order=3)]
        public List<TypeRegistration> jvmClass {
            get {
                return this.jvmClassField;
            }
            set {
                this.jvmClassField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("clrClass", Order=4)]
        public List<TypeRegistration> clrClass {
            get {
                return this.clrClassField;
            }
            set {
                this.clrClassField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string projectName {
            get {
                return this.projectNameField;
            }
            set {
                this.projectNameField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string projectVersion {
            get {
                return this.projectVersionField;
            }
            set {
                this.projectVersionField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string projectKey {
            get {
                return this.projectKeyField;
            }
            set {
                this.projectKeyField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool forceGenerateBaseClass {
            get {
                return this.forceGenerateBaseClassField;
            }
            set {
                this.forceGenerateBaseClassField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool forceGenerateInterfaces {
            get {
                return this.forceGenerateInterfacesField;
            }
            set {
                this.forceGenerateInterfacesField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool forceGenerateNestedClasses {
            get {
                return this.forceGenerateNestedClassesField;
            }
            set {
                this.forceGenerateNestedClassesField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool forceGenerateGenericParams {
            get {
                return this.forceGenerateGenericParamsField;
            }
            set {
                this.forceGenerateGenericParamsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool autoGenerateBaseClass {
            get {
                return this.autoGenerateBaseClassField;
            }
            set {
                this.autoGenerateBaseClassField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool autoGenerateInterfaces {
            get {
                return this.autoGenerateInterfacesField;
            }
            set {
                this.autoGenerateInterfacesField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool autoGenerateNestedClasses {
            get {
                return this.autoGenerateNestedClassesField;
            }
            set {
                this.autoGenerateNestedClassesField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool autoGenerateGenericParams {
            get {
                return this.autoGenerateGenericParamsField;
            }
            set {
                this.autoGenerateGenericParamsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool autoGenerateMethodParams {
            get {
                return this.autoGenerateMethodParamsField;
            }
            set {
                this.autoGenerateMethodParamsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool autoSubstituteMethodParams {
            get {
                return this.autoSubstituteMethodParamsField;
            }
            set {
                this.autoSubstituteMethodParamsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool forceAutoGenerate {
            get {
                return this.forceAutoGenerateField;
            }
            set {
                this.forceAutoGenerateField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("j4n")]
        public string targetDirJvm {
            get {
                return this.targetDirJvmField;
            }
            set {
                this.targetDirJvmField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute("j4n")]
        public string targetDirClr {
            get {
                return this.targetDirClrField;
            }
            set {
                this.targetDirClrField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string baseDirectory {
            get {
                return this.baseDirectoryField;
            }
            set {
                this.baseDirectoryField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool disableProjectGeneration {
            get {
                return this.disableProjectGenerationField;
            }
            set {
                this.disableProjectGenerationField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.38968")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://jni4net.sf.net/0.9.0.0/proxygenConfig.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://jni4net.sf.net/0.9.0.0/proxygenConfig.xsd", IsNullable=true)]
    public partial class ClassPath : TypeContainer {
        
        private List<TypeRegistration> javaClassField;
        
        private string jarFileField;
        
        private string classPathDirectoryField;
        
        public ClassPath() {
            this.javaClassField = new List<TypeRegistration>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("javaClass", Order=0)]
        public List<TypeRegistration> javaClass {
            get {
                return this.javaClassField;
            }
            set {
                this.javaClassField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string jarFile {
            get {
                return this.jarFileField;
            }
            set {
                this.jarFileField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string classPathDirectory {
            get {
                return this.classPathDirectoryField;
            }
            set {
                this.classPathDirectoryField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.38968")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://jni4net.sf.net/0.9.0.0/proxygenConfig.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://jni4net.sf.net/0.9.0.0/proxygenConfig.xsd", IsNullable=true)]
    public partial class TypeRegistration : TargetOptions {
        
        private ExtendsRegistration extendsField;
        
        private List<ImplementsRegistration> implementsField;
        
        private List<MemberRegistration> memberField;
        
        private string nameField;
        
        private string renameField;
        
        private string moveField;
        
        private bool generateField;
        
        private bool excludeField;
        
        private bool verboseField;
        
        private bool addBaseMethodsField;
        
        public TypeRegistration() {
            this.memberField = new List<MemberRegistration>();
            this.implementsField = new List<ImplementsRegistration>();
            this.extendsField = new ExtendsRegistration();
            this.generateField = true;
            this.excludeField = false;
            this.verboseField = false;
            this.addBaseMethodsField = false;
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ExtendsRegistration extends {
            get {
                return this.extendsField;
            }
            set {
                this.extendsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("implements", Order=1)]
        public List<ImplementsRegistration> implements {
            get {
                return this.implementsField;
            }
            set {
                this.implementsField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("member", Order=2)]
        public List<MemberRegistration> member {
            get {
                return this.memberField;
            }
            set {
                this.memberField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string name {
            get {
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string rename {
            get {
                return this.renameField;
            }
            set {
                this.renameField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string move {
            get {
                return this.moveField;
            }
            set {
                this.moveField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(true)]
        public bool generate {
            get {
                return this.generateField;
            }
            set {
                this.generateField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool exclude {
            get {
                return this.excludeField;
            }
            set {
                this.excludeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool verbose {
            get {
                return this.verboseField;
            }
            set {
                this.verboseField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool addBaseMethods {
            get {
                return this.addBaseMethodsField;
            }
            set {
                this.addBaseMethodsField = value;
            }
        }
    }
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ImplementsRegistration))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.38968")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://jni4net.sf.net/0.9.0.0/proxygenConfig.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://jni4net.sf.net/0.9.0.0/proxygenConfig.xsd", IsNullable=true)]
    public partial class ExtendsRegistration {
        
        private string declarationField;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string declaration {
            get {
                return this.declarationField;
            }
            set {
                this.declarationField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.38968")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://jni4net.sf.net/0.9.0.0/proxygenConfig.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://jni4net.sf.net/0.9.0.0/proxygenConfig.xsd", IsNullable=true)]
    public partial class ParameterRegistration {
        
        private string renameField;
        
        private string changeTypeField;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string rename {
            get {
                return this.renameField;
            }
            set {
                this.renameField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string changeType {
            get {
                return this.changeTypeField;
            }
            set {
                this.changeTypeField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.38968")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://jni4net.sf.net/0.9.0.0/proxygenConfig.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://jni4net.sf.net/0.9.0.0/proxygenConfig.xsd", IsNullable=true)]
    public partial class MemberRegistration {
        
        private ParameterRegistration retField;
        
        private List<ParameterRegistration> parameterField;
        
        private string signatureField;
        
        private string renameField;
        
        private bool excludeField;
        
        private bool explicitInterfaceField;
        
        public MemberRegistration() {
            this.parameterField = new List<ParameterRegistration>();
            this.retField = new ParameterRegistration();
            this.excludeField = false;
            this.explicitInterfaceField = false;
        }
        
        [System.Xml.Serialization.XmlElementAttribute(Order=0)]
        public ParameterRegistration ret {
            get {
                return this.retField;
            }
            set {
                this.retField = value;
            }
        }
        
        [System.Xml.Serialization.XmlElementAttribute("parameter", Order=1)]
        public List<ParameterRegistration> parameter {
            get {
                return this.parameterField;
            }
            set {
                this.parameterField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string signature {
            get {
                return this.signatureField;
            }
            set {
                this.signatureField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string rename {
            get {
                return this.renameField;
            }
            set {
                this.renameField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool exclude {
            get {
                return this.excludeField;
            }
            set {
                this.excludeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool explicitInterface {
            get {
                return this.explicitInterfaceField;
            }
            set {
                this.explicitInterfaceField = value;
            }
        }
    }
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TypeRegistration))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TypeContainer))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ClassPath))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Assembly))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Directory))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.38968")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://jni4net.sf.net/0.9.0.0/proxygenConfig.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://jni4net.sf.net/0.9.0.0/proxygenConfig.xsd", IsNullable=true)]
    public partial class TargetOptions {
        
        private string targetDirJvmField;
        
        private string targetDirClrField;
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string targetDirJvm {
            get {
                return this.targetDirJvmField;
            }
            set {
                this.targetDirJvmField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string targetDirClr {
            get {
                return this.targetDirClrField;
            }
            set {
                this.targetDirClrField = value;
            }
        }
    }
    
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ClassPath))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Assembly))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(Directory))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.38968")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://jni4net.sf.net/0.9.0.0/proxygenConfig.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://jni4net.sf.net/0.9.0.0/proxygenConfig.xsd", IsNullable=true)]
    public abstract partial class TypeContainer : TargetOptions {
        
        private bool generateField;
        
        public TypeContainer() {
            this.generateField = false;
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool generate {
            get {
                return this.generateField;
            }
            set {
                this.generateField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.38968")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://jni4net.sf.net/0.9.0.0/proxygenConfig.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://jni4net.sf.net/0.9.0.0/proxygenConfig.xsd", IsNullable=true)]
    public partial class Assembly : TypeContainer {
        
        private List<TypeRegistration> clrTypeField;
        
        private string fileField;
        
        private string assemblyNameField;
        
        public Assembly() {
            this.clrTypeField = new List<TypeRegistration>();
        }
        
        [System.Xml.Serialization.XmlElementAttribute("clrType", Order=0)]
        public List<TypeRegistration> clrType {
            get {
                return this.clrTypeField;
            }
            set {
                this.clrTypeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string file {
            get {
                return this.fileField;
            }
            set {
                this.fileField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string assemblyName {
            get {
                return this.assemblyNameField;
            }
            set {
                this.assemblyNameField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.38968")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://jni4net.sf.net/0.9.0.0/proxygenConfig.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://jni4net.sf.net/0.9.0.0/proxygenConfig.xsd", IsNullable=true)]
    public partial class Directory : TypeContainer {
        
        private string directoryField;
        
        private string patternField;
        
        private bool recurseField;
        
        public Directory() {
            this.recurseField = false;
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string directory {
            get {
                return this.directoryField;
            }
            set {
                this.directoryField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string pattern {
            get {
                return this.patternField;
            }
            set {
                this.patternField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool recurse {
            get {
                return this.recurseField;
            }
            set {
                this.recurseField = value;
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Xsd2Code", "3.4.0.38968")]
    [System.SerializableAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://jni4net.sf.net/0.9.0.0/proxygenConfig.xsd")]
    [System.Xml.Serialization.XmlRootAttribute(Namespace="http://jni4net.sf.net/0.9.0.0/proxygenConfig.xsd", IsNullable=true)]
    public partial class ImplementsRegistration : ExtendsRegistration {
        
        private bool excludeField;
        
        private bool includeField;
        
        public ImplementsRegistration() {
            this.excludeField = false;
            this.includeField = false;
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool exclude {
            get {
                return this.excludeField;
            }
            set {
                this.excludeField = value;
            }
        }
        
        [System.Xml.Serialization.XmlAttributeAttribute()]
        [System.ComponentModel.DefaultValueAttribute(false)]
        public bool include {
            get {
                return this.includeField;
            }
            set {
                this.includeField = value;
            }
        }
    }
}
