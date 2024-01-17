
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using SimpleJSON;

namespace Game
{
public sealed partial class DRMusic : Luban.BeanBase
{
    public DRMusic(JSONNode _buf) 
    {
        { if(!_buf["Id"].IsNumber) { throw new SerializationException(); }  Id = _buf["Id"]; }
        { if(!_buf["AssetName"].IsString) { throw new SerializationException(); }  AssetName = _buf["AssetName"]; }
        { if(!_buf["Volume"].IsNumber) { throw new SerializationException(); }  Volume = _buf["Volume"]; }
        PostInit();
    }

    public static DRMusic DeserializeDRMusic(JSONNode _buf)
    {
        return new DRMusic(_buf);
    }

    /// <summary>
    /// 音乐编号
    /// </summary>
    public readonly int Id;
    /// <summary>
    /// 资源名称
    /// </summary>
    public readonly string AssetName;
    /// <summary>
    /// 音量（0~1）
    /// </summary>
    public readonly float Volume;
    public const int __ID__ = -1651958217;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(TablesComponent tables)
    {
        
        
        
        PostResolve();
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "AssetName:" + AssetName + ","
        + "Volume:" + Volume + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}
