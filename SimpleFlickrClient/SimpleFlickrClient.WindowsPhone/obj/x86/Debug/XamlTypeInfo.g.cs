﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------



namespace SimpleFlickrClient
{
    public partial class App : global::Windows.UI.Xaml.Markup.IXamlMetadataProvider
    {
        private global::SimpleFlickrClient.SimpleFlickrClient_WindowsPhone_XamlTypeInfo.XamlTypeInfoProvider _provider;

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(global::System.Type type)
        {
            if(_provider == null)
            {
                _provider = new global::SimpleFlickrClient.SimpleFlickrClient_WindowsPhone_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByType(type);
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlType(string fullName)
        {
            if(_provider == null)
            {
                _provider = new global::SimpleFlickrClient.SimpleFlickrClient_WindowsPhone_XamlTypeInfo.XamlTypeInfoProvider();
            }
            return _provider.GetXamlTypeByName(fullName);
        }

        public global::Windows.UI.Xaml.Markup.XmlnsDefinition[] GetXmlnsDefinitions()
        {
            return new global::Windows.UI.Xaml.Markup.XmlnsDefinition[0];
        }
    }
}

namespace SimpleFlickrClient.SimpleFlickrClient_WindowsPhone_XamlTypeInfo
{
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal partial class XamlTypeInfoProvider
    {
        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByType(global::System.Type type)
        {
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByType.TryGetValue(type, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByType(type);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlType GetXamlTypeByName(string typeName)
        {
            if (string.IsNullOrEmpty(typeName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlType xamlType;
            if (_xamlTypeCacheByName.TryGetValue(typeName, out xamlType))
            {
                return xamlType;
            }
            int typeIndex = LookupTypeIndexByName(typeName);
            if(typeIndex != -1)
            {
                xamlType = CreateXamlType(typeIndex);
            }
            if (xamlType != null)
            {
                _xamlTypeCacheByName.Add(xamlType.FullName, xamlType);
                _xamlTypeCacheByType.Add(xamlType.UnderlyingType, xamlType);
            }
            return xamlType;
        }

        public global::Windows.UI.Xaml.Markup.IXamlMember GetMemberByLongName(string longMemberName)
        {
            if (string.IsNullOrEmpty(longMemberName))
            {
                return null;
            }
            global::Windows.UI.Xaml.Markup.IXamlMember xamlMember;
            if (_xamlMembers.TryGetValue(longMemberName, out xamlMember))
            {
                return xamlMember;
            }
            xamlMember = CreateXamlMember(longMemberName);
            if (xamlMember != null)
            {
                _xamlMembers.Add(longMemberName, xamlMember);
            }
            return xamlMember;
        }

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByName = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>
                _xamlTypeCacheByType = new global::System.Collections.Generic.Dictionary<global::System.Type, global::Windows.UI.Xaml.Markup.IXamlType>();

        global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>
                _xamlMembers = new global::System.Collections.Generic.Dictionary<string, global::Windows.UI.Xaml.Markup.IXamlMember>();

        string[] _typeNameTable = null;
        global::System.Type[] _typeTable = null;

        private void InitTypeTables()
        {
            _typeNameTable = new string[14];
            _typeNameTable[0] = "SimpleFlickrClient.ViewModel.ViewModelLocator";
            _typeNameTable[1] = "Object";
            _typeNameTable[2] = "SimpleFlickrClient.ViewModel.MainViewModel";
            _typeNameTable[3] = "GalaSoft.MvvmLight.ViewModelBase";
            _typeNameTable[4] = "GalaSoft.MvvmLight.ObservableObject";
            _typeNameTable[5] = "SimpleFlickrClient.HubPage";
            _typeNameTable[6] = "Windows.UI.Xaml.Controls.Page";
            _typeNameTable[7] = "Windows.UI.Xaml.Controls.UserControl";
            _typeNameTable[8] = "SimpleFlickrClient.Common.NavigationHelper";
            _typeNameTable[9] = "Windows.UI.Xaml.DependencyObject";
            _typeNameTable[10] = "SimpleFlickrClient.Common.ObservableDictionary";
            _typeNameTable[11] = "String";
            _typeNameTable[12] = "SimpleFlickrClient.SectionPage";
            _typeNameTable[13] = "SimpleFlickrClient.ItemPage";

            _typeTable = new global::System.Type[14];
            _typeTable[0] = typeof(global::SimpleFlickrClient.ViewModel.ViewModelLocator);
            _typeTable[1] = typeof(global::System.Object);
            _typeTable[2] = typeof(global::SimpleFlickrClient.ViewModel.MainViewModel);
            _typeTable[3] = typeof(global::GalaSoft.MvvmLight.ViewModelBase);
            _typeTable[4] = typeof(global::GalaSoft.MvvmLight.ObservableObject);
            _typeTable[5] = typeof(global::SimpleFlickrClient.HubPage);
            _typeTable[6] = typeof(global::Windows.UI.Xaml.Controls.Page);
            _typeTable[7] = typeof(global::Windows.UI.Xaml.Controls.UserControl);
            _typeTable[8] = typeof(global::SimpleFlickrClient.Common.NavigationHelper);
            _typeTable[9] = typeof(global::Windows.UI.Xaml.DependencyObject);
            _typeTable[10] = typeof(global::SimpleFlickrClient.Common.ObservableDictionary);
            _typeTable[11] = typeof(global::System.String);
            _typeTable[12] = typeof(global::SimpleFlickrClient.SectionPage);
            _typeTable[13] = typeof(global::SimpleFlickrClient.ItemPage);
        }

        private int LookupTypeIndexByName(string typeName)
        {
            if (_typeNameTable == null)
            {
                InitTypeTables();
            }
            for (int i=0; i<_typeNameTable.Length; i++)
            {
                if(0 == string.CompareOrdinal(_typeNameTable[i], typeName))
                {
                    return i;
                }
            }
            return -1;
        }

        private int LookupTypeIndexByType(global::System.Type type)
        {
            if (_typeTable == null)
            {
                InitTypeTables();
            }
            for(int i=0; i<_typeTable.Length; i++)
            {
                if(type == _typeTable[i])
                {
                    return i;
                }
            }
            return -1;
        }

        private object Activate_0_ViewModelLocator() { return new global::SimpleFlickrClient.ViewModel.ViewModelLocator(); }
        private object Activate_2_MainViewModel() { return new global::SimpleFlickrClient.ViewModel.MainViewModel(); }
        private object Activate_4_ObservableObject() { return new global::GalaSoft.MvvmLight.ObservableObject(); }
        private object Activate_5_HubPage() { return new global::SimpleFlickrClient.HubPage(); }
        private object Activate_10_ObservableDictionary() { return new global::SimpleFlickrClient.Common.ObservableDictionary(); }
        private object Activate_12_SectionPage() { return new global::SimpleFlickrClient.SectionPage(); }
        private object Activate_13_ItemPage() { return new global::SimpleFlickrClient.ItemPage(); }
        private void MapAdd_10_ObservableDictionary(object instance, object key, object item)
        {
            var collection = (global::System.Collections.Generic.IDictionary<global::System.String, global::System.Object>)instance;
            var newKey = (global::System.String)key;
            var newItem = (global::System.Object)item;
            collection.Add(newKey, newItem);
        }

        private global::Windows.UI.Xaml.Markup.IXamlType CreateXamlType(int typeIndex)
        {
            global::SimpleFlickrClient.SimpleFlickrClient_WindowsPhone_XamlTypeInfo.XamlSystemBaseType xamlType = null;
            global::SimpleFlickrClient.SimpleFlickrClient_WindowsPhone_XamlTypeInfo.XamlUserType userType;
            string typeName = _typeNameTable[typeIndex];
            global::System.Type type = _typeTable[typeIndex];

            switch (typeIndex)
            {

            case 0:   //  SimpleFlickrClient.ViewModel.ViewModelLocator
                userType = new global::SimpleFlickrClient.SimpleFlickrClient_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_0_ViewModelLocator;
                userType.AddMemberName("Main");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 1:   //  Object
                xamlType = new global::SimpleFlickrClient.SimpleFlickrClient_WindowsPhone_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 2:   //  SimpleFlickrClient.ViewModel.MainViewModel
                userType = new global::SimpleFlickrClient.SimpleFlickrClient_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("GalaSoft.MvvmLight.ViewModelBase"));
                userType.SetIsReturnTypeStub();
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 3:   //  GalaSoft.MvvmLight.ViewModelBase
                userType = new global::SimpleFlickrClient.SimpleFlickrClient_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("GalaSoft.MvvmLight.ObservableObject"));
                xamlType = userType;
                break;

            case 4:   //  GalaSoft.MvvmLight.ObservableObject
                userType = new global::SimpleFlickrClient.SimpleFlickrClient_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.Activator = Activate_4_ObservableObject;
                xamlType = userType;
                break;

            case 5:   //  SimpleFlickrClient.HubPage
                userType = new global::SimpleFlickrClient.SimpleFlickrClient_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_5_HubPage;
                userType.AddMemberName("NavigationHelper");
                userType.AddMemberName("DefaultViewModel");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 6:   //  Windows.UI.Xaml.Controls.Page
                xamlType = new global::SimpleFlickrClient.SimpleFlickrClient_WindowsPhone_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 7:   //  Windows.UI.Xaml.Controls.UserControl
                xamlType = new global::SimpleFlickrClient.SimpleFlickrClient_WindowsPhone_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 8:   //  SimpleFlickrClient.Common.NavigationHelper
                userType = new global::SimpleFlickrClient.SimpleFlickrClient_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.DependencyObject"));
                userType.SetIsReturnTypeStub();
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 9:   //  Windows.UI.Xaml.DependencyObject
                xamlType = new global::SimpleFlickrClient.SimpleFlickrClient_WindowsPhone_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 10:   //  SimpleFlickrClient.Common.ObservableDictionary
                userType = new global::SimpleFlickrClient.SimpleFlickrClient_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Object"));
                userType.DictionaryAdd = MapAdd_10_ObservableDictionary;
                userType.SetIsReturnTypeStub();
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 11:   //  String
                xamlType = new global::SimpleFlickrClient.SimpleFlickrClient_WindowsPhone_XamlTypeInfo.XamlSystemBaseType(typeName, type);
                break;

            case 12:   //  SimpleFlickrClient.SectionPage
                userType = new global::SimpleFlickrClient.SimpleFlickrClient_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_12_SectionPage;
                userType.AddMemberName("NavigationHelper");
                userType.AddMemberName("DefaultViewModel");
                userType.SetIsLocalType();
                xamlType = userType;
                break;

            case 13:   //  SimpleFlickrClient.ItemPage
                userType = new global::SimpleFlickrClient.SimpleFlickrClient_WindowsPhone_XamlTypeInfo.XamlUserType(this, typeName, type, GetXamlTypeByName("Windows.UI.Xaml.Controls.Page"));
                userType.Activator = Activate_13_ItemPage;
                userType.AddMemberName("NavigationHelper");
                userType.AddMemberName("DefaultViewModel");
                userType.SetIsLocalType();
                xamlType = userType;
                break;
            }
            return xamlType;
        }


        private object get_0_ViewModelLocator_Main(object instance)
        {
            var that = (global::SimpleFlickrClient.ViewModel.ViewModelLocator)instance;
            return that.Main;
        }
        private object get_1_HubPage_NavigationHelper(object instance)
        {
            var that = (global::SimpleFlickrClient.HubPage)instance;
            return that.NavigationHelper;
        }
        private object get_2_HubPage_DefaultViewModel(object instance)
        {
            var that = (global::SimpleFlickrClient.HubPage)instance;
            return that.DefaultViewModel;
        }
        private object get_3_SectionPage_NavigationHelper(object instance)
        {
            var that = (global::SimpleFlickrClient.SectionPage)instance;
            return that.NavigationHelper;
        }
        private object get_4_SectionPage_DefaultViewModel(object instance)
        {
            var that = (global::SimpleFlickrClient.SectionPage)instance;
            return that.DefaultViewModel;
        }
        private object get_5_ItemPage_NavigationHelper(object instance)
        {
            var that = (global::SimpleFlickrClient.ItemPage)instance;
            return that.NavigationHelper;
        }
        private object get_6_ItemPage_DefaultViewModel(object instance)
        {
            var that = (global::SimpleFlickrClient.ItemPage)instance;
            return that.DefaultViewModel;
        }

        private global::Windows.UI.Xaml.Markup.IXamlMember CreateXamlMember(string longMemberName)
        {
            global::SimpleFlickrClient.SimpleFlickrClient_WindowsPhone_XamlTypeInfo.XamlMember xamlMember = null;
            global::SimpleFlickrClient.SimpleFlickrClient_WindowsPhone_XamlTypeInfo.XamlUserType userType;

            switch (longMemberName)
            {
            case "SimpleFlickrClient.ViewModel.ViewModelLocator.Main":
                userType = (global::SimpleFlickrClient.SimpleFlickrClient_WindowsPhone_XamlTypeInfo.XamlUserType)GetXamlTypeByName("SimpleFlickrClient.ViewModel.ViewModelLocator");
                xamlMember = new global::SimpleFlickrClient.SimpleFlickrClient_WindowsPhone_XamlTypeInfo.XamlMember(this, "Main", "SimpleFlickrClient.ViewModel.MainViewModel");
                xamlMember.Getter = get_0_ViewModelLocator_Main;
                xamlMember.SetIsReadOnly();
                break;
            case "SimpleFlickrClient.HubPage.NavigationHelper":
                userType = (global::SimpleFlickrClient.SimpleFlickrClient_WindowsPhone_XamlTypeInfo.XamlUserType)GetXamlTypeByName("SimpleFlickrClient.HubPage");
                xamlMember = new global::SimpleFlickrClient.SimpleFlickrClient_WindowsPhone_XamlTypeInfo.XamlMember(this, "NavigationHelper", "SimpleFlickrClient.Common.NavigationHelper");
                xamlMember.Getter = get_1_HubPage_NavigationHelper;
                xamlMember.SetIsReadOnly();
                break;
            case "SimpleFlickrClient.HubPage.DefaultViewModel":
                userType = (global::SimpleFlickrClient.SimpleFlickrClient_WindowsPhone_XamlTypeInfo.XamlUserType)GetXamlTypeByName("SimpleFlickrClient.HubPage");
                xamlMember = new global::SimpleFlickrClient.SimpleFlickrClient_WindowsPhone_XamlTypeInfo.XamlMember(this, "DefaultViewModel", "SimpleFlickrClient.Common.ObservableDictionary");
                xamlMember.Getter = get_2_HubPage_DefaultViewModel;
                xamlMember.SetIsReadOnly();
                break;
            case "SimpleFlickrClient.SectionPage.NavigationHelper":
                userType = (global::SimpleFlickrClient.SimpleFlickrClient_WindowsPhone_XamlTypeInfo.XamlUserType)GetXamlTypeByName("SimpleFlickrClient.SectionPage");
                xamlMember = new global::SimpleFlickrClient.SimpleFlickrClient_WindowsPhone_XamlTypeInfo.XamlMember(this, "NavigationHelper", "SimpleFlickrClient.Common.NavigationHelper");
                xamlMember.Getter = get_3_SectionPage_NavigationHelper;
                xamlMember.SetIsReadOnly();
                break;
            case "SimpleFlickrClient.SectionPage.DefaultViewModel":
                userType = (global::SimpleFlickrClient.SimpleFlickrClient_WindowsPhone_XamlTypeInfo.XamlUserType)GetXamlTypeByName("SimpleFlickrClient.SectionPage");
                xamlMember = new global::SimpleFlickrClient.SimpleFlickrClient_WindowsPhone_XamlTypeInfo.XamlMember(this, "DefaultViewModel", "SimpleFlickrClient.Common.ObservableDictionary");
                xamlMember.Getter = get_4_SectionPage_DefaultViewModel;
                xamlMember.SetIsReadOnly();
                break;
            case "SimpleFlickrClient.ItemPage.NavigationHelper":
                userType = (global::SimpleFlickrClient.SimpleFlickrClient_WindowsPhone_XamlTypeInfo.XamlUserType)GetXamlTypeByName("SimpleFlickrClient.ItemPage");
                xamlMember = new global::SimpleFlickrClient.SimpleFlickrClient_WindowsPhone_XamlTypeInfo.XamlMember(this, "NavigationHelper", "SimpleFlickrClient.Common.NavigationHelper");
                xamlMember.Getter = get_5_ItemPage_NavigationHelper;
                xamlMember.SetIsReadOnly();
                break;
            case "SimpleFlickrClient.ItemPage.DefaultViewModel":
                userType = (global::SimpleFlickrClient.SimpleFlickrClient_WindowsPhone_XamlTypeInfo.XamlUserType)GetXamlTypeByName("SimpleFlickrClient.ItemPage");
                xamlMember = new global::SimpleFlickrClient.SimpleFlickrClient_WindowsPhone_XamlTypeInfo.XamlMember(this, "DefaultViewModel", "SimpleFlickrClient.Common.ObservableDictionary");
                xamlMember.Getter = get_6_ItemPage_DefaultViewModel;
                xamlMember.SetIsReadOnly();
                break;
            }
            return xamlMember;
        }
    }

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlSystemBaseType : global::Windows.UI.Xaml.Markup.IXamlType
    {
        string _fullName;
        global::System.Type _underlyingType;

        public XamlSystemBaseType(string fullName, global::System.Type underlyingType)
        {
            _fullName = fullName;
            _underlyingType = underlyingType;
        }

        public string FullName { get { return _fullName; } }

        public global::System.Type UnderlyingType
        {
            get
            {
                return _underlyingType;
            }
        }

        virtual public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name) { throw new global::System.NotImplementedException(); }
        virtual public bool IsArray { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsCollection { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsConstructible { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsDictionary { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsMarkupExtension { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsBindable { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsReturnTypeStub { get { throw new global::System.NotImplementedException(); } }
        virtual public bool IsLocalType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType ItemType { get { throw new global::System.NotImplementedException(); } }
        virtual public global::Windows.UI.Xaml.Markup.IXamlType KeyType { get { throw new global::System.NotImplementedException(); } }
        virtual public object ActivateInstance() { throw new global::System.NotImplementedException(); }
        virtual public void AddToMap(object instance, object key, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void AddToVector(object instance, object item)  { throw new global::System.NotImplementedException(); }
        virtual public void RunInitializer()   { throw new global::System.NotImplementedException(); }
        virtual public object CreateFromString(string input)   { throw new global::System.NotImplementedException(); }
    }
    
    internal delegate object Activator();
    internal delegate void AddToCollection(object instance, object item);
    internal delegate void AddToDictionary(object instance, object key, object item);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlUserType : global::SimpleFlickrClient.SimpleFlickrClient_WindowsPhone_XamlTypeInfo.XamlSystemBaseType
    {
        global::SimpleFlickrClient.SimpleFlickrClient_WindowsPhone_XamlTypeInfo.XamlTypeInfoProvider _provider;
        global::Windows.UI.Xaml.Markup.IXamlType _baseType;
        bool _isArray;
        bool _isMarkupExtension;
        bool _isBindable;
        bool _isReturnTypeStub;
        bool _isLocalType;

        string _contentPropertyName;
        string _itemTypeName;
        string _keyTypeName;
        global::System.Collections.Generic.Dictionary<string, string> _memberNames;
        global::System.Collections.Generic.Dictionary<string, object> _enumValues;

        public XamlUserType(global::SimpleFlickrClient.SimpleFlickrClient_WindowsPhone_XamlTypeInfo.XamlTypeInfoProvider provider, string fullName, global::System.Type fullType, global::Windows.UI.Xaml.Markup.IXamlType baseType)
            :base(fullName, fullType)
        {
            _provider = provider;
            _baseType = baseType;
        }

        // --- Interface methods ----

        override public global::Windows.UI.Xaml.Markup.IXamlType BaseType { get { return _baseType; } }
        override public bool IsArray { get { return _isArray; } }
        override public bool IsCollection { get { return (CollectionAdd != null); } }
        override public bool IsConstructible { get { return (Activator != null); } }
        override public bool IsDictionary { get { return (DictionaryAdd != null); } }
        override public bool IsMarkupExtension { get { return _isMarkupExtension; } }
        override public bool IsBindable { get { return _isBindable; } }
        override public bool IsReturnTypeStub { get { return _isReturnTypeStub; } }
        override public bool IsLocalType { get { return _isLocalType; } }

        override public global::Windows.UI.Xaml.Markup.IXamlMember ContentProperty
        {
            get { return _provider.GetMemberByLongName(_contentPropertyName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType ItemType
        {
            get { return _provider.GetXamlTypeByName(_itemTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlType KeyType
        {
            get { return _provider.GetXamlTypeByName(_keyTypeName); }
        }

        override public global::Windows.UI.Xaml.Markup.IXamlMember GetMember(string name)
        {
            if (_memberNames == null)
            {
                return null;
            }
            string longName;
            if (_memberNames.TryGetValue(name, out longName))
            {
                return _provider.GetMemberByLongName(longName);
            }
            return null;
        }

        override public object ActivateInstance()
        {
            return Activator(); 
        }

        override public void AddToMap(object instance, object key, object item) 
        {
            DictionaryAdd(instance, key, item);
        }

        override public void AddToVector(object instance, object item)
        {
            CollectionAdd(instance, item);
        }

        override public void RunInitializer() 
        {
            System.Runtime.CompilerServices.RuntimeHelpers.RunClassConstructor(UnderlyingType.TypeHandle);
        }

        override public object CreateFromString(string input)
        {
            if (_enumValues != null)
            {
                int value = 0;

                string[] valueParts = input.Split(',');

                foreach (string valuePart in valueParts) 
                {
                    object partValue;
                    int enumFieldValue = 0;
                    try
                    {
                        if (_enumValues.TryGetValue(valuePart.Trim(), out partValue))
                        {
                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                        }
                        else
                        {
                            try
                            {
                                enumFieldValue = global::System.Convert.ToInt32(valuePart.Trim());
                            }
                            catch( global::System.FormatException )
                            {
                                foreach( string key in _enumValues.Keys )
                                {
                                    if( string.Compare(valuePart.Trim(), key, global::System.StringComparison.OrdinalIgnoreCase) == 0 )
                                    {
                                        if( _enumValues.TryGetValue(key.Trim(), out partValue) )
                                        {
                                            enumFieldValue = global::System.Convert.ToInt32(partValue);
                                            break;
                                        }
                                    }
                                }
                            }
                        }
                        value |= enumFieldValue; 
                    }
                    catch( global::System.FormatException )
                    {
                        throw new global::System.ArgumentException(input, FullName);
                    }
                }

                return value; 
            }
            throw new global::System.ArgumentException(input, FullName);
        }

        // --- End of Interface methods

        public Activator Activator { get; set; }
        public AddToCollection CollectionAdd { get; set; }
        public AddToDictionary DictionaryAdd { get; set; }

        public void SetContentPropertyName(string contentPropertyName)
        {
            _contentPropertyName = contentPropertyName;
        }

        public void SetIsArray()
        {
            _isArray = true; 
        }

        public void SetIsMarkupExtension()
        {
            _isMarkupExtension = true;
        }

        public void SetIsBindable()
        {
            _isBindable = true;
        }

        public void SetIsReturnTypeStub()
        {
            _isReturnTypeStub = true;
        }

        public void SetIsLocalType()
        {
            _isLocalType = true;
        }

        public void SetItemTypeName(string itemTypeName)
        {
            _itemTypeName = itemTypeName;
        }

        public void SetKeyTypeName(string keyTypeName)
        {
            _keyTypeName = keyTypeName;
        }

        public void AddMemberName(string shortName)
        {
            if(_memberNames == null)
            {
                _memberNames =  new global::System.Collections.Generic.Dictionary<string,string>();
            }
            _memberNames.Add(shortName, FullName + "." + shortName);
        }

        public void AddEnumValue(string name, object value)
        {
            if (_enumValues == null)
            {
                _enumValues = new global::System.Collections.Generic.Dictionary<string, object>();
            }
            _enumValues.Add(name, value);
        }
    }

    internal delegate object Getter(object instance);
    internal delegate void Setter(object instance, object value);

    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks", "4.0.0.0")]    
    [System.Diagnostics.DebuggerNonUserCodeAttribute()]
    internal class XamlMember : global::Windows.UI.Xaml.Markup.IXamlMember
    {
        global::SimpleFlickrClient.SimpleFlickrClient_WindowsPhone_XamlTypeInfo.XamlTypeInfoProvider _provider;
        string _name;
        bool _isAttachable;
        bool _isDependencyProperty;
        bool _isReadOnly;

        string _typeName;
        string _targetTypeName;

        public XamlMember(global::SimpleFlickrClient.SimpleFlickrClient_WindowsPhone_XamlTypeInfo.XamlTypeInfoProvider provider, string name, string typeName)
        {
            _name = name;
            _typeName = typeName;
            _provider = provider;
        }

        public string Name { get { return _name; } }

        public global::Windows.UI.Xaml.Markup.IXamlType Type
        {
            get { return _provider.GetXamlTypeByName(_typeName); }
        }

        public void SetTargetTypeName(string targetTypeName)
        {
            _targetTypeName = targetTypeName;
        }
        public global::Windows.UI.Xaml.Markup.IXamlType TargetType
        {
            get { return _provider.GetXamlTypeByName(_targetTypeName); }
        }

        public void SetIsAttachable() { _isAttachable = true; }
        public bool IsAttachable { get { return _isAttachable; } }

        public void SetIsDependencyProperty() { _isDependencyProperty = true; }
        public bool IsDependencyProperty { get { return _isDependencyProperty; } }

        public void SetIsReadOnly() { _isReadOnly = true; }
        public bool IsReadOnly { get { return _isReadOnly; } }

        public Getter Getter { get; set; }
        public object GetValue(object instance)
        {
            if (Getter != null)
                return Getter(instance);
            else
                throw new global::System.InvalidOperationException("GetValue");
        }

        public Setter Setter { get; set; }
        public void SetValue(object instance, object value)
        {
            if (Setter != null)
                Setter(instance, value);
            else
                throw new global::System.InvalidOperationException("SetValue");
        }
    }
}


