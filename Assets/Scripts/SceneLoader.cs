using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    // 수정된 부분: SceneAsset 대신 string 사용
    [SerializeField]
    private string sceneName;

    public void LoadScene()
    {
        if (!string.IsNullOrEmpty(sceneName))
        {
            // 수정된 부분: sceneName을 직접 전달
            SceneLoadManager.Instance.LoadScene(sceneName);
        }
        else
        {
            Debug.LogError("Scene name is not set in the SceneLoader component.");
        }
    }
}