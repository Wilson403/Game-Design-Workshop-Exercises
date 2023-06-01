using UnityEngine;

namespace HotUpdateByLua
{
    public class LuaRuntime : MonoBehaviour
    {
        private void Awake ()
        {
            XLua.LuaEnv luaenv = new XLua.LuaEnv ();
            luaenv.DoString ("CS.UnityEngine.Debug.Log('hello world')");
            luaenv.Dispose ();
        }
    }
}