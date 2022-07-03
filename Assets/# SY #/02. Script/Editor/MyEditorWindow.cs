using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor; // unity editor ���� api�� ����ϱ����� ����

public class MyEditorWindow : EditorWindow
{
    // ���� editor window�� ������ ���� �Լ� ����, static ����
    // unity editor�� �޴����� �޴�â�� �����ϸ� �ش� �Լ��� ����(ȣ��ȴ�.)
    //MenuItem���� %g�� ����Ű�� �ǹ��ϸ� crtl + g�� �ǹ��Ѵ�.
    // ���� ��α� https://debuglog.tistory.com/28
    [MenuItem("MyTool/Open MyTool %g")]
    static void Open()
    {
        Debug.Log("My Tool â ����");

        // window â ����
        var window = GetWindow<MyEditorWindow>();
        window.title = "My Tool";
    }
}
