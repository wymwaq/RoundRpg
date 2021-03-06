﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class ResourceManagerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(ResourceManager), typeof(UnityEngine.MonoBehaviour));
		L.RegFunction("GetResourceUseMode", GetResourceUseMode);
		L.RegFunction("GetResource", GetResource);
		L.RegFunction("LoadResourceBlock", LoadResourceBlock);
		L.RegFunction("LoadResourceAsync", LoadResourceAsync);
		L.RegFunction("UnloadResource", UnloadResource);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("staticAssetBundleManager", get_staticAssetBundleManager, set_staticAssetBundleManager);
		L.RegVar("dynamicAssetBundleManager", get_dynamicAssetBundleManager, set_dynamicAssetBundleManager);
		L.RegVar("innerResoruceManager", get_innerResoruceManager, set_innerResoruceManager);
		L.RegVar("Instance", get_Instance, null);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetResourceUseMode(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			string arg0 = ToLua.CheckString(L, 1);
			ResUseMode o = ResourceManager.GetResourceUseMode(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int GetResource(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			ResourceManager obj = (ResourceManager)ToLua.CheckObject(L, 1, typeof(ResourceManager));
			string arg0 = ToLua.CheckString(L, 2);
			UnityEngine.Object o = obj.GetResource(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadResourceBlock(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			ResourceManager obj = (ResourceManager)ToLua.CheckObject(L, 1, typeof(ResourceManager));
			string arg0 = ToLua.CheckString(L, 2);
			UnityEngine.Object o = obj.LoadResourceBlock(arg0);
			ToLua.Push(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int LoadResourceAsync(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 3);
			ResourceManager obj = (ResourceManager)ToLua.CheckObject(L, 1, typeof(ResourceManager));
			string arg0 = ToLua.CheckString(L, 2);
			Void_STR_UnityEngineObject arg1 = null;
			LuaTypes funcType3 = LuaDLL.lua_type(L, 3);

			if (funcType3 != LuaTypes.LUA_TFUNCTION)
			{
				 arg1 = (Void_STR_UnityEngineObject)ToLua.CheckObject(L, 3, typeof(Void_STR_UnityEngineObject));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 3);
				arg1 = DelegateFactory.CreateDelegate(typeof(Void_STR_UnityEngineObject), func) as Void_STR_UnityEngineObject;
			}

			obj.LoadResourceAsync(arg0, arg1);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UnloadResource(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			ResourceManager obj = (ResourceManager)ToLua.CheckObject(L, 1, typeof(ResourceManager));
			string arg0 = ToLua.CheckString(L, 2);
			obj.UnloadResource(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int op_Equality(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UnityEngine.Object arg0 = (UnityEngine.Object)ToLua.ToObject(L, 1);
			UnityEngine.Object arg1 = (UnityEngine.Object)ToLua.ToObject(L, 2);
			bool o = arg0 == arg1;
			LuaDLL.lua_pushboolean(L, o);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_staticAssetBundleManager(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ResourceManager obj = (ResourceManager)o;
			AssetBundleManager ret = obj.staticAssetBundleManager;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index staticAssetBundleManager on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_dynamicAssetBundleManager(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ResourceManager obj = (ResourceManager)o;
			AssetBundleManager ret = obj.dynamicAssetBundleManager;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index dynamicAssetBundleManager on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_innerResoruceManager(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ResourceManager obj = (ResourceManager)o;
			InnerResourceManager ret = obj.innerResoruceManager;
			ToLua.PushObject(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index innerResoruceManager on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_Instance(IntPtr L)
	{
		try
		{
			ToLua.Push(L, ResourceManager.Instance);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_staticAssetBundleManager(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ResourceManager obj = (ResourceManager)o;
			AssetBundleManager arg0 = (AssetBundleManager)ToLua.CheckObject(L, 2, typeof(AssetBundleManager));
			obj.staticAssetBundleManager = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index staticAssetBundleManager on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_dynamicAssetBundleManager(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ResourceManager obj = (ResourceManager)o;
			AssetBundleManager arg0 = (AssetBundleManager)ToLua.CheckObject(L, 2, typeof(AssetBundleManager));
			obj.dynamicAssetBundleManager = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index dynamicAssetBundleManager on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_innerResoruceManager(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			ResourceManager obj = (ResourceManager)o;
			InnerResourceManager arg0 = (InnerResourceManager)ToLua.CheckObject(L, 2, typeof(InnerResourceManager));
			obj.innerResoruceManager = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index innerResoruceManager on a nil value" : e.Message);
		}
	}
}

