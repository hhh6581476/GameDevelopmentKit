
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
public partial class DTMusic : IDataTable
{
    private readonly System.Collections.Generic.Dictionary<int, DRMusic> _dataMap;
    private readonly System.Collections.Generic.List<DRMusic> _dataList;
    private readonly System.Func<Cysharp.Threading.Tasks.UniTask<JSONNode>> _loadFunc;

    public DTMusic(System.Func<Cysharp.Threading.Tasks.UniTask<JSONNode>> loadFunc)
    {
        _loadFunc = loadFunc;
        _dataMap = new System.Collections.Generic.Dictionary<int, DRMusic>();
        _dataList = new System.Collections.Generic.List<DRMusic>();
    }

    public async Cysharp.Threading.Tasks.UniTask LoadAsync()
    {
        JSONNode _json = await _loadFunc();
        _dataMap.Clear();
        _dataList.Clear();
        foreach(JSONNode _ele in _json.Children)
        {
            DRMusic _v;
            { if(!_ele.IsObject) { throw new SerializationException(); }  _v = DRMusic.DeserializeDRMusic(_ele);  }
            _dataList.Add(_v);
            _dataMap.Add(_v.Id, _v);
        }
        PostInit();
    }

    public System.Collections.Generic.Dictionary<int, DRMusic> DataMap => _dataMap;
    public System.Collections.Generic.List<DRMusic> DataList => _dataList;
    public DRMusic GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public DRMusic Get(int key) => _dataMap[key];
    public DRMusic this[int key] => _dataMap[key];

    public void ResolveRef(TablesComponent tables)
    {
        foreach(var _v in _dataList)
        {
            _v.ResolveRef(tables);
        }
        PostResolve();
    }


    partial void PostInit();
    partial void PostResolve();
}
}

