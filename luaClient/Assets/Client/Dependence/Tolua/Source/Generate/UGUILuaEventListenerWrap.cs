﻿//this source code was auto-generated by tolua#, do not modify it
using System;
using LuaInterface;

public class UGUILuaEventListenerWrap
{
	public static void Register(LuaState L)
	{
		L.BeginClass(typeof(UGUILuaEventListener), typeof(UnityEngine.EventSystems.EventTrigger));
		L.RegFunction("OnSubmit", OnSubmit);
		L.RegFunction("OnPointerEnter", OnPointerEnter);
		L.RegFunction("OnPointerClick", OnPointerClick);
		L.RegFunction("OnPointerExit", OnPointerExit);
		L.RegFunction("OnDrag", OnDrag);
		L.RegFunction("OnSelect", OnSelect);
		L.RegFunction("OnUpdateSelected", OnUpdateSelected);
		L.RegFunction("OnDeselect", OnDeselect);
		L.RegFunction("Get", Get);
		L.RegFunction("__eq", op_Equality);
		L.RegFunction("__tostring", ToLua.op_ToString);
		L.RegVar("onSubmit", get_onSubmit, set_onSubmit);
		L.RegVar("onClick", get_onClick, set_onClick);
		L.RegVar("onHover", get_onHover, set_onHover);
		L.RegVar("onToggleChanged", get_onToggleChanged, set_onToggleChanged);
		L.RegVar("onSliderChanged", get_onSliderChanged, set_onSliderChanged);
		L.RegVar("onScrollbarChanged", get_onScrollbarChanged, set_onScrollbarChanged);
		L.RegVar("onDrapDownChanged", get_onDrapDownChanged, set_onDrapDownChanged);
		L.RegVar("onInputFieldChanged", get_onInputFieldChanged, set_onInputFieldChanged);
		L.RegVar("luaTable", get_luaTable, set_luaTable);
		L.RegFunction("StringDelegate", UGUILuaEventListener_StringDelegate);
		L.RegFunction("IntDelegate", UGUILuaEventListener_IntDelegate);
		L.RegFunction("FloatDelegate", UGUILuaEventListener_FloatDelegate);
		L.RegFunction("BoolDelegate", UGUILuaEventListener_BoolDelegate);
		L.RegFunction("VoidDelegate", UGUILuaEventListener_VoidDelegate);
		L.EndClass();
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnSubmit(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UGUILuaEventListener obj = (UGUILuaEventListener)ToLua.CheckObject(L, 1, typeof(UGUILuaEventListener));
			UnityEngine.EventSystems.BaseEventData arg0 = (UnityEngine.EventSystems.BaseEventData)ToLua.CheckObject(L, 2, typeof(UnityEngine.EventSystems.BaseEventData));
			obj.OnSubmit(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPointerEnter(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UGUILuaEventListener obj = (UGUILuaEventListener)ToLua.CheckObject(L, 1, typeof(UGUILuaEventListener));
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
			obj.OnPointerEnter(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPointerClick(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UGUILuaEventListener obj = (UGUILuaEventListener)ToLua.CheckObject(L, 1, typeof(UGUILuaEventListener));
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
			obj.OnPointerClick(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnPointerExit(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UGUILuaEventListener obj = (UGUILuaEventListener)ToLua.CheckObject(L, 1, typeof(UGUILuaEventListener));
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
			obj.OnPointerExit(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnDrag(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UGUILuaEventListener obj = (UGUILuaEventListener)ToLua.CheckObject(L, 1, typeof(UGUILuaEventListener));
			UnityEngine.EventSystems.PointerEventData arg0 = (UnityEngine.EventSystems.PointerEventData)ToLua.CheckObject(L, 2, typeof(UnityEngine.EventSystems.PointerEventData));
			obj.OnDrag(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnSelect(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UGUILuaEventListener obj = (UGUILuaEventListener)ToLua.CheckObject(L, 1, typeof(UGUILuaEventListener));
			UnityEngine.EventSystems.BaseEventData arg0 = (UnityEngine.EventSystems.BaseEventData)ToLua.CheckObject(L, 2, typeof(UnityEngine.EventSystems.BaseEventData));
			obj.OnSelect(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnUpdateSelected(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UGUILuaEventListener obj = (UGUILuaEventListener)ToLua.CheckObject(L, 1, typeof(UGUILuaEventListener));
			UnityEngine.EventSystems.BaseEventData arg0 = (UnityEngine.EventSystems.BaseEventData)ToLua.CheckObject(L, 2, typeof(UnityEngine.EventSystems.BaseEventData));
			obj.OnUpdateSelected(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int OnDeselect(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 2);
			UGUILuaEventListener obj = (UGUILuaEventListener)ToLua.CheckObject(L, 1, typeof(UGUILuaEventListener));
			UnityEngine.EventSystems.BaseEventData arg0 = (UnityEngine.EventSystems.BaseEventData)ToLua.CheckObject(L, 2, typeof(UnityEngine.EventSystems.BaseEventData));
			obj.OnDeselect(arg0);
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int Get(IntPtr L)
	{
		try
		{
			ToLua.CheckArgsCount(L, 1);
			LuaTable arg0 = ToLua.CheckLuaTable(L, 1);
			UGUILuaEventListener o = UGUILuaEventListener.Get(arg0);
			ToLua.Push(L, o);
			return 1;
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
	static int get_onSubmit(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUILuaEventListener obj = (UGUILuaEventListener)o;
			UGUILuaEventListener.VoidDelegate ret = obj.onSubmit;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onSubmit on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onClick(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUILuaEventListener obj = (UGUILuaEventListener)o;
			UGUILuaEventListener.VoidDelegate ret = obj.onClick;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onClick on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onHover(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUILuaEventListener obj = (UGUILuaEventListener)o;
			UGUILuaEventListener.BoolDelegate ret = obj.onHover;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onHover on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onToggleChanged(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUILuaEventListener obj = (UGUILuaEventListener)o;
			UGUILuaEventListener.BoolDelegate ret = obj.onToggleChanged;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onToggleChanged on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onSliderChanged(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUILuaEventListener obj = (UGUILuaEventListener)o;
			UGUILuaEventListener.FloatDelegate ret = obj.onSliderChanged;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onSliderChanged on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onScrollbarChanged(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUILuaEventListener obj = (UGUILuaEventListener)o;
			UGUILuaEventListener.FloatDelegate ret = obj.onScrollbarChanged;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onScrollbarChanged on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onDrapDownChanged(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUILuaEventListener obj = (UGUILuaEventListener)o;
			UGUILuaEventListener.IntDelegate ret = obj.onDrapDownChanged;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onDrapDownChanged on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_onInputFieldChanged(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUILuaEventListener obj = (UGUILuaEventListener)o;
			UGUILuaEventListener.StringDelegate ret = obj.onInputFieldChanged;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onInputFieldChanged on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int get_luaTable(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUILuaEventListener obj = (UGUILuaEventListener)o;
			LuaInterface.LuaTable ret = obj.luaTable;
			ToLua.Push(L, ret);
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index luaTable on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onSubmit(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUILuaEventListener obj = (UGUILuaEventListener)o;
			UGUILuaEventListener.VoidDelegate arg0 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (UGUILuaEventListener.VoidDelegate)ToLua.CheckObject(L, 2, typeof(UGUILuaEventListener.VoidDelegate));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 2);
				arg0 = DelegateFactory.CreateDelegate(typeof(UGUILuaEventListener.VoidDelegate), func) as UGUILuaEventListener.VoidDelegate;
			}

			obj.onSubmit = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onSubmit on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onClick(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUILuaEventListener obj = (UGUILuaEventListener)o;
			UGUILuaEventListener.VoidDelegate arg0 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (UGUILuaEventListener.VoidDelegate)ToLua.CheckObject(L, 2, typeof(UGUILuaEventListener.VoidDelegate));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 2);
				arg0 = DelegateFactory.CreateDelegate(typeof(UGUILuaEventListener.VoidDelegate), func) as UGUILuaEventListener.VoidDelegate;
			}

			obj.onClick = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onClick on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onHover(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUILuaEventListener obj = (UGUILuaEventListener)o;
			UGUILuaEventListener.BoolDelegate arg0 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (UGUILuaEventListener.BoolDelegate)ToLua.CheckObject(L, 2, typeof(UGUILuaEventListener.BoolDelegate));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 2);
				arg0 = DelegateFactory.CreateDelegate(typeof(UGUILuaEventListener.BoolDelegate), func) as UGUILuaEventListener.BoolDelegate;
			}

			obj.onHover = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onHover on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onToggleChanged(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUILuaEventListener obj = (UGUILuaEventListener)o;
			UGUILuaEventListener.BoolDelegate arg0 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (UGUILuaEventListener.BoolDelegate)ToLua.CheckObject(L, 2, typeof(UGUILuaEventListener.BoolDelegate));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 2);
				arg0 = DelegateFactory.CreateDelegate(typeof(UGUILuaEventListener.BoolDelegate), func) as UGUILuaEventListener.BoolDelegate;
			}

			obj.onToggleChanged = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onToggleChanged on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onSliderChanged(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUILuaEventListener obj = (UGUILuaEventListener)o;
			UGUILuaEventListener.FloatDelegate arg0 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (UGUILuaEventListener.FloatDelegate)ToLua.CheckObject(L, 2, typeof(UGUILuaEventListener.FloatDelegate));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 2);
				arg0 = DelegateFactory.CreateDelegate(typeof(UGUILuaEventListener.FloatDelegate), func) as UGUILuaEventListener.FloatDelegate;
			}

			obj.onSliderChanged = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onSliderChanged on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onScrollbarChanged(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUILuaEventListener obj = (UGUILuaEventListener)o;
			UGUILuaEventListener.FloatDelegate arg0 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (UGUILuaEventListener.FloatDelegate)ToLua.CheckObject(L, 2, typeof(UGUILuaEventListener.FloatDelegate));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 2);
				arg0 = DelegateFactory.CreateDelegate(typeof(UGUILuaEventListener.FloatDelegate), func) as UGUILuaEventListener.FloatDelegate;
			}

			obj.onScrollbarChanged = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onScrollbarChanged on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onDrapDownChanged(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUILuaEventListener obj = (UGUILuaEventListener)o;
			UGUILuaEventListener.IntDelegate arg0 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (UGUILuaEventListener.IntDelegate)ToLua.CheckObject(L, 2, typeof(UGUILuaEventListener.IntDelegate));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 2);
				arg0 = DelegateFactory.CreateDelegate(typeof(UGUILuaEventListener.IntDelegate), func) as UGUILuaEventListener.IntDelegate;
			}

			obj.onDrapDownChanged = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onDrapDownChanged on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_onInputFieldChanged(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUILuaEventListener obj = (UGUILuaEventListener)o;
			UGUILuaEventListener.StringDelegate arg0 = null;
			LuaTypes funcType2 = LuaDLL.lua_type(L, 2);

			if (funcType2 != LuaTypes.LUA_TFUNCTION)
			{
				 arg0 = (UGUILuaEventListener.StringDelegate)ToLua.CheckObject(L, 2, typeof(UGUILuaEventListener.StringDelegate));
			}
			else
			{
				LuaFunction func = ToLua.ToLuaFunction(L, 2);
				arg0 = DelegateFactory.CreateDelegate(typeof(UGUILuaEventListener.StringDelegate), func) as UGUILuaEventListener.StringDelegate;
			}

			obj.onInputFieldChanged = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index onInputFieldChanged on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int set_luaTable(IntPtr L)
	{
		object o = null;

		try
		{
			o = ToLua.ToObject(L, 1);
			UGUILuaEventListener obj = (UGUILuaEventListener)o;
			LuaTable arg0 = ToLua.CheckLuaTable(L, 2);
			obj.luaTable = arg0;
			return 0;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e, o == null ? "attempt to index luaTable on a nil value" : e.Message);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UGUILuaEventListener_StringDelegate(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UGUILuaEventListener.StringDelegate), func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UGUILuaEventListener.StringDelegate), func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UGUILuaEventListener_IntDelegate(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UGUILuaEventListener.IntDelegate), func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UGUILuaEventListener.IntDelegate), func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UGUILuaEventListener_FloatDelegate(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UGUILuaEventListener.FloatDelegate), func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UGUILuaEventListener.FloatDelegate), func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UGUILuaEventListener_BoolDelegate(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UGUILuaEventListener.BoolDelegate), func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UGUILuaEventListener.BoolDelegate), func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}

	[MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	static int UGUILuaEventListener_VoidDelegate(IntPtr L)
	{
		try
		{
			int count = LuaDLL.lua_gettop(L);
			LuaFunction func = ToLua.CheckLuaFunction(L, 1);

			if (count == 1)
			{
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UGUILuaEventListener.VoidDelegate), func);
				ToLua.Push(L, arg1);
			}
			else
			{
				LuaTable self = ToLua.CheckLuaTable(L, 2);
				Delegate arg1 = DelegateFactory.CreateDelegate(typeof(UGUILuaEventListener.VoidDelegate), func, self);
				ToLua.Push(L, arg1);
			}
			return 1;
		}
		catch(Exception e)
		{
			return LuaDLL.toluaL_exception(L, e);
		}
	}
}

