//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;



namespace Game.Editor.item
{

public sealed partial class ItemExchange :  Bright.Config.EditorBeanBase 
{
    public ItemExchange()
    {
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["id"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  Id = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["num"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  Num = _fieldJson;
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {
        _json["$type"] = "item.ItemExchange";
        {
            _json["id"] = new JSONNumber(Id);
        }
        {
            _json["num"] = new JSONNumber(Num);
        }
    }

    public static ItemExchange LoadJsonItemExchange(SimpleJSON.JSONNode _json)
    {
        ItemExchange obj = new item.ItemExchange();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonItemExchange(ItemExchange _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    /// <summary>
    /// 道具id
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 道具数量
    /// </summary>
    public int Num { get; set; }

}

}