using UnityEngine;
using System.Collections.Generic;
using UnityEngine.AddressableAssets;

namespace ProjectCronos
{
    [CreateAssetMenu(menuName = "Create ScenarioSceneData", fileName = "ScenarioSceneData")]
    public class ScenarioSceneScriptableObject : ScriptableObject
    {
        public List<string> scenarioTexts;
    }
}
