
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using SimpleJSON;

namespace ET
{
public sealed partial class DRUnitConfig : Luban.BeanBase
{
    public DRUnitConfig(JSONNode _buf) 
    {
        { if(!_buf["Id"].IsNumber) { throw new SerializationException(); }  Id = _buf["Id"]; }
        { if(!_buf["Type"].IsNumber) { throw new SerializationException(); }  Type = _buf["Type"]; }
        { if(!_buf["Name"].IsString) { throw new SerializationException(); }  Name = _buf["Name"]; }
        { if(!_buf["Desc"].IsString) { throw new SerializationException(); }  Desc = _buf["Desc"]; }
        { if(!_buf["Position"].IsNumber) { throw new SerializationException(); }  Position = _buf["Position"]; }
        { if(!_buf["Height"].IsNumber) { throw new SerializationException(); }  Height = _buf["Height"]; }
        PostInit();
    }

    public static DRUnitConfig DeserializeDRUnitConfig(JSONNode _buf)
    {
        return new DRUnitConfig(_buf);
    }

    /// <summary>
    /// Id
    /// </summary>
    public readonly int Id;
    /// <summary>
    /// Type
    /// </summary>
    public readonly int Type;
    /// <summary>
    /// 名字
    /// </summary>
    public readonly string Name;
    /// <summary>
    /// 描述
    /// </summary>
    public readonly string Desc;
    /// <summary>
    /// 位置
    /// </summary>
    public readonly int Position;
    /// <summary>
    /// 身高
    /// </summary>
    public readonly int Height;
    public const int __ID__ = -1701961452;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        
        
        
        
        
        
        PostResolve();
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Type:" + Type + ","
        + "Name:" + Name + ","
        + "Desc:" + Desc + ","
        + "Position:" + Position + ","
        + "Height:" + Height + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}
