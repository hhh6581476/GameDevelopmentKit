
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;

namespace Game
{
public sealed partial class DRScene : Luban.BeanBase
{
    public DRScene(ByteBuf _buf) 
    {
        Id = _buf.ReadInt();
        AssetName = _buf.ReadString();
        BackgroundMusicId = _buf.ReadInt();
        PostInit();
    }

    public static DRScene DeserializeDRScene(ByteBuf _buf)
    {
        return new DRScene(_buf);
    }

    /// <summary>
    /// 场景编号
    /// </summary>
    public readonly int Id;
    /// <summary>
    /// 资源名称
    /// </summary>
    public readonly string AssetName;
    /// <summary>
    /// 背景音乐编号
    /// </summary>
    public readonly int BackgroundMusicId;
    public const int __ID__ = -1646966626;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(TablesComponent tables)
    {
        PostResolveRef();
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "AssetName:" + AssetName + ","
        + "BackgroundMusicId:" + BackgroundMusicId + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolveRef();
}
}
