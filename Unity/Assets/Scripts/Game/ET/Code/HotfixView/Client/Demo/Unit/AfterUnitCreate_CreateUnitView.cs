﻿using Cysharp.Threading.Tasks;
using Game;
using UnityEngine;
using UnityGameFramework.Extension;
using UnityGameFramework.Runtime;
using GameEntry = Game.GameEntry;

namespace ET.Client
{
    [Event(SceneType.Current)]
    public class AfterUnitCreate_CreateUnitView: AEvent<Scene, EventType.AfterUnitCreate>
    {
        protected override async UniTask Run(Scene scene, EventType.AfterUnitCreate args)
        {
            GameEntry.Camera.SceneCamera.transform.position = new Vector3(2, 35, -32);
            GameEntry.Camera.SceneCamera.transform.rotation = Quaternion.Euler(60, 0, 0);
            
            Unit unit = args.Unit;
            // Unit View层
            // 这里资源需要卸载，Demo就不搞了
            GameObject unitGo = await GameEntry.Resource.LoadAssetAsync<GameObject>(AssetUtility.GetPrefabAsset("Skeleton/Skeleton"));

            GameObject go = UnityEngine.Object.Instantiate(unitGo);
            go.transform.position = unit.Position;
            unit.AddComponent<GameObjectComponent>().GameObject = go;
            unit.AddComponent<AnimatorComponent>();
            await UniTask.CompletedTask;
        }
    }
}