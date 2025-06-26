using UnityEngine;

public class SceneLoader : MonoBehaviour
{
    // ������ �κ�: SceneAsset ��� string ���
    [SerializeField]
    private string sceneName;

    public void LoadScene()
    {
        if (!string.IsNullOrEmpty(sceneName))
        {
            // ������ �κ�: sceneName�� ���� ����
            SceneLoadManager.Instance.LoadScene(sceneName);
        }
        else
        {
            Debug.LogError("Scene name is not set in the SceneLoader component.");
        }
    }
}