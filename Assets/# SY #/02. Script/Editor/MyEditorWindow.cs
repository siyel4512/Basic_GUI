using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor; // unity editor ���� api�� ����ϱ����� ����

public class MyEditorWindow : EditorWindow
{
    #region EditorWindow ���� ���� ���1

    //static MyEditorWindow window;

    //[MenuItem("MyTool/Open MyTool %g")]
    //static void Open()
    //{
    //    Debug.Log("My Tool â ����");

    //    window = CreateInstance<MyEditorWindow>(); // EditorWindow�� ������

    //    window.Show();
    //}

    #endregion



    #region 1���� EditorWindow ���� ���1

    //static MyEditorWindow window;

    //[MenuItem("MyTool/Open MyTool %g")]
    //static void Open()
    //{
    //    Debug.Log("My Tool â ����");

    //     ���� ������ �������� ���� EditorWindow�� �����Ǿ����� Ȯ��
    //    if (window == null)
    //    {
    //        window = CreateInstance<MyEditorWindow>();
    //    }

    //    window.Show();
    //}

    #endregion



    #region 1���� EditorWindow ���� ���2

    // ���� editor window�� ������ ���� �Լ� ����, static ����
    // unity editor�� �޴����� �޴�â�� �����ϸ� �ش� �Լ��� ����(ȣ��ȴ�.)
    //MenuItem���� %g�� ����Ű�� �ǹ��ϸ� crtl + g�� �ǹ��Ѵ�.
    // ���� ��α� https://debuglog.tistory.com/28
    [MenuItem("MyTool/Open MyTool %g")]
    static void Open()
    {
        Debug.Log("My Tool â ����");

        // EditorWindow ���� (�Ѱ��� ������
        var window = GetWindow<MyEditorWindow>();

        // EditorWindow �̸� ���� (�������ϸ� default ������ Editor Window�� �ȴ�.)
        window.title = "My Tool";
    }
    #endregion

    #region GUI �׸���

    // GUI�� �׸��� ���ؼ� EditorWindow���� ����ϴ� ����� OnGUI()�� �����ؾ��� ����Ƽ���� ȣ������
    private void OnGUI()
    {
        // EditorGUILayout�� ���� �����ϱ� ���� �ʵ���� ���ִ� Ŭ�����̴�.
        EditorGUILayout.LabelField("Label!!!");
        EditorGUILayout.TextField("TextField!!!");

        // GUILayout�� ��κ� Layout���� ���� Rect�� �����Ͽ� �׸��� �ʵ���� ���ִ� Ŭ�����̴�.
        GUILayout.Button("Button!!!");

        //GUI
        //EditorGUI
        //GUILayout
        //EditorGUILayout
    }

    #endregion
}
