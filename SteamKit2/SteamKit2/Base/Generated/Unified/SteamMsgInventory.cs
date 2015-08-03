//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#pragma warning disable 1591

// Generated from: steammessages_inventory.steamclient.proto
// Note: requires additional types generated from: google/protobuf/descriptor.proto
// Note: requires additional types generated from: steammessages_unified_base.steamclient.proto
namespace SteamKit2.Unified.Internal
{
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CInventory_GetInventory_Request")]
  public partial class CInventory_GetInventory_Request : global::ProtoBuf.IExtensible
  {
    public CInventory_GetInventory_Request() {}
    

    private uint _appid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"appid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint appid
    {
      get { return _appid; }
      set { _appid = value; }
    }

    private ulong _steamid = default(ulong);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"steamid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong steamid
    {
      get { return _steamid; }
      set { _steamid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CInventory_Response")]
  public partial class CInventory_Response : global::ProtoBuf.IExtensible
  {
    public CInventory_Response() {}
    

    private string _etag = "";
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"etag", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string etag
    {
      get { return _etag; }
      set { _etag = value; }
    }
    private readonly global::System.Collections.Generic.List<ulong> _removeditemids = new global::System.Collections.Generic.List<ulong>();
    [global::ProtoBuf.ProtoMember(2, Name=@"removeditemids", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<ulong> removeditemids
    {
      get { return _removeditemids; }
    }
  

    private string _item_json = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"item_json", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string item_json
    {
      get { return _item_json; }
      set { _item_json = value; }
    }

    private string _itemdef_json = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"itemdef_json", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string itemdef_json
    {
      get { return _itemdef_json; }
      set { _itemdef_json = value; }
    }

    private byte[] _ticket = null;
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"ticket", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(null)]
    public byte[] ticket
    {
      get { return _ticket; }
      set { _ticket = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CInventory_ExchangeItem_Request")]
  public partial class CInventory_ExchangeItem_Request : global::ProtoBuf.IExtensible
  {
    public CInventory_ExchangeItem_Request() {}
    

    private uint _appid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"appid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint appid
    {
      get { return _appid; }
      set { _appid = value; }
    }

    private ulong _steamid = default(ulong);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"steamid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong steamid
    {
      get { return _steamid; }
      set { _steamid = value; }
    }
    private readonly global::System.Collections.Generic.List<ulong> _materialsitemid = new global::System.Collections.Generic.List<ulong>();
    [global::ProtoBuf.ProtoMember(3, Name=@"materialsitemid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<ulong> materialsitemid
    {
      get { return _materialsitemid; }
    }
  
    private readonly global::System.Collections.Generic.List<uint> _materialsquantity = new global::System.Collections.Generic.List<uint>();
    [global::ProtoBuf.ProtoMember(4, Name=@"materialsquantity", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<uint> materialsquantity
    {
      get { return _materialsquantity; }
    }
  

    private ulong _outputitemdefid = default(ulong);
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"outputitemdefid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong outputitemdefid
    {
      get { return _outputitemdefid; }
      set { _outputitemdefid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CInventory_AddItem_Request")]
  public partial class CInventory_AddItem_Request : global::ProtoBuf.IExtensible
  {
    public CInventory_AddItem_Request() {}
    

    private uint _appid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"appid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint appid
    {
      get { return _appid; }
      set { _appid = value; }
    }
    private readonly global::System.Collections.Generic.List<ulong> _itemdefid = new global::System.Collections.Generic.List<ulong>();
    [global::ProtoBuf.ProtoMember(2, Name=@"itemdefid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<ulong> itemdefid
    {
      get { return _itemdefid; }
    }
  
    private readonly global::System.Collections.Generic.List<string> _itempropsjson = new global::System.Collections.Generic.List<string>();
    [global::ProtoBuf.ProtoMember(3, Name=@"itempropsjson", DataFormat = global::ProtoBuf.DataFormat.Default)]
    public global::System.Collections.Generic.List<string> itempropsjson
    {
      get { return _itempropsjson; }
    }
  

    private ulong _steamid = default(ulong);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"steamid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong steamid
    {
      get { return _steamid; }
      set { _steamid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CInventory_SafeModifyItem_Request")]
  public partial class CInventory_SafeModifyItem_Request : global::ProtoBuf.IExtensible
  {
    public CInventory_SafeModifyItem_Request() {}
    

    private uint _appid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"appid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint appid
    {
      get { return _appid; }
      set { _appid = value; }
    }

    private ulong _acctid = default(ulong);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"acctid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong acctid
    {
      get { return _acctid; }
      set { _acctid = value; }
    }

    private ulong _itemid = default(ulong);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"itemid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong itemid
    {
      get { return _itemid; }
      set { _itemid = value; }
    }

    private string _itempropsjson = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"itempropsjson", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string itempropsjson
    {
      get { return _itempropsjson; }
      set { _itempropsjson = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CInventory_ConsumePlaytime_Request")]
  public partial class CInventory_ConsumePlaytime_Request : global::ProtoBuf.IExtensible
  {
    public CInventory_ConsumePlaytime_Request() {}
    

    private uint _appid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"appid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint appid
    {
      get { return _appid; }
      set { _appid = value; }
    }

    private ulong _itemdefid = default(ulong);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"itemdefid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong itemdefid
    {
      get { return _itemdefid; }
      set { _itemdefid = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CInventory_GetItemDefs_Request")]
  public partial class CInventory_GetItemDefs_Request : global::ProtoBuf.IExtensible
  {
    public CInventory_GetItemDefs_Request() {}
    

    private uint _appid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"appid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint appid
    {
      get { return _appid; }
      set { _appid = value; }
    }

    private string _modifiedsince = "";
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"modifiedsince", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string modifiedsince
    {
      get { return _modifiedsince; }
      set { _modifiedsince = value; }
    }

    private bool _includeworkshop = default(bool);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"includeworkshop", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue(default(bool))]
    public bool includeworkshop
    {
      get { return _includeworkshop; }
      set { _includeworkshop = value; }
    }
    private readonly global::System.Collections.Generic.List<ulong> _itemdefids = new global::System.Collections.Generic.List<ulong>();
    [global::ProtoBuf.ProtoMember(4, Name=@"itemdefids", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<ulong> itemdefids
    {
      get { return _itemdefids; }
    }
  
    private readonly global::System.Collections.Generic.List<ulong> _workshopids = new global::System.Collections.Generic.List<ulong>();
    [global::ProtoBuf.ProtoMember(5, Name=@"workshopids", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    public global::System.Collections.Generic.List<ulong> workshopids
    {
      get { return _workshopids; }
    }
  
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CInventory_ConsumeItem_Request")]
  public partial class CInventory_ConsumeItem_Request : global::ProtoBuf.IExtensible
  {
    public CInventory_ConsumeItem_Request() {}
    

    private uint _appid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"appid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint appid
    {
      get { return _appid; }
      set { _appid = value; }
    }

    private ulong _itemid = default(ulong);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"itemid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong itemid
    {
      get { return _itemid; }
      set { _itemid = value; }
    }

    private uint _quantity = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"quantity", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint quantity
    {
      get { return _quantity; }
      set { _quantity = value; }
    }

    private string _timestamp = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"timestamp", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string timestamp
    {
      get { return _timestamp; }
      set { _timestamp = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CInventory_DevSetNextDrop_Request")]
  public partial class CInventory_DevSetNextDrop_Request : global::ProtoBuf.IExtensible
  {
    public CInventory_DevSetNextDrop_Request() {}
    

    private uint _appid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"appid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint appid
    {
      get { return _appid; }
      set { _appid = value; }
    }

    private ulong _itemdefid = default(ulong);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"itemdefid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong itemdefid
    {
      get { return _itemdefid; }
      set { _itemdefid = value; }
    }

    private string _droptime = "";
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"droptime", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string droptime
    {
      get { return _droptime; }
      set { _droptime = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CInventory_SplitItemStack_Request")]
  public partial class CInventory_SplitItemStack_Request : global::ProtoBuf.IExtensible
  {
    public CInventory_SplitItemStack_Request() {}
    

    private uint _appid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"appid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint appid
    {
      get { return _appid; }
      set { _appid = value; }
    }

    private ulong _itemid = default(ulong);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"itemid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong itemid
    {
      get { return _itemid; }
      set { _itemid = value; }
    }

    private uint _quantity = default(uint);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"quantity", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint quantity
    {
      get { return _quantity; }
      set { _quantity = value; }
    }

    private string _timestamp = "";
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"timestamp", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string timestamp
    {
      get { return _timestamp; }
      set { _timestamp = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
  [global::System.Serializable, global::ProtoBuf.ProtoContract(Name=@"CInventory_CombineItemStacks_Request")]
  public partial class CInventory_CombineItemStacks_Request : global::ProtoBuf.IExtensible
  {
    public CInventory_CombineItemStacks_Request() {}
    

    private uint _appid = default(uint);
    [global::ProtoBuf.ProtoMember(1, IsRequired = false, Name=@"appid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint appid
    {
      get { return _appid; }
      set { _appid = value; }
    }

    private ulong _fromitemid = default(ulong);
    [global::ProtoBuf.ProtoMember(2, IsRequired = false, Name=@"fromitemid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong fromitemid
    {
      get { return _fromitemid; }
      set { _fromitemid = value; }
    }

    private ulong _destitemid = default(ulong);
    [global::ProtoBuf.ProtoMember(3, IsRequired = false, Name=@"destitemid", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(ulong))]
    public ulong destitemid
    {
      get { return _destitemid; }
      set { _destitemid = value; }
    }

    private uint _quantity = default(uint);
    [global::ProtoBuf.ProtoMember(4, IsRequired = false, Name=@"quantity", DataFormat = global::ProtoBuf.DataFormat.TwosComplement)]
    [global::System.ComponentModel.DefaultValue(default(uint))]
    public uint quantity
    {
      get { return _quantity; }
      set { _quantity = value; }
    }

    private string _fromtimestamp = "";
    [global::ProtoBuf.ProtoMember(5, IsRequired = false, Name=@"fromtimestamp", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string fromtimestamp
    {
      get { return _fromtimestamp; }
      set { _fromtimestamp = value; }
    }

    private string _desttimestamp = "";
    [global::ProtoBuf.ProtoMember(6, IsRequired = false, Name=@"desttimestamp", DataFormat = global::ProtoBuf.DataFormat.Default)]
    [global::System.ComponentModel.DefaultValue("")]
    public string desttimestamp
    {
      get { return _desttimestamp; }
      set { _desttimestamp = value; }
    }
    private global::ProtoBuf.IExtension extensionObject;
    global::ProtoBuf.IExtension global::ProtoBuf.IExtensible.GetExtensionObject(bool createIfMissing)
      { return global::ProtoBuf.Extensible.GetExtensionObject(ref extensionObject, createIfMissing); }
  }
  
    public interface IInventory
    {
      CInventory_Response GetInventory(CInventory_GetInventory_Request request);
    CInventory_Response ExchangeItem(CInventory_ExchangeItem_Request request);
    CInventory_Response AddPromoItem(CInventory_AddItem_Request request);
    CInventory_Response SafeModifyItem(CInventory_SafeModifyItem_Request request);
    CInventory_Response ConsumePlaytime(CInventory_ConsumePlaytime_Request request);
    CInventory_Response GetItemDefs(CInventory_GetItemDefs_Request request);
    CInventory_Response ConsumeItem(CInventory_ConsumeItem_Request request);
    CInventory_Response DevGenerateItem(CInventory_AddItem_Request request);
    CInventory_Response DevSetNextDrop(CInventory_DevSetNextDrop_Request request);
    CInventory_Response SplitItemStack(CInventory_SplitItemStack_Request request);
    CInventory_Response CombineItemStacks(CInventory_CombineItemStacks_Request request);
    
    }
    
    
}
#pragma warning restore 1591
