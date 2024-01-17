
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Luban;
using SimpleJSON;

namespace Game.Hot
{
public sealed partial class DRWeapon : Luban.BeanBase
{
    public DRWeapon(JSONNode _buf) 
    {
        { if(!_buf["Id"].IsNumber) { throw new SerializationException(); }  Id = _buf["Id"]; }
        { if(!_buf["Attack"].IsNumber) { throw new SerializationException(); }  Attack = _buf["Attack"]; }
        { if(!_buf["AttackInterval"].IsNumber) { throw new SerializationException(); }  AttackInterval = _buf["AttackInterval"]; }
        { if(!_buf["BulletId"].IsNumber) { throw new SerializationException(); }  BulletId = _buf["BulletId"]; }
        { if(!_buf["BulletSpeed"].IsNumber) { throw new SerializationException(); }  BulletSpeed = _buf["BulletSpeed"]; }
        { if(!_buf["BulletSoundId"].IsNumber) { throw new SerializationException(); }  BulletSoundId = _buf["BulletSoundId"]; }
        PostInit();
    }

    public static DRWeapon DeserializeDRWeapon(JSONNode _buf)
    {
        return new DRWeapon(_buf);
    }

    /// <summary>
    /// 武器编号
    /// </summary>
    public readonly int Id;
    /// <summary>
    /// 攻击力
    /// </summary>
    public readonly int Attack;
    /// <summary>
    /// 攻击间隔
    /// </summary>
    public readonly float AttackInterval;
    /// <summary>
    /// 子弹编号
    /// </summary>
    public readonly int BulletId;
    /// <summary>
    /// 子弹速度
    /// </summary>
    public readonly float BulletSpeed;
    /// <summary>
    /// 子弹声音编号
    /// </summary>
    public readonly int BulletSoundId;
    public const int __ID__ = 599888970;
    public override int GetTypeId() => __ID__;

    public  void ResolveRef(Tables tables)
    {
        
        
        
        
        
        
        PostResolve();
    }

    public override string ToString()
    {
        return "{ "
        + "Id:" + Id + ","
        + "Attack:" + Attack + ","
        + "AttackInterval:" + AttackInterval + ","
        + "BulletId:" + BulletId + ","
        + "BulletSpeed:" + BulletSpeed + ","
        + "BulletSoundId:" + BulletSoundId + ","
        + "}";
    }

    partial void PostInit();
    partial void PostResolve();
}
}
