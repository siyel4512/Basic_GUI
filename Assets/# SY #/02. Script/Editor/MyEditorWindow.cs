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



    #region GUI �׸���1

    //// GUI�� �׸��� ���ؼ� EditorWindow���� ����ϴ� ����� OnGUI()�� �����ؾ��� ����Ƽ���� ȣ������
    //private void OnGUI()
    //{
    //    // EditorGUILayout�� ���� �����ϱ� ���� �ʵ���� ���ִ� Ŭ�����̴�.
    //    EditorGUILayout.LabelField("Label!!!");
    //    EditorGUILayout.TextField("TextField!!!");

    //    // GUILayout�� ��κ� Layout���� ���� Rect�� �����Ͽ� �׸��� �ʵ���� ���ִ� Ŭ�����̴�.
    //    GUILayout.Button("Button!!!");
    //}

    #endregion



    #region GUI �׸���2

    //private void OnGUI()
    //{
    //    // Layout -> ����Ƽ�� �ڵ� ���̾ƿ� �̿��ϴ� ������ GUI��, �� ���� ��ġ�� �������� �ʿ� ����
    //    // GUI / GUILayout : Editor / ��Ÿ�ӿ� (�����Ŀ��� ��밡��)
    //    // EditorGUI / EditorGUILayout : Only Editor��

    //    GUI.Label(new Rect(250, 0, 100, 50), "GUI.Label");
    //    EditorGUI.LabelField(new Rect(250, 50, 100, 50), "EditorGUI.LabelField(");

    //    GUILayout.Label("GUILayout.Label");
    //    EditorGUILayout.LabelField("EditorGUILayout.LabelField");
    //}

    #endregion



    #region GUI �׸���3 (����� ����� GUI ��� �׷� ����غ���

    int intValue;
    float floatValue;
    Color colorValue;
    Gradient gradientValue = new Gradient();
    Vector3 vector3Value;
    Vector3Int vector3IntValue;
    Rect rectValue;
    UnityEngine.Object objectValue;
    string passwordValue;
    string tagValue;
    UnityEngine.ParticleSystemCollisionType enumValue;
    bool toggleValue;
    string[] stringArr = new string[] { "String01", "String02", "String03", "String04", "String05", "String06"};
    int selectionValue;

    private void OnGUI()
    {
        #region ===:: EditorGUILayout:: ===
        // https://blog.naver.com/PostView.naver?blogId=hammerimpact&logNo=220772494827&parentCategoryNo=&categoryNo=&viewDate=&isShowPopularPosts=false&from=postView

        // int field
        intValue = EditorGUILayout.IntField("int ��", intValue);

        // float field
        floatValue = EditorGUILayout.FloatField("float ��", floatValue);

        // color field
        colorValue = EditorGUILayout.ColorField("color ��", colorValue);

        // gradient field
        gradientValue = EditorGUILayout.GradientField("gradient ��", gradientValue);

        // vector3 field
        vector3Value = EditorGUILayout.Vector3Field("vector3 ��", vector3Value);

        // vector3Int field
        vector3IntValue = EditorGUILayout.Vector3IntField("vector3Int ��", vector3IntValue);

        //rect field
        rectValue = EditorGUILayout.RectField("rect ��", rectValue);

        // object field
        objectValue = EditorGUILayout.ObjectField("obect ��", objectValue, typeof(UnityEngine.Object), false);

        // password field
        passwordValue = EditorGUILayout.PasswordField("password ��", passwordValue);

        // tag ��
        tagValue = EditorGUILayout.TagField("tag ��", tagValue);

        EditorGUILayout.Space(15);

        // enum type field
        enumValue = (UnityEngine.ParticleSystemCollisionType)EditorGUILayout.EnumFlagsField("enum ��", enumValue);

        // slider
        floatValue = EditorGUILayout.Slider("slider", floatValue, 0, 100);

        // help box
        EditorGUILayout.HelpBox("Help box", MessageType.Error);

        // toggle
        toggleValue = EditorGUILayout.Toggle("toggle ��", toggleValue);

        // �� �߱�
        EditorGUILayout.LabelField("", GUI.skin.horizontalSlider);

        #endregion


        #region ===:: GUILayout ::===

        // toolbar
        // https://lunchballer.com/archives/561
        selectionValue = GUILayout.Toolbar(selectionValue, stringArr);

        GUILayout.Space(15);

        // selection grid
        selectionValue = GUILayout.SelectionGrid(selectionValue, stringArr, 2);

        // box (e.g. texture)
        // https://github.com/halak/unity-editor-icons
        GUILayout.Box(EditorGUIUtility.IconContent("Animation.Record"));
        GUILayout.Box(EditorGUIUtility.IconContent("animationvisibilitytoggleon"));
        GUILayout.Box(EditorGUIUtility.IconContent("animationvisibilitytoggleon@2x"));

        #endregion

    }

    #endregion
}
