public class CSharpClass
{
    private int paramInt;
    float paramFloat = 3f;
    string paramString = "banane";
    CSharpClass cSharpClass;
    //CSharpClass cSharpClass = new CSharpClass(0);

    public CSharpClass(int arg_paramInt)
    {
        paramInt = arg_paramInt;
    }

    public int GetParamInt()
    {
        return paramInt;
    }

    public void SetParamInt(int arg_paramInt)
    {
        paramInt = arg_paramInt;
    }

    public int ParamInt { get { return paramInt; } set { paramInt = value; } }
    public float ParamFloat { get { return paramFloat; } set { paramFloat = value; } }

    public string ParamString { get { return paramString; } set { paramString = value; } }




    //  NE PAS UTILISER MAIN DANS UNITY JE SAIS PAS TROP COMMENT CA MARCHE DESO
    void Main(string[] args)
    {
        //int testInt = GetAbstractParamInt();
        //int staticInt = CSharpStaticClass.staticParamInt;
    }
}
