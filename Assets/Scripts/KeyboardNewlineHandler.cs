using UnityEngine;
using TMPro;
using Microsoft.MixedReality.Toolkit.Experimental.UI;

public class KeyboardNewlineHandler : MonoBehaviour
{
    public void InsertNewLine()
    {
        TMP_InputField inputField = NonNativeKeyboard.Instance.InputField;
        if (inputField != null)
        {
            // ���� Ŀ�� ��ġ ��������
            int caretIndex = inputField.caretPosition;

            // �ؽ�Ʈ ����: Ŀ�� ��ġ ���� ��/�ڷ� ������
            string before = inputField.text.Substring(0, caretIndex);
            string after = inputField.text.Substring(caretIndex);
            inputField.text = before + "\n" + after;

            // �ؽ�Ʈ ����� ���� Ŀ�� ��ġ �ٽ� ����
            inputField.caretPosition = caretIndex + 1;
            inputField.selectionAnchorPosition = inputField.caretPosition;
            inputField.selectionFocusPosition = inputField.caretPosition;

            // �� ActivateInputField()�� ȣ������ ���� �� Ŀ�� �ʱ�ȭ ����
        }
    }
}
