using UnityEngine;
using TMPro;

public class InputMirror : MonoBehaviour
{
    [Header("�Է�â (TMP_InputField)")]
    public TMP_InputField inputField;

    [Header("���â (TextMeshProUGUI)")]
    public TextMeshProUGUI monitorText;

    void Start()
    {
        if (inputField != null && monitorText != null)
        {
            // �Է� ������ �ٲ� ������ monitorText�� ����ȭ
            inputField.onValueChanged.AddListener(OnInputChanged);
        }
    }

    void OnDestroy()
    {
        if (inputField != null)
            inputField.onValueChanged.RemoveListener(OnInputChanged);
    }

    private void OnInputChanged(string value)
    {
        monitorText.text = value;
    }
}
